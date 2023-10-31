/* 1 */

SELECT `ville_departement`,`ville_nom` AS "Nom de la Ville" FROM `villes_france` WHERE LENGTH(`ville_nom`) >= 40 ;

/* 2 */ 

SELECT `departement_code`,`departement_nom` AS "Nom de Departement" FROM `departements` WHERE `departement_code` LIKE '97%' ;

/* 3 */

SELECT `departement_code`,`departement_nom` AS "Nom de Departement" FROM `departements` WHERE `departement_regionid` = 7 ORDER BY `departement_nom` ASC ;


/* 4 */ 

SELECT d.departement_code, d.departement_nom, vf.ville_nom, vf.ville_population_2012
FROM `villes_france` vf
INNER JOIN `departements` d ON d.departement_code = vf.ville_departement 
ORDER BY `ville_population_2012` DESC ;

/* 5 */

SELECT d.departement_code, d.departement_nom, vf.ville_commune
FROM `villes_france` vf
INNER JOIN `departements` d ON d.departement_code = vf.ville_departement 
ORDER BY `ville_commune` DESC ;


/* 6 */


SELECT d.departement_code, d.departement_nom, vf.ville_surface
FROM `villes_france` vf
INNER JOIN `departements` d ON d.departement_code = vf.ville_departement 
ORDER BY `ville_surface` DESC ;

/* 7 */ 

SELECT COUNT(`ville_nom`) as "Nombre de ville possédant SAINT dans son nom" 
FROM `villes_france`
WHERE `ville_nom` LIKE '%SAINT%' ;

/* 8 */

SELECT `ville_nom`, `ville_commune` FROM `villes_france` vf
GROUP BY `ville_nom` 
ORDER BY `ville_commune` DESC ;
/* Je n'ai pas réussi a faire ce que je pensais en partant d'un tri par nom pour ensuite mettre dans l'ordre décroissant
pour que les villes ayant le plus de communes apparaissent en première et que les doubles apparaissent après */


/* 9 */

SELECT vf.ville_departement, vf.ville_nom, vf.ville_surface 
FROM `villes_france` vf 
GROUP BY vf.ville_nom
HAVING vf.ville_surface > (SELECT AVG(`ville_surface`) FROM `villes_france` );


/* 10 */

SELECT d.departement_code, d.departement_nom, vf.ville_population_2012
FROM `villes_france` vf
INNER JOIN `departements` d ON d.departement_code = vf.ville_departement 
WHERE vf.ville_population_2012 > 1000000;

/* 11 */

SELECT  CONCAT(SUBSTR(`ville_nom`,1,5), ' ', SUBSTR(`ville_nom`,7)) AS "Retirer le tiret des villes commençant par SAINT"
FROM `villes_france`
WHERE `ville_nom` LIKE 'SAINT%' ;

/* 12 */

SELECT vf.ville_departement, vf.ville_nom, vf.ville_surface
FROM `villes_france` vf
ORDER BY vf.ville_surface ASC
LIMIT (50);

/* 13 */

ALTER TABLE `regions` ADD `region_nbDepartement` INT NOT NULL AFTER `region_nom`;

/* 14 */

CREATE PROCEDURE `MajRegion`() NOT DETERMINISTIC CONTAINS SQL SQL SECURITY DEFINER 
BEGIN 
SELECT r.region_id, r.region_nom, COUNT(d.departement_regionId) AS "Nbrdep" 
FROM `departements` d 
INNER JOIN `regions` r ON r.region_id = d.departement_regionId 
GROUP BY r.region_nom ; 
UPDATE `regions` SET `region_nbDepartement` = Nbrdep; 
END
/* La procédure n'est pas correcte mais j'ai d'abod voir si je pouvais comptais le nombre de departement par region pour ensuite l'update et l'inserer dans cette valeur */


/* 15 */
DROP TABLE IF EXISTS regions_departements_villes;
CREATE VIEW regions_departements_villes AS
SELECT 
    vf.ville_id,
    vf.ville_departement,
    vf.ville_slug,
    vf.ville_nom,
    vf.ville_nom_simple,
    vf.ville_nom_reel,
    vf.ville_nom_soundex,
    vf.ville_nom_metaphone,
    vf.ville_code_postal,
    vf.ville_commune,
    vf.ville_code_commune,
    vf.ville_arrondissement,
    vf.ville_canton,
    vf.ville_amdi,
    vf.ville_population_2010,
    vf.ville_population_1999,
    vf.ville_population_2012,
    vf.ville_densite_2010,
    vf.ville_surface,
    vf.ville_longitude_deg,
    vf.ville_latitude_deg,
    vf.ville_longitude_grd,
    vf.ville_latitude_grd,
    vf.ville_longitude_dms,
    vf.ville_latitude_dms,
    vf.ville_zmin,
    vf.ville_zmax,
    d.departement_id,
    d.departement_code,
    d.departement_nom,
    d.departement_nom_uppercase,
    d.departement_slug,
    d.departement_nom_soundex,
    d.departement_regionId,
    r.region_id,
    r.region_nom,
    r.region_nbDepartement
FROM `villes_france` vf
INNER JOIN `departements` d ON d.departement_code = vf.ville_departement 
INNER JOIN `regions` r ON r.region_id = d.departement_regionId ;


/* Falcultatif : */

ALTER TABLE departements ADD CONSTRAINT departement_regionId FOREIGN KEY (region_id) REFERENCES regions(region_id);
ALTER TABLE villes_france ADD CONSTRAINT ville_departement FOREIGN KEY (departement_code) REFERENCES departements(departement_code);
/* A */

/* 1) Afficher les noms de département */

SELECT `nomdep` FROM `departement`;

/* 2) Afficher les numéros et noms de département */

SELECT `nodep`,`nomdep` FROM `departement`;

/* 3) Afficher toutes les propriétés des employés */

SELECT `noemp`,`nomemp` AS "Nom de l'employé" ,`fonction`, `noresp`, `datemb` AS "Date d'embauche", `sala` AS `Salaire`, `comm` AS "Commission" from `employe`;

/* 4) Afficher les fonctions des employés */

SELECT `fonction` from `employe`;

/* 5) Afficher les fonctions des employés sans double */

SELECT DISTINCT `fonction` from `employe`;

/* 6) Afficher les noms des employés avec leur date d'embauche, ainsi que la date d'embauche augmentée d'une journée */

SELECT `nomemp`, `datemb` from `employe` , DATE_ADD(datemb, INTERVAL 1 DAY) as "Date d'embauche + 1 Jour" FROM `employe`;

/* 7) Afficher les noms des employés suivis d'un espace, suivi de leur fonction */

SELECT CONCAT(`nomemp`, ' ', `fonction`) as "Employe" from `employe` ;


/* B */

/* 1) Donner la liste des numéros et noms des employés du département 30 */

SELECT `noemp`,`nomemp`  FROM `employe` WHERE `nodep` = 30;

/* 2) Donner la liste des numéros et noms des ouvriers ainsi que leur numéro de département */

SELECT `noemp`,`nomemp`,`nodep` FROM `employe` WHERE `fonction` = 'ouvrier';

/* 3) Donner les noms et numéros des départements dont le numéro est supérieur ou égal à 30 */

SELECT `nodep`, `nomdep` FROM `departement` WHERE `nodep` >= 30;

/* 4) Donner les noms, salaires et commissions des employés dont la commission excède le salaire */

SELECT `nomemp`, `sala`, `comm` from `employe` WHERE `sala` < `comm` ;

/* 5) Donner les noms et salaires des vendeurs du département 30 dont le salaire est supérieur à 1500 € */

SELECT `nomemp`, `sala` FROM `employe` WHERE `fonction` = 'vendeur' AND `nodep` = 30 AND `sala` > 1500;

/* 6) Donner la liste des noms, fonctions et salaires des directeurs et des présidents */

SELECT `nomemp`, `fonction`, `sala` FROM `employe` WHERE `fonction` = 'directeur' OR `fonction` ='président' ;

/* 7) Donner la liste des noms, fonctions et salaires des directeurs et des employés qui ont un salaire > 2500 € */

SELECT `nomemp`, `fonction`, `sala` FROM `employe` WHERE `fonction` = 'directeur' OR  `sala` > 2500 ;

/* 8) Donner la liste des noms, numéros de département des directeurs et des ouvriers du département 10 */

SELECT `nomemp`, `nodep` FROM `employe` WHERE `fonction` = 'directeur' AND `nodep` = 10 OR `fonction` = 'ouvrier' AND `nodep` = 10 ;
/* SI JAMAIS J'AI MAL COMPRIS L'ENONCÉ : SELECT `nomemp`, `nodep` FROM `employe` WHERE `fonction` = 'directeur' OR `fonction` = 'ouvrier' AND `nodep` = 10 ; */

/* 9) Donner la liste des noms, fonctions et numéros de département des employés du département 10 qui ne sont ni ouvrier ni directeur */

SELECT `nomemp`, `fonction`, `nodep` from `employe` WHERE `nodep` = 10 AND `fonction` != 'directeur' AND `fonction` != 'ouvrier' ;

/* 10) Donner la liste des noms, fonctions et numéros de département des directeurs qui ne sont pas directeur dans le département 30 */

SELECT `nomemp`, `fonction`, `nodep` from `employe` WHERE `fonction` = 'directeur' AND `nodep` != 30;

/* 11) Donner la liste des noms, fonctions et salaires des employés qui gagnent entre 1200 € et 1300 € */

SELECT `nomemp`, `fonction`,`sala` from `employe` WHERE `sala` >= 1200 AND `sala` =< 1300 ;

/* 12) Donner la liste des noms, numéros de département et fonctions des employés « ouvrier », « analyste » ou « vendeur » */

SELECT `nomemp`, `nodep`, `fonction` FROM `employe`  WHERE `fonction` = 'ouvrier' OR `fonction` = 'analyste' OR `fonction` = 'vendeur';

/* 13) Donner les employés qui ne sont pas "vendeur" */

SELECT `nomemp`,`fonction`, `datemb`, `sala`,`comm`,`nodep` FROM `employe` WHERE `fonction` != 'vendeur';

/* 14) Donner la liste des employés dont la première lettre du nom est un "C" */

SELECT `nomemp`, `fonction`,`datemb`, `sala`,`comm`,`nodep` FROM `employe` WHERE `nomemp` LIKE 'c%';

/* 15) Donner la liste des employés qui n'ont pas de commission */

SELECT `nomemp`, `fonction`,`datemb`, `sala`,`comm`,`nodep` FROM `employe` WHERE `comm` is NULL or `comm` = 0;

/* 16) Donner la liste des employés qui ont une commission et qui sont dans le département 30 ou 20 */

SELECT `nomemp`, `fonction`,`datemb`, `sala`,`comm`,`nodep` FROM `employe` WHERE



/* C */
/* 1) Donner la liste des salaires, fonctions et noms des employés du département 30, selon l'ordre croissant des salaires */

SELECT `sala`, `fonction`, `nomemp` FROM `employe` WHERE `nodep` = 30 ORDER BY `sala` ASC ; 

/* 2) Donner la liste des salaires, fonctions et noms des employés du département 30, selon l'ordre décroissant des salaires */

SELECT `sala`, `fonction`, `nomemp` FROM `employe` WHERE `nodep` = 30 ORDER BY `sala` DESC ; 

/* 3) Donner la liste des employés triée selon l'ordre croissant des fonctions et l'ordre décroissant des salaires */ 
l
SELECT `nomemp`, `fonction`,`datemb`, `sala`,`comm`,`nodep` FROM `employe` ORDER BY `fonction` ASC;
SELECT `nomemp`, `fonction`,`datemb`, `sala`,`comm`,`nodep` FROM `employe` ORDER BY `sala` DESC ; 

/* 4) Donner la liste des commissions, salaires et noms triée selon l'ordre croissant des commissions */

SELECT `comm`, `sala`, `nomemp` FROM `employe` ORDER BY `comm` ASC;

/* 5) Donner la liste des commissions, salaires et noms triée selon l'ordre décroissant des commissions */

SELECT `comm`, `sala`, `nomemp` FROM `employe` ORDER BY `comm` DESC;


/* D */

/* 1) Donner la ville dans laquelle travaille Costanza */

SELECT `ville` 
FROM `departement` d
INNER JOIN `employe` e ON e.nodep = d.nodep
WHERE e.nomemp = 'Costanza';

/* 2) Donner les noms, fonctions, et noms des départements des employés des départements 30 et 40 */

SELECT `nomemp`, `fonction`,`nomdep` FROM `employe` e
INNER JOIN `departement` d ON e.nodep = d.nodep
WHERE e.nodep = 30 AND e.nodep = 40;

/* 3) Donner le grade, la fonction, le nom et le salaire de chaque employé */

SELECT g.Id_grade, e.fonction, e.nomemp, e.sala 
FROM employe AS e 
JOIN grade AS g ON e.sala BETWEEN g.salmin AND g.salmax;

/* 4) Donner la liste des noms et salaires des employés qui gagnent plus que leur responsable */

SELECT e.nomemp, e.sala
FROM `employe` e
INNER JOIN `employe` em ON em.noemp = e.noresp 
WHERE e.sala > em.sala;

/* 5) Donner la liste des noms, salaires, fonctions des employés qui gagnent plus que Perou */

SELECT `nomemp`, `sala`, `fonction` 
FROM `employe` e
WHERE `sala` > ( SELECT `sala` FROM `employe` WHERE `nomemp` = 'perou');


/* E */ 

/* 1) Donner les noms, salaires, commissions et revenus des vendeurs */

SELECT `nomemp`, `sala`, `comm` , (`sala`+`comm`) AS "Revenu Vendeur" FROM `employe` WHERE `fonction` = "vendeur";

/* 2) Donner les noms, salaires et les commissions des employés dont la commission est supérieure à 25% de leur salaire */

SELECT `noemp`,`sala`,`comm` FROM `employe` WHERE `comm` >= 0.25*`sala`;

/* 3) Donner la liste des vendeurs dans l'ordre décroissant de leur commission divisée par leur salaire */

SELECT `nomemp`,`fonction`,`sala`,`comm`,`datemb` FROM `employe` ORDER BY `comm` / `sala`DESC ;

/* 4) Donner le revenu annuel de chaque vendeur */

SELECT `nomemp`, `fonction` , (`sala`+`comm`)*12 AS "Revenu annuel" FROM `employe` ;

/* 5) Donner le salaire quotidien des vendeurs */

SELECT `nomemp`, `fonction` , `sala`/30 AS "Revenu Quotidien" FROM `employe` ; /* methode pas ouf a mon avis */
SELECT `nomemp`, `fonction` , ROUND(((`sala`+`comm`)*12)/365 ,2) AS "Revenu Quotidien" FROM `employe` ; /* methode qui me parait la mieux*/
SELECT `nomemp`, `fonction` , ROUND(((`sala`+`comm`)*3)/91.25 ,2) AS "Revenu Quotidien" FROM `employe`; /* Calcul qui prend en compte les indemnités si je me referre a mon navigateur préféré qui ne mange pas toute ma ram : Google Chrome */

/* 6) Donner la moyenne des salaires des ouvriers */

SELECT AVG(`sala`) AS "Moyenne Salaire Ouvrier" from `employe` WHERE `fonction` = 'ouvrier';

/* 7) Donner le total des salaires et des commissions des vendeurs */

SELECT SUM(`sala`) AS "Total Salaires" , SUM(`comm`) AS "Total Commissions" from `employe` ;

/* 8) Donner le revenu annuel moyen de tous les vendeurs */

SELECT ROUND(AVG((`sala`+`comm`)*12),2) AS "Moyenne Revenu Annuel" from `employe`;

/* 9) Donner le plus haut salaire, le plus bas et l'écart entre les deux */

SELECT MAX(`sala`) AS "Salaire le plus haut", MIN(`sala`) AS "Salaire le plus bas", (MAX(`sala`)-MIN(`sala`)) AS "Etendu de Salaire"  FROM `employe`;

/* 10) Donner le nombre d'employés du département 30 */

SELECT COUNT(`nomemp`) FROM `employe` WHERE `nodep` = 30;



/* F */

/* 1) Donner la moyenne des salaires pour chaque département */

SELECT `nodep`,ROUND(AVG(`sala`),2) AS "Moyenne des salaires" from `employe` GROUP BY `nodep`;

/* 2) Donner pour chaque département, le salaire annuel moyen des employés qui ne sont ni directeur ni président */

SELECT `nodep`, ROUND(AVG((`sala`+`comm`)*12),2) AS "Moyenne Revenu Annuel" FROM `employe` WHERE `fonction` != 'directeur' AND `fonction` != 'président' GROUP BY `nodep`;

/* 3) Donner pour chaque fonction de chaque département le nombre d'employés et le salaire annuel moyen */

SELECT `fonction`, d.nodep, COUNT(`nomemp`) AS `Nombre d'employes`, ROUND(AVG((`sala`+`comm`)*12),2) AS "Moyenne Revenu Annuel"
FROM `employe` e
INNER JOIN `departement` d ON d.nodep = e.nodep
GROUP BY `fonction`, d.nodep;

/* 4) Donner la liste des salaires annuels moyens pour les fonctions comportant plus de deux employés */

SELECT `fonction`, ROUND(AVG((`sala`+`comm`)*12),2) AS "Moyenne Revenu Annuel" FROM `employe` WHERE COUNT(`fonction`) > 2 GROUP BY `fonction`;

/* 5) Donner la liste des départements avec au moins deux ouvriers */

SELECT `nomdep` , COUNT(`fonction`) AS "NOMBRE D'EMPLOYE"
FROM `departement` d 
INNER JOIN `employe` e ON e.nodep = d.nodep 
WHERE `fonction` IN ('ouvrier')
GROUP BY `nomdep`
HAVING COUNT(`fonction`) > 2;


/* 6) Donner les salaires moyens des présidents, directeurs et responsables */

SELECT ROUND(AVG(`sala`),2) as "Moyenne Salaire Président,directeur,responsable"
FROM `employe`
WHERE `fonction` IN ('président','directeur','responsable');


/* G */

/* 1 )Donner les noms et fonctions des employés qui gagnent plus que "Bibaut"; */ 

SELECT `nomemp`, `fonction`
FROM `employe`
WHERE `sala` > (SELECT `sala` FROM `employe` WHERE `nomemp` = 'Bibaut');

/* 2 )Donner les fonctions dont la moyenne des salaires est supérieure à la moyenne des "vendeurs"; */

SELECT e.fonction , AVG(e.sala) AS "Moyennef"
FROM `employe` e
GROUP BY e.fonction
HAVING Moyennef > (SELECT AVG(em.sala) from `employe` em WHERE em.fonction = 'vendeur');



/* 3 )Donner les noms des départements des employés qui gagnent plus de 2 700 € ; */

SELECT DISTINCT `nomdep`
FROM `departement` d 
INNER JOIN `employe` e ON e.nodep = d.nodep 
WHERE e.sala > 2700;

/* 4 )Déterminer le salarié le plus ancien */

SELECT `nomemp`, MIN(`datemb`) AS "Date d'embauche la plus ancienne" from `employe`;

/* 5 )Déterminer le dernier salarié embauché */

SELECT `nomemp`, MAX(`datemb`) AS "Date d'embauche la plus recente" from `employe`;

/* 6 )Afficher la liste des employés responsables d\autres employés. */

SELECT DISTINCT e.nomemp from `employe` e
INNER JOIN `employe` em ON em.noresp = e.noemp;

/* 7 )Donner les employés qui ont occupé les fonctions de vendeur et de directeur */

Select e.nomemp, h.noemp, COUNT(h.noemp) AS "Nombre de poste Occupé"
FROM `employe` e
INNER JOIN `histofonction` h ON h.noemp = e.noemp
WHERE h.fonction = 'directeur' OR h.fonction = 'vendeur'
GROUP BY `nomemp`
HAVING COUNT(h.noemp) = 2;

/* 8 )Donner les noms des employés (avec leur numéro de département et leur salaire) qui gagnent plus que la moyenne des employés de leur département */


SELECT d.nodep, e.nomemp, e.sala, AVG(e.sala) AS " Moyenne"
FROM `employe` e
INNER JOIN `departement` d ON d.nodep = e.nodep
GROUP BY e.nodep
HAVING Moyenne < (SELECT em.sala from `employe` em);

Ca n\affiche que 4 lignes donc il y a une manipulation a faire pour afficher tout les lignes salaires 


// ESSAI DE BOULE JOINTURES ( sans doute une idée douteuse)

SELECT d.nodep, e.nomemp, e.sala, AVG(e.sala) AS " Moyenne"
FROM `employe` e
INNER JOIN `departement` d ON d.nodep = e.nodep
GROUP BY e.nodep
HAVING Moyenne < (SELECT em.sala from `employe` em
INNER JOIN `departement` de ON de.nodep = em.nodep);
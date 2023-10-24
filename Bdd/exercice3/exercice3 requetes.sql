A SELECT CONCAT(`nomEtudiant`," ", `prenomEtudiant`) as "Etudiant" FROM `etudiants` WHERE `dateNaissanceEtudiant` < (SELECT `dateNaissanceEtudiant` FROM `etudiants` WHERE `nomEtudiant` = "leclercq" AND `prenomEtudiant` = "jules");

B SELECT CONCAT(`nomEtudiant`," ", `prenomEtudiant`) as "Etudiant", `note`
FROM `etudiants` e
INNER JOIN `avoir_note` a ON a.idEtudiant = e.idEtudiant
WHERE idEpreuve = 4 AND `note` > (SELECT AVG(`note`) FROM `avoir_note` WHERE idEpreuve = 4);

C SELECT CONCAT(`nomEtudiant`," ", `prenomEtudiant`) as "Etudiant"
FROM `etudiants` e
INNER JOIN `avoir_note` a ON a.idEtudiant = e.idEtudiant 
WHERE `note` > 12;

D SELECT DISTINCT CONCAT(`nomEtudiant`," ", `prenomEtudiant`) as "Etudiant"
FROM `etudiants` e
INNER JOIN `avoir_note` a ON a.idEtudiant = e.idEtudiant
WHERE idEpreuve = 4 AND a.note > (SELECT `note` FROM `avoir_note` a2
INNER JOIN `etudiants` e2 ON e2.idEtudiant = a2.idEtudiant
WHERE a2.idEpreuve = 4 AND e2.prenomEtudiant = 'luc' AND e2.nomEtudiant = 'dupont');


E SELECT DISTINCT CONCAT(`nomEtudiant`," ", `prenomEtudiant`) as "Etudiant"
FROM `etudiants` e
INNER JOIN `avoir_note` a ON a.idEtudiant = e.idEtudiant 
WHERE e.prenomEtudiant != 'luc' AND e.nomEtudiant != 'dupont' AND `note` IN (SELECT `note` FROM `avoir_note` a2
INNER JOIN `etudiants` e2 ON e2.idEtudiant = a2.idEtudiant
WHERE e2.prenomEtudiant = 'luc' AND e2.nomEtudiant = 'dupont');

F ALTER TABLE etudiants
ADD HOBBY VARCHAR(20)
DEFAULT 'sport';

G ALTER TABLE etudiants ADD newcol int ;

ALTER TABLE etudiants DROP COLUMN newcol;

H DESCRIBE etudiants;

ALTER TABLE etudiants MODIFY COLUMN prenomEtudiant VARCHAR(20) NOT NULL;

I  
INSERT INTO epreuves(idEpreuve,libelleEpreuve,idEnseignantEpreuve,idMatiereEpreuve,dateEpreuve,CoefficientEpreuve) VALUES (7, 'interro écrite', 9,1, '1996-08-21',1); 

    INSERT INTO avoir_note(idEtudiant, idEpreuve ,note) VALUES 
    (1,7,10),
    (2,7,08),
    (3,7,05),
    (4,7,09),
    (17,3,15)

J UPDATE `avoir_note` SET `note` = 7 WHERE `idEtudiant` = 3 AND `idEpreuve` = 7 ;
K UPDATE `avoir_note` SET `note` = `note` + 1 WHERE `idEtudiant` = 1 AND `idEpreuve` = 7 ;
L DELETE FROM `avoir_note` WHERE `idEpreuve` = 7 ;
DELETE FROM `epreuves` WHERE `idEpreuve` = 7;
( PAS BESOIN DE METTRE LES NOMS QUE TU DELETE )
M Avec Delete Cascade =>

Create Table avoir_note (
    idAvoirNote int AUTO_INCREMENT PRIMARY KEY,
    idEtudiant int NOT NULL,
    idEpreuve int NOT NULL,
    note int,
    FOREIGN KEY (idEpreuve)
        REFERENCES epreuves (idEpreuve)
        ON DELETE CASCADE
);

( pour modifier direct ) 
ALTER TABLE avoir_note
ADD CONSTRAINT FK_AvoirNote_Epreuves
FOREIGN KEY (idEpreuve)
REFERENCES epreuves (idEpreuve)
ON DELETE CASCADE;

N

// Pour Selectionner

SELECT m.nomMatiere , CONCAT(`nomEtudiant`," ", `prenomEtudiant`) as "Etudiant", a.note
FROM `matieres` m
INNER JOIN `epreuves` e ON e.idMatiereEpreuve = m.idMatiere
INNER JOIN `avoir_note` a ON a.idEpreuve = e.idEpreuve 
INNER JOIN `etudiants` et ON et.idEtudiant = a.idEtudiant 
WHERE m.nomMatiere = "BD" AND et.nomEtudiant = "marke" ;


// Pour Update :


UPDATE :

UPDATE `avoir_note` a
INNER JOIN `etudiants` et ON et.idEtudiant = a.idEtudiant 
INNER JOIN `epreuves` e ON e.idEpreuve = a.idEpreuve
INNER JOIN `matieres` m ON m.idMatiere = e.idMatiereEpreuve
SET a.note = a.note - 3
WHERE m.nomMatiere = "BD" AND et.nomEtudiant = "marke" ;

O INSERT INTO `avoir_note` (`idEtudiant`, `idEpreuve`, 
VALUES ((SELECT `idEtudiant` FROM `etudiants` WHERE nomEtudiant = 'dewa',4, 
(SELECT AVG(`note`)*0.9 as "Note de Marke" FROM `avoir_note` AS an WHERE idEpreuve = 4 ))));


P INSERT INTO `etudiants` ( `idEtudiant`, `nomEtudiant`, `prenomEtudiant`, `HOBBY` , anneeEtudiant ) 
VALUES (25, 'DARTE','REMY','SCULPTURE',1);






SELECT `nomEtudiant`,`prenomEtudiant`,`libelleEpreuve`,`note` FROM etudiants_epreuves ; 




B SELECT CONCAT(`nomEtudiant`," ", `prenomEtudiant`) as "Etudiant", `note`
FROM `etudiants_epreuves`
WHERE `idEpreuve` = 4 AND `note` > (SELECT AVG(`note`) FROM `etudiants_epreuves` WHERE `idEpreuve` = 4);


C SELECT CONCAT(`nomEtudiant`," ", `prenomEtudiant`) as "Etudiant"
FROM `etudiants_epreuves`
WHERE `note` > 12;
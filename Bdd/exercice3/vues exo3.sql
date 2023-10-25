DROP VIEW IF EXISTS etudiants_epreuves ;
CREATE VIEW etudiants_epreuves  AS 
SELECT
    e.idEtudiant,
    e.nomEtudiant,
    e.prenomEtudiant,
    e.adresseEtudiant,
    e.villeEtudiant,
    e.codePostalEtudiant,
    e.telephoneEtudiant,
    e.dateEntreeEtudiant,
    e.anneeEtudiant,
    e.remarqueEtudiant,
    e.sexeEtudiant,
    e.dateNaissanceEtudiant,
    e.HOBBY,
    ep.idEpreuve,
    ep.libelleEpreuve,
    ep.idEnseignantEpreuve,
    ep.idMatiereEpreuve,
    ep.dateEpreuve,
    ep.CoefficientEpreuve,
    ep.anneeEpreuve,
    a.note,
    a.idAvoirNote
FROM etudiants e
INNER JOIN avoir_note a ON a.idEtudiant = e.idEtudiant
INNER JOIN epreuves ep ON ep.idEpreuve = a.idEpreuve ;


DROP VIEW IF EXISTS enseignant_matieres ;
CREATE VIEW enseignant_matieres AS
SELECT
    en.idEnseignant,
    en.nomEnseignant,
    en.prenomEnseignant,
    en.fonctionEnseignant,
    en.adresseEnseignant,
    en.villeEnseignant,
    en.codePostalEnseignant,
    en.telephoneEnseignant,
    en.dateNaissanceEnseignant,
    en.dateEmbaucheEnseignant,
    fc.idFaireCours,
    fc.annee,
    m.idMatiere,
    m.nomMatiere,
    m.idModule,
    m.coefficientMatiere
FROM enseignants en
INNER JOIN faire_cours fc ON fc.idEnseignant = en.idEnseignant
INNER JOIN matieres m ON m.idMatiere = fc.idMatiere ;
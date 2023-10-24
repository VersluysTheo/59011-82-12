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

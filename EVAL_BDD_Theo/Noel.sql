/* Creation DB */

DROP DATABASE IF EXISTS `noel`;
CREATE DATABASE IF NOT EXISTS `noel` ; /* Fonctionne uniquement que lorsque la DB existe déja */

/* Creation Table */


CREATE TABLE IF NOT EXISTS Lutin(
   Id_Lutin INT AUTO_INCREMENT,
   NomLutin VARCHAR(50) ,
   PrenomLutin VARCHAR(50) ,
   PRIMARY KEY(Id_Lutin)
);

CREATE TABLE Traineau(
   Id_Traineau INT AUTO_INCREMENT,
   Taille_Traineau DECIMAL(15,2) ,
   PRIMARY KEY(Id_Traineau)
);

CREATE TABLE Tournee(
   Id_Tournee INT AUTO_INCREMENT,
   Heure_Depart TIME,
   PRIMARY KEY(Id_Tournee)
);

CREATE TABLE Cadeau(
   Id_Cadeau INT AUTO_INCREMENT,
   Libelle_Cadeau VARCHAR(50) ,
   PRIMARY KEY(Id_Cadeau)
);

CREATE TABLE Renne(
   Id_Renne INT AUTO_INCREMENT,
   Nom_Renne VARCHAR(50) ,
   Sexe_Renne VARCHAR(10) ,
   Date_Naissance_Renne DATE,
   Id_Traineau INT NOT NULL,
   PRIMARY KEY(Id_Renne)
);

CREATE TABLE Enfant(
   Id_Enfant INT AUTO_INCREMENT,
   Nom_Enfant VARCHAR(50) ,
   Prenom_Enfant VARCHAR(50) ,
   Adresse_Enfant VARCHAR(256) ,
   Sexe_Enfant VARCHAR(1) ,
   Voeu_Enfant VARCHAR(50) ,
   Pourcentage_Sagesse INT,
   Id_Cadeau INT NOT NULL,
   PRIMARY KEY(Id_Enfant)
);

CREATE TABLE responsable(
   Id_Lutin INT,
   Id_Traineau INT,
   Date_Mise_en_Service DATE,
   Date_revision DATE,
   PRIMARY KEY(Id_Lutin, Id_Traineau)
);

CREATE TABLE grande_tournee(
   Id_Lutin INT,
   Id_Traineau INT,
   Id_Tournee INT,
   Id_Renne INT,
   PRIMARY KEY(Id_Lutin, Id_Traineau, Id_Tournee, Id_Renne)
);

CREATE TABLE distribution(
   Id_Tournee INT,
   Id_Cadeau INT,
   PRIMARY KEY(Id_Tournee, Id_Cadeau)
);


/* Contraintes */

ALTER TABLE Renne ADD CONSTRAINT FOREIGN KEY(Id_Traineau) REFERENCES Traineau(Id_Traineau);

ALTER TABLE Enfant ADD CONSTRAINT FOREIGN KEY(Id_Cadeau) REFERENCES Cadeau(Id_Cadeau);

ALTER TABLE grande_tournee
ADD CONSTRAINT FOREIGN KEY(Id_Lutin) REFERENCES Lutin(Id_Lutin),
ADD CONSTRAINT FOREIGN KEY(Id_Traineau) REFERENCES Traineau(Id_Traineau),
ADD CONSTRAINT FOREIGN KEY(Id_Tournee) REFERENCES Tournee(Id_Tournee),
ADD CONSTRAINT FOREIGN KEY(Id_Renne) REFERENCES Renne(Id_Renne);

ALTER TABLE responsable ADD CONSTRAINT FOREIGN KEY(Id_Lutin) REFERENCES Lutin(Id_Lutin),
ADD CONSTRAINT FOREIGN KEY(Id_Traineau) REFERENCES Traineau(Id_Traineau);

ALTER TABLE distribution ADD CONSTRAINT FOREIGN KEY(Id_Tournee) REFERENCES Tournee(Id_Tournee),
ADD FOREIGN KEY(Id_Cadeau) REFERENCES Cadeau(Id_Cadeau);

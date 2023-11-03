/* Creation BDD */ 

CREATE DATABASE IF NOT EXISTS `camping` ; 

Use `camping`;


/* Creation des Tables */


CREATE TABLE Client(
   Id_Client INT AUTO_INCREMENT,
   nom_client VARCHAR(50) ,
   prenom_client VARCHAR(50) ,
   adresse_client VARCHAR(50) ,
   numero_de_telephone VARCHAR(10) ,
   adresse_mail VARCHAR(50) ,
   PRIMARY KEY(Id_Client)
);

CREATE TABLE Type_d_emplacement(
   Id_Type_d_emplacement INT AUTO_INCREMENT,
   libelle_emplacement VARCHAR(50) ,
   PRIMARY KEY(Id_Type_d_emplacement)
);

CREATE TABLE Zone(
   Id_Zone INT AUTO_INCREMENT,
   libelle_zone VARCHAR(50) ,
   PRIMARY KEY(Id_Zone)
);

CREATE TABLE Activite(
   Id_Activite INT AUTO_INCREMENT,
   Libelle_activite VARCHAR(50) ,
   est_payante BOOLEAN,
   Id_Zone INT NOT NULL,
   PRIMARY KEY(Id_Activite)
);

CREATE TABLE Tarif_points(
   Id_Tarif_points INT AUTO_INCREMENT,
   libelle_mois VARCHAR(50) ,
   tarif_points DECIMAL(15,2)  ,
   PRIMARY KEY(Id_Tarif_points)
);

CREATE TABLE Emplacement(
   Id_Emplacement INT AUTO_INCREMENT,
   place_de_parking BOOLEAN,
   electricite BOOLEAN,
   nbr_points INT,
   Id_Zone INT NOT NULL,
   Id_Type_d_emplacement INT NOT NULL,
   PRIMARY KEY(Id_Emplacement)
);

CREATE TABLE Reservation(
   Id_Reservation INT AUTO_INCREMENT,
   date_reservation DATE,
   moyen_reservation VARCHAR(10) ,
   options_souhaitees VARCHAR(256) ,
   Id_Tarif_points INT NOT NULL,
   PRIMARY KEY(Id_Reservation)
);

CREATE TABLE Sejour(
   Id_Client INT,
   Id_Reservation INT,
   id_sejour INT AUTO_INCREMENT,
   date_debut DATE,
   date_fin DATE,
   date_envoi_acompte DATE,
   prix_sejour DECIMAL(15,2)  ,
   PRIMARY KEY(id_sejour)
);

CREATE TABLE prix_acompte(
   Id_Emplacement INT,
   Id_Reservation INT,
   id_prix_acompte INT AUTO_INCREMENT,
   date_butoir DATE,
   prix_acompte DECIMAL(15,2),
   PRIMARY KEY(id_prix_acompte)
);


/* Contraintes */


ALTER TABLE Activite ADD CONSTRAINT Activite_zone FOREIGN KEY(Id_Zone) REFERENCES Zone(Id_Zone);

ALTER TABLE Emplacement 
ADD CONSTRAINT Emplacement_zone FOREIGN KEY(Id_Zone) REFERENCES Zone(Id_Zone),
ADD CONSTRAINT Emplacement_type FOREIGN KEY(Id_Type_d_emplacement) REFERENCES Type_d_emplacement(Id_Type_d_emplacement);

ALTER TABLE Reservation ADD CONSTRAINT Reservation_Tarif FOREIGN KEY(Id_Tarif_points) REFERENCES Tarif_points(Id_Tarif_points);

ALTER TABLE Sejour 
ADD CONSTRAINT Sejour_client FOREIGN KEY(Id_Client) REFERENCES Client(Id_Client),
ADD CONSTRAINT Sejour_reservation FOREIGN KEY(Id_Reservation) REFERENCES Reservation(Id_Reservation);

ALTER TABLE prix_acompte
ADD CONSTRAINT acompte_emplacement FOREIGN KEY(Id_Emplacement) REFERENCES Emplacement(Id_Emplacement),
ADD CONSTRAINT acompte_reservation FOREIGN KEY(Id_Reservation) REFERENCES Reservation(Id_Reservation);


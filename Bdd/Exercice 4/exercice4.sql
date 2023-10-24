CREATE TABLE Departement(
   Id_Departement INT AUTO_INCREMENT,
   nodep INT,
   ville VARCHAR(50) ,
   nomdep VARCHAR(50) ,
   PRIMARY KEY(Id_Departement)
);

CREATE TABLE Employe(
   Id_Employe INT AUTO_INCREMENT,
   noemp INT NOT NULL,
   nomemp VARCHAR(50) ,
   fonction VARCHAR(50) ,
   noresp INT,
   datemb DATE,
   sala DECIMAL(19,4),
   comm DECIMAL(19,4),
   Id_Employe_1 INT,
   Id_Departement INT NOT NULL,
   PRIMARY KEY(Id_Employe),
   FOREIGN KEY(Id_Employe_1) REFERENCES Employe(Id_Employe),
   FOREIGN KEY(Id_Departement) REFERENCES Departement(Id_Departement)
);

CREATE TABLE Grade(
   Id_Grade INT AUTO_INCREMENT,
   nograde INT,
   salmin DECIMAL(19,4),
   salmax DECIMAL(19,4),
   PRIMARY KEY(Id_Grade)
);

CREATE TABLE Histofonction(
   Id_Histofonction INT AUTO_INCREMENT,
   datenom DATE,
   fonction VARCHAR(50) ,
   PRIMARY KEY(Id_Histofonction)
);

CREATE TABLE possede(
   Id_Employe INT,
   Id_Histofonction INT,
   PRIMARY KEY(Id_Employe, Id_Histofonction),
   FOREIGN KEY(Id_Employe) REFERENCES Employe(Id_Employe),
   FOREIGN KEY(Id_Histofonction) REFERENCES Histofonction(Id_Histofonction)
);

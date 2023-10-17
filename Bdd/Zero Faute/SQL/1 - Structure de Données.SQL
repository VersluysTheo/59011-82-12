
// Table Faute

DROP TABLE IF EXISTS Faute;

CREATE TABLE Faute(
    PRIMARY KEY(Id_Faute),
   Id_Faute COUNTER,
   Libellé_Faute VARCHAR(50),
   Commentaire_Faute VARCHAR(50),
   Date_Detection DATE,
   Date_Reparation DATE
);

// Table Produit

DROP TABLE IF EXISTS Produit;

CREATE TABLE Produit(
    Id_Produit INT AUTO_INCREMENT PRIMARY KEY,
   Nom_Produit VARCHAR(50),
   Numero_de_Serie INT,
   Année_de_Production DATE
);


// Table Modèle

DROP TABLE IF EXISTS Modèle;

CREATE TABLE Modele(
   Id_Modele INT AUTO_INCREMENT PRIMARY KEY,
   Nom_modele VARCHAR(50),
   Code_Modele VARCHAR(50),
   Date_Mise_sur_le_Maché_Modele DATE
);



// Table Catégories

DROP TABLE IF EXISTS Catégories;

CREATE TABLE Categories(
     Id_Categories INT AUTO_INCREMENT PRIMARY KEY,
   Nom_Categorie VARCHAR(50),
   Description_Categorie VARCHAR(50),
   Nom_Sous_Categorie VARCHAR(50),
   Description_Sous_Categorie VARCHAR(50)
);


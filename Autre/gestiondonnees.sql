CREATE TABLE TypesProduits(
   Id_TypesProduits INT AUTO_INCREMENT,
   LibelleTypeProduit VARCHAR(50) ,
   PRIMARY KEY(Id_TypesProduits)
);

CREATE TABLE Categories(
   Id_Categories INT AUTO_INCREMENT,
   LibelleCategorie VARCHAR(50) ,
   Id_TypesProduits INT NOT NULL,
   PRIMARY KEY(Id_Categories),
   FOREIGN KEY(Id_TypesProduits) REFERENCES TypesProduits(Id_TypesProduits)
);

CREATE TABLE Articles(
   Id_Articles INT AUTO_INCREMENT,
   LibelleArticle VARCHAR(50) ,
   QuantiteStockee INT,
   Id_Categories INT NOT NULL,
   PRIMARY KEY(Id_Articles),
   FOREIGN KEY(Id_Categories) REFERENCES Categories(Id_Categories)
);

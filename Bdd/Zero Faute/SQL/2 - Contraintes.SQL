
// Contraintes 

//Table Modele

ALTER TABLE Modele
ADD FOREIGN KEY(Id_Produit) REFERENCES Produit(Id_Produit);


// Table Faute

ALTER TABLE Faute
ADD FOREIGN KEY(Id_Produit) REFERENCES Produit(Id_Produit);
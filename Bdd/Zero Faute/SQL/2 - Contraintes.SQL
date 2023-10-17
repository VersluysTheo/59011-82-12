
// Contraintes 

ALTER TABLE Modele
ADD FOREIGN KEY(Id_Produit) REFERENCES Produit(Id_Produit);
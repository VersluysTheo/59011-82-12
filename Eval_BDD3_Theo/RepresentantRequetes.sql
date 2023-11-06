/* 1 Tous les détails de tous les clients. */

Select `idClient`, `nomClient`,`VilleClient` FROM clients;


/* 2 Les numéros et les noms des produits de couleur rouge et de poids supérieur à 2000. */

Select `idProduit`, `nomProduit` FROM produits WHERE `CouleurProduit` = "Rouge" AND `PoidsProduit` > 2000 ;


/* 3 Les noms des représentants ayant vendu au moins un produit trié par ordre alphabétique. */

Select DISTINCT r.NomRepres FROM representants r
INNER JOIN ventes v ON r.idRepres = v.idRepres
ORDER BY r.NomRepres ASC;

/* 4 Les noms des clients de Paris ayant acheté un produit pour une quantité supérieure à 180 */

Select DISTINCT c.NomClient FROM clients c
INNER JOIN ventes v ON c.idClient = v.idClient
WHERE c.VilleClient = "Paris" AND v.Quantite > 180;

/* 5 Les noms des représentants et les clients à qui ces représentants ont vendu un produit de couleur rouge pour une quantité supérieure à 100. */

SELECT r.NomRepres, c.NomClient FROM representants r
INNER JOIN ventes v ON r.idRepres = v.idRepres
INNER JOIN clients c ON v.idClient = c.idClient
INNER JOIN produits p ON v.idProduit = p.idProduit
WHERE p.CouleurProduit = "Rouge" AND v.Quantite > 100;


/* 6 Les produits et le nombre vendus */

SELECT p.NomProduit, SUM(v.Quantite) AS "Vente de ce Produit" FROM ventes v
INNER JOIN produits p ON v.idProduit = p.idProduit
GROUP BY p.NomProduit;

/* 7 Les clients ayant achetés plus que la moyenne. */

Select c.NomClient, c.VilleClient, SUM(v.Quantite) AS "Sommevente" FROM clients c
INNER JOIN ventes v ON c.idClient = v.idClient
GROUP BY c.NomClient, c.VilleClient
HAVING Sommevente > ( SELECT AVG(`Quantite`) FROM ventes);


/* 8 Créer une vue pleine entre clients et ventes */

CREATE VIEW clients_ventes AS
SELECT 
    c.IdClient,
    c.NomClient,
    c.VilleClient,
    v.IdVente,
    v.IdRepres,
    v.IdProduit,
    v.Quantite
FROM clients c
INNER JOIN ventes v ON c.idClient = v.idClient;
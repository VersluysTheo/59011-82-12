let tableau = document.querySelectorAll("#tableau");

tableau.forEach(element => {
    // selectionne les element du tableau
element.addEventListener("change", function() {
    // ajoute a l'evenement change la valeur de la quantité et la unitaire une action de calcul
        let quantite = element.querySelector("#quantite");
        quantite = quantite.value;
        // quantite

        let unitaire = element.querySelector("#unitaire");
        unitaire = unitaire.value;
        // unitaire

        let prix = element.querySelector("#prix");
        prix.value = quantite * unitaire;
        // calcul du prix

        let Prixtotal = document.querySelectorAll("#prix");


        Prixtotal.forEach(element => {
            element.addEventListener("change", function() {
                Prixtotal = prix.value + prix.value;
                let total = element.querySelector("#total");
                Prixtotal = total.value;
            }
        );
        console.log(total.value);
        });
    });
});

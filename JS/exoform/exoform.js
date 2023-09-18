let myForm = document.querySelector('#myForm');
let butSubmit = document.getElementById('submit');


// fonction pour afficher le message

function showMessage(input, message, type) {
	const msg = input.parentNode.querySelector("small");
	msg.innerText = message;
	input.className = type ? "success" : "error";
	return type;
}

// Fonction en cas d'echec

function showError(input, message) {
	return showMessage(input, message, false);
}

// Fonction en cas de réussite

function showSuccess(input) {
	return showMessage(input, "", true);
}

// Fonction du message a afficher

function hasValue(input, message) {
	if (input.value.trim() == "") {
		return showError(input, message);
	}
	return showSuccess(input);
}

function validateName(input, requiredMsg, invalidMsg) {
    // nom vide ?
    if (!hasValue(input, requiredMsg)) {
        return false;
    }
    const nameRegex = /^[a-zA-ZÀ-ÿ\s]+$/;

    // Verif nom
    const nom = input.value.trim();
    if (!nameRegex.test(nom)){
        return showError(input, invalidMsg);
    }
    return true;
}

const nomPattern = "[A-Za-z]*";
function validatenamePattern(nomPattern){
	if (nomPattern = myForm.nom.pattern) {
		myForm.setAttribute(nom.title, "title");
}
}

function validateNumero(input, requiredMsg, invalidMsg) {
	// Numero vide?
	if (!hasValue(input, requiredMsg)) {
		return false;
	}
	const numRegex = /^(0)[1-9][0-9]{8}$/;

	// Verif numero
	const numero = input.value.trim();
    if (!numRegex.test(numero)) {
        return showError(input, invalidMsg);
    }
    return true;
}

function validatePostal(input, requiredMsg, invalidMsg) {
	//Code postal vide ?
	if (!hasValue(input, requiredMsg)) {
        return false;
    }
    const postalRegex = /^[0-9]{5}$/;

    // Verif code postal
    const codePostal = input.value.trim();
    if (!postalRegex.test(codePostal)) {
        return showError(input, invalidMsg);
    }
    return true;
}

function validateEmail(input, requiredMsg, invalidMsg) {
	// Email vide ?
	if (!hasValue(input, requiredMsg)) {
		return false;
	}

    // Regex mail
	const emailRegex =
		/^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;

        // Verif mail
	const email = input.value.trim();
	if (!emailRegex.test(email)) {
		return showError(input, invalidMsg);
	}
	return true;
}

function validateMotdePasse(input, requiredMsg, invalidMsg) {
	// Mot de passe vide?
    if (!hasValue(input, requiredMsg)) {
        return false;
    }

    // Regex mot de passe
    const motdepasseRegex = /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}$/;

    // Verif mot de passe
    const motdepasse = input.value.trim();
    if (!motdepasseRegex.test(motdepasse)) {
        return showError(input, invalidMsg);
    }
    return true;
}




// Mot de passe ecrit à la main
let elmotdepasse = document.getElementById('mdp');
elmotdepasse.onpaste = function(e) {
	e.preventDefault();
};



// Messages d'erreur

const NOM_REQUIS = "Entrez votre Nom";
// const NOM_INVALIDE = "Ceci n'est pas un nom valide";
const NUMERO_REQUIS = "Entrez votre numero";
// const NUMERO_INVALIDE = "Ceci n'est pas un numero valide";
const POSTAL_REQUIS = "Entrez votre code postal";
// const POSTAL_INVALIDE = "Ceci n'est pas un code postal valide";
const EMAIL_REQUIS = "Entrez votre mail";
// const EMAIL_INVALIDE = "Ceci n'est pas une adresse email valide";
const MOTDEPASSE_REQUIS = "Entrez votre mot de passe";
// const MOTDEPASSE_INVALIDE = "Le mot de passe n'est pas assez fort";

myForm.addEventListener("submit", function (event) {

	event.preventDefault();
	
    // Verification

	let nameValid = validateName(myForm.elements["nom"], NOM_REQUIS);
	let numeroValid = validateNumero(myForm.elements["numero"], NUMERO_REQUIS);
	let postalValid = validatePostal(myForm.elements["postal"], POSTAL_REQUIS);
	let emailValid = validateEmail(myForm.elements["email"], EMAIL_REQUIS);
	let motdepasseValid = validateMotdePasse(myForm.elements["mdp"], MOTDEPASSE_REQUIS);
	if (nameValid && emailValid && numeroValid && postalValid && motdepasseValid) {
		alert("Oui");
	}
});

// myForm.addEventListener("click", function () {
// 	console.log(input.nom);
// });
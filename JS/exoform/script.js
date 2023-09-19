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

// Validation REGEX en HTML (Nom)

const nomPattern = "[A-Za-z]*";
function validatenamePattern(nomPattern){
	if (nomPattern != myForm.elements['nom'].pattern) {
		myForm.elements['nom'].setAttribute("title", "Le nom ne doit pas contenir de chiffres");
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

// Validation REGEX en HTML (numero)

const numeroPattern = "0+([0-9]{9})";
function validatenumeroPattern(numeroPattern){
	if(numeroPattern != myForm.elements['numero'].pattern) {
		myForm.elements['numero'].setAttribute("title", "Un numéro est une suite de 10 chiffres commencant par 0");
}	
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

// Validation REGEX en HTML (code postal)

const postalPattern = "[0-9]{5}";
function validatepostalPattern(postalPattern){
	if(postalPattern != myForm.elements['postal'].pattern) {
		myForm.elements['postal'].setAttribute("title", "Un code postal est une suite de 5 Chiffres");
}	
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

// const emailPattern = "[a-zA-Z0-9._\\-]{1,50}@[a-zA-Z0-9]{1,50}.[a-zA-Z]{1,10}";
// function validateemailPattern(emailPattern){
// 	if(emailPattern != myForm.elements['email'].pattern) {
// 		myForm.elements['email'].removeAttribute('title');
// 		myForm.elements['email'].setAttribute("title", "Voici un exemple d'addresse mail valide : Jesuisuneadressemail@gmail.com");
// }	
// }

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

// Validation REGEX en HTML ( Mot de Passe )

const mdpPattern = "[a-zA-Z0-9!@#$%^&*_=+\-].{12,}";
function validatemdpPattern(mdpPattern){
	if(mdpPattern != myForm.elements['mdp'].pattern) {
		myForm.elements['mdp'].removeAttribute('title');
		myForm.elements['mdp'].setAttribute("title", "Un Mot de Passe sécurisé contient : 12 Caractères dont au minimum une majuscule, une minuscule, un chiffre et un caractère spécial");
}	
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
const EMAIL_INVALIDE = "Ceci n'est pas une adresse email valide";
const MOTDEPASSE_REQUIS = "Entrez votre mot de passe";
const MOTDEPASSE_INVALIDE = "Le mot de passe n'est pas assez fort";

myForm.addEventListener("click", function(){
	validatenamePattern();
	validatenumeroPattern();
	validatepostalPattern();
	validatemdpPattern();
})


myForm.addEventListener("submit", function (event) {
	
    // Verification

	event.preventDefault();

	let nameValid = validateName(myForm.elements["nom"], NOM_REQUIS);
	let numeroValid = validateNumero(myForm.elements["numero"], NUMERO_REQUIS);
	let postalValid = validatePostal(myForm.elements["postal"], POSTAL_REQUIS);
	let emailValid = validateEmail(myForm.elements["email"], EMAIL_REQUIS, EMAIL_INVALIDE);
	let motdepasseValid = validateMotdePasse(myForm.elements["mdp"], MOTDEPASSE_REQUIS , MOTDEPASSE_INVALIDE);
	if (nameValid && emailValid && numeroValid && postalValid && motdepasseValid) {
		alert("Simulation d'envoi de données");
	}
	}
);
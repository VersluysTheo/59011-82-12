<?php

class Voiture
{
    /*****************Attributs***************** */
    private $_couleur;
    private $_marque;
    private $_modele;
    private $_nbDeKm;
    private $_motorisation;

    

    public function getCouleur()
    {
        return $this->_couleur;
    }

    public function setCouleur($couleur)
    {
        $this->_couleur = $couleur;
    }

    public function getMarque()
    {
        return $this->_marque;
    }

    public function setMarque($marque)
    {
        $this->_marque = $marque;
    }

    public function getModele()
    {
        return $this->_modele;
    }

    public function setModele($modele)
    {
        $this->_modele = $modele;
    }

    public function getNbDeKm()
    {
        return $this->_nbDeKm;
    }

    public function setNbDeKm($nbDeKm)
    {
        $this->_nbDeKm = $nbDeKm;
    }

    public function getMotorisation()
    {
        return $this->_motorisation;
    }

    public function setMotorisation($motorisation)
    {
        $this->_motorisation = $motorisation;
    }

    /*****************Constructeur***************** */

    public function __construct(array $options = [])
    {
        if (!empty($options)) // empty : renvoi vrai si le tableau est vide
        {
            $this->hydrate($options);
        }
    }
    public function hydrate($data)
    {
        foreach ($data as $key => $value) {
            $methode = 'set' . ucfirst($key);
            if (is_callable([$this, $methode])) {
                $this->$methode($value);
            }
        }
    }

    /*****************Autres Méthodes***************** */

    public function __toString()
    {
        return "Cette voiture est de marque " . $this->getMarque() . ", de couleur " . $this->getCouleur() . ", de motorisation " . $this->getMotorisation() . ", avec " . $this->getNbDeKm() . " Kilomètres. ";
    }

    public function concatenation()
    {
        echo $this->__toString();
    }

    public function rouler($valeur){
        $this->setNbDeKm($this->getnbDeKm() + $valeur);
    }
}





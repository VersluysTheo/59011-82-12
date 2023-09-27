<?php

class Agence
{
/*****************Attributs***************** */
    private $_nom;
    private $_adresse;
    private $_codepostal;
    private $_ville;
    private $_modeRestauration;

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
    foreach ($data as $key => $value)
    {
    $methode = 'set' . ucfirst($key);
    if (is_callable([$this, $methode]))
        {
    $this->$methode($value);
        }
    }
}

    public function getNom()
    {
        return $this->_nom;
    }

    public function setNom($nom)
    {
        $this->_nom = $nom;
    }

    public function getAdresse()
    {
        return $this->_adresse;
    }

    public function setAdresse($adresse)
    {
        $this->_adresse = $adresse;
    }

    public function getCodepostal()
    {
        return $this->_codepostal;
    }

    public function setCodepostal($codepostal)
    {
        $this->_codepostal = $codepostal;
    }

    public function getVille()
    {
        return $this->_ville;
    }

    public function setVille($ville)
    {
        $this->_ville = $ville;
    }

    public function getModeRestauration()
    {
        return $this->_modeRestauration;
    }

    public function setModeRestauration($modeRestauration)
    {
        $this->_modeRestauration = $modeRestauration;
    }
}
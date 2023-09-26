<?php

class Pave extends Rectangle
{
    /**********Attributs****************/
    private $_hauteur;

/*************Constructeurs***********/

    public function getHauteur()
    {
        return $this->_hauteur;
    }

    public function setHauteur($hauteur)
    {
        $this->_hauteur = $hauteur;
    }

        /********Autres Methodes*************/
        function perimetre()
        {
            return (parent::perimetre()*2+$this->getHauteur()*4);
        }
        function volume(){
            return (parent::aire()* $this->getHauteur()); 
        }
        function __toString()
        {
            return "Pave => Perimetre : [" . $this->perimetre() . "] - " . "Volume : [" . $this->volume() . "]";
        }
        
        function Afficher(){
            echo $this->__toString();
        }
}


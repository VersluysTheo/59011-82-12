<?php 

class Pyramide extends Trianglerectangle
{
        /*****************Autres Méthodes***************** */
        function perimetre()
        {
            return ((parent::perimetre()*2) + (parent::getHauteur()*3));
        }
        function volume(){
            return (parent::aire()*parent::getHauteur());
        }

        function __toString()
    {
        return "Pyramide => Perimetre : [" . $this->perimetre() . "] - " . "Volume : [" . $this->volume() . "]";
    }
        function Afficher(){
        echo $this->__toString();
    }
}
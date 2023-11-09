<?php 

class Sphere extends Cercle
{
    /*****************Autres Méthodes***************** */

        function perimetre()
        {
            return round((2*pi()*parent::getDiametre()/2),2);
        }

        function volume()
        {
            return round(((4/3)*pi()*((parent::getDiametre()/2)**3)),2);
        }

        function __toString()
    {
        return "Sphere=> Perimetre : [" . $this->perimetre() . "] - " . "Volume : [" . $this->volume() . "]";
    }
        function Afficher(){
            echo $this->__toString();
        }
}
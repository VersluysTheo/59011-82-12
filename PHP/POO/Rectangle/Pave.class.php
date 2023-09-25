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
            $perimetre = $this->getHauteur() + 2;
            return $perimetre;
        }
}
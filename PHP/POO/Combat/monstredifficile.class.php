<?php

class MonstreDifficile extends MonstreFacile
{
        /************Attributs************************/
        static $Nbmonstre;
        const DEGATS_SORT = 5;

        /***************Constructeurs*************************/

        public function __construct(array $options = [])
        {
            if (!empty($options)) // empty : renvoi vrai si le tableau est vide
            {
            $this->hydrate($options);
            }
            self::$Nbmonstre++;
        }

        /*****************Autres Méthodes***************** */
        public function Attaque($joueur)
        {
            return "" ;
        }

        public function Subitdegat()
        {
            return "";
        }

        public function sortmagique(){
            $sortmag = Dice::Lancerlede();
            $degatmag = $sortmag * 5 ;
            return $degatmag;
        }
}
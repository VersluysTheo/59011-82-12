<?php

class MonstreDifficile extends MonstreFacile
{
#region Attributs

        /************Attributs************************/
        static $Nbmonstre;
        const DEGATS_SORT = 5;

#regionend Attributs
#region Constructeur

        /***************Constructeurs*************************/

        public function __construct(array $options = [])
        {
            if (!empty($options)) // empty : renvoi vrai si le tableau est vide
            {
            $this->hydrate($options);
            }
            self::$Nbmonstre++;
        }

#endregion Constructeur
#region Autres methodes

        /*****************Autres Méthodes***************** */
        public function Attaque($joueur)
        {
            $joueurde = Joueur::Lancerlede();
            $monstrediffde = MonstreDifficile::Lancerlede();
            if (($monstrediffde < $joueurde) && (Joueur::Bouclier() == false)){
                return $joueur->Subitdegat(MonstreFacile::DEGATS);
                $this->sortmagique();
            } else {
                return "";
            };
        }

        public function Subitdegat()
        {
            return "";
        }

        public function sortmagique(){
            $sortmag = Dice::Lancerlede();
            $degatmag = $sortmag * MonstreDifficile::DEGATS_SORT ;
            return $degatmag;
        }
#endregion Autre methodes      
}
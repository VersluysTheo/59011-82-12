<?php 

class MonstreFacile
{

#region Attribut

/*****************Attributs***************** */
    protected $_Estenvie;
    static $Nbmonstre;
    const DEGATS = 10;

#endregion Attribut

#region Constructeur

/*****************Constructeur***************** */

    public function __construct(array $options = [])
{
    if (!empty($options)) // empty : renvoi vrai si le tableau est vide
    {
    $this->hydrate($options);
    }
    self::$Nbmonstre++;
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

    public function getEstenvie()
    {
        return $this->_Estenvie;
    }

    public function setEstenvie($Estenvie)
    {
        $this->_Estenvie = $Estenvie;
    }


#endregion Constructeur


#region Autres Methodes

    /*****************Autres Méthodes***************** */

    public function Attaque($joueur){ // Fonction d'attaque
        $joueurde = Joueur::Lancerlede();
        $monstrede = MonstreFacile::Lancerlede();
        if ($monstrede <= $joueurde){
            return $joueur->Subitdegat(MonstreFacile::DEGATS);
        } else {
            return "";
        };
    }
    public static function Lancerlede(){ // Lancer de des 
        return Dice::Lancerlede();
    }
    public function Subitdegat(){
        return "" ;
    }

    #endregion Autre Methodes

}
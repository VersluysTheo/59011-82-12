<?php 
class GenPoco {

    /**
     * Fonction pour générer les attributs et les accesseurs
     * toto = classe et le tableau = $colonnes
     *
     * @param string $table
     * @param array $colonnes
     * @return string
     */
    public static function createPoco($table,$colonnes): string
    {
        $pocoStr  = self::generateAttributes($table,$colonnes);
        $pocoStr .= self::generateConstruct();
        return $pocoStr .= self::generateToString($colonnes);
    }

    /**
     * Fonction pour générer les constructeurs
     *
     * @return string
     */
    private static function generateAttributes($table,$colonnes)
    {
        $return= "<?php" . "\n";
        $return.= "\n" ;
        $return.= "class " . ucfirst($table) . "\n" ;
        $return.= "{" . "\n" ;
        //Attributs
        $return.= " /*****************Attributs*********************/ " . "\n";
        foreach ($colonnes as $key => $value) {
            $return.= " private ". '$_' . $value. ";". "\n";
            $return.= "\n" ;
        }
        $return.= " private static " . '$_attributes' . "[" ;
        foreach ($colonnes as $key => $value){
            $return.= "$value,";
        }
        // On retire la virgule
        $return.= substr($return,0,-1);
        $return.= "]" . "\n";
        $return.= "\n" . "\n";
        //Accesseurs
        $return.= " /******************Accesseurs*******************/" . "\n";
        $return.= "\n" ;

        /** fonction Getter
         * return string
         */

        foreach ($colonnes as $key => $value) {
        $return.= "     public function get" . ucfirst($value) . "()" . "\n";
        $return.= " {" . "\n";
        $return.= "     return " . '$this' . '->_' . $value . ";" ."\n";
        $return.= " }" . "\n" ;
        $return.= "\n" ;
        }

        /** fonction Setter
         * return string
         */
        foreach ($colonnes as $key => $value) {
            // dans ce cas :
            // $key => int(0), int(1) etc
            // $value => "nom de la colonne"
            // Dans le cas du tableau "Id... => int" remplacer $value par $key
            if (str_contains($value, 'id')){
                $type = "?int";
            } else if (str_contains($value, 'date')){
                $type ="date";
            } else {
                $type = "string";
            }
            $return.= "     public function set" . ucfirst($value) . "(" . $type . " " . '$' . $value . ")" . "\n";
            $return.= " {" . "\n";
            $return.= '     $this' . '->_' . $value . " = " . '$' . $value . ";" . "\n";
            $return.= " }" . "\n" ;
            $return.= "\n" ;
            }
        // fonction get attributes
        $return.= "     public static function getAttributes()". "\n";
        $return.= " {". "\n";
        $return.= "     return self::" . '$_attributes' . ";" . "\n";
        $return.= " }". "\n" ;
        $return.= " }". "\n";
        //var_dump($return);
        return $return;
    }
        
    /**
     * Permet de créer la fonction construct et hydrate
     *
     * @return void
     */
    private static function generateConstruct()
    {
        $aff = '';

        $aff .= "public function __construct(array \$options = [])\n";
        $aff .= "   {\n";
        $aff .= "    if (!empty(\$options))\n";
        $aff .= "    {\n";
        $aff .= "        \$this->hydrate(\$options);\n";
        $aff .= "    }\n";
        $aff .= "   }\n\n";

        $aff .= "public function hydrate(\$data)\n";
        $aff .= "   {\n";
        $aff .= "    foreach (\$data as \$key => \$value) {\n";
        $aff .= "        \$method = \"set\" . ucfirst(\$key);\n";
        $aff .= "        if (is_callable([\$this, \$method]))\n";
        $aff .= "        {\n";
        $aff .= "            \$this->\$method(\$value);\n";
        $aff .= "        }\n";
        $aff .= "    }\n";
        $aff .= "   }\n";

        return $aff;
    }

    /**
     * Transforme l'objet en chaine de caractères
     *
     * @return string
     */
     public static function generateToString(array $tableauColonnes)
     {
         $aff = '/**'."\n";
         $aff .= ' * Transforme l\'objet en chaîne de caractères'."\n";
         $aff .= ' *'."\n";
         $aff .= ' * @return string'."\n";
         $aff .= ' */'."\n";
         $aff .= 'public function toString(){'."\n";
         $aff .= '{'."\n";
         $aff .= '   return';
         $tableauAff = [];
         foreach($tableauColonnes as $colonnes => $value)
         {
             if($value == "array")
             {
                 $tableauAff[$colonnes] = ' "'.ucfirst($value).' : [".';
                 $tableauAff[$colonnes] .= "implode(";
                 $tableauAff[$colonnes] .= '", ",$this->get'; 
                 $tableauAff[$colonnes] .= ucfirst($value);
                 $tableauAff[$colonnes] .= '())."] . ';
             }
             else
             {
                 $tableauAff[$colonnes] = ' "'.ucfirst($value).' : "';
                 $tableauAff[$colonnes] .= ". \$this->get"; 
                 $tableauAff[$colonnes] .= ucfirst($value);
                 $tableauAff[$colonnes] .= "() . ";
             }
         }
         $aff .= implode('", " .',$tableauAff);
         $aff .= '"\n";'."\n";
         $aff .= '}'."\n";
         return $aff;
     }
}
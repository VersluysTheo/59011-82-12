<?php 

// pour un Poco 
// Generer attribut ( table et colonnes ) avec leurs setter et getter ( et attributs )
// Table = classe et colonnes = attributs

function generateattributes($table,$colonnes)
{
    $return= "<?php" . "\n";
    $return.= "\n" ;
    $return.= "class " . $table . "\n" ;
    $return.= "{" . "\n" ;
    //Attributs
    $return.= " /*****************Attributs*********************/ " . "\n";
    foreach ($colonnes as $key => $value) {
        $return.= " private ". '$_' . $value. ";". "\n";
    }
    $return.= "private static " . '$_attributes' . " = [" . implode("," ,$colonnes) . "]";
    $return.= "\n" ;
    $return.= "\n" . "\n";
    //Accesseurs
    $return.= " /******************Accesseurs*******************/" . "\n";
    $return.= "\n" ;
    // fonction getter
    foreach ($colonnes as $key => $value) {
    $return.= " public function get" . ucfirst($value) . "()" . "\n";
    $return.= "{" . "\n";
    $return.= "     return " . '$this' . '->_' . $value . "\n";
    $return.= "}" . "\n" ;
    $return.= "\n" ;
    }
    // fonction setter
    foreach ($colonnes as $key => $value) {
        $return.= " public function set" . ucfirst($value) . "()" . "\n";
        $return.= "{" . "\n";
        $return.= '     $this' . '->_' . $value . "=" . '$' . $value . "\n";
        $return.= "}" . "\n" ;
        $return.= "\n" ;
        }
    // fonction get attributes
    $return.= "public static function getAttributes()". "\n";
    $return.= "{". "\n";
    $return.= "     return self::" . '$_attributes' . ";" . "\n";
    $return.= "}". "\n" ;
    //Partie de Florent 
    // Construct
    $return.= "\n" . "\n";
    $return.= " /******************Construct*******************/" . "\n" . "\n";
    $return.= "public function __construct(array \$options = [])\n";
    $return.= "{\n";
    $return.= "    if (!empty(\$options))\n";
    $return.= "    {\n";
    $return.= "        \$this->hydrate(\$options);\n";
    $return.= "    }\n";
    $return.= "}\n";
    // Hydrate
    $return.= "public function hydrate(\$data)\n";
    $return.= "{\n";
    $return.= "    foreach (\$data as \$key => \$value) {\n";
    $return.= "        \$method = \"set\" . ucfirst(\$key);\n";
    $return.= "        if (is_callable([\$this, \$method]))\n";
    $return.= "        {\n";
    $return.= "            \$this->\$method(\$value);\n";
    $return.= "        }\n";
    $return.= "    }\n";
    $return.= "}\n";
    // fonction to string
    $return.= "public function toString()\n";
    $return.= "{\n";

    $return.= "}\n";
    return $return;
}

// generateattributes("toto", ["nom","prenom"]);
var_dump(generateattributes("toto", ["nom","prenom"]));
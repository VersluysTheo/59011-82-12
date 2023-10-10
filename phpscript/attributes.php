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
    
/**
 * Permet de créer la fonction construct
 *
 * @return void
 */
function generateConstruct()
{
    $aff = '';

    $aff .= "public function __construct(array \$options = [])\n";
    $aff .= "{\n";
    $aff .= "    if (!empty(\$options))\n";
    $aff .= "    {\n";
    $aff .= "        \$this->hydrate(\$options);\n";
    $aff .= "    }\n";
    $aff .= "}\n";

    return $aff;
}

/**
 * Permet de créer la fonction hydrate
 *
 * @return void
 */
function generateHydrate()
{
    $aff = '';

    $aff .= "public function hydrate(\$data)\n";
    $aff .= "{\n";
    $aff .= "    foreach (\$data as \$key => \$value) {\n";
    $aff .= "        \$method = \"set\" . ucfirst(\$key);\n";
    $aff .= "        if (is_callable([\$this, \$method]))\n";
    $aff .= "        {\n";
    $aff .= "            \$this->\$method(\$value);\n";
    $aff .= "        }\n";
    $aff .= "    }\n";
    $aff .= "}\n";

    return $aff;
}

/**
 * Transforme l'objet en chaine de caractères
 *
 * @return String
 */
function generateToString()
{
    $aff = '';

    $aff .= "public function toString()\n";
    $aff .= "{\n";
    $aff .= "    \$properties = get_object_vars(\$this);\n";
    $aff .= "    \$output = [];\n";
    $aff .= "    foreach (\$properties as \$name => \$value) {\n";
    $aff .= "        \$output[] = \"\$name : \$value\";\n";
    $aff .= "    }\n";
    $aff .= "    return implode(\", \", \$output);\n";
    $aff .= "}\n";

    return $aff;
}

// generateattributes("toto", ["nom","prenom"]);
var_dump(generateattributes("toto", ["nom","prenom"]));

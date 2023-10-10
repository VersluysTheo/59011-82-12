<?php 

class Parametres
{
/*****************Attributs***************** */
    private static $_host;
    private static $_port;
    private static $_user;
    private static $_password;
    private static $_dbname;

/*****************Constructeur***************** */

    public function __construct(array $options = [])
{
    if (!empty($options)) // empty : renvoi vrai si le tableau est vide
    {
    $this->hydrate($options);
    }
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

    /**
     * Get the value of _host
     */ 
    public static function get_host()
    {
        return self::$_host;
    }

    public static function set_host($value){
        self::$_host = $value;
    }

    /**
     * Get the value of _port
     */ 
    public static function get_port()
    {
        return self::$_port;
    }

    public static function set_port($value){
        self::$_port = $value;
    }

    /**
     * Get the value of _user
     */ 
    public static function get_user()
    {
        return self::$_user;
    }

    public static function set_user($value){
        self::$_user = $value;
    }


    /**
     * Get the value of _password
     */ 
    public static function get_password()
    {
        return self::$_password;
    }

    public static function set_password($value){
        self::$_password = $value;
    }


    /**
     * Get the value of _dbname
     */ 
    public static function get_dbname()
    {
        return self::$_dbname;
    }

    public static function set_dbname($value){
        self::$_dbname = $value;
    }


    public static function init(){
    $jsonStr = file_get_contents("config.json");
    $config = json_decode($jsonStr,true); // Decode du fichier Json
    // var_dump($config);
    $database = $config["database"];
    //Setter
    // self::set_host($database["host"]);
    // var_dump(self::get_host());

    // Boucle pour les valeurs du json
        foreach ($database as $key => $value){
            if($key == "host"){
                self::set_host($value);
            } else if($key == "port"){
                self::set_port($value);
            } else if($key == "user"){
                self::set_user($value);
            } else if ($key == "password"){
                self::set_password($value);
            } else if ($key == "dbname"){
                self::set_dbname($value);
            }
            else{
                echo "Il n'y a pas de " . $key ;
            }
        }
    }
}
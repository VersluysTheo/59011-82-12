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
    $config = json_decode($jsonStr,true);
    var_dump($config);
    $database = $config["database"];
    var_dump($database["host"]);
    self::set_host($database["host"]);
    var_dump(self::get_host());
        // foreach ($database as $key => $value){
        //     var_dump(($value));
        // }
    }
}
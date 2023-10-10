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

    /**
     * Get the value of _port
     */ 
    public static function get_port()
    {
        return self::$_port;
    }

    /**
     * Get the value of _user
     */ 
    public static function get_user()
    {
        return self::$_user;
    }


    /**
     * Get the value of _password
     */ 
    public static function get_password()
    {
        return self::$_password;
    }


    /**
     * Get the value of _dbname
     */ 
    public static function get_dbname()
    {
        return self::$_dbname;
    }

}
<?php 

class AuthorEditor extends User implements Author, Editor
{
/*****************Attributs***************** */
    private $_authorPrivilegesArray;
    private $_editorPrivilegeArray;

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


    public function setAuthorprivileges(array $authorPrivilegesArray){
        $this->_authorPrivilegesArray = $authorPrivilegesArray;
    }
    public function getAuthorprivileges(){
        return $this->_editorPrivilegeArray;
    }
    public function setEditorPrivileges(array $editorPrivilegeArray){
        $this->_editorPrivilegeArray = $editorPrivilegeArray;
    }
    public function getEditorPrivileges(){
        return $this->_authorPrivilegesArray;
    }
}
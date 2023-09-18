<?php 

class leForm{
    public $id = 'int';
    public $name = 'string';
    public $postal = 'int';
    public $email = 'string';
    public $password = 'string';
    public function __construct($newId = null, $newName = null, $newPostal = null, $newEmail = null, $newPassword = null) {
        $this->id = $newId;
        $this->name = $newName;
        $this->postal = $newPostal;
        $this->email = $newEmail;
        $this->password = $newPassword;
    }

    public function generateForm() {
        $form = '<form>';
        $form .= '<input type="hidden" id="id" name="id" value="' . $this->id . '" "><br><br>';

        $form .= '<label for="name">Name : </label>';
        $form .= '<input type="text" id="name" name="name" value="' . $this->name . '"><br><br>';

        $form .= '<label for="postal">Postal : </label>';
        $form .= '<input type="text" id="postal" name="postal" value="' . $this->postal . '"><br><br>';

        $form .= '<label for="email">Email : </label>';
        $form .= '<input type="text" id="email" name="email" value="' . $this->email . '"><br><br>';

        $form .= '<label for="password">Password : </label>';
        $form .= '<input type="password" id="password" name="password" value="' . $this->password . '"><br><br>';

        $form .= '<input type="submit" value="Submit">';
        $form .= '</form>';

        return $form;
    
}
}

$form1 = new leForm(1, 'DUH', 13254, 'jesuisunechaise@gmail.com', 'je65');
$form2 = new leForm(null, 'DaH', 54254, 'oikloi@gmail.com' , 'pl+90');
$htmlForm = $form1->generateForm();
echo $htmlForm;
echo "$form1->name" . "<br>" . "$form1->postal" ."<br>" . "$form1->email" . "<br>" . "$form1->password" . "<br>";
?>
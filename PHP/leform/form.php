<?php 

class leForm{

private $fields = [];

public function addField($name, $type, $label, $value, $holder, $pattern, $title = '') {
    $this->fields[] = [
        'name' => $name,
        'type' => $type,
        'label' => $label,
        'value' => $value,
        'placeholder' => $holder,
        'pattern' => $pattern ,
        'title' => $title,
    ];
}

public function generateForm() {
    $form = '<form action="index.php" method="post">';

    foreach ($this->fields as $field) {
        $name = $field['name'];
        $type = $field['type'];
        $label = $field['label'];
        $value = $field['value'];
        $holder = $field['placeholder'];
        $pattern = $field['pattern'];
        $title = $field['title'];

        $form .= '<label for="' . $name . '">' . $label . ' </label>';

        if ($type === 'text') {
            $form .= '<input type="text" id="' . $name . '" name="' . $name . '" value="' . $value . '" placeholder = "' . $holder . '" pattern="'. $pattern . '" title="' . $title .'" ><br>';
        } elseif ($type === 'password') {
            $form .= '<input type="password" id="' . $name . '" name="' . $name . '" value="' . $value . '" placeholder = "' . $holder . '" pattern="'. $pattern . '" title="' . $title .'" ><br>';
        } elseif ($type === 'hidden') {
            $form .= '<input type="hidden" id="' . $name . '" name="' . $name . '" value="' . $value . '" placeholder = "' . $holder . '" pattern="'. $pattern . '" title="' . $title .'" ><br>';
        } elseif ($type === 'number'){
            $form .= '<input type="number" id="' . $name . '" name="' . $name . '" value="' . $value . '" placeholder = "' . $holder . '" pattern="'. $pattern . '" title="' . $title .'" ><br>';
        }
    }

    $form .= '<input id="submit" type="submit" value="Submit">';
    $form .= '</form>';

    return $form;
}
}

$form = new leForm();
$form->addField('name', 'text', 'Nom', '' , 'Nom' , '[A-Za-Z]*', '');
$form->addField('numero', 'number', 'Numero', '', 'Numero', '0+([0-9]{9})', '');
$form->addField('postal', 'number', 'Code Postal', '' , 'Code Postal' ,'[0-9]{5,5}', '' );
$form->addField('email', 'text', 'Email', '' , 'Email' ,'[a-zA-Z0-9._\-].{1,50}@[a-zA-Z0-9]{1,50}.[a-zA-Z].{1,10}', '');
$form->addField('mdp', 'password', 'Password' , '' , 'Mot de passe', '[a-zA-Z0-9!@#$%^&*_=+\-].{12,}', '');
$form->addField('id', 'hidden', '', 1 ,'' ,'','');
$htmlform = $form->generateForm();
echo $htmlform ;
echo $_POST['name'] . '<br>';
echo $_POST['numero'] . '<br>' ;
echo $_POST['postal'] . '<br>' ;
echo $_POST['email'] . '<br>';
echo $_POST['mdp'] . '<br>';

?>
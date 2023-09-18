<?php 

class leForm{

private $fields = [];

public function addField($name, $type, $label, $value = '') {
    $this->fields[] = [
        'name' => $name,
        'type' => $type,
        'label' => $label,
        'value' => $value,
    ];
}

public function generateForm() {
    $form = '<form action="index.php" method="post">';

    foreach ($this->fields as $field) {
        $name = $field['name'];
        $type = $field['type'];
        $label = $field['label'];
        $value = $field['value'];

        $form .= '<label for="' . $name . '">' . $label . ' </label>';

        if ($type === 'text') {
            $form .= '<input type="text" id="' . $name . '" name="' . $name . '" value="' . $value . '"><br>';
        } elseif ($type === 'password') {
            $form .= '<input type="password" id="' . $name . '" name="' . $name . '" value="' . $value . '"><br>';
        } elseif ($type === 'hidden') {
            $form .= '<input type="hidden" id="' . $name . '" name="' . $name . '" value="' . $value . '"><br>';
        } elseif ($type === 'number'){
            $form .= '<input type="number" id="' . $name . '" name="' . $name . '" value="' . $value . '"><br>';
        }
    }

    $form .= '<input type="submit" value="Submit">';
    $form .= '</form>';

    return $form;
}
}

$form = new leForm();
$form->addField('name', 'text', 'Name', '');
$form->addField('age', 'number', 'Age', '');
$form->addField('email', 'text', 'Email', '');
$form->addField('password', 'password', 'Password' , '');
$form->addField('id', 'hidden', '', 1);
$htmlform = $form->generateForm();
echo $htmlform ;
echo $_POST['name'] . '<br>';
echo $_POST['age'] . '<br>' ;
echo $_POST['email'] . '<br>';
echo $_POST['password'] . '<br>';
?>
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
    $form = '<form>';

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
$form->addField('name', 'text', 'Name', 'John Doe');
$form->addField('age', 'number', 'Age', 54);
$form->addField('email', 'text', 'Email', 'john@example.com');
$form->addField('password', 'password', 'Password' , '51615321');
$form->addField('id', 'hidden', '', 1);
$htmlform = $form->generateForm();
echo $htmlform ;


?>
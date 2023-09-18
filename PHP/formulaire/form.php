<?php class FormGenerator {
    private $fields = [];

    public function addTextField($name, $label, $value = '') {
        $field = '<label for="' . $name . '">' . $label . '</label>';
        $field .= '<input type="text" id="' . $name . '" name="' . $name . '" value="' . $value . '">';
        $this->fields[] = $field;
    }

    public function addCheckbox($name, $label, $checked = false) {
        $checkedAttr = $checked ? 'checked' : '';
        $field = '<label for="' . $name . '">' . $label . '</label>';
        $field .= '<input type="checkbox" id="' . $name . '" name="' . $name . '" ' . $checkedAttr . '>';
        $this->fields[] = $field;
    }

    public function generateForm() {
        $form = '<form>';
        foreach ($this->fields as $field) {
            $form .= $field ; ?>
            <br>
        <?php }
        $form .= '<input type="submit" value="Submit">';
        $form .= '</form>';
        return $form;
    }
}

// Exemple d'utilisation
$formGenerator = new FormGenerator();
$formGenerator->addTextField('name', 'Name');
$formGenerator->addCheckbox('subscribe', 'Subscribe to newsletter', true);
$form = $formGenerator->generateForm();
echo $form;
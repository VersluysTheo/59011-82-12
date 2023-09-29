<?php 

$user1 = new User(["username" => "Balthazar"]);
$user1->setAuthorprivileges(["write text", "add punctuation"]);
$user1->setEditorPrivileges(["edit text", "edit punctuation"]);
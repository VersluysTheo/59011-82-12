<?php 

$user1 = new AuthorEditor(["username" => "Balthazar"]);
$user1->setAuthorprivileges(["write text", "add punctuation"]);
$user1->setEditorPrivileges(["edit text", "edit punctuation"]);

$user1->__toString();
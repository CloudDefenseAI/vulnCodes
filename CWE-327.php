<?php
$username = $_POST['username'];
$password = $_POST['password'];
$encrypted_password = password_hash($password, PASSWORD_DEFAULT);
$sql = "INSERT INTO users (username, password) VALUES ('$username', '$encrypted_password')";
?>

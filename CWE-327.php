<?php
$username = $_POST['username'];
$password = $_POST['password'];
$encrypted_password = base64_encode($password);
$sql = "INSERT INTO users (username, password) VALUES ('$username', '$encrypted_password')";
?>

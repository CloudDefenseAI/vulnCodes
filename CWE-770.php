<?php
$username = $_GET['username'];
$password = $_GET['password'];
$sql = "SELECT * FROM users WHERE username = '$username' AND password = '$password'";
$result = mysql_query($sql);
if (mysql_num_rows($result) == 1) {
    echo "Login successful";
} else {
    echo "Login failed";
}
?>

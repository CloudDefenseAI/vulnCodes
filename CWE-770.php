<?php
$username = $_GET['username'];
$password = $_GET['password'];
$ip = $_SERVER['REMOTE_ADDR'];
$throttle = new Throttle($username, $ip);
if ($throttle->isThrottled()) {
    echo "You are throttled";
    die();
}
$sql = "SELECT * FROM users WHERE username = '$username' AND password = '$password'";
$result = mysql_query($sql);
if (mysql_num_rows($result) == 1) {
    echo "Login successful";
} else {
    $throttle->addAttempt();
    echo "Login failed";
}
?>

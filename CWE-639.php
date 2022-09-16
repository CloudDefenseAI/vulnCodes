<?php
$userId = $_SESSION['user_id'];
$query = "SELECT * FROM users WHERE id = $userId";
$result = mysql_query($query);
$row = mysql_fetch_array($result);
echo "Your name is " . $row['name'];
echo "Your email is " . $row['email'];
echo "Your address is " . $row['address'];
?>

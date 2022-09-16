<?php
$userName = getCurrentUser();
$command = 'ps aux | grep ' . $userName;
system($command);
?>

<?php
## enter folder name to check whats inside that folder
$folder = $_GET['folder'];
$output = shell_exec('ls -la '.$folder);
echo "<pre>$output</pre>";
?>

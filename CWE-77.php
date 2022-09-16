<?php
## enter folder name to check whats inside that folder
$folder = $_GET['folder'];
## check if folder exists any blank space or special character
if (preg_match('/[\'^£$%&*()}{@#~?><>,|=_+¬-]/', $folder))
{
    echo "Folder name is not valid";
}else{
    $output = shell_exec('ls -la '.$folder);
    echo "<pre>$output</pre>";
}
?>

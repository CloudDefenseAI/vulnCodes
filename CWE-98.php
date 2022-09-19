<?php
$dir = $_GET['module_name'];
if (in_array($dir, array('admin', 'student', 'parent', 'teacher'))) {
    include($dir . "/function.php");
} else {
    echo "Error";
}
?>

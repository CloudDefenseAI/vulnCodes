<?php 
$input = $_GET['input'];
ini_set("memory_limit",-1);
$str=str_repeat("A", $input);
$str.=$str;
?>

<?php
$input = $_GET['input'];
ini_set("memory_limit",-1);
// let's protect against inputs like 0x7fffffff which will cause heap buffer overflow
if(!is_numeric($input)) {
    echo "Input is not numeric";
    exit;
}else if($input > 5000) {
    echo "Input is too big";
    exit;
}
$str=str_repeat("A", $input);
$str.=$str;
?>

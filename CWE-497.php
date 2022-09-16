<?php
$userName = getCurrentUser();
// allow only if username is mike
if($userName != "mike"){
  echo "We can't show processes of other user";
}else{
  $command = 'ps aux | grep ' . $userName;
  system($command);
}
?>

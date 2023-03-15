<head>
	<meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
	<h2>Создайте свою таблицу!</h2>
</head>
<body>
	<div class="alert alert-success" role="alert">
		<text><b>Для этого вам нужно ввести:</b></text> 
		<br>
	</div>
	<form action="third2.php" method=POST class="alert alert-success" role="alert">
<?php
	$array=array("Строки:","Столбцы:","Значения, которые там будут лежать:");
	$array2=array("str","col","mn");
	for ($i=0;$i<count($array);$i++)
	{
		echo "<b>$array[$i]</b><br><input type=text name=$array2[$i]><br>";
	}
?>
		<div class="alert alert-success">
			<input type=reset value="Отменить" class="btn btn-outline-danger">
			<input type=submit value="Отправить" class="btn btn-outline-success">
		</div>
	</form>
</body>
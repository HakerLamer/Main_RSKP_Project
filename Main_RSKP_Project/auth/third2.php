<head>
	<style type="text/css">
	   TABLE 
	   {
		width: 300px; /* Ширина таблицы */
		border-collapse: collapse; /* Убираем двойные линии между ячейками */
	   }
	   TD, TH 
	   {
		padding: 3px; /* Поля вокруг содержимого таблицы */
		border: 1px solid black; /* Параметры рамки */
	   }
	   TH 
	   {
		background: #b0e0e6; /* Цвет фона */
	   }
    </style>
</head>
<body>
<?php
	$str=$_POST["str"];
	$col=$_POST["col"];
	$mn=$_POST["mn"];
	if (is_numeric($str) and is_numeric($col))
	{
		echo '<table>';
		for ($i=0;$i<$str;$i++)
		{
			echo "<tr>";
			for($j=0;$j<$col;$j++)
			{
				echo "<td>$mn</td>";
			}
			echo "</tr>";
		}
		echo "</table>";
	}
	else
	{
		echo "WRONG INPUT!";
	}
?>
</body>
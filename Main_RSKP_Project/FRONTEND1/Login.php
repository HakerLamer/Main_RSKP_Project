<?php
session_start();

if ($_SERVER['REQUEST_METHOD'] == 'POST') {
  $username = $_POST['username'];
  $password = $_POST['password'];

  // проверка введенных данных на корректность
  if ($username === 'user' && $password === 'password') {
    $_SESSION['username'] = $username;
    header('Location: dashboard.php');
    exit;
  } else {
    $error = 'Invalid username or password';
  }
}
?>

<!DOCTYPE html>
<html>
  <head>
    <title>Здесь логинишься, Баклажан</title>
    <link rel="stylesheet" type="text/css" href="style.css">
  </head>
  <body>
    <div class="login-box">
      <h1>Логин</h1>
      <form action="dashboard.php" method="post">
        <label for="username">Имя пользователя:</label>
        <input type="text" name="username" required>
        <label for="password">Пароль:</label>
        <input type="password" name="password" required>
        <button type="submit">Войти</button>
      </form>
	  <p align="center">Нет учетной записи? <a href="StranicaReg.php">Зарегистрируйся</a></p>
    </div>
  </body>
</html>
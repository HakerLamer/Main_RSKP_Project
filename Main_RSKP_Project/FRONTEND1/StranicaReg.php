<!DOCTYPE html>
<html>
  <head>
    <title>Здесь регаешься, Баклажан</title>
    <link rel="stylesheet" type="text/css" href="style.css">
  </head>
  <body>
   <div class="login-box">
   <H1>Регистрация</h1>
		<form action="dashboard.php" method="post">
        <label for="username">Имя пользователя:</label>
        <input type="text" name="username" required>
		<label for="email">Адрес электронной почты:</label>
        <input type="email" name="email" required>
        <label for="password">Пароль:</label>
        <input type="password" name="password" required>
		<label for="password">Подтверждение пароля:</label>
        <input type="password" name="password" required>
        <button type="submit">Зарегистрироваться</button>
		</form>
		<p align="center">Уже есть аккаунт? <a href="Login.php">Войти</a></p>
  </div>
  </body>
</html>
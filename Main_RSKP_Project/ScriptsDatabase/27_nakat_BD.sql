USE [VladBase]
GO

/****** Object:  Table [dbo].[Table_users]    Script Date: 19.03.2023 19:26:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Table_users](
	[ID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
	[Login] [nvarchar](50) NOT NULL,
	[Mail] [nvarchar](50) NOT NULL,
	[Phone_number] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[First_date] [datetimeoffset](7) NOT NULL,
	[Last_date] [datetimeoffset](7) NOT NULL
) ON [PRIMARY]
GO

INSERT INTO Table_users VALUES (NEWID(), 'admin', ' project.mail@gmail.com', '+12345678901',  'Qwerty123456', GETDATE(), GETDATE());
INSERT INTO Table_users VALUES (NEWID(), 'qqwer', ' m12345678900@gmail.com', '+12345678901',  'Qwerty123456', GETDATE(), GETDATE());
INSERT INTO Table_users VALUES (NEWID(), 'qwert', ' project.mail@gmail.com', '+12345678901',  'Qwerty123456', GETDATE(), GETDATE());
INSERT INTO Table_users VALUES (NEWID(), 'werty', ' project.mail@gmail.com', '+12345678901',  'Qwerty123456', GETDATE(), GETDATE());
INSERT INTO Table_users VALUES (NEWID(), 'ertyu', ' project.mail@gmail.com', '+12345678901',  'Qwerty123456', GETDATE(), GETDATE());
INSERT INTO Table_users VALUES (NEWID(), 'rtyui', ' project.mail@gmail.com', '+12345678901',  'Qwerty123456', GETDATE(), GETDATE());
GO

SELECT * FROM Table_users
GO

--Процедура, отвечающая за регистрацию.
CREATE PROCEDURE CheckAccountExistsReg
    @Login VARCHAR(50),
	@Mail VARCHAR(50),
	@Phone_number VARCHAR(50),
	@Password VARCHAR(50)
AS
BEGIN
    -- Проверяем, есть ли аккаунт с указанным именем
    IF EXISTS(SELECT * FROM Table_users WHERE Login = @Login)
    BEGIN
        -- Если существует, возвращаем пустой результат
		SELECT NULL;
    END
    ELSE
    BEGIN
        -- Если аккаунт не найден, добавляем как нового пользоателя.
        INSERT INTO Table_users VALUES (NEWID(), @Login, @Mail, @Phone_number, @Password, GETDATE(), GETDATE());
    END
END
GO

-- Процедура, отвечающая за логирование.
CREATE PROCEDURE CheckAccountExistsLog
    @accountName VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    -- Проверяем, есть ли аккаунт с указанным именем
    IF EXISTS(SELECT * FROM Table_users WHERE Login = @accountName)
    BEGIN
	--Обновляем последнюю дату захода.
		UPDATE Table_users
		SET Last_date = GETDATE();
        -- Возвращаем строку с информацией о найденном аккаунте
        SELECT * FROM Table_users WHERE Login = @accountName;
    END
    ELSE
    BEGIN
        -- Если аккаунт не найден, возвращаем пустой результат
        SELECT NULL;
    END
END
GO

-- Процедура, отвечающая за обновление почты, номера телефона или пароля.
CREATE PROCEDURE UpdateUserInfo
    @UserID VARCHAR(50),
    @Mail VARCHAR(50) = NULL,
    @Phone_number VARCHAR(20) = NULL,
    @Password VARCHAR(50) = NULL
AS
BEGIN
    UPDATE Table_users
    SET
        Mail = COALESCE(@Mail, Mail),
        Phone_number = COALESCE(@Phone_number, Phone_number),
        Password = COALESCE(@Password, Password)
    WHERE ID = @UserID
END
GO

--Процедура для удаления пользователя из базы.
CREATE PROCEDURE Deleteuser
	@UserID VARCHAR(50) 
AS
BEGIN
	IF EXISTS(SELECT * FROM Table_users WHERE ID = @UserID)
	BEGIN
		DELETE Table_users;
	END
END
GO
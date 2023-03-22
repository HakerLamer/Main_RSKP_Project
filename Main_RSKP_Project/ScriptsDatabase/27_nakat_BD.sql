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

INSERT INTO Table_users (Login, Mail, Phone_number, Password, First_date, Last_date) 
VALUES ('admin', ' project.mail@gmail.com', '+12345678901',  'Qwerty123456', GETDATE(), GETDATE());
GO

SELECT * FROM Table_users
GO


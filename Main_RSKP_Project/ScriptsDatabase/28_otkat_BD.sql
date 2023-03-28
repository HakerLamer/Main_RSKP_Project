USE [VladBase]
GO

/****** Object:  Table [dbo].[Table_users]    Script Date: 28.03.2023 19:04:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Table_users]') AND type in (N'U'))
DROP TABLE [dbo].[Table_users]
GO

DROP PROCEDURE CheckAccountExistsReg --registration procedure
GO
DROP PROCEDURE CheckAccountExistsLog --authorization procedure
GO
DROP PROCEDURE UpdateUserInfo --data update procedure 
GO
DROP PROCEDURE Deleteuser --user deletion procedure
GO
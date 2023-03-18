USE [VladBase]
GO

/****** Object:  Table [dbo].[Table_Team]    Script Date: 17.03.2023 17:53:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Table_Team]') AND type in (N'U'))
DROP TABLE [dbo].[Table_Team]
GO


DROP PROCEDURE Output_test
GO
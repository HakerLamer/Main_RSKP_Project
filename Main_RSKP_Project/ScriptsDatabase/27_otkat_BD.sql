USE [VladBase]
GO

/****** Object:  Table [dbo].[Table_users]    Script Date: 19.03.2023 20:22:33 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Table_users]') AND type in (N'U'))
DROP TABLE [dbo].[Table_users]
GO



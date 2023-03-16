USE [VladBase]
GO

/****** Object:  Table [dbo].[ClientNames]    Script Date: 16.03.2023 12:12:59 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ClientNames]') AND type in (N'U'))
DROP TABLE [dbo].[ClientNames]
GO



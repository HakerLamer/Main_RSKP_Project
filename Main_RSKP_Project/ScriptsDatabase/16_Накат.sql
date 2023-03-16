USE [VladBase]
GO

/****** Object:  Table [dbo].[ClientNames]    Script Date: 16.03.2023 12:12:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ClientNames](
	[Name] [nchar](100) NOT NULL,
	[Surname] [nchar](100) NOT NULL
) ON [PRIMARY]
GO

GO

INSERT INTO [dbo].[ClientNames] ([Name],[Surname]) VALUES ('Егор','Шрамов')
INSERT INTO [dbo].[ClientNames] ([Name],[Surname]) VALUES ('Артем','Грищенко')
INSERT INTO [dbo].[ClientNames] ([Name],[Surname]) VALUES ('Влад','Кутанин')

GO



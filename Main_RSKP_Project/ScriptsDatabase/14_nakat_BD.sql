USE [VladBase]
GO

/****** Object:  Table [dbo].[Table_Team]    Script Date: 16.03.2023 17:08:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Table_Team](
	[Members] [nvarchar](50) NOT NULL,
	[Status] [nvarchar](50) NOT NULL,
	[Discipline] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO


INSERT INTO Table_Team (Members, Status, Discipline) VALUES ('Shramov', 'TimLid', 'Backend') 
INSERT INTO Table_Team (Members, Status, Discipline) VALUES ('Kutanin', 'Member', 'DataBase')
INSERT INTO Table_Team (Members, Status, Discipline) VALUES ('Kiselev', 'Member', 'JavaS')
INSERT INTO Table_Team (Members, Status, Discipline) VALUES ('Grishenko', 'Member', 'Backend')
GO

CREATE PROCEDURE Output_test
@Text NVARCHAR(50) NULL AS
SELECT * FROM Table_Team
WHERE Members = @Text OR Status = @Text OR Discipline = @Text;
GO


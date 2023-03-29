USE [VladBase]
GO

/****** Object:  Table [dbo].[Table_users]    Script Date: 28.03.2023 16:19:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Table_users](
	[ID] [uniqueidentifier] NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Mail] [nvarchar](50) NOT NULL,
	[Phone_number] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[First_date] [datetimeoffset](7) NOT NULL,
	[Last_date] [datetimeoffset](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Table_users] ADD  DEFAULT (newid()) FOR [ID]
GO

--Procedure for registration.
CREATE PROCEDURE CheckAccountExistsReg
    @Login VARCHAR(50),
	@Mail VARCHAR(50),
	@Phone_number VARCHAR(50),
	@Password VARCHAR(50)
AS
BEGIN
    -- Check if there is an account with the specified name
    IF EXISTS(SELECT * FROM Table_users WHERE Login = @Login OR Mail = @Mail OR Phone_number = @Phone_number)
    BEGIN
        -- If exists, return an empty result
		SELECT NULL;
    END
    ELSE
    BEGIN
        -- If the account is not found, add it as a new user.
        INSERT INTO Table_users VALUES (NEWID(), @Login, @Mail, @Phone_number, @Password, GETDATE(), GETDATE());
    END
END
GO

-- The procedure responsible for logging.
CREATE PROCEDURE CheckAccountExistsLog
    @accountName VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    -- Check if there is an account with the specified name
    IF EXISTS(SELECT * FROM Table_users WHERE Login = @accountName)
    BEGIN
	--We update the last entry date.
		UPDATE Table_users
		SET Last_date = GETDATE();
        -- Returning a string with information about the found account
        SELECT * FROM Table_users WHERE Login = @accountName;
    END
    ELSE
    BEGIN
      -- If the account is not found, we return an empty result
        SELECT NULL;
    END
END
GO
-- The procedure responsible for updating the mail, phone number or password.
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

--Procedure for removing a user from the database.
CREATE PROCEDURE Deleteuser
	@UserID VARCHAR(50) 
AS
BEGIN
		DELETE FROM Table_users 
		WHERE ID = @UserID;
END
GO


/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
IF OBJECT_ID('[dbo].[Clients]') IS NULL
	CREATE TABLE [dbo].[Clients] (
		[ClientId]  INT PRIMARY KEY IDENTITY(1,1),
		[FirstName] VARCHAR(100) NOT NULL,
		[LastName]  VARCHAR(100) NOT NULL,
		[MiddleName] VARCHAR(100),
		[Email]     VARCHAR(100),
		[DateBirth] DATE NOT NULL,
		[Gender]    SMALLINT NOT NULL
	)

IF OBJECT_ID('[dbo].[Accounts]') IS NULL
BEGIN
	CREATE TABLE [dbo].[Accounts] (
    [AccountId] INT PRIMARY KEY IDENTITY(1,1),
    [ClientId] INT NOT NULL,
    [Identifier] VARCHAR(30) NOT NULL,
    [PlatformId] INT NOT NULL,
    [Code] VARCHAR(30) NOT NULL
  )

  ALTER TABLE [dbo].[Accounts] ADD CONSTRAINT [FK_Clients_ClientId] FOREIGN KEY ([ClientId])
  REFERENCES [dbo].[Clients]([ClientId]) 
END

IF OBJECT_ID('[dbo].[Accounts.Codes]') IS NULL
BEGIN
	CREATE TABLE [dbo].[Accounts.Codes] (    
    [CodeId] INT PRIMARY KEY IDENTITY(1,1),
    [AccountId] INT NOT NULL,
    [Code] VARCHAR(30) NOT NULL,
    [IsRegistered] BIT NOT NULL DEFAULT(0)
  )

  ALTER TABLE [dbo].[Accounts.Codes] ADD CONSTRAINT [FK_Accounts.Codes#AccountId] FOREIGN KEY ([AccountId])
  REFERENCES [dbo].[Accounts]([AccountId]) 
END
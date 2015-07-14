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
    [PlatformId] INT NOT NULL
    --[Code] VARCHAR(30) NOT NULL
  )

  ALTER TABLE [dbo].[Accounts] ADD CONSTRAINT [FK_Accounts#ClientId] FOREIGN KEY ([ClientId])
  REFERENCES [dbo].[Clients]([ClientId]) 

  ALTER TABLE [dbo].[Accounts] ADD CONSTRAINT [FK_Accounts#PlatformId] FOREIGN KEY ([PlatformId])
  REFERENCES [dbo].[Platforms]([PlatformId]) 
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

IF OBJECT_ID('[dbo].[Platforms]') IS NULL
BEGIN
	CREATE TABLE [dbo].[Platforms] (
    [PlatformId] INT PRIMARY KEY IDENTITY(1,1),
    [Name] VARCHAR(150) NOT NULL,
    [Code] VARCHAR(30) NOT NULL,
    [PlatformGroupId] INT  
  )

  --ALTER TABLE [dbo].[Platforms] DROP CONSTRAINT [FK_Platforms#PlatformGroupId]
  ALTER TABLE [dbo].[Platforms] ADD CONSTRAINT [FK_Platforms#PlatformGroupId] FOREIGN KEY ([PlatformGroupId])
  REFERENCES [dbo].[Platforms.Groups]([PlatformGroupId]) 
END

IF OBJECT_ID('[dbo].[Platforms.Groups]') IS NULL
BEGIN
	CREATE TABLE [dbo].[Platforms.Groups] (
    [PlatformGroupId] INT PRIMARY KEY IDENTITY(1,1),
    [Name] VARCHAR(150) NOT NULL,
    [Code] VARCHAR(30) NOT NULL
  )
END

IF OBJECT_ID('[dbo].[Transactions]') IS NULL
BEGIN
	CREATE TABLE [dbo].[Transactions] (
    [TranId] INT PRIMARY KEY IDENTITY(1,1),
    [AccountId] INT NOT NULL,
    [TranTypeId] SMALLINT NOT NULL,
    [InstrumentId] INT,
    [Quantity] NUMERIC(18, 4),
    [Price] NUMERIC(18, 6),
    [Sum] NUMERIC(18, 2)
  )

  ALTER TABLE [dbo].[Transactions] ADD CONSTRAINT [FK_Accounts#AccountId] FOREIGN KEY ([AccountId])
  REFERENCES [dbo].[Accounts]([AccountId]) 

END

RETURN

ALTER TABLE [dbo].[Transactions] ADD [Quantity] NUMERIC(18, 4)
ALTER TABLE [dbo].[Transactions] ADD [Price] NUMERIC(18, 6)

ALTER TABLE [dbo].[Platforms.Groups] ALTER COLUMN [Name] VARCHAR(150) NOT NULL
ALTER TABLE [dbo].[Platforms] ALTER COLUMN [Name] VARCHAR(150) NOT NULL

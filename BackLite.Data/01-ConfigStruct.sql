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
		[ClientId] INT PRIMARY KEY IDENTITY(1,1),
		[FirstName] VARCHAR(100),
		[MiddleName] VARCHAR(100),
		[LastName] VARCHAR(100),
		[Email] VARCHAR(100),
		[DateBirth] DATE NOT NULL,
		[Gender] SMALLINT NOT NULL
	)
USE [BackLite]
GO

CREATE VIEW [dbo].[Accounts.Codes.View]
AS
  SELECT --TOP 20 
    AC.[CodeId], AC.[AccountId], AC.[Code], AC.[IsRegistered]
  FROM [dbo].[Accounts.Codes] AC
GO

RETURN
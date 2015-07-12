USE [BackLite]
GO

-- DROP PROCEDURE [dbo].[Accounts.View]
-- GO

CREATE VIEW [dbo].[Accounts.View]
AS
  SELECT --TOP 20 
    A.[AccountId], A.[ClientId], A.[Identifier], A.[PlatformId], A.[Code]
  FROM [dbo].[Accounts] A
GO

RETURN

SELECT * FROM [dbo].[Accounts.View] av

/*
CREATE PROCEDURE [dbo].[Accounts.View]
-- 
WITH EXEC AS OWNER
--
AS 
BEGIN
  SELECT TOP 20 
    A.[AccountId], A.[ClientId], A.[Identifier], A.[PlatformId], A.[Code]
  FROM [dbo].[Accounts] A
END
GO
*/
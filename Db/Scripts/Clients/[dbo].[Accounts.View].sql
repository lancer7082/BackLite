USE [BackLite]
GO

-- DROP PROCEDURE [dbo].[Accounts.View]
-- GO

ALTER VIEW [dbo].[Accounts.View]
AS
  SELECT --TOP 20 
    A.[AccountId], A.[ClientId], A.[Identifier], A.[PlatformId],
    P.[PlatformGroupId]
  FROM [dbo].[Accounts] A
  INNER JOIN [dbo].[Platforms] P ON P.[PlatformId] = A.[PlatformId]
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
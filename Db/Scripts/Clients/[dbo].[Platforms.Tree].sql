ALTER PROCEDURE [dbo].[Platforms.Tree]
---
WITH EXECUTE AS OWNER
---
AS 
BEGIN
  DECLARE
    @MaxPlatformGroupId INT 

  SELECT @MaxPlatformGroupId = MAX([PlatformGroupId]) FROM [dbo].[Platforms.Groups]

  SELECT 
    [Id] = -1,
    [ParentId] = NULL,
    [Name] = N'Все платформы',
    [PlatformGroupId] = NULL,
    [PlatformId] = NULL
    
  UNION ALL    

  SELECT
    [Id] = G.[PlatformGroupId],
    [ParentId] = -1,
    G.[Name],
    G.[PlatformGroupId],
    [PlatformId] = NULL    
  FROM [dbo].[Platforms.Groups] G

  UNION ALL

  SELECT 
    [Id] = @MaxPlatformGroupId + PL.[PlatformId],
    [ParentId] = PL.[PlatformGroupId],
    PL.[Name],
    G.[PlatformGroupId],
    PL.[PlatformId]
  FROM [dbo].[Platforms] PL
  LEFT JOIN [dbo].[Platforms.Groups] G ON G.[PlatformGroupId] = PL.[PlatformGroupId]
END
GO  
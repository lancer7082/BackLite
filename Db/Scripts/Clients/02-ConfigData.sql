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

IF NOT EXISTS(
	SELECT * FROM [dbo].[Clients]
)
BEGIN
  IF OBJECT_ID('tempdb..#Data') IS NOT NULL DROP TABLE #Data
  CREATE TABLE #Data ([Id] INT PRIMARY KEY)
  DECLARE @i INT = 1
	WHILE @i <= 100
  BEGIN
    INSERT INTO #Data VALUES(@i)

    SET @i += 1
  END	

  INSERT INTO [dbo].[Clients]
  ([FirstName], [LastName], [MiddleName], [Email], [DateBirth], [Gender])  
  SELECT
    [FirstName] = 'FName' + CAST([RowId] AS varchar),
    [LastName]  = 'LName' + CAST([RowId] AS varchar),
    [MiddleName]  = 'MName' + CAST([RowId] AS varchar),
    [Email]     = 'Login@Domain' + CAST([RowId] AS varchar),
    [DateBirth] = CAST(0 AS DATETIME),
    [Gender]    = 0
  FROM (
    SELECT 
      [RowId] = ROW_NUMBER() OVER(ORDER BY (SELECT 0)) 
    FROM #Data D1
    CROSS JOIN #Data D2
  ) T

  select * from dbo.Clients
END
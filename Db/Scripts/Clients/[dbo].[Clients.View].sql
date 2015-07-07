USE BackLite
GO

ALTER PROCEDURE [dbo].[Clients.View]
-- 
WITH EXEC AS OWNER
--
AS 
BEGIN
  SELECT TOP 20 
    C.ClientId, C.FirstName, C.LastName, C.MiddleName, C.DateBirth, C.Email, C.Gender
  FROM [dbo].[Clients] C
END
GO
USE BackLite
GO

CREATE PROCEDURE [dbo].[Client.Modify]
  @ClientId INT = NULL,
  @FirstName VARCHAR(100),
  @LastName VARCHAR(100),
  @Email VARCHAR(100)
-- 
WITH EXEC AS OWNER
--
AS 
BEGIN TRY
  DECLARE @ProcName SYSNAME
  SET @ProcName = OBJECT_NAME(@@PROCID)
  
  BEGIN TRAN
  
    IF @ClientId IS NULL
    BEGIN
      RAISERROR('Error', 16, 1)
    END
    ELSE
    BEGIN
      UPDATE dbo.Clients SET
        LastName = @LastName,
        Email = @Email
      WHERE ClientId = @ClientId
    END  
  COMMIT

END TRY
BEGIN CATCH
  IF XACT_STATE() = 1
    IF @@TRANCOUNT > 0
      ROLLBACK

  RAISERROR(@ProcName, 16, 1)
END CATCH
GO
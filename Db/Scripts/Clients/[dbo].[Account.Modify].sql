USE BackLite
GO

CREATE PROCEDURE [dbo].[Account.Modify]
  @AccountId INT = NULL,
  @Code VARCHAR(30)
-- 
WITH EXEC AS OWNER
--
AS 
BEGIN TRY
  DECLARE @ProcName SYSNAME
  SET @ProcName = OBJECT_NAME(@@PROCID)
  
  BEGIN TRAN
  
    IF @AccountId IS NULL
    BEGIN
      RAISERROR('Error', 16, 1)
    END
    ELSE
    BEGIN
      UPDATE dbo.[Accounts] SET
        [Code] = @Code
      WHERE [AccountId] = @AccountId
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
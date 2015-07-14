USE [BackLite]
GO

ALTER VIEW [dbo].[Transactions.View]
AS
  SELECT 
    T.[TranId], T.[AccountId], T.[TranTypeId], T.[InstrumentId], T.[Quantity],
    T.[Price], T.[Sum], A.[Identifier]    
  FROM [dbo].[Transactions] T
  INNER JOIN [dbo].[Accounts] A ON A.[AccountId] = T.[AccountId]
  --INNER JOIN [dbo].[Platforms] P ON P.[PlatformId] = A.[PlatformId]
GO

CREATE VIEW [dbo].[Transaction.Money.View]
AS
  SELECT T.[TranId], T.[AccountId], T.[TranTypeId], T.[Sum]
  FROM [dbo].[Transactions] T
GO  

CREATE VIEW [dbo].[Transaction.Deal.View]
AS
  SELECT T.[TranId], T.[AccountId], T.[TranTypeId], T.[InstrumentId], T.[Quantity],
         T.[Price], T.[Sum]
  FROM [dbo].[Transactions] T
GO  

RETURN

SELECT * FROM [dbo].[Transactions.View] 
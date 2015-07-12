INSERT INTO dbo.Accounts (ClientId, Identifier, PlatformId, Code)
VALUES
(1, '1', 1, '1'),
(1, '2', 2, '2')

RETURN

SELECT TOP 5 * FROM dbo.Clients
SELECT TOP 100 * FROM dbo.Accounts



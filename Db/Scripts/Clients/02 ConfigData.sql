TRUNCATE TABLE [dbo].[Platforms.Groups]
DBCC CHECKIDENT('[dbo].[Platforms.Groups]', RESEED, 1)
INSERT INTO [dbo].[Platforms.Groups] ([Name], [Code])
VALUES
('Group1', 'GR1'),
('Group2', 'GR2')

TRUNCATE TABLE [dbo].[Platforms]
DBCC CHECKIDENT('[dbo].[Platforms]', RESEED, 1)
INSERT INTO [dbo].[Platforms] ([Name], [Code], [PlatformGroupId])
VALUES
('Platform1', 'PL1', 1),
('Platform2', 'PL2', 2)

INSERT INTO dbo.Accounts (ClientId, Identifier, PlatformId, Code)
VALUES
(1, '1', 1, '1'),
(1, '2', 2, '2')

RETURN

SELECT TOP 5 * FROM dbo.Clients
SELECT * FROM dbo.[Platforms] p
SELECT * FROM dbo.[Platforms.Groups] g 
SELECT TOP 100 * FROM dbo.Accounts



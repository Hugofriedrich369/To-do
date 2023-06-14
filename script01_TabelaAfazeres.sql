IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Afazeres] (
    [Id] int NOT NULL IDENTITY,
    [Titulo] nvarchar(max) NOT NULL,
    [Desc] nvarchar(max) NOT NULL,
    [Data] datetime2 NOT NULL,
    [Status] bit NOT NULL,
    CONSTRAINT [PK_Afazeres] PRIMARY KEY ([Id])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Data', N'Desc', N'Status', N'Titulo') AND [object_id] = OBJECT_ID(N'[Afazeres]'))
    SET IDENTITY_INSERT [Afazeres] ON;
INSERT INTO [Afazeres] ([Id], [Data], [Desc], [Status], [Titulo])
VALUES (1, '2023-06-13T20:44:09.7603050-03:00', N'Apenas um Teste', CAST(1 AS bit), N'Teste');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Data', N'Desc', N'Status', N'Titulo') AND [object_id] = OBJECT_ID(N'[Afazeres]'))
    SET IDENTITY_INSERT [Afazeres] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230613234409_InitialCreate', N'7.0.7');
GO

COMMIT;
GO


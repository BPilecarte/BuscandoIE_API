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

CREATE TABLE [TB_IE] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NOT NULL,
    [CNPJ] bigint NOT NULL,
    [NroIE] int NOT NULL,
    [UF] nvarchar(max) NOT NULL,
    [SituacaoIE] int NOT NULL,
    CONSTRAINT [PK_TB_IE] PRIMARY KEY ([Id])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CNPJ', N'Nome', N'NroIE', N'SituacaoIE', N'UF') AND [object_id] = OBJECT_ID(N'[TB_IE]'))
    SET IDENTITY_INSERT [TB_IE] ON;
INSERT INTO [TB_IE] ([Id], [CNPJ], [Nome], [NroIE], [SituacaoIE], [UF])
VALUES (1, CAST(61550141000172 AS bigint), N'LIBERTY SEGUROS S.A', 123456, 1, N'SP'),
(2, CAST(2233469000104 AS bigint), N'F1RST TECNOLOGIA E INOVACAO LTDA', 789456, 3, N'SP'),
(3, CAST(29980158000157 AS bigint), N'HDI SEGUROS S.A', 159753, 4, N'SP'),
(4, CAST(60872504000123 AS bigint), N'ITAU UNIBANCO HOLDING S.A', 951357, 3, N'RJ'),
(5, CAST(90400888000142 AS bigint), N'BANCO SANTANDER (BRASIL) S.A', 654238, 1, N'BA'),
(6, CAST(66970229000167 AS bigint), N'CLARO NXT TELECOMUNICACOES S.A', 786216, 4, N'PA'),
(7, CAST(29309127000179 AS bigint), N'AMIL ASSISTENCIA MEDICA INTERNACIONAL S.A', 658920, 4, N'GO');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CNPJ', N'Nome', N'NroIE', N'SituacaoIE', N'UF') AND [object_id] = OBJECT_ID(N'[TB_IE]'))
    SET IDENTITY_INSERT [TB_IE] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231213162427_InitialCreat', N'7.0.0');
GO

COMMIT;
GO


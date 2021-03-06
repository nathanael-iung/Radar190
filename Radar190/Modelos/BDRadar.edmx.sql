
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/27/2018 18:58:22
-- Generated from EDMX file: C:\Users\1718167\Documents\1718167\Radar190\Radar190\Modelos\BDRadar.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Radar190DB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AdministradorContatosEmergenciais]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContatosEmergenciaisSet] DROP CONSTRAINT [FK_AdministradorContatosEmergenciais];
GO
IF OBJECT_ID(N'[dbo].[FK_AdministradorDicasSeguranca]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DicasSegurancaSet] DROP CONSTRAINT [FK_AdministradorDicasSeguranca];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioFaleConosco]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FaleConoscoSet] DROP CONSTRAINT [FK_UsuarioFaleConosco];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioDenuncia]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DenunciaSet] DROP CONSTRAINT [FK_UsuarioDenuncia];
GO
IF OBJECT_ID(N'[dbo].[FK_AdministradorUsuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UsuarioSet] DROP CONSTRAINT [FK_AdministradorUsuario];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioChat]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ChatSet] DROP CONSTRAINT [FK_UsuarioChat];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[UsuarioSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UsuarioSet];
GO
IF OBJECT_ID(N'[dbo].[DenunciaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DenunciaSet];
GO
IF OBJECT_ID(N'[dbo].[AdministradorSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AdministradorSet];
GO
IF OBJECT_ID(N'[dbo].[ContatosEmergenciaisSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContatosEmergenciaisSet];
GO
IF OBJECT_ID(N'[dbo].[DicasSegurancaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DicasSegurancaSet];
GO
IF OBJECT_ID(N'[dbo].[FaleConoscoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FaleConoscoSet];
GO
IF OBJECT_ID(N'[dbo].[ChatSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ChatSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UsuarioSet'
CREATE TABLE [dbo].[UsuarioSet] (
    [IdUsuario] int IDENTITY(1,1) NOT NULL,
    [NomeCompleto] nvarchar(max)  NOT NULL,
    [DtNasc] datetime  NOT NULL,
    [Experiencia] bit  NULL,
    [Descricao] nvarchar(max)  NULL,
    [User] nvarchar(max)  NOT NULL,
    [Senha] nvarchar(max)  NOT NULL,
    [Cidade] nvarchar(max)  NOT NULL,
    [AdministradorUsuario_Usuario_IdAdministrador] int  NULL
);
GO

-- Creating table 'DenunciaSet'
CREATE TABLE [dbo].[DenunciaSet] (
    [IdDenuncia] int IDENTITY(1,1) NOT NULL,
    [NomeCompleto] nvarchar(max)  NOT NULL,
    [Idade] smallint  NULL,
    [Tipo] nvarchar(max)  NOT NULL,
    [Sexo] nvarchar(max)  NULL,
    [Endereco] nvarchar(max)  NOT NULL,
    [Numero] smallint  NOT NULL,
    [CPF] nvarchar(max)  NOT NULL,
    [Distrito] nvarchar(max)  NOT NULL,
    [City] nvarchar(max)  NOT NULL,
    [UF] nvarchar(max)  NOT NULL,
    [Data] datetime  NOT NULL,
    [Hora] nvarchar(max)  NOT NULL,
    [BO] bit  NULL,
    [TipoOcorrencia] nvarchar(max)  NOT NULL,
    [Prejuizo] nvarchar(max)  NULL,
    [Descricao] nvarchar(max)  NULL,
    [Dinheiro] bit  NULL,
    [Carteira] bit  NULL,
    [Documentos] bit  NULL,
    [Celular] bit  NULL,
    [Notebook] bit  NULL,
    [Motocicleta] bit  NULL,
    [Veiculo] bit  NULL,
    [OutrosEletronicos] bit  NULL,
    [Outros] bit  NULL,
    [UsuarioIdUsuario] int  NULL,
    [Latitude] nvarchar(max)  NULL,
    [Longitude] nvarchar(max)  NULL
);
GO

-- Creating table 'AdministradorSet'
CREATE TABLE [dbo].[AdministradorSet] (
    [IdAdministrador] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Usuario] nvarchar(max)  NOT NULL,
    [Senha] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ContatosEmergenciaisSet'
CREATE TABLE [dbo].[ContatosEmergenciaisSet] (
    [IdContEmergenciais] int IDENTITY(1,1) NOT NULL,
    [Numero] nvarchar(max)  NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [AdministradorIdAdministrador] int  NOT NULL
);
GO

-- Creating table 'DicasSegurancaSet'
CREATE TABLE [dbo].[DicasSegurancaSet] (
    [IdDicasSeguranca] int IDENTITY(1,1) NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [AdministradorIdAdministrador] int  NOT NULL
);
GO

-- Creating table 'FaleConoscoSet'
CREATE TABLE [dbo].[FaleConoscoSet] (
    [IdFaleConosco] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Assunto] nvarchar(max)  NOT NULL,
    [Mensagem] nvarchar(max)  NOT NULL,
    [UsuarioIdUsuario] int  NOT NULL
);
GO

-- Creating table 'ChatSet'
CREATE TABLE [dbo].[ChatSet] (
    [IdChat] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Mensagem] nvarchar(max)  NOT NULL,
    [UsuarioIdUsuario] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdUsuario] in table 'UsuarioSet'
ALTER TABLE [dbo].[UsuarioSet]
ADD CONSTRAINT [PK_UsuarioSet]
    PRIMARY KEY CLUSTERED ([IdUsuario] ASC);
GO

-- Creating primary key on [IdDenuncia] in table 'DenunciaSet'
ALTER TABLE [dbo].[DenunciaSet]
ADD CONSTRAINT [PK_DenunciaSet]
    PRIMARY KEY CLUSTERED ([IdDenuncia] ASC);
GO

-- Creating primary key on [IdAdministrador] in table 'AdministradorSet'
ALTER TABLE [dbo].[AdministradorSet]
ADD CONSTRAINT [PK_AdministradorSet]
    PRIMARY KEY CLUSTERED ([IdAdministrador] ASC);
GO

-- Creating primary key on [IdContEmergenciais] in table 'ContatosEmergenciaisSet'
ALTER TABLE [dbo].[ContatosEmergenciaisSet]
ADD CONSTRAINT [PK_ContatosEmergenciaisSet]
    PRIMARY KEY CLUSTERED ([IdContEmergenciais] ASC);
GO

-- Creating primary key on [IdDicasSeguranca] in table 'DicasSegurancaSet'
ALTER TABLE [dbo].[DicasSegurancaSet]
ADD CONSTRAINT [PK_DicasSegurancaSet]
    PRIMARY KEY CLUSTERED ([IdDicasSeguranca] ASC);
GO

-- Creating primary key on [IdFaleConosco] in table 'FaleConoscoSet'
ALTER TABLE [dbo].[FaleConoscoSet]
ADD CONSTRAINT [PK_FaleConoscoSet]
    PRIMARY KEY CLUSTERED ([IdFaleConosco] ASC);
GO

-- Creating primary key on [IdChat] in table 'ChatSet'
ALTER TABLE [dbo].[ChatSet]
ADD CONSTRAINT [PK_ChatSet]
    PRIMARY KEY CLUSTERED ([IdChat] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [AdministradorIdAdministrador] in table 'ContatosEmergenciaisSet'
ALTER TABLE [dbo].[ContatosEmergenciaisSet]
ADD CONSTRAINT [FK_AdministradorContatosEmergenciais]
    FOREIGN KEY ([AdministradorIdAdministrador])
    REFERENCES [dbo].[AdministradorSet]
        ([IdAdministrador])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AdministradorContatosEmergenciais'
CREATE INDEX [IX_FK_AdministradorContatosEmergenciais]
ON [dbo].[ContatosEmergenciaisSet]
    ([AdministradorIdAdministrador]);
GO

-- Creating foreign key on [AdministradorIdAdministrador] in table 'DicasSegurancaSet'
ALTER TABLE [dbo].[DicasSegurancaSet]
ADD CONSTRAINT [FK_AdministradorDicasSeguranca]
    FOREIGN KEY ([AdministradorIdAdministrador])
    REFERENCES [dbo].[AdministradorSet]
        ([IdAdministrador])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AdministradorDicasSeguranca'
CREATE INDEX [IX_FK_AdministradorDicasSeguranca]
ON [dbo].[DicasSegurancaSet]
    ([AdministradorIdAdministrador]);
GO

-- Creating foreign key on [UsuarioIdUsuario] in table 'FaleConoscoSet'
ALTER TABLE [dbo].[FaleConoscoSet]
ADD CONSTRAINT [FK_UsuarioFaleConosco]
    FOREIGN KEY ([UsuarioIdUsuario])
    REFERENCES [dbo].[UsuarioSet]
        ([IdUsuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioFaleConosco'
CREATE INDEX [IX_FK_UsuarioFaleConosco]
ON [dbo].[FaleConoscoSet]
    ([UsuarioIdUsuario]);
GO

-- Creating foreign key on [UsuarioIdUsuario] in table 'DenunciaSet'
ALTER TABLE [dbo].[DenunciaSet]
ADD CONSTRAINT [FK_UsuarioDenuncia]
    FOREIGN KEY ([UsuarioIdUsuario])
    REFERENCES [dbo].[UsuarioSet]
        ([IdUsuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioDenuncia'
CREATE INDEX [IX_FK_UsuarioDenuncia]
ON [dbo].[DenunciaSet]
    ([UsuarioIdUsuario]);
GO

-- Creating foreign key on [AdministradorUsuario_Usuario_IdAdministrador] in table 'UsuarioSet'
ALTER TABLE [dbo].[UsuarioSet]
ADD CONSTRAINT [FK_AdministradorUsuario]
    FOREIGN KEY ([AdministradorUsuario_Usuario_IdAdministrador])
    REFERENCES [dbo].[AdministradorSet]
        ([IdAdministrador])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AdministradorUsuario'
CREATE INDEX [IX_FK_AdministradorUsuario]
ON [dbo].[UsuarioSet]
    ([AdministradorUsuario_Usuario_IdAdministrador]);
GO

-- Creating foreign key on [UsuarioIdUsuario] in table 'ChatSet'
ALTER TABLE [dbo].[ChatSet]
ADD CONSTRAINT [FK_UsuarioChat]
    FOREIGN KEY ([UsuarioIdUsuario])
    REFERENCES [dbo].[UsuarioSet]
        ([IdUsuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioChat'
CREATE INDEX [IX_FK_UsuarioChat]
ON [dbo].[ChatSet]
    ([UsuarioIdUsuario]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
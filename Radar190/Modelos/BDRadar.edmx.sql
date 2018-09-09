
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/08/2018 23:24:46
-- Generated from EDMX file: C:\Users\natha\Documents\CSharp\Radar190\Radar190\Modelos\BDRadar.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [master];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UsuarioSet'
CREATE TABLE [dbo].[UsuarioSet] (
    [IdUsuario] int IDENTITY(1,1) NOT NULL,
    [NomeCompleto] nvarchar(max)  NOT NULL,
    [DtNasc] datetime  NOT NULL,
    [Experiencia] bit  NULL,
    [Cidade] nvarchar(max)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [User] nvarchar(max)  NOT NULL,
    [Senha] smallint  NOT NULL,
    [CidadeIdCidade] int  NOT NULL,
    [Denuncia_IdDenuncia] int  NOT NULL
);
GO

-- Creating table 'CidadeSet'
CREATE TABLE [dbo].[CidadeSet] (
    [IdCidade] int IDENTITY(1,1) NOT NULL,
    [City] nvarchar(max)  NOT NULL,
    [UF] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DenunciaSet'
CREATE TABLE [dbo].[DenunciaSet] (
    [IdDenuncia] int IDENTITY(1,1) NOT NULL,
    [NomeCompleto] nvarchar(max)  NOT NULL,
    [Idade] smallint  NULL,
    [Tipo] nvarchar(max)  NOT NULL,
    [Sexo] nvarchar(max)  NULL,
    [CPF] nvarchar(max)  NOT NULL,
    [DataHora] datetime  NOT NULL,
    [BO] bit  NULL,
    [TipoOcorrencia] nvarchar(max)  NOT NULL,
    [Descricao] nvarchar(max)  NULL,
    [Prejuizo] nvarchar(max)  NULL,
    [UsuarioIdUsuario] int  NULL,
    [MapaIdMapa] int  NOT NULL
);
GO

-- Creating table 'ObjRoubadoSet'
CREATE TABLE [dbo].[ObjRoubadoSet] (
    [IdObjRoubados] int IDENTITY(1,1) NOT NULL,
    [Dinheiro] bit  NULL,
    [Carteira] bit  NULL,
    [Documentos] bit  NULL,
    [Celular] bit  NULL,
    [Notebook] bit  NULL,
    [Motocicleta] bit  NULL,
    [Veiculo] bit  NULL,
    [OutrosEletronicos] bit  NULL,
    [Outros] bit  NULL,
    [DenunciaIdDenuncia] int  NOT NULL
);
GO

-- Creating table 'MapaSet'
CREATE TABLE [dbo].[MapaSet] (
    [IdMapa] int IDENTITY(1,1) NOT NULL,
    [Endereco] nvarchar(max)  NOT NULL,
    [Numero] nvarchar(max)  NOT NULL,
    [BairroIdBairro] int  NOT NULL
);
GO

-- Creating table 'BairroSet'
CREATE TABLE [dbo].[BairroSet] (
    [IdBairro] int IDENTITY(1,1) NOT NULL,
    [Distrito] nvarchar(max)  NOT NULL,
    [CidadeIdCidade] int  NOT NULL
);
GO

-- Creating table 'AdministradorSet'
CREATE TABLE [dbo].[AdministradorSet] (
    [IdAdministrador] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Usuario] nvarchar(max)  NOT NULL,
    [Senha] nvarchar(max)  NOT NULL,
    [Usuarios_IdUsuario] int  NOT NULL
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

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdUsuario] in table 'UsuarioSet'
ALTER TABLE [dbo].[UsuarioSet]
ADD CONSTRAINT [PK_UsuarioSet]
    PRIMARY KEY CLUSTERED ([IdUsuario] ASC);
GO

-- Creating primary key on [IdCidade] in table 'CidadeSet'
ALTER TABLE [dbo].[CidadeSet]
ADD CONSTRAINT [PK_CidadeSet]
    PRIMARY KEY CLUSTERED ([IdCidade] ASC);
GO

-- Creating primary key on [IdDenuncia] in table 'DenunciaSet'
ALTER TABLE [dbo].[DenunciaSet]
ADD CONSTRAINT [PK_DenunciaSet]
    PRIMARY KEY CLUSTERED ([IdDenuncia] ASC);
GO

-- Creating primary key on [IdObjRoubados] in table 'ObjRoubadoSet'
ALTER TABLE [dbo].[ObjRoubadoSet]
ADD CONSTRAINT [PK_ObjRoubadoSet]
    PRIMARY KEY CLUSTERED ([IdObjRoubados] ASC);
GO

-- Creating primary key on [IdMapa] in table 'MapaSet'
ALTER TABLE [dbo].[MapaSet]
ADD CONSTRAINT [PK_MapaSet]
    PRIMARY KEY CLUSTERED ([IdMapa] ASC);
GO

-- Creating primary key on [IdBairro] in table 'BairroSet'
ALTER TABLE [dbo].[BairroSet]
ADD CONSTRAINT [PK_BairroSet]
    PRIMARY KEY CLUSTERED ([IdBairro] ASC);
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

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DenunciaIdDenuncia] in table 'ObjRoubadoSet'
ALTER TABLE [dbo].[ObjRoubadoSet]
ADD CONSTRAINT [FK_DenunciaObjRoubados]
    FOREIGN KEY ([DenunciaIdDenuncia])
    REFERENCES [dbo].[DenunciaSet]
        ([IdDenuncia])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DenunciaObjRoubados'
CREATE INDEX [IX_FK_DenunciaObjRoubados]
ON [dbo].[ObjRoubadoSet]
    ([DenunciaIdDenuncia]);
GO

-- Creating foreign key on [BairroIdBairro] in table 'MapaSet'
ALTER TABLE [dbo].[MapaSet]
ADD CONSTRAINT [FK_MapaBairro]
    FOREIGN KEY ([BairroIdBairro])
    REFERENCES [dbo].[BairroSet]
        ([IdBairro])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MapaBairro'
CREATE INDEX [IX_FK_MapaBairro]
ON [dbo].[MapaSet]
    ([BairroIdBairro]);
GO

-- Creating foreign key on [Usuarios_IdUsuario] in table 'AdministradorSet'
ALTER TABLE [dbo].[AdministradorSet]
ADD CONSTRAINT [FK_AdministradorUsuario]
    FOREIGN KEY ([Usuarios_IdUsuario])
    REFERENCES [dbo].[UsuarioSet]
        ([IdUsuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AdministradorUsuario'
CREATE INDEX [IX_FK_AdministradorUsuario]
ON [dbo].[AdministradorSet]
    ([Usuarios_IdUsuario]);
GO

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

-- Creating foreign key on [MapaIdMapa] in table 'DenunciaSet'
ALTER TABLE [dbo].[DenunciaSet]
ADD CONSTRAINT [FK_MapaDenuncia]
    FOREIGN KEY ([MapaIdMapa])
    REFERENCES [dbo].[MapaSet]
        ([IdMapa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MapaDenuncia'
CREATE INDEX [IX_FK_MapaDenuncia]
ON [dbo].[DenunciaSet]
    ([MapaIdMapa]);
GO

-- Creating foreign key on [Denuncia_IdDenuncia] in table 'UsuarioSet'
ALTER TABLE [dbo].[UsuarioSet]
ADD CONSTRAINT [FK_UsuarioDenuncia]
    FOREIGN KEY ([Denuncia_IdDenuncia])
    REFERENCES [dbo].[DenunciaSet]
        ([IdDenuncia])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioDenuncia'
CREATE INDEX [IX_FK_UsuarioDenuncia]
ON [dbo].[UsuarioSet]
    ([Denuncia_IdDenuncia]);
GO

-- Creating foreign key on [CidadeIdCidade] in table 'BairroSet'
ALTER TABLE [dbo].[BairroSet]
ADD CONSTRAINT [FK_CidadeBairro]
    FOREIGN KEY ([CidadeIdCidade])
    REFERENCES [dbo].[CidadeSet]
        ([IdCidade])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CidadeBairro'
CREATE INDEX [IX_FK_CidadeBairro]
ON [dbo].[BairroSet]
    ([CidadeIdCidade]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
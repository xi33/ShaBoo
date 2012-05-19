
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 05/09/2012 09:06:39
-- Generated from EDMX file: D:\Documents\Visual Studio 2010\Projects\ShaBoo_all\ShaBoo\src\Entities\ShaBoo.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [shaboo_test];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_RoleUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserSet] DROP CONSTRAINT [FK_RoleUser];
GO
IF OBJECT_ID(N'[dbo].[FK_FstClassSndClass]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SndClassSet] DROP CONSTRAINT [FK_FstClassSndClass];
GO
IF OBJECT_ID(N'[dbo].[FK_SndClassTrdClass]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TrdClassSet] DROP CONSTRAINT [FK_SndClassTrdClass];
GO
IF OBJECT_ID(N'[dbo].[FK_FstClassDocument]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DocumentSet] DROP CONSTRAINT [FK_FstClassDocument];
GO
IF OBJECT_ID(N'[dbo].[FK_SndClassDocument]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DocumentSet] DROP CONSTRAINT [FK_SndClassDocument];
GO
IF OBJECT_ID(N'[dbo].[FK_TrdClassDocument]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DocumentSet] DROP CONSTRAINT [FK_TrdClassDocument];
GO
IF OBJECT_ID(N'[dbo].[FK_ProfileDocument]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DocumentSet] DROP CONSTRAINT [FK_ProfileDocument];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[RoleSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RoleSet];
GO
IF OBJECT_ID(N'[dbo].[UserSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserSet];
GO
IF OBJECT_ID(N'[dbo].[DocumentSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DocumentSet];
GO
IF OBJECT_ID(N'[dbo].[ProfileSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProfileSet];
GO
IF OBJECT_ID(N'[dbo].[FstClassSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FstClassSet];
GO
IF OBJECT_ID(N'[dbo].[SndClassSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SndClassSet];
GO
IF OBJECT_ID(N'[dbo].[TrdClassSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TrdClassSet];
GO
IF OBJECT_ID(N'[dbo].[BoardSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BoardSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'RoleSet'
CREATE TABLE [dbo].[RoleSet] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'UserSet'
CREATE TABLE [dbo].[UserSet] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [RoleID] int  NOT NULL
);
GO

-- Creating table 'DocumentSet'
CREATE TABLE [dbo].[DocumentSet] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Path] nvarchar(max)  NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Tags] nvarchar(max)  NOT NULL,
    [Intro] nvarchar(max)  NOT NULL,
    [Suffix] nvarchar(max)  NOT NULL,
    [Size] int  NOT NULL,
    [Views] smallint  NOT NULL,
    [Downloads] smallint  NOT NULL,
    [UploadedOn] datetime  NOT NULL,
    [FstClassID] int  NOT NULL,
    [SndClassID] int  NOT NULL,
    [TrdClassID] int  NOT NULL,
    [ProfileID] int  NOT NULL
);
GO

-- Creating table 'ProfileSet'
CREATE TABLE [dbo].[ProfileSet] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(max)  NOT NULL,
    [FirstName] nvarchar(max)  NULL,
    [LastName] nvarchar(max)  NULL,
    [Alias] nvarchar(max)  NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Intro] nvarchar(max)  NULL,
    [Point] int  NOT NULL
);
GO

-- Creating table 'FstClassSet'
CREATE TABLE [dbo].[FstClassSet] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'SndClassSet'
CREATE TABLE [dbo].[SndClassSet] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [FstClassID] int  NOT NULL
);
GO

-- Creating table 'TrdClassSet'
CREATE TABLE [dbo].[TrdClassSet] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [SndClassID] int  NOT NULL
);
GO

-- Creating table 'BoardSet'
CREATE TABLE [dbo].[BoardSet] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [PostedOn] datetime  NOT NULL,
    [Content] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'RoleSet'
ALTER TABLE [dbo].[RoleSet]
ADD CONSTRAINT [PK_RoleSet]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'UserSet'
ALTER TABLE [dbo].[UserSet]
ADD CONSTRAINT [PK_UserSet]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'DocumentSet'
ALTER TABLE [dbo].[DocumentSet]
ADD CONSTRAINT [PK_DocumentSet]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ProfileSet'
ALTER TABLE [dbo].[ProfileSet]
ADD CONSTRAINT [PK_ProfileSet]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'FstClassSet'
ALTER TABLE [dbo].[FstClassSet]
ADD CONSTRAINT [PK_FstClassSet]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'SndClassSet'
ALTER TABLE [dbo].[SndClassSet]
ADD CONSTRAINT [PK_SndClassSet]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TrdClassSet'
ALTER TABLE [dbo].[TrdClassSet]
ADD CONSTRAINT [PK_TrdClassSet]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'BoardSet'
ALTER TABLE [dbo].[BoardSet]
ADD CONSTRAINT [PK_BoardSet]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [RoleID] in table 'UserSet'
ALTER TABLE [dbo].[UserSet]
ADD CONSTRAINT [FK_RoleUser]
    FOREIGN KEY ([RoleID])
    REFERENCES [dbo].[RoleSet]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_RoleUser'
CREATE INDEX [IX_FK_RoleUser]
ON [dbo].[UserSet]
    ([RoleID]);
GO

-- Creating foreign key on [FstClassID] in table 'SndClassSet'
ALTER TABLE [dbo].[SndClassSet]
ADD CONSTRAINT [FK_FstClassSndClass]
    FOREIGN KEY ([FstClassID])
    REFERENCES [dbo].[FstClassSet]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FstClassSndClass'
CREATE INDEX [IX_FK_FstClassSndClass]
ON [dbo].[SndClassSet]
    ([FstClassID]);
GO

-- Creating foreign key on [SndClassID] in table 'TrdClassSet'
ALTER TABLE [dbo].[TrdClassSet]
ADD CONSTRAINT [FK_SndClassTrdClass]
    FOREIGN KEY ([SndClassID])
    REFERENCES [dbo].[SndClassSet]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SndClassTrdClass'
CREATE INDEX [IX_FK_SndClassTrdClass]
ON [dbo].[TrdClassSet]
    ([SndClassID]);
GO

-- Creating foreign key on [FstClassID] in table 'DocumentSet'
ALTER TABLE [dbo].[DocumentSet]
ADD CONSTRAINT [FK_FstClassDocument]
    FOREIGN KEY ([FstClassID])
    REFERENCES [dbo].[FstClassSet]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FstClassDocument'
CREATE INDEX [IX_FK_FstClassDocument]
ON [dbo].[DocumentSet]
    ([FstClassID]);
GO

-- Creating foreign key on [SndClassID] in table 'DocumentSet'
ALTER TABLE [dbo].[DocumentSet]
ADD CONSTRAINT [FK_SndClassDocument]
    FOREIGN KEY ([SndClassID])
    REFERENCES [dbo].[SndClassSet]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SndClassDocument'
CREATE INDEX [IX_FK_SndClassDocument]
ON [dbo].[DocumentSet]
    ([SndClassID]);
GO

-- Creating foreign key on [TrdClassID] in table 'DocumentSet'
ALTER TABLE [dbo].[DocumentSet]
ADD CONSTRAINT [FK_TrdClassDocument]
    FOREIGN KEY ([TrdClassID])
    REFERENCES [dbo].[TrdClassSet]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TrdClassDocument'
CREATE INDEX [IX_FK_TrdClassDocument]
ON [dbo].[DocumentSet]
    ([TrdClassID]);
GO

-- Creating foreign key on [ProfileID] in table 'DocumentSet'
ALTER TABLE [dbo].[DocumentSet]
ADD CONSTRAINT [FK_ProfileDocument]
    FOREIGN KEY ([ProfileID])
    REFERENCES [dbo].[ProfileSet]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProfileDocument'
CREATE INDEX [IX_FK_ProfileDocument]
ON [dbo].[DocumentSet]
    ([ProfileID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
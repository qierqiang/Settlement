
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/10/2017 16:28:54
-- Generated from EDMX file: D:\Projects\Settlement\Settlement.Model\Settlement.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SalesmenSettlementDev];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[UserInfoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserInfoSet];
GO
IF OBJECT_ID(N'[dbo].[ProfileSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProfileSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UserInfoSet'
CREATE TABLE [dbo].[UserInfoSet] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(50)  NOT NULL,
    [DisplayName] nvarchar(50)  NOT NULL,
    [Password] nvarchar(32)  NOT NULL,
    [Disabled] bit  NOT NULL
);
GO

-- Creating table 'ProfileSet'
CREATE TABLE [dbo].[ProfileSet] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [Category] nvarchar(50)  NOT NULL,
    [Key] nvarchar(50)  NOT NULL,
    [Value] nvarchar(max)  NOT NULL,
    [Discription] nvarchar(50)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'UserInfoSet'
ALTER TABLE [dbo].[UserInfoSet]
ADD CONSTRAINT [PK_UserInfoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProfileSet'
ALTER TABLE [dbo].[ProfileSet]
ADD CONSTRAINT [PK_ProfileSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
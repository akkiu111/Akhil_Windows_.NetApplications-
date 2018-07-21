
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/16/2018 14:07:45
-- Generated from EDMX file: E:\IMCS\DotNetProjects\Akhil_Voting\Akhil_Voting\PlayersModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [voting];
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

-- Creating table 'Voters'
CREATE TABLE [dbo].[Voters] (
    [VoterId] int IDENTITY(1,1) NOT NULL,
    [VoterPassword] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Pets'
CREATE TABLE [dbo].[Pets] (
    [PetId] int IDENTITY(1,1) NOT NULL,
    [PetName] nvarchar(max)  NOT NULL,
    [ImageUrl] nvarchar(max)  NOT NULL,
    [TotalVotes] nvarchar(max)  NOT NULL,
    [Voting] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'VoterPet'
CREATE TABLE [dbo].[VoterPet] (
    [Voters_VoterId] int  NOT NULL,
    [Pets_PetId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [VoterId] in table 'Voters'
ALTER TABLE [dbo].[Voters]
ADD CONSTRAINT [PK_Voters]
    PRIMARY KEY CLUSTERED ([VoterId] ASC);
GO

-- Creating primary key on [PetId] in table 'Pets'
ALTER TABLE [dbo].[Pets]
ADD CONSTRAINT [PK_Pets]
    PRIMARY KEY CLUSTERED ([PetId] ASC);
GO

-- Creating primary key on [Voters_VoterId], [Pets_PetId] in table 'VoterPet'
ALTER TABLE [dbo].[VoterPet]
ADD CONSTRAINT [PK_VoterPet]
    PRIMARY KEY CLUSTERED ([Voters_VoterId], [Pets_PetId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Voters_VoterId] in table 'VoterPet'
ALTER TABLE [dbo].[VoterPet]
ADD CONSTRAINT [FK_VoterPet_Voter]
    FOREIGN KEY ([Voters_VoterId])
    REFERENCES [dbo].[Voters]
        ([VoterId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Pets_PetId] in table 'VoterPet'
ALTER TABLE [dbo].[VoterPet]
ADD CONSTRAINT [FK_VoterPet_Pet]
    FOREIGN KEY ([Pets_PetId])
    REFERENCES [dbo].[Pets]
        ([PetId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VoterPet_Pet'
CREATE INDEX [IX_FK_VoterPet_Pet]
ON [dbo].[VoterPet]
    ([Pets_PetId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
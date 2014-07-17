
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/10/2014 17:40:41
-- Generated from EDMX file: C:\MyDevelopment\TimeTracker\TimeTracker.EF\TimeTrackerModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Tracker];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AddressesAgencies]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Agencies] DROP CONSTRAINT [FK_AddressesAgencies];
GO
IF OBJECT_ID(N'[dbo].[FK_AddressesCompanies]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Companies] DROP CONSTRAINT [FK_AddressesCompanies];
GO
IF OBJECT_ID(N'[dbo].[FK_AgenciesConsultants]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Consultants] DROP CONSTRAINT [FK_AgenciesConsultants];
GO
IF OBJECT_ID(N'[dbo].[FK_CompaniesPeople]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[People] DROP CONSTRAINT [FK_CompaniesPeople];
GO
IF OBJECT_ID(N'[dbo].[FK_AgenciesEngagements]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Engagements] DROP CONSTRAINT [FK_AgenciesEngagements];
GO
IF OBJECT_ID(N'[dbo].[FK_ConsultantsEngagements]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Engagements] DROP CONSTRAINT [FK_ConsultantsEngagements];
GO
IF OBJECT_ID(N'[dbo].[FK_CompaniesEngagements]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Engagements] DROP CONSTRAINT [FK_CompaniesEngagements];
GO
IF OBJECT_ID(N'[dbo].[FK_AddressesEngagements]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Engagements] DROP CONSTRAINT [FK_AddressesEngagements];
GO
IF OBJECT_ID(N'[dbo].[FK_PeopleEngagements]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Engagements] DROP CONSTRAINT [FK_PeopleEngagements];
GO
IF OBJECT_ID(N'[dbo].[FK_PeopleProjects]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Projects] DROP CONSTRAINT [FK_PeopleProjects];
GO
IF OBJECT_ID(N'[dbo].[FK_EngagementsProjects]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Projects] DROP CONSTRAINT [FK_EngagementsProjects];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectsTasks]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tasks] DROP CONSTRAINT [FK_ProjectsTasks];
GO
IF OBJECT_ID(N'[dbo].[FK_TasksLog]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Logs] DROP CONSTRAINT [FK_TasksLog];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Addresses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Addresses];
GO
IF OBJECT_ID(N'[dbo].[Agencies]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Agencies];
GO
IF OBJECT_ID(N'[dbo].[Companies]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Companies];
GO
IF OBJECT_ID(N'[dbo].[Consultants]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Consultants];
GO
IF OBJECT_ID(N'[dbo].[Engagements]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Engagements];
GO
IF OBJECT_ID(N'[dbo].[People]', 'U') IS NOT NULL
    DROP TABLE [dbo].[People];
GO
IF OBJECT_ID(N'[dbo].[Projects]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Projects];
GO
IF OBJECT_ID(N'[dbo].[Tasks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tasks];
GO
IF OBJECT_ID(N'[dbo].[Logs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Logs];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Addresses'
CREATE TABLE [dbo].[Addresses] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Street1] nvarchar(100)  NOT NULL,
    [Street2] nvarchar(100)  NULL,
    [Street3] nvarchar(100)  NULL,
    [Suburb] nvarchar(100)  NOT NULL,
    [StateID] int  NOT NULL,
    [Postcode] nvarchar(4)  NOT NULL
);
GO

-- Creating table 'Agencies'
CREATE TABLE [dbo].[Agencies] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(100)  NOT NULL,
    [PhoneNumber] nvarchar(12)  NOT NULL,
    [Address_Id] int  NULL
);
GO

-- Creating table 'Companies'
CREATE TABLE [dbo].[Companies] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(100)  NOT NULL,
    [Address_Id] int  NULL
);
GO

-- Creating table 'Consultants'
CREATE TABLE [dbo].[Consultants] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(30)  NOT NULL,
    [LastName] nvarchar(30)  NOT NULL,
    [PhoneNumber] nvarchar(12)  NOT NULL,
    [Email] nvarchar(200)  NOT NULL,
    [AgenciesId] int  NOT NULL
);
GO

-- Creating table 'Engagements'
CREATE TABLE [dbo].[Engagements] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Commencement] datetime  NOT NULL,
    [Completion] datetime  NULL,
    [AgenciesId] int  NOT NULL,
    [ConsultantsId] int  NOT NULL,
    [CompaniesId] int  NOT NULL,
    [AddressesId] int  NOT NULL,
    [PeopleId] int  NOT NULL
);
GO

-- Creating table 'People'
CREATE TABLE [dbo].[People] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(30)  NOT NULL,
    [LastName] nvarchar(30)  NOT NULL,
    [PhoneNumber] nvarchar(12)  NOT NULL,
    [Email] nvarchar(200)  NOT NULL,
    [CompaniesId] int  NOT NULL
);
GO

-- Creating table 'Projects'
CREATE TABLE [dbo].[Projects] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(100)  NOT NULL,
    [PeopleId] int  NOT NULL,
    [EngagementsId] int  NOT NULL
);
GO

-- Creating table 'Tasks'
CREATE TABLE [dbo].[Tasks] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(100)  NOT NULL,
    [ProjectsId] int  NOT NULL
);
GO

-- Creating table 'Logs'
CREATE TABLE [dbo].[Logs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [LogDate] datetime  NOT NULL,
    [Description] nvarchar(200)  NOT NULL,
    [StartTime] datetime  NOT NULL,
    [EndTime] datetime  NULL,
    [TasksId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Addresses'
ALTER TABLE [dbo].[Addresses]
ADD CONSTRAINT [PK_Addresses]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Agencies'
ALTER TABLE [dbo].[Agencies]
ADD CONSTRAINT [PK_Agencies]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Companies'
ALTER TABLE [dbo].[Companies]
ADD CONSTRAINT [PK_Companies]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Consultants'
ALTER TABLE [dbo].[Consultants]
ADD CONSTRAINT [PK_Consultants]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Engagements'
ALTER TABLE [dbo].[Engagements]
ADD CONSTRAINT [PK_Engagements]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [PK_People]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Projects'
ALTER TABLE [dbo].[Projects]
ADD CONSTRAINT [PK_Projects]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Tasks'
ALTER TABLE [dbo].[Tasks]
ADD CONSTRAINT [PK_Tasks]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Logs'
ALTER TABLE [dbo].[Logs]
ADD CONSTRAINT [PK_Logs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Address_Id] in table 'Agencies'
ALTER TABLE [dbo].[Agencies]
ADD CONSTRAINT [FK_AddressesAgencies]
    FOREIGN KEY ([Address_Id])
    REFERENCES [dbo].[Addresses]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AddressesAgencies'
CREATE INDEX [IX_FK_AddressesAgencies]
ON [dbo].[Agencies]
    ([Address_Id]);
GO

-- Creating foreign key on [Address_Id] in table 'Companies'
ALTER TABLE [dbo].[Companies]
ADD CONSTRAINT [FK_AddressesCompanies]
    FOREIGN KEY ([Address_Id])
    REFERENCES [dbo].[Addresses]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AddressesCompanies'
CREATE INDEX [IX_FK_AddressesCompanies]
ON [dbo].[Companies]
    ([Address_Id]);
GO

-- Creating foreign key on [AgenciesId] in table 'Consultants'
ALTER TABLE [dbo].[Consultants]
ADD CONSTRAINT [FK_AgenciesConsultants]
    FOREIGN KEY ([AgenciesId])
    REFERENCES [dbo].[Agencies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AgenciesConsultants'
CREATE INDEX [IX_FK_AgenciesConsultants]
ON [dbo].[Consultants]
    ([AgenciesId]);
GO

-- Creating foreign key on [CompaniesId] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [FK_CompaniesPeople]
    FOREIGN KEY ([CompaniesId])
    REFERENCES [dbo].[Companies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CompaniesPeople'
CREATE INDEX [IX_FK_CompaniesPeople]
ON [dbo].[People]
    ([CompaniesId]);
GO

-- Creating foreign key on [AgenciesId] in table 'Engagements'
ALTER TABLE [dbo].[Engagements]
ADD CONSTRAINT [FK_AgenciesEngagements]
    FOREIGN KEY ([AgenciesId])
    REFERENCES [dbo].[Agencies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AgenciesEngagements'
CREATE INDEX [IX_FK_AgenciesEngagements]
ON [dbo].[Engagements]
    ([AgenciesId]);
GO

-- Creating foreign key on [ConsultantsId] in table 'Engagements'
ALTER TABLE [dbo].[Engagements]
ADD CONSTRAINT [FK_ConsultantsEngagements]
    FOREIGN KEY ([ConsultantsId])
    REFERENCES [dbo].[Consultants]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ConsultantsEngagements'
CREATE INDEX [IX_FK_ConsultantsEngagements]
ON [dbo].[Engagements]
    ([ConsultantsId]);
GO

-- Creating foreign key on [CompaniesId] in table 'Engagements'
ALTER TABLE [dbo].[Engagements]
ADD CONSTRAINT [FK_CompaniesEngagements]
    FOREIGN KEY ([CompaniesId])
    REFERENCES [dbo].[Companies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CompaniesEngagements'
CREATE INDEX [IX_FK_CompaniesEngagements]
ON [dbo].[Engagements]
    ([CompaniesId]);
GO

-- Creating foreign key on [AddressesId] in table 'Engagements'
ALTER TABLE [dbo].[Engagements]
ADD CONSTRAINT [FK_AddressesEngagements]
    FOREIGN KEY ([AddressesId])
    REFERENCES [dbo].[Addresses]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AddressesEngagements'
CREATE INDEX [IX_FK_AddressesEngagements]
ON [dbo].[Engagements]
    ([AddressesId]);
GO

-- Creating foreign key on [PeopleId] in table 'Engagements'
ALTER TABLE [dbo].[Engagements]
ADD CONSTRAINT [FK_PeopleEngagements]
    FOREIGN KEY ([PeopleId])
    REFERENCES [dbo].[People]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PeopleEngagements'
CREATE INDEX [IX_FK_PeopleEngagements]
ON [dbo].[Engagements]
    ([PeopleId]);
GO

-- Creating foreign key on [PeopleId] in table 'Projects'
ALTER TABLE [dbo].[Projects]
ADD CONSTRAINT [FK_PeopleProjects]
    FOREIGN KEY ([PeopleId])
    REFERENCES [dbo].[People]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PeopleProjects'
CREATE INDEX [IX_FK_PeopleProjects]
ON [dbo].[Projects]
    ([PeopleId]);
GO

-- Creating foreign key on [EngagementsId] in table 'Projects'
ALTER TABLE [dbo].[Projects]
ADD CONSTRAINT [FK_EngagementsProjects]
    FOREIGN KEY ([EngagementsId])
    REFERENCES [dbo].[Engagements]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EngagementsProjects'
CREATE INDEX [IX_FK_EngagementsProjects]
ON [dbo].[Projects]
    ([EngagementsId]);
GO

-- Creating foreign key on [ProjectsId] in table 'Tasks'
ALTER TABLE [dbo].[Tasks]
ADD CONSTRAINT [FK_ProjectsTasks]
    FOREIGN KEY ([ProjectsId])
    REFERENCES [dbo].[Projects]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectsTasks'
CREATE INDEX [IX_FK_ProjectsTasks]
ON [dbo].[Tasks]
    ([ProjectsId]);
GO

-- Creating foreign key on [TasksId] in table 'Logs'
ALTER TABLE [dbo].[Logs]
ADD CONSTRAINT [FK_TasksLog]
    FOREIGN KEY ([TasksId])
    REFERENCES [dbo].[Tasks]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TasksLog'
CREATE INDEX [IX_FK_TasksLog]
ON [dbo].[Logs]
    ([TasksId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
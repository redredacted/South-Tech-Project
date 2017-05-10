
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/09/2017 14:02:18
-- Generated from EDMX file: E:\South Tech\C#\Ch. 8\South-Tech-Project\South-Tech-Project\Medical.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Medical];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Contacts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Contacts];
GO
IF OBJECT_ID(N'[dbo].[Drugs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Drugs];
GO
IF OBJECT_ID(N'[dbo].[Employees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employees];
GO
IF OBJECT_ID(N'[dbo].[Notes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Notes];
GO
IF OBJECT_ID(N'[dbo].[Patients]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Patients];
GO
IF OBJECT_ID(N'[dbo].[PatientInventories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PatientInventories];
GO
IF OBJECT_ID(N'[dbo].[Treatments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Treatments];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Contacts'
CREATE TABLE [dbo].[Contacts] (
    [ContactID] uniqueidentifier  NOT NULL,
    [PatientID] uniqueidentifier  NOT NULL,
    [Relation] int  NOT NULL,
    [WorkPhone] nvarchar(20)  NOT NULL,
    [HomePhone] nvarchar(20)  NOT NULL,
    [CellPhone] nvarchar(20)  NOT NULL
);
GO

-- Creating table 'Drugs'
CREATE TABLE [dbo].[Drugs] (
    [DrugID] uniqueidentifier  NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [FDAApproved] bit  NOT NULL,
    [SideAffects] nvarchar(250)  NOT NULL,
    [Stock] int  NOT NULL,
    [Description] nvarchar(250)  NOT NULL
);
GO

-- Creating table 'Employees'
CREATE TABLE [dbo].[Employees] (
    [EmployeeID] uniqueidentifier  NOT NULL,
    [Position] int  NOT NULL,
    [Title] nvarchar(25)  NOT NULL,
    [FirstName] nvarchar(25)  NOT NULL,
    [MiddleName] nvarchar(25)  NOT NULL,
    [LastName] nvarchar(25)  NOT NULL,
    [Phone] nvarchar(20)  NOT NULL,
    [Salary] decimal(19,4)  NOT NULL,
    [Working] bit  NOT NULL
);
GO

-- Creating table 'Notes'
CREATE TABLE [dbo].[Notes] (
    [NoteID] uniqueidentifier  NOT NULL,
    [EmployeeID] uniqueidentifier  NOT NULL,
    [PatientID] uniqueidentifier  NOT NULL,
    [Note1] nvarchar(250)  NOT NULL,
    [Important] bit  NOT NULL,
    [Timestamp] binary(8)  NOT NULL
);
GO

-- Creating table 'Patients'
CREATE TABLE [dbo].[Patients] (
    [PatientID] uniqueidentifier  NOT NULL,
    [NurseID] uniqueidentifier  NOT NULL,
    [FirstName] varchar(50)  NOT NULL,
    [MiddleName] varchar(50)  NOT NULL,
    [LastName] varchar(50)  NOT NULL,
    [Status] int  NOT NULL
);
GO

-- Creating table 'PatientInventories'
CREATE TABLE [dbo].[PatientInventories] (
    [ID] uniqueidentifier  NOT NULL,
    [PatientID] uniqueidentifier  NOT NULL,
    [type] int  NOT NULL,
    [Timestamp] binary(8)  NOT NULL,
    [Notes] nvarchar(250)  NOT NULL
);
GO

-- Creating table 'Treatments'
CREATE TABLE [dbo].[Treatments] (
    [TreatmentID] uniqueidentifier  NOT NULL,
    [EmployeeID] uniqueidentifier  NOT NULL,
    [PatientID] uniqueidentifier  NOT NULL,
    [Type] int  NOT NULL,
    [Result] nvarchar(250)  NOT NULL,
    [Timestamp] binary(8)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ContactID] in table 'Contacts'
ALTER TABLE [dbo].[Contacts]
ADD CONSTRAINT [PK_Contacts]
    PRIMARY KEY CLUSTERED ([ContactID] ASC);
GO

-- Creating primary key on [DrugID] in table 'Drugs'
ALTER TABLE [dbo].[Drugs]
ADD CONSTRAINT [PK_Drugs]
    PRIMARY KEY CLUSTERED ([DrugID] ASC);
GO

-- Creating primary key on [EmployeeID] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [PK_Employees]
    PRIMARY KEY CLUSTERED ([EmployeeID] ASC);
GO

-- Creating primary key on [NoteID] in table 'Notes'
ALTER TABLE [dbo].[Notes]
ADD CONSTRAINT [PK_Notes]
    PRIMARY KEY CLUSTERED ([NoteID] ASC);
GO

-- Creating primary key on [PatientID] in table 'Patients'
ALTER TABLE [dbo].[Patients]
ADD CONSTRAINT [PK_Patients]
    PRIMARY KEY CLUSTERED ([PatientID] ASC);
GO

-- Creating primary key on [ID] in table 'PatientInventories'
ALTER TABLE [dbo].[PatientInventories]
ADD CONSTRAINT [PK_PatientInventories]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [TreatmentID] in table 'Treatments'
ALTER TABLE [dbo].[Treatments]
ADD CONSTRAINT [PK_Treatments]
    PRIMARY KEY CLUSTERED ([TreatmentID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
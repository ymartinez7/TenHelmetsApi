IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [ActionTypes] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_ActionTypes] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [ActivityTypes] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Description] nvarchar(200) NULL,
    CONSTRAINT [PK_ActivityTypes] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [AlertTypes] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Description] nvarchar(200) NULL,
    CONSTRAINT [PK_AlertTypes] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Brands] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Brands] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [DocumentTypes] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Description] nvarchar(200) NULL,
    CONSTRAINT [PK_DocumentTypes] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [EspenseTypes] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Description] nvarchar(200) NULL,
    CONSTRAINT [PK_EspenseTypes] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [EventLogTypes] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_EventLogTypes] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [InspectionTypes] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Description] nvarchar(200) NULL,
    CONSTRAINT [PK_InspectionTypes] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Organizations] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Description] nvarchar(500) NULL,
    [Email] nvarchar(max) NULL,
    CONSTRAINT [PK_Organizations] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [PaymentTypes] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_PaymentTypes] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [ResourceTypes] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_ResourceTypes] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Sectors] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Description] nvarchar(200) NULL,
    CONSTRAINT [PK_Sectors] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Status] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Description] nvarchar(200) NULL,
    CONSTRAINT [PK_Status] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Priotities] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [MinTM] int NOT NULL,
    [MaxTM] int NOT NULL,
    [AlertTypeId] int NOT NULL,
    [AlertTypeId1] int NULL,
    CONSTRAINT [PK_Priotities] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Priotities_AlertTypes_AlertTypeId] FOREIGN KEY ([AlertTypeId]) REFERENCES [AlertTypes] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Priotities_AlertTypes_AlertTypeId1] FOREIGN KEY ([AlertTypeId1]) REFERENCES [AlertTypes] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [EventLogs] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [EventLogTypeId] int NOT NULL,
    [Description] nvarchar(500) NOT NULL,
    [EventLogTypeId1] int NULL,
    CONSTRAINT [PK_EventLogs] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_EventLogs_EventLogTypes_EventLogTypeId] FOREIGN KEY ([EventLogTypeId]) REFERENCES [EventLogTypes] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_EventLogs_EventLogTypes_EventLogTypeId1] FOREIGN KEY ([EventLogTypeId1]) REFERENCES [EventLogTypes] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Units] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Description] nvarchar(200) NULL,
    [Email] nvarchar(max) NULL,
    [OrganizationId] int NOT NULL,
    [OrganizationId1] int NULL,
    CONSTRAINT [PK_Units] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Units_Organizations_OrganizationId] FOREIGN KEY ([OrganizationId]) REFERENCES [Organizations] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Units_Organizations_OrganizationId1] FOREIGN KEY ([OrganizationId1]) REFERENCES [Organizations] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Resources] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Description] nvarchar(200) NOT NULL,
    [ResourceTypeId] int NOT NULL,
    [BrandId] int NOT NULL,
    [SerialNumber] nvarchar(max) NULL,
    [Quantity] int NOT NULL,
    [UnitaryPrice] decimal(18,2) NOT NULL,
    [State] nvarchar(max) NULL,
    [BrandId1] int NULL,
    [ResourceTypeId1] int NULL,
    CONSTRAINT [PK_Resources] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Resources_Brands_BrandId] FOREIGN KEY ([BrandId]) REFERENCES [Brands] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Resources_Brands_BrandId1] FOREIGN KEY ([BrandId1]) REFERENCES [Brands] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Resources_ResourceTypes_ResourceTypeId] FOREIGN KEY ([ResourceTypeId]) REFERENCES [ResourceTypes] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Resources_ResourceTypes_ResourceTypeId1] FOREIGN KEY ([ResourceTypeId1]) REFERENCES [ResourceTypes] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Customers] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Rif] nvarchar(10) NOT NULL,
    [TaxAddress] nvarchar(200) NOT NULL,
    [SectorId] int NOT NULL,
    [ContactEmployeeFirstName] nvarchar(200) NOT NULL,
    [ContactEmployeeLastName] nvarchar(200) NOT NULL,
    [PhoneNumber] nvarchar(max) NULL,
    [Email] nvarchar(max) NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Customers_Sectors_SectorId] FOREIGN KEY ([SectorId]) REFERENCES [Sectors] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Providers] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Rif] nvarchar(10) NOT NULL,
    [TaxAddress] nvarchar(200) NOT NULL,
    [SectorId] int NOT NULL,
    [LocalNumber] nvarchar(max) NULL,
    [Email] nvarchar(max) NULL,
    [SectorId1] int NULL,
    CONSTRAINT [PK_Providers] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Providers_Sectors_SectorId] FOREIGN KEY ([SectorId]) REFERENCES [Sectors] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Providers_Sectors_SectorId1] FOREIGN KEY ([SectorId1]) REFERENCES [Sectors] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [RequestTypes] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Description] nvarchar(200) NULL,
    [UnitId] int NOT NULL,
    [UnitId1] int NULL,
    CONSTRAINT [PK_RequestTypes] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_RequestTypes_Units_UnitId] FOREIGN KEY ([UnitId]) REFERENCES [Units] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_RequestTypes_Units_UnitId1] FOREIGN KEY ([UnitId1]) REFERENCES [Units] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Roles] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [Name] nvarchar(max) NULL,
    [Description] nvarchar(max) NULL,
    [UnitId] int NOT NULL,
    CONSTRAINT [PK_Roles] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Roles_Units_UnitId] FOREIGN KEY ([UnitId]) REFERENCES [Units] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [Models] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Year] int NOT NULL,
    [Capacity] nvarchar(max) NULL,
    [Measure] nvarchar(max) NULL,
    [ResourceId] int NOT NULL,
    [ResourceId1] int NULL,
    CONSTRAINT [PK_Models] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Models_Resources_ResourceId] FOREIGN KEY ([ResourceId]) REFERENCES [Resources] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Models_Resources_ResourceId1] FOREIGN KEY ([ResourceId1]) REFERENCES [Resources] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [ServiceOrders] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [Amount] decimal(18,2) NOT NULL,
    [Description] nvarchar(500) NOT NULL,
    [CustomerId] int NOT NULL,
    [UnitId] int NOT NULL,
    [ReceptionDate] datetime2 NOT NULL,
    [CustomerId1] int NULL,
    [UnitId1] int NULL,
    CONSTRAINT [PK_ServiceOrders] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_ServiceOrders_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customers] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_ServiceOrders_Customers_CustomerId1] FOREIGN KEY ([CustomerId1]) REFERENCES [Customers] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_ServiceOrders_Units_UnitId] FOREIGN KEY ([UnitId]) REFERENCES [Units] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_ServiceOrders_Units_UnitId1] FOREIGN KEY ([UnitId1]) REFERENCES [Units] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Employees] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [FirstName] nvarchar(max) NOT NULL,
    [MiddleName] nvarchar(max) NULL,
    [FirstSureName] nvarchar(max) NOT NULL,
    [SecondSureName] nvarchar(max) NULL,
    [DocumentTypeId] int NOT NULL,
    [Document] nvarchar(10) NOT NULL,
    [RolId] int NOT NULL,
    [PhoneNumber] nvarchar(max) NULL,
    [Email] nvarchar(max) NULL,
    [DocumentTypeId1] int NULL,
    [RolId1] int NULL,
    CONSTRAINT [PK_Employees] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Employees_DocumentTypes_DocumentTypeId] FOREIGN KEY ([DocumentTypeId]) REFERENCES [DocumentTypes] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Employees_DocumentTypes_DocumentTypeId1] FOREIGN KEY ([DocumentTypeId1]) REFERENCES [DocumentTypes] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Employees_Roles_RolId] FOREIGN KEY ([RolId]) REFERENCES [Roles] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Employees_Roles_RolId1] FOREIGN KEY ([RolId1]) REFERENCES [Roles] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Files] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Size] int NOT NULL,
    [Extension] nvarchar(3) NOT NULL,
    [ServiceOrderId] int NOT NULL,
    [ServiceOrderId1] int NULL,
    CONSTRAINT [PK_Files] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Files_ServiceOrders_ServiceOrderId] FOREIGN KEY ([ServiceOrderId]) REFERENCES [ServiceOrders] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Files_ServiceOrders_ServiceOrderId1] FOREIGN KEY ([ServiceOrderId1]) REFERENCES [ServiceOrders] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Projects] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [Code] nvarchar(8) NOT NULL,
    [ServiceOrderId] int NOT NULL,
    [StartDate] datetime2 NOT NULL,
    [EndDate] datetime2 NOT NULL,
    [StatusId] int NOT NULL,
    [ServiceOrderId1] int NULL,
    [StatusId1] int NULL,
    CONSTRAINT [PK_Projects] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Projects_ServiceOrders_ServiceOrderId] FOREIGN KEY ([ServiceOrderId]) REFERENCES [ServiceOrders] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Projects_ServiceOrders_ServiceOrderId1] FOREIGN KEY ([ServiceOrderId1]) REFERENCES [ServiceOrders] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Projects_Status_StatusId] FOREIGN KEY ([StatusId]) REFERENCES [Status] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Projects_Status_StatusId1] FOREIGN KEY ([StatusId1]) REFERENCES [Status] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Sales] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [CustomerId] int NOT NULL,
    [EmployeeId] int NOT NULL,
    [TotalAmount] decimal(18,2) NOT NULL,
    [PaymentTypeId] int NOT NULL,
    [CustomerId1] int NULL,
    [EmployeeId1] int NULL,
    [PaymentTypeId1] int NULL,
    CONSTRAINT [PK_Sales] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Sales_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customers] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Sales_Customers_CustomerId1] FOREIGN KEY ([CustomerId1]) REFERENCES [Customers] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Sales_Employees_EmployeeId] FOREIGN KEY ([EmployeeId]) REFERENCES [Employees] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Sales_Employees_EmployeeId1] FOREIGN KEY ([EmployeeId1]) REFERENCES [Employees] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Sales_PaymentTypes_PaymentTypeId] FOREIGN KEY ([PaymentTypeId]) REFERENCES [PaymentTypes] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Sales_PaymentTypes_PaymentTypeId1] FOREIGN KEY ([PaymentTypeId1]) REFERENCES [PaymentTypes] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Activities] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [ActivityTypeId] int NOT NULL,
    [Description] nvarchar(500) NOT NULL,
    [StartDate] datetime2 NOT NULL,
    [EndDate] datetime2 NOT NULL,
    [EmployeeId] int NOT NULL,
    [ProviderId] int NOT NULL,
    [Accomplish] bit NOT NULL,
    [StatusId] int NOT NULL,
    [AlertTypeId] int NOT NULL,
    [ActivityTypeId1] int NULL,
    [AlertTypeId1] int NULL,
    [EmployeeId1] int NULL,
    [ProjectId] int NULL,
    [ProviderId1] int NULL,
    [StatusId1] int NULL,
    CONSTRAINT [PK_Activities] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Activities_ActivityTypes_ActivityTypeId] FOREIGN KEY ([ActivityTypeId]) REFERENCES [ActivityTypes] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Activities_ActivityTypes_ActivityTypeId1] FOREIGN KEY ([ActivityTypeId1]) REFERENCES [ActivityTypes] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Activities_AlertTypes_AlertTypeId] FOREIGN KEY ([AlertTypeId]) REFERENCES [AlertTypes] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Activities_AlertTypes_AlertTypeId1] FOREIGN KEY ([AlertTypeId1]) REFERENCES [AlertTypes] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Activities_Employees_EmployeeId] FOREIGN KEY ([EmployeeId]) REFERENCES [Employees] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Activities_Employees_EmployeeId1] FOREIGN KEY ([EmployeeId1]) REFERENCES [Employees] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Activities_Projects_ProjectId] FOREIGN KEY ([ProjectId]) REFERENCES [Projects] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Activities_Providers_ProviderId] FOREIGN KEY ([ProviderId]) REFERENCES [Providers] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Activities_Providers_ProviderId1] FOREIGN KEY ([ProviderId1]) REFERENCES [Providers] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Activities_Status_StatusId] FOREIGN KEY ([StatusId]) REFERENCES [Status] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Activities_Status_StatusId1] FOREIGN KEY ([StatusId1]) REFERENCES [Status] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Bills] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [ProjectId] int NOT NULL,
    [Date] datetime2 NOT NULL,
    [Amount] decimal(18,2) NOT NULL,
    [PaymentTypeId] int NOT NULL,
    [PaymentTypeId1] int NULL,
    [ProjectId1] int NULL,
    [StatusId] int NULL,
    CONSTRAINT [PK_Bills] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Bills_PaymentTypes_PaymentTypeId] FOREIGN KEY ([PaymentTypeId]) REFERENCES [PaymentTypes] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Bills_PaymentTypes_PaymentTypeId1] FOREIGN KEY ([PaymentTypeId1]) REFERENCES [PaymentTypes] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Bills_Projects_ProjectId] FOREIGN KEY ([ProjectId]) REFERENCES [Projects] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Bills_Projects_ProjectId1] FOREIGN KEY ([ProjectId1]) REFERENCES [Projects] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Bills_Status_StatusId] FOREIGN KEY ([StatusId]) REFERENCES [Status] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Espenses] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [EmployeeId] int NOT NULL,
    [EspenseTypeId] int NOT NULL,
    [Amount] decimal(18,2) NOT NULL,
    [Description] nvarchar(200) NULL,
    [StartDate] datetime2 NOT NULL,
    [EndDate] datetime2 NOT NULL,
    [Reimbursement] bit NOT NULL,
    [ReimbursementAmount] decimal(18,2) NOT NULL,
    [ReimbursementDate] datetime2 NOT NULL,
    [StatusId] int NOT NULL,
    [EmployeeId1] int NULL,
    [EspenseTypeId1] int NULL,
    [ProjectId] int NULL,
    [StatusId1] int NULL,
    CONSTRAINT [PK_Espenses] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Espenses_Employees_EmployeeId] FOREIGN KEY ([EmployeeId]) REFERENCES [Employees] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Espenses_Employees_EmployeeId1] FOREIGN KEY ([EmployeeId1]) REFERENCES [Employees] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Espenses_EspenseTypes_EspenseTypeId] FOREIGN KEY ([EspenseTypeId]) REFERENCES [EspenseTypes] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Espenses_EspenseTypes_EspenseTypeId1] FOREIGN KEY ([EspenseTypeId1]) REFERENCES [EspenseTypes] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Espenses_Projects_ProjectId] FOREIGN KEY ([ProjectId]) REFERENCES [Projects] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Espenses_Status_StatusId] FOREIGN KEY ([StatusId]) REFERENCES [Status] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Espenses_Status_StatusId1] FOREIGN KEY ([StatusId1]) REFERENCES [Status] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [ProjectBudgets] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [UnitId] int NOT NULL,
    [ProjectId] int NOT NULL,
    [Amount] decimal(18,2) NOT NULL,
    [Description] nvarchar(500) NOT NULL,
    [EmployeeId] int NOT NULL,
    [ApprovalDate] datetime2 NOT NULL,
    [EmployeeId1] int NULL,
    [ProjectId1] int NULL,
    [UnitId1] int NULL,
    CONSTRAINT [PK_ProjectBudgets] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_ProjectBudgets_Employees_EmployeeId] FOREIGN KEY ([EmployeeId]) REFERENCES [Employees] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_ProjectBudgets_Employees_EmployeeId1] FOREIGN KEY ([EmployeeId1]) REFERENCES [Employees] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_ProjectBudgets_Projects_ProjectId] FOREIGN KEY ([ProjectId]) REFERENCES [Projects] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_ProjectBudgets_Projects_ProjectId1] FOREIGN KEY ([ProjectId1]) REFERENCES [Projects] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_ProjectBudgets_Units_UnitId] FOREIGN KEY ([UnitId]) REFERENCES [Units] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_ProjectBudgets_Units_UnitId1] FOREIGN KEY ([UnitId1]) REFERENCES [Units] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Requests] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [RequestTypeId] int NOT NULL,
    [Description] nvarchar(500) NOT NULL,
    [ProjectId] int NOT NULL,
    [RequiredDate] datetime2 NOT NULL,
    [EmployeeId] int NOT NULL,
    [PriorityId] int NOT NULL,
    [StatusId] int NOT NULL,
    [Accomplish] bit NOT NULL,
    [EndDate] datetime2 NOT NULL,
    [EmployeeId1] int NULL,
    [PriorityId1] int NULL,
    [ProjectId1] int NULL,
    [RequestTypeId1] int NULL,
    [StatusId1] int NULL,
    CONSTRAINT [PK_Requests] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Requests_Employees_EmployeeId] FOREIGN KEY ([EmployeeId]) REFERENCES [Employees] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Requests_Employees_EmployeeId1] FOREIGN KEY ([EmployeeId1]) REFERENCES [Employees] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Requests_Priotities_PriorityId] FOREIGN KEY ([PriorityId]) REFERENCES [Priotities] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Requests_Priotities_PriorityId1] FOREIGN KEY ([PriorityId1]) REFERENCES [Priotities] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Requests_Projects_ProjectId] FOREIGN KEY ([ProjectId]) REFERENCES [Projects] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Requests_Projects_ProjectId1] FOREIGN KEY ([ProjectId1]) REFERENCES [Projects] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Requests_RequestTypes_RequestTypeId] FOREIGN KEY ([RequestTypeId]) REFERENCES [RequestTypes] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Requests_RequestTypes_RequestTypeId1] FOREIGN KEY ([RequestTypeId1]) REFERENCES [RequestTypes] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Requests_Status_StatusId] FOREIGN KEY ([StatusId]) REFERENCES [Status] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Requests_Status_StatusId1] FOREIGN KEY ([StatusId1]) REFERENCES [Status] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Surveys] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [CustomerId] int NOT NULL,
    [Score] real NOT NULL,
    [Qualification] nvarchar(max) NULL,
    [ProjectId] int NULL,
    CONSTRAINT [PK_Surveys] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Surveys_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customers] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Surveys_Projects_ProjectId] FOREIGN KEY ([ProjectId]) REFERENCES [Projects] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [SaleDetails] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [SaleId] int NOT NULL,
    [ResourceId] int NOT NULL,
    [ModelId] int NOT NULL,
    [Quantity] int NOT NULL,
    [UnitPrice] decimal(18,2) NOT NULL,
    [ModelId1] int NULL,
    [ResourceId1] int NULL,
    [SaleId1] int NULL,
    CONSTRAINT [PK_SaleDetails] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SaleDetails_Models_ModelId] FOREIGN KEY ([ModelId]) REFERENCES [Models] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_SaleDetails_Models_ModelId1] FOREIGN KEY ([ModelId1]) REFERENCES [Models] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_SaleDetails_Resources_ResourceId] FOREIGN KEY ([ResourceId]) REFERENCES [Resources] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_SaleDetails_Resources_ResourceId1] FOREIGN KEY ([ResourceId1]) REFERENCES [Resources] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_SaleDetails_Sales_SaleId] FOREIGN KEY ([SaleId]) REFERENCES [Sales] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_SaleDetails_Sales_SaleId1] FOREIGN KEY ([SaleId1]) REFERENCES [Sales] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Cals] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [DetectionDate] datetime2 NOT NULL,
    [ActivityId] int NOT NULL,
    [EmployeeId] int NOT NULL,
    [Description] nvarchar(max) NULL,
    [Analysis] nvarchar(max) NULL,
    [ActionTypeId] int NOT NULL,
    [StatusId] int NOT NULL,
    [CorrectionDate] datetime2 NOT NULL,
    [CorrectionResult] nvarchar(max) NULL,
    CONSTRAINT [PK_Cals] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Cals_ActionTypes_ActionTypeId] FOREIGN KEY ([ActionTypeId]) REFERENCES [ActionTypes] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Cals_Activities_ActivityId] FOREIGN KEY ([ActivityId]) REFERENCES [Activities] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Cals_Employees_EmployeeId] FOREIGN KEY ([EmployeeId]) REFERENCES [Employees] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Cals_Status_StatusId] FOREIGN KEY ([StatusId]) REFERENCES [Status] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [Inspections] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [ActivityId] int NOT NULL,
    [InspectionTypeId] int NOT NULL,
    [Date] datetime2 NOT NULL,
    [ActivityId1] int NULL,
    [InspectionTypeId1] int NULL,
    CONSTRAINT [PK_Inspections] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Inspections_Activities_ActivityId] FOREIGN KEY ([ActivityId]) REFERENCES [Activities] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Inspections_Activities_ActivityId1] FOREIGN KEY ([ActivityId1]) REFERENCES [Activities] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Inspections_InspectionTypes_InspectionTypeId] FOREIGN KEY ([InspectionTypeId]) REFERENCES [InspectionTypes] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Inspections_InspectionTypes_InspectionTypeId1] FOREIGN KEY ([InspectionTypeId1]) REFERENCES [InspectionTypes] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Notes] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [Content] nvarchar(500) NOT NULL,
    [ActivityId] int NOT NULL,
    [ActivityId1] int NULL,
    CONSTRAINT [PK_Notes] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Notes_Activities_ActivityId] FOREIGN KEY ([ActivityId]) REFERENCES [Activities] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Notes_Activities_ActivityId1] FOREIGN KEY ([ActivityId1]) REFERENCES [Activities] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Alerts] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [AlertTypeId] int NOT NULL,
    [ActivityId] int NOT NULL,
    [RequestId] int NOT NULL,
    [ProjectBudgetId] int NOT NULL,
    [Warning] nvarchar(max) NULL,
    [Critical] nvarchar(max) NULL,
    [ActivityId1] int NULL,
    [AlertTypeId1] int NULL,
    [ProjectBudgetId1] int NULL,
    CONSTRAINT [PK_Alerts] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Alerts_Activities_ActivityId] FOREIGN KEY ([ActivityId]) REFERENCES [Activities] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Alerts_Activities_ActivityId1] FOREIGN KEY ([ActivityId1]) REFERENCES [Activities] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Alerts_AlertTypes_AlertTypeId] FOREIGN KEY ([AlertTypeId]) REFERENCES [AlertTypes] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Alerts_AlertTypes_AlertTypeId1] FOREIGN KEY ([AlertTypeId1]) REFERENCES [AlertTypes] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Alerts_ProjectBudgets_ProjectBudgetId] FOREIGN KEY ([ProjectBudgetId]) REFERENCES [ProjectBudgets] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Alerts_ProjectBudgets_ProjectBudgetId1] FOREIGN KEY ([ProjectBudgetId1]) REFERENCES [ProjectBudgets] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Alerts_Requests_RequestId] FOREIGN KEY ([RequestId]) REFERENCES [Requests] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Purchases] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [RequestId] int NOT NULL,
    [DeliveryDate] datetime2 NOT NULL,
    [ProviderId] int NOT NULL,
    [EmployeeId] int NOT NULL,
    [TotalAmount] decimal(18,2) NOT NULL,
    [PaymentTypeId] int NOT NULL,
    [EmployeeId1] int NULL,
    [PaymentTypeId1] int NULL,
    [ProviderId1] int NULL,
    CONSTRAINT [PK_Purchases] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Purchases_Employees_EmployeeId] FOREIGN KEY ([EmployeeId]) REFERENCES [Employees] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Purchases_Employees_EmployeeId1] FOREIGN KEY ([EmployeeId1]) REFERENCES [Employees] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Purchases_PaymentTypes_PaymentTypeId] FOREIGN KEY ([PaymentTypeId]) REFERENCES [PaymentTypes] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Purchases_PaymentTypes_PaymentTypeId1] FOREIGN KEY ([PaymentTypeId1]) REFERENCES [PaymentTypes] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Purchases_Providers_ProviderId] FOREIGN KEY ([ProviderId]) REFERENCES [Providers] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Purchases_Providers_ProviderId1] FOREIGN KEY ([ProviderId1]) REFERENCES [Providers] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Purchases_Requests_RequestId] FOREIGN KEY ([RequestId]) REFERENCES [Requests] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [ResourceRequests] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [RequestsId] int NOT NULL,
    [ResourceId] int NOT NULL,
    [Quantity] int NOT NULL,
    [RequestId] int NULL,
    [ResourceId1] int NULL,
    CONSTRAINT [PK_ResourceRequests] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_ResourceRequests_Requests_RequestId] FOREIGN KEY ([RequestId]) REFERENCES [Requests] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_ResourceRequests_Requests_RequestsId] FOREIGN KEY ([RequestsId]) REFERENCES [Requests] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_ResourceRequests_Resources_ResourceId] FOREIGN KEY ([ResourceId]) REFERENCES [Resources] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_ResourceRequests_Resources_ResourceId1] FOREIGN KEY ([ResourceId1]) REFERENCES [Resources] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [PurchaseDetails] (
    [Id] int NOT NULL IDENTITY,
    [IsActive] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModificatedDate] datetime2 NOT NULL,
    [PurchaseId] int NOT NULL,
    [Item] nvarchar(200) NOT NULL,
    [Brand] nvarchar(200) NOT NULL,
    [Model] nvarchar(200) NOT NULL,
    [Quantity] int NOT NULL,
    [UnitPrice] decimal(18,2) NOT NULL,
    [PurchaseId1] int NULL,
    CONSTRAINT [PK_PurchaseDetails] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_PurchaseDetails_Purchases_PurchaseId] FOREIGN KEY ([PurchaseId]) REFERENCES [Purchases] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_PurchaseDetails_Purchases_PurchaseId1] FOREIGN KEY ([PurchaseId1]) REFERENCES [Purchases] ([Id]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_Activities_ActivityTypeId] ON [Activities] ([ActivityTypeId]);

GO

CREATE INDEX [IX_Activities_ActivityTypeId1] ON [Activities] ([ActivityTypeId1]);

GO

CREATE INDEX [IX_Activities_AlertTypeId] ON [Activities] ([AlertTypeId]);

GO

CREATE INDEX [IX_Activities_AlertTypeId1] ON [Activities] ([AlertTypeId1]);

GO

CREATE INDEX [IX_Activities_EmployeeId] ON [Activities] ([EmployeeId]);

GO

CREATE INDEX [IX_Activities_EmployeeId1] ON [Activities] ([EmployeeId1]);

GO

CREATE INDEX [IX_Activities_ProjectId] ON [Activities] ([ProjectId]);

GO

CREATE INDEX [IX_Activities_ProviderId] ON [Activities] ([ProviderId]);

GO

CREATE INDEX [IX_Activities_ProviderId1] ON [Activities] ([ProviderId1]);

GO

CREATE INDEX [IX_Activities_StatusId] ON [Activities] ([StatusId]);

GO

CREATE INDEX [IX_Activities_StatusId1] ON [Activities] ([StatusId1]);

GO

CREATE INDEX [IX_Alerts_ActivityId] ON [Alerts] ([ActivityId]);

GO

CREATE INDEX [IX_Alerts_ActivityId1] ON [Alerts] ([ActivityId1]);

GO

CREATE INDEX [IX_Alerts_AlertTypeId] ON [Alerts] ([AlertTypeId]);

GO

CREATE INDEX [IX_Alerts_AlertTypeId1] ON [Alerts] ([AlertTypeId1]);

GO

CREATE INDEX [IX_Alerts_ProjectBudgetId] ON [Alerts] ([ProjectBudgetId]);

GO

CREATE INDEX [IX_Alerts_ProjectBudgetId1] ON [Alerts] ([ProjectBudgetId1]);

GO

CREATE INDEX [IX_Alerts_RequestId] ON [Alerts] ([RequestId]);

GO

CREATE INDEX [IX_Bills_PaymentTypeId] ON [Bills] ([PaymentTypeId]);

GO

CREATE INDEX [IX_Bills_PaymentTypeId1] ON [Bills] ([PaymentTypeId1]);

GO

CREATE INDEX [IX_Bills_ProjectId] ON [Bills] ([ProjectId]);

GO

CREATE INDEX [IX_Bills_ProjectId1] ON [Bills] ([ProjectId1]);

GO

CREATE INDEX [IX_Bills_StatusId] ON [Bills] ([StatusId]);

GO

CREATE INDEX [IX_Cals_ActionTypeId] ON [Cals] ([ActionTypeId]);

GO

CREATE INDEX [IX_Cals_ActivityId] ON [Cals] ([ActivityId]);

GO

CREATE INDEX [IX_Cals_EmployeeId] ON [Cals] ([EmployeeId]);

GO

CREATE INDEX [IX_Cals_StatusId] ON [Cals] ([StatusId]);

GO

CREATE INDEX [IX_Customers_SectorId] ON [Customers] ([SectorId]);

GO

CREATE INDEX [IX_Employees_DocumentTypeId] ON [Employees] ([DocumentTypeId]);

GO

CREATE INDEX [IX_Employees_DocumentTypeId1] ON [Employees] ([DocumentTypeId1]);

GO

CREATE INDEX [IX_Employees_RolId] ON [Employees] ([RolId]);

GO

CREATE INDEX [IX_Employees_RolId1] ON [Employees] ([RolId1]);

GO

CREATE INDEX [IX_Espenses_EmployeeId] ON [Espenses] ([EmployeeId]);

GO

CREATE INDEX [IX_Espenses_EmployeeId1] ON [Espenses] ([EmployeeId1]);

GO

CREATE INDEX [IX_Espenses_EspenseTypeId] ON [Espenses] ([EspenseTypeId]);

GO

CREATE INDEX [IX_Espenses_EspenseTypeId1] ON [Espenses] ([EspenseTypeId1]);

GO

CREATE INDEX [IX_Espenses_ProjectId] ON [Espenses] ([ProjectId]);

GO

CREATE INDEX [IX_Espenses_StatusId] ON [Espenses] ([StatusId]);

GO

CREATE INDEX [IX_Espenses_StatusId1] ON [Espenses] ([StatusId1]);

GO

CREATE INDEX [IX_EventLogs_EventLogTypeId] ON [EventLogs] ([EventLogTypeId]);

GO

CREATE INDEX [IX_EventLogs_EventLogTypeId1] ON [EventLogs] ([EventLogTypeId1]);

GO

CREATE INDEX [IX_Files_ServiceOrderId] ON [Files] ([ServiceOrderId]);

GO

CREATE INDEX [IX_Files_ServiceOrderId1] ON [Files] ([ServiceOrderId1]);

GO

CREATE INDEX [IX_Inspections_ActivityId] ON [Inspections] ([ActivityId]);

GO

CREATE INDEX [IX_Inspections_ActivityId1] ON [Inspections] ([ActivityId1]);

GO

CREATE INDEX [IX_Inspections_InspectionTypeId] ON [Inspections] ([InspectionTypeId]);

GO

CREATE INDEX [IX_Inspections_InspectionTypeId1] ON [Inspections] ([InspectionTypeId1]);

GO

CREATE INDEX [IX_Models_ResourceId] ON [Models] ([ResourceId]);

GO

CREATE INDEX [IX_Models_ResourceId1] ON [Models] ([ResourceId1]);

GO

CREATE INDEX [IX_Notes_ActivityId] ON [Notes] ([ActivityId]);

GO

CREATE INDEX [IX_Notes_ActivityId1] ON [Notes] ([ActivityId1]);

GO

CREATE INDEX [IX_Priotities_AlertTypeId] ON [Priotities] ([AlertTypeId]);

GO

CREATE INDEX [IX_Priotities_AlertTypeId1] ON [Priotities] ([AlertTypeId1]);

GO

CREATE INDEX [IX_ProjectBudgets_EmployeeId] ON [ProjectBudgets] ([EmployeeId]);

GO

CREATE INDEX [IX_ProjectBudgets_EmployeeId1] ON [ProjectBudgets] ([EmployeeId1]);

GO

CREATE INDEX [IX_ProjectBudgets_ProjectId] ON [ProjectBudgets] ([ProjectId]);

GO

CREATE INDEX [IX_ProjectBudgets_ProjectId1] ON [ProjectBudgets] ([ProjectId1]);

GO

CREATE INDEX [IX_ProjectBudgets_UnitId] ON [ProjectBudgets] ([UnitId]);

GO

CREATE INDEX [IX_ProjectBudgets_UnitId1] ON [ProjectBudgets] ([UnitId1]);

GO

CREATE INDEX [IX_Projects_ServiceOrderId] ON [Projects] ([ServiceOrderId]);

GO

CREATE INDEX [IX_Projects_ServiceOrderId1] ON [Projects] ([ServiceOrderId1]);

GO

CREATE INDEX [IX_Projects_StatusId] ON [Projects] ([StatusId]);

GO

CREATE INDEX [IX_Projects_StatusId1] ON [Projects] ([StatusId1]);

GO

CREATE INDEX [IX_Providers_SectorId] ON [Providers] ([SectorId]);

GO

CREATE INDEX [IX_Providers_SectorId1] ON [Providers] ([SectorId1]);

GO

CREATE INDEX [IX_PurchaseDetails_PurchaseId] ON [PurchaseDetails] ([PurchaseId]);

GO

CREATE INDEX [IX_PurchaseDetails_PurchaseId1] ON [PurchaseDetails] ([PurchaseId1]);

GO

CREATE INDEX [IX_Purchases_EmployeeId] ON [Purchases] ([EmployeeId]);

GO

CREATE INDEX [IX_Purchases_EmployeeId1] ON [Purchases] ([EmployeeId1]);

GO

CREATE INDEX [IX_Purchases_PaymentTypeId] ON [Purchases] ([PaymentTypeId]);

GO

CREATE INDEX [IX_Purchases_PaymentTypeId1] ON [Purchases] ([PaymentTypeId1]);

GO

CREATE INDEX [IX_Purchases_ProviderId] ON [Purchases] ([ProviderId]);

GO

CREATE INDEX [IX_Purchases_ProviderId1] ON [Purchases] ([ProviderId1]);

GO

CREATE INDEX [IX_Purchases_RequestId] ON [Purchases] ([RequestId]);

GO

CREATE INDEX [IX_Requests_EmployeeId] ON [Requests] ([EmployeeId]);

GO

CREATE INDEX [IX_Requests_EmployeeId1] ON [Requests] ([EmployeeId1]);

GO

CREATE INDEX [IX_Requests_PriorityId] ON [Requests] ([PriorityId]);

GO

CREATE INDEX [IX_Requests_PriorityId1] ON [Requests] ([PriorityId1]);

GO

CREATE INDEX [IX_Requests_ProjectId] ON [Requests] ([ProjectId]);

GO

CREATE INDEX [IX_Requests_ProjectId1] ON [Requests] ([ProjectId1]);

GO

CREATE INDEX [IX_Requests_RequestTypeId] ON [Requests] ([RequestTypeId]);

GO

CREATE INDEX [IX_Requests_RequestTypeId1] ON [Requests] ([RequestTypeId1]);

GO

CREATE INDEX [IX_Requests_StatusId] ON [Requests] ([StatusId]);

GO

CREATE INDEX [IX_Requests_StatusId1] ON [Requests] ([StatusId1]);

GO

CREATE INDEX [IX_RequestTypes_UnitId] ON [RequestTypes] ([UnitId]);

GO

CREATE INDEX [IX_RequestTypes_UnitId1] ON [RequestTypes] ([UnitId1]);

GO

CREATE INDEX [IX_ResourceRequests_RequestId] ON [ResourceRequests] ([RequestId]);

GO

CREATE INDEX [IX_ResourceRequests_RequestsId] ON [ResourceRequests] ([RequestsId]);

GO

CREATE INDEX [IX_ResourceRequests_ResourceId] ON [ResourceRequests] ([ResourceId]);

GO

CREATE INDEX [IX_ResourceRequests_ResourceId1] ON [ResourceRequests] ([ResourceId1]);

GO

CREATE INDEX [IX_Resources_BrandId] ON [Resources] ([BrandId]);

GO

CREATE INDEX [IX_Resources_BrandId1] ON [Resources] ([BrandId1]);

GO

CREATE INDEX [IX_Resources_ResourceTypeId] ON [Resources] ([ResourceTypeId]);

GO

CREATE INDEX [IX_Resources_ResourceTypeId1] ON [Resources] ([ResourceTypeId1]);

GO

CREATE INDEX [IX_Roles_UnitId] ON [Roles] ([UnitId]);

GO

CREATE INDEX [IX_SaleDetails_ModelId] ON [SaleDetails] ([ModelId]);

GO

CREATE INDEX [IX_SaleDetails_ModelId1] ON [SaleDetails] ([ModelId1]);

GO

CREATE INDEX [IX_SaleDetails_ResourceId] ON [SaleDetails] ([ResourceId]);

GO

CREATE INDEX [IX_SaleDetails_ResourceId1] ON [SaleDetails] ([ResourceId1]);

GO

CREATE INDEX [IX_SaleDetails_SaleId] ON [SaleDetails] ([SaleId]);

GO

CREATE INDEX [IX_SaleDetails_SaleId1] ON [SaleDetails] ([SaleId1]);

GO

CREATE INDEX [IX_Sales_CustomerId] ON [Sales] ([CustomerId]);

GO

CREATE INDEX [IX_Sales_CustomerId1] ON [Sales] ([CustomerId1]);

GO

CREATE INDEX [IX_Sales_EmployeeId] ON [Sales] ([EmployeeId]);

GO

CREATE INDEX [IX_Sales_EmployeeId1] ON [Sales] ([EmployeeId1]);

GO

CREATE INDEX [IX_Sales_PaymentTypeId] ON [Sales] ([PaymentTypeId]);

GO

CREATE INDEX [IX_Sales_PaymentTypeId1] ON [Sales] ([PaymentTypeId1]);

GO

CREATE INDEX [IX_ServiceOrders_CustomerId] ON [ServiceOrders] ([CustomerId]);

GO

CREATE INDEX [IX_ServiceOrders_CustomerId1] ON [ServiceOrders] ([CustomerId1]);

GO

CREATE INDEX [IX_ServiceOrders_UnitId] ON [ServiceOrders] ([UnitId]);

GO

CREATE INDEX [IX_ServiceOrders_UnitId1] ON [ServiceOrders] ([UnitId1]);

GO

CREATE INDEX [IX_Surveys_CustomerId] ON [Surveys] ([CustomerId]);

GO

CREATE INDEX [IX_Surveys_ProjectId] ON [Surveys] ([ProjectId]);

GO

CREATE INDEX [IX_Units_OrganizationId] ON [Units] ([OrganizationId]);

GO

CREATE INDEX [IX_Units_OrganizationId1] ON [Units] ([OrganizationId1]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191115143958_Initial', N'2.2.3-servicing-35854');

GO


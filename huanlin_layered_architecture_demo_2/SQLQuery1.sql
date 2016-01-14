CREATE TABLE [dbo].[Orders] ( 
    [OrderID] INT IDENTITY (1, 1) NOT NULL, 
    [CustomerID] NVARCHAR (200) NULL, 
    [EmployeeID] INT NULL, 
    [OrderDate] DATETIME NULL, 
    [RequiredDate] DATETIME NULL, 
    [ShippedDate] DATETIME  NULL, 
    [ShipVia] INT NULL, 
    [Freight] Decimal NULL, 
    [ShipName] NVARCHAR (200) NULL, 
    [ShipAddress] NVARCHAR (200) NULL, 
    [ShipCity] NVARCHAR (200) NULL, 
    [ShipRegion] NVARCHAR (200) NULL, 
    [ShipPostalCode] NVARCHAR (200) NULL, 
    [ShipCountry] NVARCHAR (200) NULL, 
    CONSTRAINT [PK_dbo.Orders] PRIMARY KEY CLUSTERED ([OrderID] ASC) 
); 

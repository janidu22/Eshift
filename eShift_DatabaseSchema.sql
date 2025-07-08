-- =========================
-- e-Shift Database Schema
-- =========================

-- 1. Roles
CREATE TABLE Roles (
    RoleId INT IDENTITY(1,1) PRIMARY KEY,
    RoleName NVARCHAR(20) NOT NULL UNIQUE
);

-- 2. Users
CREATE TABLE Users (
    UserId INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(256) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    IsActive BIT NOT NULL DEFAULT 1,
    CreatedAt DATETIME NOT NULL DEFAULT GETDATE()
);

-- 3. UserRoles (for role assignment)
CREATE TABLE UserRoles (
    UserId INT NOT NULL,
    RoleId INT NOT NULL,
    PRIMARY KEY (UserId, RoleId),
    FOREIGN KEY (UserId) REFERENCES Users(UserId),
    FOREIGN KEY (RoleId) REFERENCES Roles(RoleId)
);

-- 4. Customers
CREATE TABLE Customers (
    CustomerId INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT NOT NULL UNIQUE,
    Name NVARCHAR(100) NOT NULL,
    Address NVARCHAR(200),
    Phone NVARCHAR(20),
    Email NVARCHAR(100),
    FOREIGN KEY (UserId) REFERENCES Users(UserId)
);

-- 5. Admins
CREATE TABLE Admins (
    AdminId INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT NOT NULL UNIQUE,
    Name NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100),
    FOREIGN KEY (UserId) REFERENCES Users(UserId)
);

-- 6. Products
CREATE TABLE Products (
    ProductId INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Description NVARCHAR(200)
);

-- 7. Lorries
CREATE TABLE Lorries (
    LorryId INT IDENTITY(1,1) PRIMARY KEY,
    PlateNumber NVARCHAR(20) NOT NULL UNIQUE,
    Model NVARCHAR(50),
    Capacity DECIMAL(10,2)
);

-- 8. Drivers
CREATE TABLE Drivers (
    DriverId INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    LicenseNumber NVARCHAR(50) NOT NULL UNIQUE,
    Phone NVARCHAR(20)
);

-- 9. Assistants
CREATE TABLE Assistants (
    AssistantId INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Phone NVARCHAR(20)
);

-- 10. Containers
CREATE TABLE Containers (
    ContainerId INT IDENTITY(1,1) PRIMARY KEY,
    Type NVARCHAR(50),
    Capacity DECIMAL(10,2)
);

-- 11. TransportUnits
CREATE TABLE TransportUnits (
    TransportUnitId INT IDENTITY(1,1) PRIMARY KEY,
    LorryId INT NOT NULL,
    DriverId INT NOT NULL,
    AssistantId INT NOT NULL,
    ContainerId INT NOT NULL,
    FOREIGN KEY (LorryId) REFERENCES Lorries(LorryId),
    FOREIGN KEY (DriverId) REFERENCES Drivers(DriverId),
    FOREIGN KEY (AssistantId) REFERENCES Assistants(AssistantId),
    FOREIGN KEY (ContainerId) REFERENCES Containers(ContainerId)
);

-- 12. Jobs (Transport Operations)
CREATE TABLE Jobs (
    JobId INT IDENTITY(1,1) PRIMARY KEY,
    CustomerId INT NOT NULL,
    StartLocation NVARCHAR(200) NOT NULL,
    Destination NVARCHAR(200) NOT NULL,
    RequestedDate DATETIME NOT NULL,
    Status NVARCHAR(20) NOT NULL, -- e.g., Pending, Accepted, Declined, Completed
    AdminId INT NULL, -- Who processed the job
    CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),
    UpdatedAt DATETIME NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId),
    FOREIGN KEY (AdminId) REFERENCES Admins(AdminId)
);

-- 13. Loads
CREATE TABLE Loads (
    LoadId INT IDENTITY(1,1) PRIMARY KEY,
    JobId INT NOT NULL,
    ProductId INT NOT NULL,
    TransportUnitId INT NOT NULL,
    Quantity INT NOT NULL,
    Weight DECIMAL(10,2),
    Notes NVARCHAR(200),
    FOREIGN KEY (JobId) REFERENCES Jobs(JobId),
    FOREIGN KEY (ProductId) REFERENCES Products(ProductId),
    FOREIGN KEY (TransportUnitId) REFERENCES TransportUnits(TransportUnitId)
);

-- 14. Job Status History (Audit)
CREATE TABLE JobStatusHistory (
    HistoryId INT IDENTITY(1,1) PRIMARY KEY,
    JobId INT NOT NULL,
    Status NVARCHAR(20) NOT NULL,
    ChangedByAdminId INT NULL,
    ChangedAt DATETIME NOT NULL DEFAULT GETDATE(),
    Notes NVARCHAR(200),
    FOREIGN KEY (JobId) REFERENCES Jobs(JobId),
    FOREIGN KEY (ChangedByAdminId) REFERENCES Admins(AdminId)
); 
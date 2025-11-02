CREATE TABLE [dbo].[Staff]
(
	[StaffID] INT NOT NULL PRIMARY KEY, 
    [DepartmentID] INT NULL, 
    [FirstName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NULL, 
    [Role] NVARCHAR(50) NULL,
    [Shift] NVARCHAR(20) NULL
    FOREIGN KEY (DepartmentID) REFERENCES Department(DepartmentID)
)

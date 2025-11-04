CREATE PROCEDURE [dbo].[GetStaffByID]
	@StaffID INT
AS
	SELECT 
	s.StaffID,
	d.DepartmentName,
	s.FirstName,
	s.LastName,
	s.Role,
	s.Shift
	FROM dbo.Staff s
	INNER JOIN Department d ON d.DepartmentID = s.DepartmentID
	WHERE s.StaffID = @StaffID
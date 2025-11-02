CREATE PROCEDURE [dbo].[GetAllStaff]
		As 
	Select 
	s.StaffID,
	d.DepartmentName,
	s.FirstName,
	s.LastName,
	s.Role,
	s.Shift
	
	From dbo.Staff s
	inner join Department d on d.DepartmentID = s.DepartmentID
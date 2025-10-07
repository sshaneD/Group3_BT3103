CREATE PROCEDURE [dbo].[SearchPatient]
	@searchTerm nvarchar(50)
	as 
	select * from Patient
	Where FirstName like '%' + @searchTerm + '%'
	or LastName like '%' + @searchTerm + '%'
	or Cast(PatientID as nvarchar(50)) like '%' + @searchTerm + '%'

CREATE PROCEDURE [dbo].[SearchPatient]
	@searchTerm nvarchar(50)
	as 
	select * from Patient
	Where FirstName like '%' + @searchTerm + '%'
	or LastName like '%' + @searchTerm + '%'
	or Cast(PatientID as nvarchar(50)) like '%' + @searchTerm + '%'
	or (FirstName + ' ' + MiddleName + ' ' + LastName) like '%' + @searchTerm + '%'
	or (FirstName + ' ' + MiddleName) like '%' + @searchTerm + '%'
	or (FirstName + ' ' + LastName) like '%' + @searchTerm + '%'
	or (MiddleName + ' ' + LastName) like '%' + @searchTerm + '%'
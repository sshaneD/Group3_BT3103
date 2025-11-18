/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.
--------------------------------------------------------------------------------------
*/


-- Insert records into User table

INSERT INTO [dbo].[User] 
(
[Username], 
[Password],
[Role])
VALUES
('admin','admin','admin'),
('cashier','cashier123','cashier'),
('receptionist','receptionist1234','receptionist');

INSERT INTO [dbo].[Patient]
(FirstName, MiddleName, LastName, DateOfBirth, Age, Gender, GuardianName, GuardianNo, Status)
VALUES
('Ethan','Javier','Cruz','2013-05-10',12,'Male','Maria Cruz','09171234567','Admitted'),
('Sophia','Elena','Santos','2016-08-22',9,'Female','Carlo Santos','09182345678','Admitted'),
('Daniel','Hector','Reyes','2010-02-15',15,'Male','Liza Reyes','09293456789','Discharged'),
('Mia','Louise','Torres','2014-11-05',11,'Female','Juan Torres','09304567891','Admitted'),
('Liam','Gabriel','Mendoza','2011-03-09',14,'Male','Ana Mendoza','09415678902','Discharged'),
('Chloe','Denise','Ramirez','2015-09-18',10,'Female','Pedro Ramirez','09526789013','Admitted'),
('Noah','Francis','Villanueva','2012-06-25',13,'Male','Grace Villanueva','09637890124','Discharged'),
('Isabella','Rose','Bautista','2017-12-02',8,'Female','Marco Bautista','09748901235','Admitted'),
('Lucas','Nathan','Navarro','2009-01-19',16,'Male','Rosa Navarro','09859012346','Discharged'),
('Ava','Nicole','Dela Cruz','2018-10-27',7,'Female','Jose Dela Cruz','09160123457','Admitted'),
('Elijah','Thomas','Ramos','2013-04-11',12,'Male','Karen Ramos','09171235678','Admitted'),
('Aria','Mae','Flores','2010-07-30',15,'Female','Roberto Flores','09182346789','Discharged'),
('Mason','Rafael','Gutierrez','2011-09-14',14,'Male','Teresa Gutierrez','09193457890','Admitted'),
('Amelia','Faith','Castillo','2014-12-08',11,'Female','Edgar Castillo','09204568901','Discharged'),
('Benjamin','Joel','Morales','2016-05-21',9,'Male','Clara Morales','09315679012','Admitted'),
('Harper','Celeste','Santiago','2012-02-07',13,'Female','Ramon Santiago','09426780123','Discharged'),
('James','Patrick','Perez','2009-06-03',16,'Male','Julia Perez','09537891234','Discharged'),
('Emily','Sarah','Lozano','2015-08-25',10,'Female','Mario Lozano','09648902345','Admitted'),
('Alexander','Julian','Bautista','2010-09-29',15,'Male','Cecilia Bautista','09759013456','Admitted'),
('Abigail','Hope','Rivera','2017-11-16',8,'Female','Hector Rivera','09860124567','Discharged'),
('Michael','Andre','Jimenez','2011-04-02',14,'Male','Sonia Jimenez','09171235679','Admitted'),
('Grace','Elaine','Aguilar','2013-07-09',12,'Female','Leo Aguilar','09182346780','Admitted'),
('William','Marcus','Fernandez','2012-03-28',13,'Male','Andrea Fernandez','09193457891','Admitted'),
('Ella','Marion','Salazar','2018-09-19',7,'Female','Carlo Salazar','09204568902','Admitted'),
('Henry','Joseph','Gonzales','2010-01-13',15,'Male','Pilar Gonzales','09315679013','Admitted'),
('Scarlett','Diana','Lim','2015-10-10',10,'Female','Alvin Lim','09426780124','Admitted'),
('Jacob','Vincent','Cruz','2014-02-26',11,'Male','Maria Cruz','09537891235','Discharged'),
('Victoria','Iris','Ramos','2009-03-05',16,'Female','Karen Ramos','09648902346','Admitted'),
('Matthew','Reid','Reyes','2013-11-15',12,'Male','Liza Reyes','09759013457','Admitted'),
('Sofia','Anne','Navarro','2016-06-07',9,'Female','Rosa Navarro','09860124568','Admitted'),
('David','Christian','Santiago','2011-07-23',14,'Male','Ramon Santiago','09171235670','Admitted'),
('Avery','Lou','Mendoza','2012-10-14',13,'Female','Ana Mendoza','09182346781','Admitted'),
('Joseph','Clark','Villanueva','2010-12-01',15,'Male','Grace Villanueva','09193457892','Admitted'),
('Lily','Dawn','Torres','2017-09-20',8,'Female','Juan Torres','09204568903','Admitted'),
('Samuel','Dean','Santos','2015-05-02',10,'Male','Carlo Santos','09315679014','Admitted'),
('Natalie','Eve','Cruz','2014-08-13',11,'Female','Maria Cruz','09426780125','Admitted'),
('Anthony','Paul','Gutierrez','2011-03-27',14,'Male','Teresa Gutierrez','09537891236','Admitted'),
('Zoey','Kate','Castillo','2012-01-18',13,'Female','Edgar Castillo','09648902347','Admitted'),
('Andrew','Shawn','Morales','2009-05-25',16,'Male','Clara Morales','09759013458','Admitted'),
('Hannah','Tess','Ramos','2018-04-11',7,'Female','Karen Ramos','09860124569','Admitted'),
('Christopher','Joel','Reyes','2013-09-30',12,'Male','Liza Reyes','09171235671','Admitted'),
('Layla','Aimee','Navarro','2016-11-07',9,'Female','Rosa Navarro','09182346782','Discharged'),
('Joshua','Kyle','Aguilar','2010-07-05',15,'Male','Leo Aguilar','09193457893','Discharged'),
('Zoella','Marie','Santiago','2017-02-03',8,'Female','Ramon Santiago','09204568904','Admitted'),
('Ryan','Cole','Mendoza','2011-06-15',14,'Male','Ana Mendoza','09315679015','Discharged'),
('Penelope','Hazel','Villanueva','2015-01-24',10,'Female','Grace Villanueva','09426780126','Admitted'),
('Isaac','Rowan','Cruz','2012-05-09',13,'Male','Maria Cruz','09537891237','Admitted'),
('Camila','Joy','Perez','2009-08-28',16,'Female','Julia Perez','09648902348','Admitted'),
('Oliver','Zane','Jimenez','2013-03-17',12,'Male','Sonia Jimenez','09759013459','Admitted'),
('Aurora','Belle','Torres','2014-10-22',11,'Female','Juan Torres','09860124560','Admitted');

INSERT INTO [dbo].[Admissions] ([PatientID], [AdmissionDate], [DischargeDate])
VALUES
(1000, '2025-10-20', NULL),
(1001, '2025-10-21', NULL),
(1002, '2025-10-22', '2025-10-25'),
(1003, '2025-10-22', NULL),
(1004, '2025-10-23', '2025-10-28'),
(1005, '2025-10-23', NULL),
(1006, '2025-10-24', '2025-10-29'),
(1007, '2025-10-24', NULL),
(1008, '2025-10-25', '2025-10-30'),
(1009, '2025-10-25', NULL),
(1010, '2025-10-26', NULL),
(1011, '2025-10-26', '2025-10-31'),
(1012, '2025-10-27', NULL),
(1013, '2025-10-27', '2025-11-01'),
(1014, '2025-10-28', '2025-11-02'),
(1015, '2025-10-28', NULL),
(1016, '2025-10-29', NULL),
(1017, '2025-10-29', '2025-11-03'),
(1018, '2025-10-30', NULL),
(1019, '2025-10-30', '2025-11-04'),
(1020, '2025-10-31', '2025-11-05'),
(1021, '2025-10-31', NULL),
(1022, '2025-11-01', NULL),
(1023, '2025-11-01', '2025-11-06'),
(1024, '2025-11-02', NULL),
(1025, '2025-11-02', '2025-11-07'),
(1026, '2025-11-03', NULL),
(1027, '2025-11-03', '2025-11-08'),
(1028, '2025-11-04', NULL),
(1029, '2025-11-04', '2025-11-09'),
(1030, '2025-11-05', '2025-11-10'),
(1031, '2025-11-05', '2025-11-10'),
(1032, '2025-11-06', NULL),
(1033, '2025-11-06', '2025-11-11'),
(1034, '2025-11-07', NULL),
(1035, '2025-11-07', '2025-11-12'),
(1036, '2025-11-08', '2025-11-13'),
(1037, '2025-11-08', '2025-11-14'),
(1038, '2025-11-09', NULL),
(1039, '2025-11-09', '2025-11-14'),
(1040, '2025-11-09', NULL),
(1041, '2025-11-10', NULL),
(1042, '2025-11-10', '2025-11-15'),
(1043, '2025-11-10', NULL),
(1044, '2025-11-11', NULL),
(1045, '2025-11-11', '2025-11-16'),
(1046, '2025-11-11', NULL),
(1047, '2025-11-12', NULL),
(1048, '2025-11-12', '2025-11-17'),
(1049, '2025-11-13', NULL);

INSERT INTO [dbo].[Department] ([DepartmentID], [DepartmentName])
VALUES 
(1, 'Emergency'),
(2, 'Surgery'),
(3, 'Pediatrics'),
(4, 'Radiology'),
(5, 'Cardiology'),
(6, 'Obstetrics and Gynecology'),
(7, 'General Medicine');

INSERT INTO [dbo].[Staff] ([StaffID], [DepartmentID], [FirstName], [LastName], [Role], [Shift])
VALUES
('03001', 1, 'Maria', 'De Leon', 'Doctor', '7:00AM-3:00PM'),
('03002', 1, 'James', 'Villanueva', 'Nurse', '7:00AM-3:00PM'),
('03003', 2, 'Carlos', 'Reyes', 'Doctor', '3:00PM-11:00PM'),
('03004', 2, 'Angela', 'Cruz', 'Nurse', '3:00PM-11:00PM'),
('03005', 3, 'Ella', 'Santos', 'Doctor', '11:00PM-7:00AM'),
('03006', 3, 'Luis', 'Domingo', 'Nurse', '11:00PM-7:00AM'),
('03007', 4, 'Rafael', 'Torres', 'Doctor', '7:00AM-3:00PM'),
('03008', 4, 'Diana', 'Garcia', 'Nurse', '7:00AM-3:00PM'),
('03009', 5, 'Jace', 'Sarmiento', 'Doctor', '3:00PM-11:00PM'),
('03010', 5, 'Bea', 'Gomez', 'Nurse', '3:00PM-11:00PM'),
('03011', 6, 'Nina', 'Lopez', 'Doctor', '11:00PM-7:00AM'),
('03012', 6, 'Erwin', 'Castillo', 'Nurse', '11:00PM-7:00AM'),
('03013', 7, 'Hannah', 'Lim', 'Doctor', '7:00AM-3:00PM'),
('03014', 7, 'Marco', 'Ramos', 'Nurse', '7:00AM-3:00PM'),
('03015', 1, 'Tristan', 'Valdez', 'Doctor', '3:00PM-11:00PM'),
('03016', 1, 'Lea', 'Mendoza', 'Nurse', '3:00PM-11:00PM'),
('03017', 2, 'Patrick', 'Aquino', 'Doctor', '11:00PM-7:00AM'),
('03018', 2, 'Clarisse', 'Tan', 'Nurse', '11:00PM-7:00AM'),
('03019', 3, 'Isabel', 'Morales', 'Doctor', '7:00AM-3:00PM'),
('03020', 3, 'Jerome', 'Gutierrez', 'Nurse', '7:00AM-3:00PM'),
('03021', 4, 'Kyle', 'Navarro', 'Doctor', '3:00PM-11:00PM'),
('03022', 4, 'Faith', 'Dizon', 'Nurse', '3:00PM-11:00PM'),
('03023', 5, 'Arthur', 'Santos', 'Doctor', '11:00PM-7:00AM'),
('03024', 5, 'Lara', 'Villareal', 'Nurse', '11:00PM-7:00AM'),
('03025', 6, 'Monica', 'Soriano', 'Doctor', '7:00AM-3:00PM'),
('03026', 6, 'Victor', 'Salazar', 'Nurse', '7:00AM-3:00PM'),
('03027', 7, 'Ethan', 'Cabrera', 'Doctor', '3:00PM-11:00PM'),
('03028', 7, 'Alyssa', 'Rivera', 'Nurse', '3:00PM-11:00PM'),
('03029', 7, 'Sophia', 'Manalo', 'Doctor', '11:00PM-7:00AM'),
('03030', 6, 'Noel', 'Roxas', 'Nurse', '11:00PM-7:00AM');

INSERT INTO [dbo].[StaffAssignment] ([PatientID], [StaffID], [Role])
SELECT 1000, 3001, [Role] FROM Staff WHERE StaffID = 3001 UNION ALL
SELECT 1000, 3002, [Role] FROM Staff WHERE StaffID = 3002 UNION ALL
SELECT 1001, 3003, [Role] FROM Staff WHERE StaffID = 3003 UNION ALL
SELECT 1001, 3004, [Role] FROM Staff WHERE StaffID = 3004 UNION ALL
SELECT 1002, 3005, [Role] FROM Staff WHERE StaffID = 3005 UNION ALL
SELECT 1002, 3006, [Role] FROM Staff WHERE StaffID = 3006 UNION ALL
SELECT 1003, 3007, [Role] FROM Staff WHERE StaffID = 3007 UNION ALL
SELECT 1003, 3008, [Role] FROM Staff WHERE StaffID = 3008 UNION ALL
SELECT 1004, 3009, [Role] FROM Staff WHERE StaffID = 3009 UNION ALL
SELECT 1004, 3010, [Role] FROM Staff WHERE StaffID = 3010 UNION ALL
SELECT 1005, 3011, [Role] FROM Staff WHERE StaffID = 3011 UNION ALL
SELECT 1005, 3012, [Role] FROM Staff WHERE StaffID = 3012 UNION ALL
SELECT 1006, 3013, [Role] FROM Staff WHERE StaffID = 3013 UNION ALL
SELECT 1006, 3014, [Role] FROM Staff WHERE StaffID = 3014 UNION ALL
SELECT 1007, 3001, [Role] FROM Staff WHERE StaffID = 3001 UNION ALL
SELECT 1007, 3002, [Role] FROM Staff WHERE StaffID = 3002 UNION ALL
SELECT 1008, 3003, [Role] FROM Staff WHERE StaffID = 3003 UNION ALL
SELECT 1008, 3004, [Role] FROM Staff WHERE StaffID = 3004 UNION ALL
SELECT 1009, 3005, [Role] FROM Staff WHERE StaffID = 3005 UNION ALL
SELECT 1009, 3006, [Role] FROM Staff WHERE StaffID = 3006 UNION ALL
SELECT 1010, 3007, [Role] FROM Staff WHERE StaffID = 3007 UNION ALL
SELECT 1010, 3008, [Role] FROM Staff WHERE StaffID = 3008 UNION ALL
SELECT 1011, 3009, [Role] FROM Staff WHERE StaffID = 3009 UNION ALL
SELECT 1011, 3010, [Role] FROM Staff WHERE StaffID = 3010 UNION ALL
SELECT 1012, 3011, [Role] FROM Staff WHERE StaffID = 3011 UNION ALL
SELECT 1012, 3012, [Role] FROM Staff WHERE StaffID = 3012 UNION ALL
SELECT 1013, 3013, [Role] FROM Staff WHERE StaffID = 3013 UNION ALL
SELECT 1013, 3014, [Role] FROM Staff WHERE StaffID = 3014 UNION ALL
SELECT 1014, 3001, [Role] FROM Staff WHERE StaffID = 3001 UNION ALL
SELECT 1014, 3002, [Role] FROM Staff WHERE StaffID = 3002 UNION ALL
SELECT 1015, 3003, [Role] FROM Staff WHERE StaffID = 3003 UNION ALL
SELECT 1015, 3004, [Role] FROM Staff WHERE StaffID = 3004 UNION ALL
SELECT 1016, 3005, [Role] FROM Staff WHERE StaffID = 3005 UNION ALL
SELECT 1016, 3006, [Role] FROM Staff WHERE StaffID = 3006 UNION ALL
SELECT 1017, 3007, [Role] FROM Staff WHERE StaffID = 3007 UNION ALL
SELECT 1017, 3008, [Role] FROM Staff WHERE StaffID = 3008 UNION ALL
SELECT 1018, 3009, [Role] FROM Staff WHERE StaffID = 3009 UNION ALL
SELECT 1018, 3010, [Role] FROM Staff WHERE StaffID = 3010 UNION ALL
SELECT 1019, 3011, [Role] FROM Staff WHERE StaffID = 3011 UNION ALL
SELECT 1019, 3012, [Role] FROM Staff WHERE StaffID = 3012 UNION ALL
SELECT 1020, 3013, [Role] FROM Staff WHERE StaffID = 3013 UNION ALL
SELECT 1020, 3014, [Role] FROM Staff WHERE StaffID = 3014 UNION ALL
SELECT 1021, 3001, [Role] FROM Staff WHERE StaffID = 3001 UNION ALL
SELECT 1021, 3002, [Role] FROM Staff WHERE StaffID = 3002 UNION ALL
SELECT 1022, 3003, [Role] FROM Staff WHERE StaffID = 3003 UNION ALL
SELECT 1022, 3004, [Role] FROM Staff WHERE StaffID = 3004 UNION ALL
SELECT 1023, 3005, [Role] FROM Staff WHERE StaffID = 3005 UNION ALL
SELECT 1023, 3006, [Role] FROM Staff WHERE StaffID = 3006 UNION ALL
SELECT 1024, 3007, [Role] FROM Staff WHERE StaffID = 3007 UNION ALL
SELECT 1024, 3008, [Role] FROM Staff WHERE StaffID = 3008 UNION ALL
SELECT 1025, 3009, [Role] FROM Staff WHERE StaffID = 3009 UNION ALL
SELECT 1025, 3010, [Role] FROM Staff WHERE StaffID = 3010 UNION ALL
SELECT 1026, 3011, [Role] FROM Staff WHERE StaffID = 3011 UNION ALL
SELECT 1026, 3012, [Role] FROM Staff WHERE StaffID = 3012 UNION ALL
SELECT 1027, 3013, [Role] FROM Staff WHERE StaffID = 3013 UNION ALL
SELECT 1027, 3014, [Role] FROM Staff WHERE StaffID = 3014 UNION ALL
SELECT 1028, 3001, [Role] FROM Staff WHERE StaffID = 3001 UNION ALL
SELECT 1028, 3002, [Role] FROM Staff WHERE StaffID = 3002 UNION ALL
SELECT 1029, 3003, [Role] FROM Staff WHERE StaffID = 3003 UNION ALL
SELECT 1029, 3004, [Role] FROM Staff WHERE StaffID = 3004 UNION ALL
SELECT 1030, 3005, [Role] FROM Staff WHERE StaffID = 3005 UNION ALL
SELECT 1030, 3006, [Role] FROM Staff WHERE StaffID = 3006 UNION ALL
SELECT 1031, 3007, [Role] FROM Staff WHERE StaffID = 3007 UNION ALL
SELECT 1031, 3008, [Role] FROM Staff WHERE StaffID = 3008 UNION ALL
SELECT 1032, 3009, [Role] FROM Staff WHERE StaffID = 3009 UNION ALL
SELECT 1032, 3010, [Role] FROM Staff WHERE StaffID = 3010 UNION ALL
SELECT 1033, 3011, [Role] FROM Staff WHERE StaffID = 3011 UNION ALL
SELECT 1033, 3012, [Role] FROM Staff WHERE StaffID = 3012 UNION ALL
SELECT 1034, 3013, [Role] FROM Staff WHERE StaffID = 3013 UNION ALL
SELECT 1034, 3014, [Role] FROM Staff WHERE StaffID = 3014 UNION ALL
SELECT 1035, 3001, [Role] FROM Staff WHERE StaffID = 3001 UNION ALL
SELECT 1035, 3002, [Role] FROM Staff WHERE StaffID = 3002 UNION ALL
SELECT 1036, 3003, [Role] FROM Staff WHERE StaffID = 3003 UNION ALL
SELECT 1036, 3004, [Role] FROM Staff WHERE StaffID = 3004 UNION ALL
SELECT 1037, 3005, [Role] FROM Staff WHERE StaffID = 3005 UNION ALL
SELECT 1037, 3006, [Role] FROM Staff WHERE StaffID = 3006 UNION ALL
SELECT 1038, 3007, [Role] FROM Staff WHERE StaffID = 3007 UNION ALL
SELECT 1038, 3008, [Role] FROM Staff WHERE StaffID = 3008 UNION ALL
SELECT 1039, 3009, [Role] FROM Staff WHERE StaffID = 3009 UNION ALL
SELECT 1039, 3010, [Role] FROM Staff WHERE StaffID = 3010 UNION ALL
SELECT 1040, 3011, [Role] FROM Staff WHERE StaffID = 3011 UNION ALL
SELECT 1040, 3012, [Role] FROM Staff WHERE StaffID = 3012 UNION ALL
SELECT 1041, 3013, [Role] FROM Staff WHERE StaffID = 3013 UNION ALL
SELECT 1041, 3014, [Role] FROM Staff WHERE StaffID = 3014 UNION ALL
SELECT 1042, 3001, [Role] FROM Staff WHERE StaffID = 3001 UNION ALL
SELECT 1042, 3002, [Role] FROM Staff WHERE StaffID = 3002 UNION ALL
SELECT 1043, 3003, [Role] FROM Staff WHERE StaffID = 3003 UNION ALL
SELECT 1043, 3004, [Role] FROM Staff WHERE StaffID = 3004 UNION ALL
SELECT 1044, 3005, [Role] FROM Staff WHERE StaffID = 3005 UNION ALL
SELECT 1044, 3006, [Role] FROM Staff WHERE StaffID = 3006 UNION ALL
SELECT 1045, 3007, [Role] FROM Staff WHERE StaffID = 3007 UNION ALL
SELECT 1045, 3008, [Role] FROM Staff WHERE StaffID = 3008 UNION ALL
SELECT 1046, 3009, [Role] FROM Staff WHERE StaffID = 3009 UNION ALL
SELECT 1046, 3010, [Role] FROM Staff WHERE StaffID = 3010 UNION ALL
SELECT 1047, 3011, [Role] FROM Staff WHERE StaffID = 3011 UNION ALL
SELECT 1047, 3012, [Role] FROM Staff WHERE StaffID = 3012 UNION ALL
SELECT 1048, 3013, [Role] FROM Staff WHERE StaffID = 3013 UNION ALL
SELECT 1048, 3014, [Role] FROM Staff WHERE StaffID = 3014 UNION ALL
SELECT 1049, 3001, [Role] FROM Staff WHERE StaffID = 3001 UNION ALL
SELECT 1049, 3002, [Role] FROM Staff WHERE StaffID = 3002;

INSERT INTO [dbo].[Rooms] ([RoomID], [RoomNumber], [RoomType], [RatePerDay], [Capacity])
VALUES
(1, 101, 'Emergency Room', 5000.00, 30),
(2, 102, 'Ward', 1200.00, 4),
(3, 103, 'Ward', 1200.00, 4),
(4, 104, 'Ward', 1200.00, 4),
(5, 105, 'Ward', 1200.00, 4),
(6, 106, 'Ward', 1200.00, 4),
(7, 201, 'Private Room', 3000.00, 1),
(8, 202, 'Private Room', 3000.00, 1),
(9, 203, 'Private Room', 3000.00, 1),
(10, 204, 'Private Room', 3000.00, 1),
(11, 205, 'Private Room', 3000.00, 1),
(12, 206, 'Private Room', 3000.00, 1),
(13, 207, 'Private Room', 3000.00, 1),
(14, 208, 'Private Room', 3000.00, 1),
(15, 209, 'Private Room', 3000.00, 1),
(16, 210, 'Private Room', 3000.00, 1),
(17, 301, 'Nursery Room', 2000.00, 10),
(18, 401, 'Intensive Care Unit (ICU)', 8000.00, 1),
(19, 402, 'Intensive Care Unit (ICU)', 8000.00, 1),
(20, 403, 'Intensive Care Unit (ICU)', 8000.00, 1),
(21, 501, 'Neonatal Intensive Care Unit (NICU)', 9000.00, 1),
(22, 502, 'Neonatal Intensive Care Unit (NICU)', 9000.00, 1),
(23, 503, 'Neonatal Intensive Care Unit (NICU)', 9000.00, 1);

INSERT INTO [dbo].[RoomAssignments] (AdmissionID, RoomID, PatientID, BedNumber, StartDate, EndDate) VALUES
(1, 17, 1000, 1, '2025-10-20', NULL),
(2, 17, 1001, 2, '2025-10-21', NULL),
(3, 2, 1002, 1, '2025-10-22', '2025-10-24'),
(3, 3, 1002, 1, '2025-10-24', '2025-10-25'),
(4, 17, 1003, 3, '2025-10-22', NULL),
(5, 2, 1004, 2, '2025-10-23', '2025-10-28'),
(6, 17, 1005, 4, '2025-10-23', NULL),
(7, 3, 1006, 2, '2025-10-24', '2025-10-29'),
(8, 17, 1007, 5, '2025-10-24', NULL),
(9, 7, 1008, 1, '2025-10-25', '2025-10-30'),
(10, 17, 1009, 6, '2025-10-25', NULL),
(11, 17, 1010, 7, '2025-10-26', '2025-10-29'),
(11, 2, 1010, 3, '2025-10-29', '2025-10-31'),
(12, 4, 1011, 1, '2025-10-26', '2025-10-31'),
(13, 5, 1012, 1, '2025-10-27', NULL),
(14, 17, 1013, 8, '2025-10-27', '2025-11-01'),
(15, 17, 1014, 9, '2025-10-28', '2025-11-02'),
(16, 6, 1015, 1, '2025-10-28', NULL),
(17, 3, 1016, 3, '2025-10-29', '2025-11-03'),
(18, 17, 1017, 10, '2025-10-29', NULL),
(19, 5, 1018, 2, '2025-10-30', '2025-11-04'),
(20, 17, 1019, 11, '2025-10-30', '2025-11-04'),
(21, 8, 1020, 1, '2025-10-31', '2025-11-05'),
(22, 17, 1021, 12, '2025-10-31', NULL),
(23, 17, 1022, 13, '2025-11-01', NULL),
(24, 4, 1023, 2, '2025-11-01', '2025-11-06'),
(25, 17, 1024, 14, '2025-11-02', NULL),
(26, 2, 1025, 4, '2025-11-02', '2025-11-07'),
(27, 3, 1026, 4, '2025-11-03', NULL),
(28, 6, 1027, 2, '2025-11-03', '2025-11-08'),
(29, 9, 1028, 1, '2025-11-04', NULL),
(30, 10, 1029, 1, '2025-11-04', '2025-11-09'),
(31, 3, 1030, 5, '2025-11-05', '2025-11-10'),
(32, 17, 1031, 15, '2025-11-05', '2025-11-10'),
(33, 17, 1032, 16, '2025-11-06', NULL),
(34, 17, 1033, 17, '2025-11-06', '2025-11-11'),
(35, 5, 1034, 3, '2025-11-07', NULL),
(36, 17, 1035, 18, '2025-11-07', '2025-11-12'),
(37, 6, 1036, 3, '2025-11-08', '2025-11-13'),
(38, 2, 1037, 1, '2025-11-08', '2025-11-14'),
(39, 3, 1038, 6, '2025-11-09', NULL),
(40, 17, 1039, 19, '2025-11-09', '2025-11-14'),
(41, 17, 1040, 20, '2025-11-09', NULL),
(42, 6, 1041, 4, '2025-11-10', NULL),
(43, 17, 1042, 21, '2025-11-10', '2025-11-15'),
(44, 17, 1043, 22, '2025-11-10', NULL),
(45, 11, 1044, 1, '2025-11-11', '2025-11-16'),
(46, 17, 1045, 23, '2025-11-11', NULL),
(47, 3, 1046, 7, '2025-11-12', NULL),
(48, 17, 1047, 24, '2025-11-12', '2025-11-17'),
(49, 17, 1048, 25, '2025-11-13', NULL),
(50, 17, 1049, 26, '2025-11-13', NULL);

INSERT INTO [dbo].[MedicalRecords] ([AdmissionID], [PatientID], [RecordDate], [Diagnosis], [Notes])
VALUES
(1, 1000, '2025-10-20', 'Hypertension', 'Patient presented with elevated blood pressure. Recommended monitoring and low-sodium diet.'),
(2, 1001, '2025-10-21', 'Asthma', 'Patient reported shortness of breath and wheezing. Prescribed inhaler and advised to avoid triggers.'),
(3, 1002, '2025-10-22', 'Gastroenteritis', 'Complaints of abdominal pain and diarrhea. Advised hydration and rest.'),
(4, 1003, '2025-10-22', 'Migraine', 'Patient experienced severe headache and nausea. Given pain management instructions.'),
(5, 1004, '2025-10-23', 'Type 2 Diabetes', 'Routine follow-up. Blood sugar levels slightly elevated. Adjusted diet plan.'),
(6, 1005, '2025-10-23', 'Pneumonia', 'Chest X-ray showed mild infection. Antibiotic therapy initiated.'),
(7, 1006, '2025-10-24', 'Anemia', 'Low hemoglobin detected. Prescribed iron supplements and advised balanced diet.'),
(8, 1007, '2025-10-24', 'Urinary Tract Infection', 'Patient complained of painful urination. Antibiotics prescribed.'),
(9, 1008, '2025-10-25', 'Fractured Arm', 'X-ray confirmed minor fracture. Arm immobilized with cast.'),
(10, 1009, '2025-10-25', 'Allergic Rhinitis', 'Complaints of sneezing and congestion. Advised antihistamine use.'),
(11, 1010, '2025-10-26', 'Bronchitis', 'Persistent cough for over a week. Prescribed bronchodilator.'),
(12, 1011, '2025-10-26', 'Tonsillitis', 'Swollen tonsils observed. Antibiotics prescribed.'),
(13, 1012, '2025-10-27', 'Appendicitis', 'Severe abdominal pain. Patient underwent appendectomy.'),
(14, 1013, '2025-10-27', 'Sprained Ankle', 'Minor sprain from sports activity. Advised RICE treatment.'),
(15, 1014, '2025-10-28', 'Gastritis', 'Complaints of stomach discomfort. Prescribed proton pump inhibitor.'),
(16, 1015, '2025-10-28', 'Depression', 'Patient expressed low mood and fatigue. Referred to psychiatry for evaluation.'),
(17, 1016, '2025-10-29', 'Hypertension', 'Follow-up visit. Blood pressure improved with medication.'),
(18, 1017, '2025-10-29', 'Chickenpox', 'Rashes observed on torso. Advised isolation and symptomatic care.'),
(19, 1018, '2025-10-29', 'Otitis Media', 'Ear pain reported. Mild infection observed. Antibiotics prescribed.'),
(20, 1019, '2025-10-30', 'Conjunctivitis', 'Redness and discharge in left eye. Eye drops prescribed.'),
(21, 1020, '2025-10-30', 'Hyperthyroidism', 'Lab results showed elevated thyroid levels. Medication started.'),
(22, 1021, '2025-10-31', 'Insomnia', 'Difficulty sleeping for several weeks. Advised sleep hygiene measures.'),
(23, 1022, '2025-10-31', 'COVID-19', 'Patient tested positive. Advised isolation and rest.'),
(24, 1023, '2025-10-31', 'Dehydration', 'Low fluid intake noted. IV fluids administered.'),
(25, 1024, '2025-11-01', 'Arthritis', 'Joint pain and stiffness reported. Prescribed anti-inflammatory meds.'),
(26, 1025, '2025-11-01', 'Stroke', 'Sudden weakness observed. Patient stabilized and referred to neurology.'),
(27, 1026, '2025-11-02', 'Asthma', 'Mild exacerbation. Advised proper inhaler use.'),
(28, 1027, '2025-11-02', 'Epilepsy', 'Seizure episode. Adjusted anticonvulsant dosage.'),
(29, 1028, '2025-11-02', 'Hypertension', 'Routine check-up. Blood pressure within normal limits.'),
(30, 1029, '2025-11-03', 'Dengue Fever', 'Platelet count monitored. Hydration therapy ongoing.'),
(31, 1030, '2025-11-03', 'Sinusitis', 'Nasal congestion and facial pain. Prescribed nasal decongestant.'),
(32, 1031, '2025-11-03', 'Tuberculosis', 'Positive sputum test. Started anti-TB medication.'),
(33, 1032, '2025-11-04', 'Gout', 'Foot pain and swelling. Prescribed uric acid–lowering medication.'),
(34, 1033, '2025-11-04', 'Pneumonia', 'Follow-up. Patient responding well to antibiotics.'),
(35, 1034, '2025-11-05', 'Anxiety Disorder', 'Reports of panic attacks. Started cognitive behavioral therapy.'),
(36, 1035, '2025-11-05', 'Fractured Leg', 'Surgical repair performed. Recovery in progress.'),
(37, 1036, '2025-11-06', 'Dehydration', 'Admitted due to vomiting. IV fluids administered.'),
(38, 1037, '2025-11-06', 'Hepatitis A', 'Jaundice observed. Advised rest and hydration.'),
(39, 1038, '2025-11-07', 'Allergic Reaction', 'Rash after seafood consumption. Antihistamine administered.'),
(40, 1039, '2025-11-07', 'Diabetes Mellitus', 'Routine blood sugar check. Adjusted insulin dosage.'),
(41, 1040, '2025-11-07', 'Pneumonia', 'Recurrent infection. Further testing recommended.'),
(42, 1041, '2025-11-08', 'Migraine', 'Recurring headaches. Prescribed migraine relief medication.'),
(43, 1042, '2025-11-08', 'Bronchitis', 'Cough and chest discomfort. Continued medication.'),
(44, 1043, '2025-11-09', 'Hypertension', 'Stable condition. Regular follow-up advised.'),
(45, 1044, '2025-11-09', 'Otitis Externa', 'Outer ear infection. Ear drops prescribed.'),
(46, 1045, '2025-11-09', 'Anemia', 'Low red blood cell count. Iron supplements prescribed.'),
(47, 1046, '2025-11-10', 'Gastritis', 'Patient reported acid reflux. Dietary changes recommended.'),
(48, 1047, '2025-11-10', 'Fractured Wrist', 'Minor fracture. Cast applied.'),
(49, 1048, '2025-11-10', 'Viral Fever', 'High temperature recorded. Symptomatic treatment given.'),
(50, 1049, '2025-11-11', 'Pneumonia', 'Mild infection detected. Antibiotic treatment started.');

INSERT INTO [dbo].[Medications] 
([RecordID], [MedicationName], [FrequencyCount], [FrequencyValue], [FrequencyType], [Duration], [Price])
VALUES
(1, 'Amlodipine 5mg', 1, 24, 'hour(s)', 30, 25.00),
(2, 'Salbutamol Inhaler', 2, 12, 'hour(s)', 14, 180.00),
(3, 'Loperamide 2mg', 1, 8, 'hour(s)', 3, 15.00),
(4, 'Ibuprofen 400mg', 1, 6, 'hour(s)', 5, 10.00),
(5, 'Metformin 500mg', 1, 12, 'hour(s)', 30, 20.00),
(6, 'Amoxicillin 500mg', 1, 8, 'hour(s)', 10, 12.00),
(7, 'Ferrous Sulfate 325mg', 1, 24, 'hour(s)', 60, 8.00),
(8, 'Ciprofloxacin 500mg', 1, 12, 'hour(s)', 7, 18.00),
(9, 'Paracetamol 500mg', 1, 8, 'hour(s)', 5, 5.00),
(10, 'Cetirizine 10mg', 1, 24, 'hour(s)', 14, 7.00),
(11, 'Salbutamol Syrup', 1, 8, 'hour(s)', 10, 25.00),
(12, 'Amoxicillin 500mg', 1, 8, 'hour(s)', 7, 12.00),
(13, 'Ceftriaxone 1g Injection', 1, 24, 'hour(s)', 5, 150.00),
(14, 'Paracetamol 500mg', 1, 6, 'hour(s)', 3, 5.00),
(15, 'Omeprazole 20mg', 1, 24, 'hour(s)', 14, 10.00),
(16, 'Sertraline 50mg', 1, 24, 'hour(s)', 30, 30.00),
(17, 'Losartan 50mg', 1, 24, 'hour(s)', 30, 22.00),
(18, 'Calamine Lotion', 1, 24, 'hour(s)', 7, 60.00),
(19, 'Amoxicillin 500mg', 1, 8, 'hour(s)', 7, 12.00),
(20, 'Tobramycin Eye Drops', 1, 8, 'hour(s)', 5, 90.00),
(21, 'Methimazole 10mg', 1, 24, 'hour(s)', 30, 28.00),
(22, 'Melatonin 3mg', 1, 24, 'hour(s)', 14, 15.00),
(23, 'Paracetamol 500mg', 1, 6, 'hour(s)', 10, 5.00),
(24, 'ORS Solution', 1, 24, 'hour(s)', 3, 40.00),
(25, 'Ibuprofen 400mg', 1, 8, 'hour(s)', 7, 10.00),
(26, 'Aspirin 81mg', 1, 24, 'hour(s)', 30, 10.00),
(27, 'Salbutamol Inhaler', 2, 12, 'hour(s)', 14, 180.00),
(28, 'Carbamazepine 200mg', 1, 12, 'hour(s)', 30, 35.00),
(29, 'Losartan 50mg', 1, 24, 'hour(s)', 30, 22.00),
(30, 'Acetaminophen 500mg', 1, 6, 'hour(s)', 5, 5.00),
(31, 'Amoxicillin-Clavulanate 625mg', 1, 12, 'hour(s)', 7, 25.00),
(32, 'Isoniazid 300mg', 1, 24, 'hour(s)', 180, 15.00),
(33, 'Allopurinol 100mg', 1, 24, 'hour(s)', 30, 20.00),
(34, 'Amoxicillin 500mg', 1, 8, 'hour(s)', 7, 12.00),
(35, 'Paracetamol 500mg', 1, 6, 'hour(s)', 7, 5.00),
(36, 'ORS Solution', 1, 24, 'hour(s)', 3, 40.00),
(37, 'Vitamin B Complex', 1, 24, 'hour(s)', 14, 12.00),
(38, 'Silymarin 140mg', 1, 12, 'hour(s)', 30, 25.00),
(39, 'Diphenhydramine 25mg', 1, 8, 'hour(s)', 5, 10.00),
(40, 'Insulin 100IU/mL', 1, 24, 'hour(s)', 30, 50.00),
(41, 'Levofloxacin 500mg', 1, 24, 'hour(s)', 7, 25.00),
(42, 'Salbutamol 2mg Tablet', 1, 8, 'hour(s)', 7, 18.00),
(43, 'Amlodipine 5mg', 1, 24, 'hour(s)', 30, 25.00),
(44, 'Ciprofloxacin Ear Drops', 1, 8, 'hour(s)', 7, 95.00),
(45, 'Ferrous Sulfate 325mg', 1, 24, 'hour(s)', 30, 8.00),
(46, 'Omeprazole 20mg', 1, 24, 'hour(s)', 14, 10.00),
(47, 'Paracetamol 500mg', 1, 6, 'hour(s)', 5, 5.00),
(48, 'Ibuprofen 400mg', 1, 8, 'hour(s)', 7, 10.00),
(49, 'Paracetamol 500mg', 1, 6, 'hour(s)', 5, 5.00),
(50, 'Amoxicillin 500mg', 1, 8, 'hour(s)', 7, 12.00);

INSERT INTO [dbo].[Treatments] ([RecordID], [TreatmentType], [Price])
VALUES
(1, 'Blood Pressure Monitoring', 500.00),
(2, 'Nebulization', 800.00),
(3, 'IV Fluid Therapy', 1200.00),
(4, 'CT Scan', 3000.00),
(6, 'Chest X-Ray', 1500.00),
(9, 'Cast Application', 2500.00),
(11, 'Chest Physiotherapy', 1000.00),
(12, 'Throat Swab and Culture', 700.00),
(13, 'Appendectomy', 25000.00),
(14, 'Ankle Bandaging', 600.00),
(15, 'Endoscopy', 3500.00),
(16, 'Psychiatric Evaluation', 2000.00),
(18, 'Rash Treatment and Skin Care', 900.00),
(19, 'Ear Cleaning', 800.00),
(20, 'Eye Examination', 600.00),
(21, 'Thyroid Function Test', 1200.00),
(23, 'IV Fluid Administration', 1000.00),
(25, 'Joint Therapy', 1800.00),
(26, 'CT Scan', 3200.00),
(27, 'Nebulization', 700.00),
(28, 'EEG Monitoring', 2000.00),
(30, 'Blood Platelet Monitoring', 1500.00),
(31, 'Nasal Irrigation', 800.00),
(32, 'Sputum Test', 900.00),
(33, 'Uric Acid Test', 600.00),
(35, 'Leg Surgery', 28000.00),
(36, 'IV Fluid Therapy', 1000.00),
(37, 'Liver Function Test', 1100.00),
(40, 'Chest X-Ray', 1500.00),
(41, 'CT Scan', 3000.00),
(42, 'Nebulization', 800.00),
(45, 'Blood Test', 700.00),
(47, 'Cast Application', 2200.00),
(48, 'Temperature Monitoring', 500.00),
(50, 'Chest X-Ray', 1500.00);
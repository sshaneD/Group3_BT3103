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


---- tbl Patients

INSERT INTO [dbo].[Patient]
(FirstName, MiddleName, LastName, AdmissionDate, DateOfBirth, Age, Gender, GuardianName, GuardianNo)
VALUES
('Ethan','Ramirez','Cruz','2025-01-15','2013-05-10',12,'Male','Maria Cruz','09171234567'),
('Sophia','Lopez','Santos','2025-02-02','2016-08-22',9,'Female','Carlo Santos','09182345678'),
('Daniel','Moreno','Reyes','2025-03-18','2010-02-15',15,'Male','Liza Reyes','09293456789'),
('Mia','Garcia','Torres','2025-01-25','2014-11-05',11,'Female','Juan Torres','09304567891'),
('Liam','Flores','Mendoza','2025-02-11','2011-03-09',14,'Male','Ana Mendoza','09415678902'),
('Chloe','Ramos','Ramirez','2025-01-30','2015-09-18',10,'Female','Pedro Ramirez','09526789013'),
('Noah','Reyes','Villanueva','2025-03-05','2012-06-25',13,'Male','Grace Villanueva','09637890124'),
('Isabella','Dela Cruz','Bautista','2025-04-12','2017-12-02',8,'Female','Marco Bautista','09748901235'),
('Lucas','Mendoza','Navarro','2025-01-19','2009-01-19',16,'Male','Rosa Navarro','09859012346'),
('Ava','Castro','Dela Cruz','2025-02-22','2018-10-27',7,'Female','Jose Dela Cruz','09160123457'),
('Elijah','Torres','Ramos','2025-03-10','2013-04-11',12,'Male','Karen Ramos','09171235678'),
('Aria','Villanueva','Flores','2025-01-08','2010-07-30',15,'Female','Roberto Flores','09182346789'),
('Mason','Gutierrez','Gutierrez','2025-03-02','2011-09-14',14,'Male','Teresa Gutierrez','09193457890'),
('Amelia','Cruz','Castillo','2025-02-14','2014-12-08',11,'Female','Edgar Castillo','09204568901'),
('Benjamin','Lozano','Morales','2025-01-20','2016-05-21',9,'Male','Clara Morales','09315679012'),
('Harper','Santos','Santiago','2025-02-28','2012-02-07',13,'Female','Ramon Santiago','09426780123'),
('James','Perez','Perez','2025-03-06','2009-06-03',16,'Male','Julia Perez','09537891234'),
('Emily','Bautista','Lozano','2025-01-13','2015-08-25',10,'Female','Mario Lozano','09648902345'),
('Alexander','Fernandez','Bautista','2025-02-07','2010-09-29',15,'Male','Cecilia Bautista','09759013456'),
('Abigail','Rivera','Rivera','2025-04-04','2017-11-16',8,'Female','Hector Rivera','09860124567'),
('Michael','Jimenez','Jimenez','2025-02-16','2011-04-02',14,'Male','Sonia Jimenez','09171235679'),
('Grace','Aguilar','Aguilar','2025-01-27','2013-07-09',12,'Female','Leo Aguilar','09182346780'),
('William','Fernandez','Fernandez','2025-03-15','2012-03-28',13,'Male','Andrea Fernandez','09193457891'),
('Ella','Salazar','Salazar','2025-02-05','2018-09-19',7,'Female','Carlo Salazar','09204568902'),
('Henry','Gonzales','Gonzales','2025-01-17','2010-01-13',15,'Male','Pilar Gonzales','09315679013'),
('Scarlett','Lim','Lim','2025-03-24','2015-10-10',10,'Female','Alvin Lim','09426780124'),
('Jacob','Cruz','Cruz','2025-04-09','2014-02-26',11,'Male','Maria Cruz','09537891235'),
('Victoria','Ramos','Ramos','2025-01-09','2009-03-05',16,'Female','Karen Ramos','09648902346'),
('Matthew','Reyes','Reyes','2025-02-12','2013-11-15',12,'Male','Liza Reyes','09759013457'),
('Sofia','Navarro','Navarro','2025-03-21','2016-06-07',9,'Female','Rosa Navarro','09860124568'),
('David','Santiago','Santiago','2025-01-25','2011-07-23',14,'Male','Ramon Santiago','09171235670'),
('Avery','Mendoza','Mendoza','2025-02-02','2012-10-14',13,'Female','Ana Mendoza','09182346781'),
('Joseph','Villanueva','Villanueva','2025-03-29','2010-12-01',15,'Male','Grace Villanueva','09193457892'),
('Lily','Torres','Torres','2025-01-31','2017-09-20',8,'Female','Juan Torres','09204568903'),
('Samuel','Santos','Santos','2025-02-08','2015-05-02',10,'Male','Carlo Santos','09315679014'),
('Natalie','Cruz','Cruz','2025-04-11','2014-08-13',11,'Female','Maria Cruz','09426780125'),
('Anthony','Gutierrez','Gutierrez','2025-03-17','2011-03-27',14,'Male','Teresa Gutierrez','09537891236'),
('Zoey','Castillo','Castillo','2025-01-22','2012-01-18',13,'Female','Edgar Castillo','09648902347'),
('Andrew','Morales','Morales','2025-02-19','2009-05-25',16,'Male','Clara Morales','09759013458'),
('Hannah','Ramos','Ramos','2025-04-06','2018-04-11',7,'Female','Karen Ramos','09860124569'),
('Christopher','Reyes','Reyes','2025-01-10','2013-09-30',12,'Male','Liza Reyes','09171235671'),
('Layla','Navarro','Navarro','2025-03-11','2016-11-07',9,'Female','Rosa Navarro','09182346782'),
('Joshua','Aguilar','Aguilar','2025-02-24','2010-07-05',15,'Male','Leo Aguilar','09193457893'),
('Zoella','Santiago','Santiago','2025-01-28','2017-02-03',8,'Female','Ramon Santiago','09204568904'),
('Ryan','Mendoza','Mendoza','2025-03-09','2011-06-15',14,'Male','Ana Mendoza','09315679015'),
('Penelope','Villanueva','Villanueva','2025-02-21','2015-01-24',10,'Female','Grace Villanueva','09426780126'),
('Isaac','Cruz','Cruz','2025-03-30','2012-05-09',13,'Male','Maria Cruz','09537891237'),
('Camila','Perez','Perez','2025-01-16','2009-08-28',16,'Female','Julia Perez','09648902348'),
('Oliver','Jimenez','Jimenez','2025-02-18','2013-03-17',12,'Male','Sonia Jimenez','09759013459'),
('Aurora','Torres','Torres','2025-03-23','2014-10-22',11,'Female','Juan Torres','09860124560');

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
SELECT 1000, 3001, [Role] FROM [dbo].[Staff] WHERE [StaffID] = 3001 UNION ALL
SELECT 1000, 3002, [Role] FROM [dbo].[Staff] WHERE [StaffID] = 3002 UNION ALL
SELECT 1001, 3003, [Role] FROM [dbo].[Staff] WHERE [StaffID] = 3003 UNION ALL
SELECT 1001, 3004, [Role] FROM [dbo].[Staff] WHERE [StaffID] = 3004 UNION ALL
SELECT 1002, 3005, [Role] FROM [dbo].[Staff] WHERE [StaffID] = 3005 UNION ALL
SELECT 1002, 3006, [Role] FROM [dbo].[Staff] WHERE [StaffID] = 3006 UNION ALL
SELECT 1003, 3007, [Role] FROM [dbo].[Staff] WHERE [StaffID] = 3007 UNION ALL
SELECT 1003, 3008, [Role] FROM [dbo].[Staff] WHERE [StaffID] = 3008 UNION ALL
SELECT 1004, 3009, [Role] FROM [dbo].[Staff] WHERE [StaffID] = 3009 UNION ALL
SELECT 1004, 3010, [Role] FROM [dbo].[Staff] WHERE [StaffID] = 3010 UNION ALL
SELECT 1005, 3011, [Role] FROM [dbo].[Staff] WHERE [StaffID] = 3011 UNION ALL
SELECT 1005, 3012, [Role] FROM [dbo].[Staff] WHERE [StaffID] = 3012 UNION ALL
SELECT 1006, 3013, [Role] FROM [dbo].[Staff] WHERE [StaffID] = 3013 UNION ALL
SELECT 1006, 3014, [Role] FROM [dbo].[Staff] WHERE [StaffID] = 3014 UNION ALL
SELECT 1007, 3015, [Role] FROM [dbo].[Staff] WHERE [StaffID] = 3015 UNION ALL
SELECT 1007, 3016, [Role] FROM [dbo].[Staff] WHERE [StaffID] = 3016 UNION ALL
SELECT 1008, 3017, [Role] FROM [dbo].[Staff] WHERE [StaffID] = 3017 UNION ALL
SELECT 1008, 3018, [Role] FROM [dbo].[Staff] WHERE [StaffID] = 3018 UNION ALL
SELECT 1009, 3019, [Role] FROM [dbo].[Staff] WHERE [StaffID] = 3019 UNION ALL
SELECT 1009, 3020, [Role] FROM [dbo].[Staff] WHERE [StaffID] = 3020 UNION ALL
SELECT 1010, 3021, [Role] FROM [dbo].[Staff] WHERE [StaffID] = 3021 UNION ALL
SELECT 1010, 3022, [Role] FROM [dbo].[Staff] WHERE [StaffID] = 3022 UNION ALL
SELECT 1011, 3023, [Role] FROM [dbo].[Staff] WHERE [StaffID] = 3023 UNION ALL
SELECT 1011, 3024, [Role] FROM [dbo].[Staff] WHERE [StaffID] = 3024 UNION ALL
SELECT 1012, 3025, [Role] FROM [dbo].[Staff] WHERE [StaffID] = 3025 UNION ALL
SELECT 1012, 3026, [Role] FROM [dbo].[Staff] WHERE [StaffID] = 3026 UNION ALL
SELECT 1013, 3027, [Role] FROM [dbo].[Staff] WHERE [StaffID] = 3027 UNION ALL
SELECT 1013, 3028, [Role] FROM [dbo].[Staff] WHERE [StaffID] = 3028 UNION ALL
SELECT 1014, 3029, [Role] FROM [dbo].[Staff] WHERE [StaffID] = 3029 UNION ALL
SELECT 1014, 3030, [Role] FROM [dbo].[Staff] WHERE [StaffID] = 3030;

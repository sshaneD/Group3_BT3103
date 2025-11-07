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
(FirstName, MiddleName, LastName, AdmissionDate, DateOfBirth, Age, Gender, GuardianName, GuardianNo, Status)
VALUES
('Ethan','Ramirez','Cruz','2025-01-15','2013-05-10',12,'Male','Maria Cruz','09171234567','Admitted'),
('Sophia','Lopez','Santos','2025-02-02','2016-08-22',9,'Female','Carlo Santos','09182345678','Admitted'),
('Daniel','Moreno','Reyes','2025-03-18','2010-02-15',15,'Male','Liza Reyes','09293456789','Discharged'),
('Mia','Garcia','Torres','2025-01-25','2014-11-05',11,'Female','Juan Torres','09304567891','Admitted'),
('Liam','Flores','Mendoza','2025-02-11','2011-03-09',14,'Male','Ana Mendoza','09415678902','Discharged'),
('Chloe','Ramos','Ramirez','2025-01-30','2015-09-18',10,'Female','Pedro Ramirez','09526789013','Admitted'),
('Noah','Reyes','Villanueva','2025-03-05','2012-06-25',13,'Male','Grace Villanueva','09637890124','Discharged'),
('Isabella','Dela Cruz','Bautista','2025-04-12','2017-12-02',8,'Female','Marco Bautista','09748901235','Admitted'),
('Lucas','Mendoza','Navarro','2025-01-19','2009-01-19',16,'Male','Rosa Navarro','09859012346','Discharged'),
('Ava','Castro','Dela Cruz','2025-02-22','2018-10-27',7,'Female','Jose Dela Cruz','09160123457','Admitted'),
('Elijah','Torres','Ramos','2025-03-10','2013-04-11',12,'Male','Karen Ramos','09171235678','Admitted'),
('Aria','Villanueva','Flores','2025-01-08','2010-07-30',15,'Female','Roberto Flores','09182346789','Discharged'),
('Mason','Gutierrez','Gutierrez','2025-03-02','2011-09-14',14,'Male','Teresa Gutierrez','09193457890','Admitted'),
('Amelia','Cruz','Castillo','2025-02-14','2014-12-08',11,'Female','Edgar Castillo','09204568901','Discharged'),
('Benjamin','Lozano','Morales','2025-01-20','2016-05-21',9,'Male','Clara Morales','09315679012','Admitted'),
('Harper','Santos','Santiago','2025-02-28','2012-02-07',13,'Female','Ramon Santiago','09426780123','Admitted'),
('James','Perez','Perez','2025-03-06','2009-06-03',16,'Male','Julia Perez','09537891234','Discharged'),
('Emily','Bautista','Lozano','2025-01-13','2015-08-25',10,'Female','Mario Lozano','09648902345','Admitted'),
('Alexander','Fernandez','Bautista','2025-02-07','2010-09-29',15,'Male','Cecilia Bautista','09759013456','Admitted'),
('Abigail','Rivera','Rivera','2025-04-04','2017-11-16',8,'Female','Hector Rivera','09860124567','Discharged'),
('Michael','Jimenez','Jimenez','2025-02-16','2011-04-02',14,'Male','Sonia Jimenez','09171235679','Admitted'),
('Grace','Aguilar','Aguilar','2025-01-27','2013-07-09',12,'Female','Leo Aguilar','09182346780','Admitted'),
('William','Fernandez','Fernandez','2025-03-15','2012-03-28',13,'Male','Andrea Fernandez','09193457891','Discharged'),
('Ella','Salazar','Salazar','2025-02-05','2018-09-19',7,'Female','Carlo Salazar','09204568902','Admitted'),
('Henry','Gonzales','Gonzales','2025-01-17','2010-01-13',15,'Male','Pilar Gonzales','09315679013','Discharged'),
('Scarlett','Lim','Lim','2025-03-24','2015-10-10',10,'Female','Alvin Lim','09426780124','Admitted'),
('Jacob','Cruz','Cruz','2025-04-09','2014-02-26',11,'Male','Maria Cruz','09537891235','Discharged'),
('Victoria','Ramos','Ramos','2025-01-09','2009-03-05',16,'Female','Karen Ramos','09648902346','Admitted'),
('Matthew','Reyes','Reyes','2025-02-12','2013-11-15',12,'Male','Liza Reyes','09759013457','Admitted'),
('Sofia','Navarro','Navarro','2025-03-21','2016-06-07',9,'Female','Rosa Navarro','09860124568','Admitted'),
('David','Santiago','Santiago','2025-01-25','2011-07-23',14,'Male','Ramon Santiago','09171235670','Discharged'),
('Avery','Mendoza','Mendoza','2025-02-02','2012-10-14',13,'Female','Ana Mendoza','09182346781','Admitted'),
('Joseph','Villanueva','Villanueva','2025-03-29','2010-12-01',15,'Male','Grace Villanueva','09193457892','Admitted'),
('Lily','Torres','Torres','2025-01-31','2017-09-20',8,'Female','Juan Torres','09204568903','Discharged'),
('Samuel','Santos','Santos','2025-02-08','2015-05-02',10,'Male','Carlo Santos','09315679014','Admitted'),
('Natalie','Cruz','Cruz','2025-04-11','2014-08-13',11,'Female','Maria Cruz','09426780125','Admitted'),
('Anthony','Gutierrez','Gutierrez','2025-03-17','2011-03-27',14,'Male','Teresa Gutierrez','09537891236','Discharged'),
('Zoey','Castillo','Castillo','2025-01-22','2012-01-18',13,'Female','Edgar Castillo','09648902347','Admitted'),
('Andrew','Morales','Morales','2025-02-19','2009-05-25',16,'Male','Clara Morales','09759013458','Admitted'),
('Hannah','Ramos','Ramos','2025-04-06','2018-04-11',7,'Female','Karen Ramos','09860124569','Discharged'),
('Christopher','Reyes','Reyes','2025-01-10','2013-09-30',12,'Male','Liza Reyes','09171235671','Admitted'),
('Layla','Navarro','Navarro','2025-03-11','2016-11-07',9,'Female','Rosa Navarro','09182346782','Admitted'),
('Joshua','Aguilar','Aguilar','2025-02-24','2010-07-05',15,'Male','Leo Aguilar','09193457893','Discharged'),
('Zoella','Santiago','Santiago','2025-01-28','2017-02-03',8,'Female','Ramon Santiago','09204568904','Admitted'),
('Ryan','Mendoza','Mendoza','2025-03-09','2011-06-15',14,'Male','Ana Mendoza','09315679015','Discharged'),
('Penelope','Villanueva','Villanueva','2025-02-21','2015-01-24',10,'Female','Grace Villanueva','09426780126','Admitted'),
('Isaac','Cruz','Cruz','2025-03-30','2012-05-09',13,'Male','Maria Cruz','09537891237','Admitted'),
('Camila','Perez','Perez','2025-01-16','2009-08-28',16,'Female','Julia Perez','09648902348','Discharged'),
('Oliver','Jimenez','Jimenez','2025-02-18','2013-03-17',12,'Male','Sonia Jimenez','09759013459','Admitted'),
('Aurora','Torres','Torres','2025-03-23','2014-10-22',11,'Female','Juan Torres','09860124560','Admitted');


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

INSERT INTO [dbo].[RoomAssignments] 
([RoomID], [PatientID], [BedNumber], [StartDate], [EndDate])
VALUES
(1, 1000, 1, '2025-01-05', NULL),
(1, 1001, 2, '2025-01-10', '2025-02-10'),
(2, 1002, 1, '2025-01-12', NULL),
(2, 1003, 2, '2025-01-15', '2025-02-20'),
(3, 1004, 1, '2025-01-20', NULL),
(4, 1005, 1, '2025-01-25', NULL),
(4, 1006, 2, '2025-01-27', '2025-02-25'),
(5, 1007, 1, '2025-02-01', NULL),
(6, 1008, 1, '2025-02-03', NULL),
(7, 1009, 1, '2025-02-05', '2025-03-05'),
(8, 1010, 1, '2025-02-08', NULL),
(9, 1011, 1, '2025-02-10', '2025-03-10'),
(10, 1012, 1, '2025-02-12', NULL),
(11, 1013, 1, '2025-02-14', NULL),
(12, 1014, 1, '2025-02-16', NULL),
(13, 1015, 1, '2025-02-18', '2025-03-15'),
(14, 1016, 1, '2025-02-20', NULL),
(15, 1017, 1, '2025-02-22', NULL),
(16, 1018, 1, '2025-02-25', '2025-03-20'),
(17, 1019, 1, '2025-02-28', NULL),
(18, 1020, 1, '2025-03-01', NULL),
(19, 1021, 1, '2025-03-02', NULL),
(20, 1022, 1, '2025-03-03', NULL),
(21, 1023, 1, '2025-03-04', NULL),
(22, 1024, 1, '2025-03-05', NULL);

INSERT INTO [dbo].[MedicalRecords] ([PatientID], [RecordDate], [Diagnosis], [Notes])
VALUES
(1000, '2025-10-20', 'Hypertension', 'Patient presented with elevated blood pressure. Recommended monitoring and low-sodium diet.'),
(1001, '2025-10-21', 'Asthma', 'Patient reported shortness of breath and wheezing. Prescribed inhaler and advised to avoid triggers.'),
(1002, '2025-10-22', 'Gastroenteritis', 'Complaints of abdominal pain and diarrhea. Advised hydration and rest.'),
(1003, '2025-10-22', 'Migraine', 'Patient experienced severe headache and nausea. Given pain management instructions.'),
(1004, '2025-10-23', 'Type 2 Diabetes', 'Routine follow-up. Blood sugar levels slightly elevated. Adjusted diet plan.'),
(1005, '2025-10-23', 'Pneumonia', 'Chest X-ray showed mild infection. Antibiotic therapy initiated.'),
(1006, '2025-10-24', 'Anemia', 'Low hemoglobin detected. Prescribed iron supplements and advised balanced diet.'),
(1007, '2025-10-24', 'Urinary Tract Infection', 'Patient complained of painful urination. Antibiotics prescribed.'),
(1008, '2025-10-25', 'Fractured Arm', 'X-ray confirmed minor fracture. Arm immobilized with cast.'),
(1009, '2025-10-25', 'Allergic Rhinitis', 'Complaints of sneezing and congestion. Advised antihistamine use.'),
(1010, '2025-10-26', 'Bronchitis', 'Persistent cough for over a week. Prescribed bronchodilator.'),
(1011, '2025-10-26', 'Tonsillitis', 'Swollen tonsils observed. Antibiotics prescribed.'),
(1012, '2025-10-27', 'Appendicitis', 'Severe abdominal pain. Patient underwent appendectomy.'),
(1013, '2025-10-27', 'Sprained Ankle', 'Minor sprain from sports activity. Advised RICE treatment.'),
(1014, '2025-10-28', 'Gastritis', 'Complaints of stomach discomfort. Prescribed proton pump inhibitor.'),
(1015, '2025-10-28', 'Depression', 'Patient expressed low mood and fatigue. Referred to psychiatry for evaluation.'),
(1016, '2025-10-29', 'Hypertension', 'Follow-up visit. Blood pressure improved with medication.'),
(1017, '2025-10-29', 'Chickenpox', 'Rashes observed on torso. Advised isolation and symptomatic care.'),
(1018, '2025-10-29', 'Otitis Media', 'Ear pain reported. Mild infection observed. Antibiotics prescribed.'),
(1019, '2025-10-30', 'Conjunctivitis', 'Redness and discharge in left eye. Eye drops prescribed.'),
(1020, '2025-10-30', 'Hyperthyroidism', 'Lab results showed elevated thyroid levels. Medication started.'),
(1021, '2025-10-31', 'Insomnia', 'Difficulty sleeping for several weeks. Advised sleep hygiene measures.'),
(1022, '2025-10-31', 'COVID-19', 'Patient tested positive. Advised isolation and rest.'),
(1023, '2025-10-31', 'Dehydration', 'Low fluid intake noted. IV fluids administered.'),
(1024, '2025-11-01', 'Arthritis', 'Joint pain and stiffness reported. Prescribed anti-inflammatory meds.'),
(1025, '2025-11-01', 'Stroke', 'Sudden weakness observed. Patient stabilized and referred to neurology.'),
(1026, '2025-11-02', 'Asthma', 'Mild exacerbation. Advised proper inhaler use.'),
(1027, '2025-11-02', 'Epilepsy', 'Seizure episode. Adjusted anticonvulsant dosage.'),
(1028, '2025-11-02', 'Hypertension', 'Routine check-up. Blood pressure within normal limits.'),
(1029, '2025-11-03', 'Dengue Fever', 'Platelet count monitored. Hydration therapy ongoing.'),
(1030, '2025-11-03', 'Sinusitis', 'Nasal congestion and facial pain. Prescribed nasal decongestant.'),
(1031, '2025-11-03', 'Tuberculosis', 'Positive sputum test. Started anti-TB medication.'),
(1032, '2025-11-04', 'Gout', 'Foot pain and swelling. Prescribed uric acid–lowering medication.'),
(1033, '2025-11-04', 'Pneumonia', 'Follow-up. Patient responding well to antibiotics.'),
(1034, '2025-11-05', 'Anxiety Disorder', 'Reports of panic attacks. Started cognitive behavioral therapy.'),
(1035, '2025-11-05', 'Fractured Leg', 'Surgical repair performed. Recovery in progress.'),
(1036, '2025-11-06', 'Dehydration', 'Admitted due to vomiting. IV fluids administered.'),
(1037, '2025-11-06', 'Hepatitis A', 'Jaundice observed. Advised rest and hydration.'),
(1038, '2025-11-07', 'Allergic Reaction', 'Rash after seafood consumption. Antihistamine administered.'),
(1039, '2025-11-07', 'Diabetes Mellitus', 'Routine blood sugar check. Adjusted insulin dosage.'),
(1040, '2025-11-07', 'Pneumonia', 'Recurrent infection. Further testing recommended.'),
(1041, '2025-11-08', 'Migraine', 'Recurring headaches. Prescribed migraine relief medication.'),
(1042, '2025-11-08', 'Bronchitis', 'Cough and chest discomfort. Continued medication.'),
(1043, '2025-11-09', 'Hypertension', 'Stable condition. Regular follow-up advised.'),
(1044, '2025-11-09', 'Otitis Externa', 'Outer ear infection. Ear drops prescribed.'),
(1045, '2025-11-09', 'Anemia', 'Low red blood cell count. Iron supplements prescribed.'),
(1046, '2025-11-10', 'Gastritis', 'Patient reported acid reflux. Dietary changes recommended.'),
(1047, '2025-11-10', 'Fractured Wrist', 'Minor fracture. Cast applied.'),
(1048, '2025-11-10', 'Viral Fever', 'High temperature recorded. Symptomatic treatment given.'),
(1049, '2025-11-11', 'Pneumonia', 'Mild infection detected. Antibiotic treatment started.');

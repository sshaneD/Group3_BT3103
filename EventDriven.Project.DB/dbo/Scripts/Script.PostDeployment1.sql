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

insert into [dbo].[Patient] (FirstName, LastName, Age, Gender, Diagnosis, RoomNo, GuardianName, GuardianNo) values
		('Ethan','Cruz',12,'Male','Asthma',101,'Maria Cruz','09171234567'),
('Sophia','Santos',9,'Female','Pneumonia',102,'Carlo Santos','09182345678'),
('Daniel','Reyes',15,'Male','Fracture (Arm)',103,'Liza Reyes','09293456789'),
('Mia','Torres',11,'Female','Dengue Fever',104,'Juan Torres','09304567891'),
('Liam','Mendoza',14,'Male','Appendicitis',105,'Ana Mendoza','09415678902'),
('Chloe','Ramirez',10,'Female','UTI',106,'Pedro Ramirez','09526789013'),
('Noah','Villanueva',13,'Male','Migraine',107,'Grace Villanueva','09637890124'),
('Isabella','Bautista',8,'Female','Tonsillitis',108,'Marco Bautista','09748901235'),
('Lucas','Navarro',16,'Male','Hypertension',109,'Rosa Navarro','09859012346'),
('Ava','Dela Cruz',7,'Female','Flu',110,'Jose Dela Cruz','09160123457'),
('Elijah','Ramos',12,'Male','Food Poisoning',111,'Karen Ramos','09171235678'),
('Aria','Flores',15,'Female','Diabetes Type 1',112,'Roberto Flores','09182346789'),
('Mason','Gutierrez',14,'Male','Asthma',113,'Teresa Gutierrez','09193457890'),
('Amelia','Castillo',11,'Female','Chickenpox',114,'Edgar Castillo','09204568901'),
('Benjamin','Morales',9,'Male','Allergic Rhinitis',115,'Clara Morales','09315679012'),
('Harper','Santiago',13,'Female','Anemia',116,'Ramon Santiago','09426780123'),
('James','Perez',16,'Male','Sprained Ankle',117,'Julia Perez','09537891234'),
('Emily','Lozano',10,'Female','Bronchitis',118,'Mario Lozano','09648902345'),
('Alexander','Bautista',15,'Male','Dengue Fever',119,'Cecilia Bautista','09759013456'),
('Abigail','Rivera',8,'Female','Ear Infection',120,'Hector Rivera','09860124567'),
('Michael','Jimenez',14,'Male','Fracture (Leg)',121,'Sonia Jimenez','09171235679'),
('Grace','Aguilar',12,'Female','Pneumonia',122,'Leo Aguilar','09182346780'),
('William','Fernandez',13,'Male','Viral Infection',123,'Andrea Fernandez','09193457891'),
('Ella','Salazar',7,'Female','Dehydration',124,'Carlo Salazar','09204568902'),
('Henry','Gonzales',15,'Male','Hypertension',125,'Pilar Gonzales','09315679013'),
('Scarlett','Lim',10,'Female','Skin Allergy',126,'Alvin Lim','09426780124'),
('Jacob','Cruz',11,'Male','Flu',127,'Maria Cruz','09537891235'),
('Victoria','Ramos',16,'Female','Anxiety',128,'Karen Ramos','09648902346'),
('Matthew','Reyes',12,'Male','Chickenpox',129,'Liza Reyes','09759013457'),
('Sofia','Navarro',9,'Female','Asthma',130,'Rosa Navarro','09860124568'),
('David','Santiago',14,'Male','UTI',131,'Ramon Santiago','09171235670'),
('Avery','Mendoza',13,'Female','Tonsillitis',132,'Ana Mendoza','09182346781'),
('Joseph','Villanueva',15,'Male','Diabetes Type 1',133,'Grace Villanueva','09193457892'),
('Lily','Torres',8,'Female','Flu',134,'Juan Torres','09204568903'),
('Samuel','Santos',10,'Male','Food Poisoning',135,'Carlo Santos','09315679014'),
('Natalie','Cruz',11,'Female','Anemia',136,'Maria Cruz','09426780125'),
('Anthony','Gutierrez',14,'Male','Dengue Fever',137,'Teresa Gutierrez','09537891236'),
('Zoey','Castillo',13,'Female','Migraine',138,'Edgar Castillo','09648902347'),
('Andrew','Morales',16,'Male','Bronchitis',139,'Clara Morales','09759013458'),
('Hannah','Ramos',7,'Female','Ear Infection',140,'Karen Ramos','09860124569'),
('Christopher','Reyes',12,'Male','Hypertension',141,'Liza Reyes','09171235671'),
('Layla','Navarro',9,'Female','Chickenpox',142,'Rosa Navarro','09182346782'),
('Joshua','Aguilar',15,'Male','Flu',143,'Leo Aguilar','09193457893'),
('Zoella','Santiago',8,'Female','Viral Infection',144,'Ramon Santiago','09204568904'),
('Ryan','Mendoza',14,'Male','Asthma',145,'Ana Mendoza','09315679015'),
('Penelope','Villanueva',10,'Female','Tonsillitis',146,'Grace Villanueva','09426780126'),
('Isaac','Cruz',13,'Male','Fracture (Arm)',147,'Maria Cruz','09537891237'),
('Camila','Perez',16,'Female','Diabetes Type 1',148,'Julia Perez','09648902348'),
('Oliver','Jimenez',12,'Male','Dehydration',149,'Sonia Jimenez','09759013459'),
('Aurora','Torres',11,'Female','Pneumonia',150,'Juan Torres','09860124560');


-- Insert records into Account table
INSERT INTO [dbo].[Account] (ClientId, Balance, ModifiedDate)
VALUES 
(1, 1000.00, GETDATE()),
(2, 2500.50, GETDATE()),
(3, 500.75, GETDATE()),
(4, 3000.00, GETDATE()),
(5, 750.25, GETDATE()),
(6, 1200.00, GETDATE()),
(7, 2000.00, GETDATE()),
(8, 1800.75, GETDATE()),
(9, 150.00, GETDATE()),
(10, 5000.00, GETDATE());



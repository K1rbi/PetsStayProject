
SET IDENTITY_INSERT [dbo].[tblCustomers] ON
INSERT INTO [dbo].[tblCustomers] ([Id],[Name],[Phone],[Email],[Notes]) Values(0,'Steve','0277971641','maron@fakemail.com','blank') 
INSERT INTO [dbo].[tblCustomers] ([Id],[Name],[Phone],[Email],[Notes]) Values(1,  'Fey',  '0277971642',  'fey@notreal.co.nz',  'blank')
INSERT INTO [dbo].[tblCustomers] ([Id],[Name],[Phone],[Email],[Notes]) Values(2,  'Gai',  '022222222',  'sumgai@gmail.ca',  'Repeat customer')
INSERT INTO [dbo].[tblCustomers] ([Id],[Name],[Phone],[Email],[Notes]) Values(3,  'Connolly', '0277971643',  'Connolly@pretendmail.co.nz',  'may have early pick up')
INSERT INTO [dbo].[tblCustomers] ([Id],[Name],[Phone],[Email],[Notes]) Values(4,  'Rock',  '0277971644',  'hard@pretendmail.co.nz',  'Casual')
SET IDENTITY_INSERT [dbo].[tblCustomers] OFF

SET IDENTITY_INSERT [dbo].[tblPets] ON
INSERT INTO [dbo].[tblPets] ([ID],[Name],[Breed],[Location],[Age],[Owner],[Notes],[Entry],[Exit]) Values(0,'Jeff','Armant','A12',7,0,'blank','2021-11-19','2021-11-22')
INSERT INTO [dbo].[tblPets] ([ID],[Name],[Breed],[Location],[Age],[Owner],[Notes],[Entry],[Exit]) Values(1,'Geef','Barbet','B03',5,1,'blank','2021-11-11','2021-11-18')
INSERT INTO [dbo].[tblPets] ([ID],[Name],[Breed],[Location],[Age],[Owner],[Notes],[Entry],[Exit]) Values(2,'Remi','Billy','A11',3,1,'blank','2021-11-11','2021-11-18')
INSERT INTO [dbo].[tblPets] ([ID],[Name],[Breed],[Location],[Age],[Owner],[Notes],[Entry],[Exit]) Values(3,'Abby','Dunker','B10',4,2,'blank','2021-10-20','2021-10-27')
INSERT INTO [dbo].[tblPets] ([ID],[Name],[Breed],[Location],[Age],[Owner],[Notes],[Entry],[Exit]) Values(4,'Bean','Kishu','C02',5,3,'blank','2021-11-22','2021-11-29')
INSERT INTO [dbo].[tblPets] ([ID],[Name],[Breed],[Location],[Age],[Owner],[Notes],[Entry],[Exit]) Values(5,'Buffy','Maltese','C06',3,4,'blank','2021-11-18','2021-11-22')
SET IDENTITY_INSERT [dbo].[tblPets] OFF

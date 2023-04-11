/* Check if database already exists and delete it if it does exist*/
IF EXISTS(SELECT 1 FROM master.dbo.sysdatabases WHERE name = 'cs6232-f2f') 
BEGIN
DROP DATABASE "cs6232-f2f"
END
GO

CREATE DATABASE "cs6232-f2f"
GO

USE [cs6232-f2f]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[PersonalDetails](
	[pdID] [int] IDENTITY(1,1) NOT NULL,
	[firstName] [varchar](50) NOT NULL,
	[lastName] [varchar](50) NOT NULL,
	[dateOfBirth] [datetime] NOT NULL,
	[gender] [varchar](10) NOT NULL,
	[streetAddress] [varchar](50) NOT NULL,
	[city] [varchar](50) NOT NULL,
	[state] [varchar](50) NOT NULL,
	[zipCode] [varchar](50) NOT NULL,
	[country] [varchar](50) NOT NULL,
	[phoneNumber] [char](10) NOT NULL,
 CONSTRAINT [PK_PersonalDetails] PRIMARY KEY 
(
	[pdID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Nurse](
	[nurseID] [int] IDENTITY(1,1) NOT NULL,
	[pdID] [int] NOT NULL,
 CONSTRAINT [PK_Nurse] PRIMARY KEY 
(
	[nurseID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Patient](
	[patientID] [int] IDENTITY(1,1) NOT NULL,
	[pdID] [int] NOT NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY 
(
	[patientID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Doctor](
	[doctorID] [int] IDENTITY(1,1) NOT NULL,
	[pdID] [int] NOT NULL,
 CONSTRAINT [PK_Doctor] PRIMARY KEY 
(
	[doctorID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[DoctorSpecialities](
	[doctorID] [int] NOT NULL,
	[specialityID] [int] NOT NULL,
 CONSTRAINT [PK_DoctorSpecialities] PRIMARY KEY 
(
	[doctorID] ASC,
	[specialityID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Specialities](
	[specialityID] [int] IDENTITY(1,1) NOT NULL,
	[speciality] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Specialities] PRIMARY KEY 
(
	[specialityID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Appointment](
	[appointmentID] [int] IDENTITY(1,1) NOT NULL,
	[patientID] [int] NOT NULL,
	[doctorID] [int] NOT NULL,
	[schedulateDate] [datetime] NOT NULL,
	[reason] [varchar](255)
 CONSTRAINT [PK_Appointment] PRIMARY KEY 
(
	[appointmentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Visit](
	[visitID] [int] IDENTITY(1,1) NOT NULL,
	[appointmentID] [int] NOT NULL,
	[nurseID] [int] NOT NULL,
	[height] [varchar](50),
	[weight] [varchar](50),
	[systolicBP] [int],
	[diastolic] [int],
	[bodyTemperature] [decimal](4, 1),
	[pulse] [int],
	[symptoms] [varchar](255),
	[initialDiagnosis] [varchar](255),
	[finalDiagnosis] [varchar](255),
 CONSTRAINT [PK_Visit] PRIMARY KEY 
(
	[visitID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Tests](
	[testID] [int] IDENTITY(1,1) NOT NULL,
	[testName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Tests] PRIMARY KEY 
(
	[testID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[PatientTests](
	[testID] [int] NOT NULL,
	[visitID] [int] NOT NULL,
	[result] [varchar](255),
	[performedDate] [datetime],
	[abnormal] [varchar](50),
 CONSTRAINT [PK_PatientTests] PRIMARY KEY 
(
	[testID] ASC,
	[visitID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Users](
	[userName] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[pdID] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY 
(
	[userName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[States](
	[stateName] [varchar](50) NOT NULL,
	[stateCode] [varchar](50) NOT NULL,
 CONSTRAINT [PK_States] PRIMARY KEY 
(
	[stateCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Nurse_PersonalDetails]') AND parent_object_id = OBJECT_ID(N'[dbo].[Nurse]'))
ALTER TABLE [dbo].[PersonalDetails]  WITH CHECK ADD  CONSTRAINT [FK_Nurse_PersonalDetails] FOREIGN KEY([pdID])
REFERENCES [dbo].[PersonalDetails] (pdID)
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Nurse_PersonalDetails]') AND parent_object_id = OBJECT_ID(N'[dbo].[Nurse]'))
ALTER TABLE [dbo].[Nurse] CHECK CONSTRAINT [FK_Nurse_PersonalDetails]
GO

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Doctor_PersonalDetails]') AND parent_object_id = OBJECT_ID(N'[dbo].[Doctor]'))
ALTER TABLE [dbo].[PersonalDetails]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_PersonalDetails] FOREIGN KEY([pdID])
REFERENCES [dbo].[PersonalDetails] (pdID)
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Doctor_PersonalDetails]') AND parent_object_id = OBJECT_ID(N'[dbo].[Doctor]'))
ALTER TABLE [dbo].[Doctor] CHECK CONSTRAINT [FK_Doctor_PersonalDetails]
GO

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Patient_PersonalDetails]') AND parent_object_id = OBJECT_ID(N'[dbo].[Patient]'))
ALTER TABLE [dbo].[PersonalDetails]  WITH CHECK ADD  CONSTRAINT [FK_Patient_PersonalDetails] FOREIGN KEY([pdID])
REFERENCES [dbo].[PersonalDetails] (pdID)
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Patient_PersonalDetails]') AND parent_object_id = OBJECT_ID(N'[dbo].[Patient]'))
ALTER TABLE [dbo].[Patient] CHECK CONSTRAINT [FK_Patient_PersonalDetails]
GO

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DoctorSpecialities_Doctor]') AND parent_object_id = OBJECT_ID(N'[dbo].[DoctorSpecialities]'))
ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD  CONSTRAINT [FK_DoctorSpecialities_Doctor] FOREIGN KEY([doctorID])
REFERENCES [dbo].[Doctor] (doctorID)
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DoctorSpecialities_Doctor]') AND parent_object_id = OBJECT_ID(N'[dbo].[DoctorSpecialities]'))
ALTER TABLE [dbo].[DoctorSpecialities] CHECK CONSTRAINT [FK_DoctorSpecialities_Doctor]
GO

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DoctorSpecialities_Specialities]') AND parent_object_id = OBJECT_ID(N'[dbo].[DoctorSpecialities]'))
ALTER TABLE [dbo].[Specialities]  WITH CHECK ADD  CONSTRAINT [FK_DoctorSpecialities_Specialities] FOREIGN KEY([specialityID])
REFERENCES [dbo].[Specialities] (specialityID)
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DoctorSpecialities_Specialities]') AND parent_object_id = OBJECT_ID(N'[dbo].[DoctorSpecialities]'))
ALTER TABLE [dbo].[DoctorSpecialities] CHECK CONSTRAINT [FK_DoctorSpecialities_Specialities]
GO

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Appointment_Patient]') AND parent_object_id = OBJECT_ID(N'[dbo].[Appointment]'))
ALTER TABLE [dbo].[Patient]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Patient] FOREIGN KEY([patientID])
REFERENCES [dbo].[Patient] (patientID)
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Appointment_Patient]') AND parent_object_id = OBJECT_ID(N'[dbo].[Appointment]'))
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Patient]
GO

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Appointment_Doctor]') AND parent_object_id = OBJECT_ID(N'[dbo].[Appointment]'))
ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Doctor] FOREIGN KEY([doctorID])
REFERENCES [dbo].[Doctor] (doctorID)
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Appointment_Doctor]') AND parent_object_id = OBJECT_ID(N'[dbo].[Appointment]'))
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Doctor]
GO

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Visit_Nurse]') AND parent_object_id = OBJECT_ID(N'[dbo].[Visit]'))
ALTER TABLE [dbo].[Nurse]  WITH CHECK ADD  CONSTRAINT [FK_Visit_Nurse] FOREIGN KEY([nurseID])
REFERENCES [dbo].[Nurse] (nurseID)
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Visit_Nurse]') AND parent_object_id = OBJECT_ID(N'[dbo].[Visit]'))
ALTER TABLE [dbo].[Visit] CHECK CONSTRAINT [FK_Visit_Nurse]
GO

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Visit_Appointment]') AND parent_object_id = OBJECT_ID(N'[dbo].[Visit]'))
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Visit_Doctor] FOREIGN KEY([appointmentID])
REFERENCES [dbo].[Appointment] (appointmentID)
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Visit_Appointment]') AND parent_object_id = OBJECT_ID(N'[dbo].[Visit]'))
ALTER TABLE [dbo].[Visit] CHECK CONSTRAINT [FK_Visit_Appointment]
GO

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PatientTests_Visit]') AND parent_object_id = OBJECT_ID(N'[dbo].[PatientTests]'))
ALTER TABLE [dbo].[Visit]  WITH CHECK ADD  CONSTRAINT [FK_PatientTests_Visit] FOREIGN KEY([visitID])
REFERENCES [dbo].[Visit] (visitID)
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PatientTests_Visit]') AND parent_object_id = OBJECT_ID(N'[dbo].[PatientTests]'))
ALTER TABLE [dbo].[PatientTests] CHECK CONSTRAINT [FK_PatientTests_Visit]
GO

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PatientTests_Tests]') AND parent_object_id = OBJECT_ID(N'[dbo].[PatientTests]'))
ALTER TABLE [dbo].[Tests]  WITH CHECK ADD  CONSTRAINT [FK_PatientTests_Tests] FOREIGN KEY([testID])
REFERENCES [dbo].[Tests] (testID)
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PatientTests_Tests]') AND parent_object_id = OBJECT_ID(N'[dbo].[PatientTests]'))
ALTER TABLE [dbo].[PatientTests] CHECK CONSTRAINT [FK_PatientTests_Tests]
GO

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Users_PersonalDetails]') AND parent_object_id = OBJECT_ID(N'[dbo].[Users]'))
ALTER TABLE [dbo].[PersonalDetails]  WITH CHECK ADD  CONSTRAINT [FK_Users_PersonalDetails] FOREIGN KEY([pdID])
REFERENCES [dbo].[PersonalDetails] (pdID)
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Users_PersonalDetails]') AND parent_object_id = OBJECT_ID(N'[dbo].[Users]'))
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_PersonalDetails]
GO



SET ANSI_PADDING OFF
GO
INSERT [dbo].[PersonalDetails] ([pdID], [firstName], [lastName], [dateOfBirth], [gender], [streetAddress], [city], [state], [zipCode], [country], [phoneNumber]) VALUES (1, 'Tom', 'Brown', '12-6-2000', 'Male', '245-Beverely Hills', 'Newnan', 'Georgia', '30117', 'United States', '1112223344') 
INSERT [dbo].[PersonalDetails] ([pdID], [firstName], [lastName], [dateOfBirth], [gender], [streetAddress], [city], [state], [zipCode], [country], [phoneNumber]) VALUES (2, 'Milly', 'Jane', '1-5-2001', 'Female', '245-New Hills', 'Carrollton', 'Georgia', '30119', 'United States', '1233453344')
INSERT [dbo].[PersonalDetails] ([pdID], [firstName], [lastName], [dateOfBirth], [gender], [streetAddress], [city], [state], [zipCode], [country], [phoneNumber]) VALUES (3, 'Steve', 'Bernard', '12-12-1988', 'Male', '24-Town Hills', 'Brewman', 'Tennesse', '30115', 'United States', '9987654321') 
INSERT [dbo].[PersonalDetails] ([pdID], [firstName], [lastName], [dateOfBirth], [gender], [streetAddress], [city], [state], [zipCode], [country], [phoneNumber]) VALUES (4, 'Tim', 'Cook', '9-5-1995', 'Male', '9-New Hills', 'Cary', 'North Carolina', '30224', 'United States', '8529637417')
INSERT [dbo].[PersonalDetails] ([pdID], [firstName], [lastName], [dateOfBirth], [gender], [streetAddress], [city], [state], [zipCode], [country], [phoneNumber]) VALUES (5, 'Jack', 'Sparrow', '1-7-1992', 'Male', '23-North Street', 'Colombia', 'Florida', '30414', 'United States', '7418529631') 
INSERT [dbo].[PersonalDetails] ([pdID], [firstName], [lastName], [dateOfBirth], [gender], [streetAddress], [city], [state], [zipCode], [country], [phoneNumber]) VALUES (6, 'Heiley', 'Jr', '11-5-1991', 'Female', '2-Up Mountain Parkway', 'Orlando', 'Florida', '30329', 'United States', '3216549874')
INSERT [dbo].[PersonalDetails] ([pdID], [firstName], [lastName], [dateOfBirth], [gender], [streetAddress], [city], [state], [zipCode], [country], [phoneNumber]) VALUES (7, 'Yasmin', 'Habibi', '9-2-1995', 'Female', '2564-Brewman Road', 'Douglasville', 'Georgia', '30455', 'United States', '9874561234') 
INSERT [dbo].[PersonalDetails] ([pdID], [firstName], [lastName], [dateOfBirth], [gender], [streetAddress], [city], [state], [zipCode], [country], [phoneNumber]) VALUES (8, 'Mike', 'John', '9-8-1985', 'Male', '65-South Street', 'Greenland', 'South Carolina', '30824', 'United States', '6541239877')

SET ANSI_PADDING OFF
GO
INSERT [dbo].[Nurse] ([nurseID], [pdID]) VALUES (1, 2)
INSERT [dbo].[Nurse] ([nurseID], [pdID]) VALUES (2, 6)
INSERT [dbo].[Nurse] ([nurseID], [pdID]) VALUES (3, 8)

SET ANSI_PADDING OFF
GO
INSERT [dbo].[Patient] ([patientID], [pdID]) VALUES (1, 1)
INSERT [dbo].[Patient] ([patientID], [pdID]) VALUES (2, 5)
INSERT [dbo].[Patient] ([patientID], [pdID]) VALUES (3, 7)

SET ANSI_PADDING OFF
GO
INSERT [dbo].[Doctor] ([doctorID], [pdID]) VALUES (1, 3)
INSERT [dbo].[Doctor] ([doctorID], [pdID]) VALUES (2, 4)

SET ANSI_PADDING OFF
GO
INSERT [dbo].[Specialities] ([specialityID], [speciality]) VALUES (1, 'General Surgery')
INSERT [dbo].[Specialities] ([specialityID], [speciality]) VALUES (2, 'Primary Care')

SET ANSI_PADDING OFF
GO
INSERT [dbo].[DoctorSpecialities] ([doctorID], [specialityID]) VALUES (1, 1)
INSERT [dbo].[DoctorSpecialities] ([doctorID], [specialityID]) VALUES (1, 2)
INSERT [dbo].[DoctorSpecialities] ([doctorID], [specialityID]) VALUES (2, 2)


SET ANSI_PADDING OFF
GO
INSERT [dbo].[Appointment] ([appointmentID], [doctorID], [patientID], [schedulateDate], [reason]) VALUES (1, 3, 2, '2023-04-14', 'Mild Surgery for the body')
INSERT [dbo].[Appointment] ([appointmentID], [doctorID], [patientID], [schedulateDate], [reason]) VALUES (2, 4, 1, '2023-04-13', 'General health check up')


SET ANSI_PADDING OFF
GO
INSERT [dbo].[Tests] ([testID], [testName]) VALUES (1, 'Xray')
INSERT [dbo].[Tests] ([testID], [testName]) VALUES (2, 'Blood sugar test')


SET ANSI_PADDING OFF
GO
INSERT [dbo].[Users] ([userName], [password], [pdID]) VALUES ('test', 'test1234', 2)
INSERT [dbo].[Users] ([userName], [password], [pdID]) VALUES ('user', 'user1234', 6)


SET ANSI_PADDING OFF
GO
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Alabama', 'AL')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Alaska', 'AK')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Arizona', 'AZ')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Arkansas', 'AR')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('California', 'CA')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Colorado', 'CO')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Connecticut', 'CT')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Delaware', 'DE')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('District of Columbia', 'DC')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Florida', 'FL')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Georgia', 'GA')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Hawaii', 'HI')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Idaho', 'ID')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Illinois', 'IL')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Indiana', 'IN')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Iowa', 'IA')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Kansas', 'KS')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Kentucky', 'KY')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Louisiana', 'LA')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Maine', 'ME')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Maryland', 'MD')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Massachusetts', 'MA')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Michigan', 'MI')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Minnesota', 'MN')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Mississippi', 'MS')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Missouri', 'MO')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Montana', 'MT')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Nebraska', 'NE')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Nevada', 'NV')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('New Hampshire', 'NH')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('New Jersey', 'NJ')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('New Mexico', 'NM')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('New York', 'NY')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('North Carolina', 'NC')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('North Dakota', 'ND')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Ohio', 'OH')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Oklahoma', 'OK')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Oregon', 'OR')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Pennsylvania', 'PA')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Puerto Rico', 'PR')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Rhode Island', 'RI')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('South Carolina', 'SC')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('South Dakota', 'SD')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Tennessee', 'TN')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Texas', 'TX')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Utah', 'UT')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Vermont', 'VT')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Virginia', 'VA')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Virgin Islands', 'VI')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Washington', 'WA')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('West Virginia', 'WV')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Wisconsin', 'WI')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES ('Wyoming', 'WY')


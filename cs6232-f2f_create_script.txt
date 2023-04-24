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
	[dateOfBirth] [date] NOT NULL,
	[gender] [varchar](20) NOT NULL,
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
	[scheduledDate] [datetime] NOT NULL,
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
	[height] [decimal](5, 2),
	[weight] [decimal](5, 2),
	[systolicBP] [int],
	[diastolicBP] [int],
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

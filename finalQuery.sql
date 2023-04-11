USE [master]
GO
/****** Object:  Database [cs6232-f2f]    Script Date: 4/11/2023 12:15:23 AM ******/
CREATE DATABASE [cs6232-f2f]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'cs6232-f2f', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\cs6232-f2f.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'cs6232-f2f_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\cs6232-f2f_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [cs6232-f2f] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [cs6232-f2f].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [cs6232-f2f] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [cs6232-f2f] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [cs6232-f2f] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [cs6232-f2f] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [cs6232-f2f] SET ARITHABORT OFF 
GO
ALTER DATABASE [cs6232-f2f] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [cs6232-f2f] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [cs6232-f2f] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [cs6232-f2f] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [cs6232-f2f] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [cs6232-f2f] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [cs6232-f2f] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [cs6232-f2f] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [cs6232-f2f] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [cs6232-f2f] SET  ENABLE_BROKER 
GO
ALTER DATABASE [cs6232-f2f] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [cs6232-f2f] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [cs6232-f2f] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [cs6232-f2f] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [cs6232-f2f] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [cs6232-f2f] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [cs6232-f2f] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [cs6232-f2f] SET RECOVERY FULL 
GO
ALTER DATABASE [cs6232-f2f] SET  MULTI_USER 
GO
ALTER DATABASE [cs6232-f2f] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [cs6232-f2f] SET DB_CHAINING OFF 
GO
ALTER DATABASE [cs6232-f2f] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [cs6232-f2f] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [cs6232-f2f] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [cs6232-f2f] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'cs6232-f2f', N'ON'
GO
ALTER DATABASE [cs6232-f2f] SET QUERY_STORE = OFF
GO
USE [cs6232-f2f]
GO
/****** Object:  Table [dbo].[Appointment]    Script Date: 4/11/2023 12:15:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointment](
	[appointmentID] [int] NOT NULL,
	[patientID] [int] NOT NULL,
	[doctorID] [int] NOT NULL,
	[schedulateDate] [datetime] NOT NULL,
	[reason] [varchar](255) NULL,
 CONSTRAINT [PK_Appointment] PRIMARY KEY CLUSTERED 
(
	[appointmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 4/11/2023 12:15:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor](
	[doctorID] [int] NOT NULL,
	[pdID] [int] NOT NULL,
 CONSTRAINT [PK_Doctor] PRIMARY KEY CLUSTERED 
(
	[doctorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoctorSpecialities]    Script Date: 4/11/2023 12:15:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoctorSpecialities](
	[doctorID] [int] NOT NULL,
	[specialityID] [int] NOT NULL,
 CONSTRAINT [PK_DoctorSpecialities] PRIMARY KEY CLUSTERED 
(
	[doctorID] ASC,
	[specialityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nurse]    Script Date: 4/11/2023 12:15:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nurse](
	[nurseID] [int] NOT NULL,
	[pdID] [int] NOT NULL,
 CONSTRAINT [PK_Nurse] PRIMARY KEY CLUSTERED 
(
	[nurseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 4/11/2023 12:15:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[patientID] [int] NOT NULL,
	[pdID] [int] NOT NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[patientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PatientTests]    Script Date: 4/11/2023 12:15:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PatientTests](
	[testID] [int] NOT NULL,
	[visitID] [int] NOT NULL,
	[result] [varchar](255) NULL,
	[performedDate] [datetime] NULL,
	[abnormal] [varchar](50) NULL,
 CONSTRAINT [PK_PatientTests] PRIMARY KEY CLUSTERED 
(
	[testID] ASC,
	[visitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonalDetails]    Script Date: 4/11/2023 12:15:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonalDetails](
	[pdID] [int] NOT NULL,
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
 CONSTRAINT [PK_PersonalDetails] PRIMARY KEY CLUSTERED 
(
	[pdID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Specialities]    Script Date: 4/11/2023 12:15:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Specialities](
	[specialityID] [int] NOT NULL,
	[speciality] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Specialities] PRIMARY KEY CLUSTERED 
(
	[specialityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[States]    Script Date: 4/11/2023 12:15:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[States](
	[stateName] [varchar](50) NOT NULL,
	[stateCode] [varchar](50) NOT NULL,
 CONSTRAINT [PK_States] PRIMARY KEY CLUSTERED 
(
	[stateCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tests]    Script Date: 4/11/2023 12:15:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tests](
	[testID] [int] NOT NULL,
	[testName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Tests] PRIMARY KEY CLUSTERED 
(
	[testID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 4/11/2023 12:15:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[userName] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[pdID] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[userName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Visit]    Script Date: 4/11/2023 12:15:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Visit](
	[visitID] [int] NOT NULL,
	[appointmentID] [int] NOT NULL,
	[nurseID] [int] NOT NULL,
	[height] [varchar](50) NULL,
	[weight] [varchar](50) NULL,
	[systolicBP] [int] NULL,
	[diastolic] [int] NULL,
	[bodyTemperature] [decimal](4, 1) NULL,
	[pulse] [int] NULL,
	[symptoms] [varchar](255) NULL,
	[initialDiagnosis] [varchar](255) NULL,
	[finalDiagnosis] [varchar](255) NULL,
 CONSTRAINT [PK_Visit] PRIMARY KEY CLUSTERED 
(
	[visitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [schedulateDate], [reason]) VALUES (1, 2, 3, CAST(N'2023-04-14T00:00:00.000' AS DateTime), N'Mild Surgery for the body')
INSERT [dbo].[Appointment] ([appointmentID], [patientID], [doctorID], [schedulateDate], [reason]) VALUES (2, 1, 4, CAST(N'2023-04-13T00:00:00.000' AS DateTime), N'General health check up')
GO
INSERT [dbo].[Doctor] ([doctorID], [pdID]) VALUES (1, 3)
INSERT [dbo].[Doctor] ([doctorID], [pdID]) VALUES (2, 4)
GO
INSERT [dbo].[DoctorSpecialities] ([doctorID], [specialityID]) VALUES (1, 1)
INSERT [dbo].[DoctorSpecialities] ([doctorID], [specialityID]) VALUES (1, 2)
INSERT [dbo].[DoctorSpecialities] ([doctorID], [specialityID]) VALUES (2, 2)
GO
INSERT [dbo].[Nurse] ([nurseID], [pdID]) VALUES (1, 2)
INSERT [dbo].[Nurse] ([nurseID], [pdID]) VALUES (2, 6)
INSERT [dbo].[Nurse] ([nurseID], [pdID]) VALUES (3, 8)
GO
INSERT [dbo].[Patient] ([patientID], [pdID]) VALUES (1, 1)
INSERT [dbo].[Patient] ([patientID], [pdID]) VALUES (2, 5)
INSERT [dbo].[Patient] ([patientID], [pdID]) VALUES (3, 7)
GO
INSERT [dbo].[PersonalDetails] ([pdID], [firstName], [lastName], [dateOfBirth], [gender], [streetAddress], [city], [state], [zipCode], [country], [phoneNumber]) VALUES (1, N'Tom', N'Brown', CAST(N'2000-12-06T00:00:00.000' AS DateTime), N'Male', N'245-Beverely Hills', N'Newnan', N'Georgia', N'30117', N'United States', N'1112223344')
INSERT [dbo].[PersonalDetails] ([pdID], [firstName], [lastName], [dateOfBirth], [gender], [streetAddress], [city], [state], [zipCode], [country], [phoneNumber]) VALUES (2, N'Milly', N'Jane', CAST(N'2001-01-05T00:00:00.000' AS DateTime), N'Female', N'245-New Hills', N'Carrollton', N'Georgia', N'30119', N'United States', N'1233453344')
INSERT [dbo].[PersonalDetails] ([pdID], [firstName], [lastName], [dateOfBirth], [gender], [streetAddress], [city], [state], [zipCode], [country], [phoneNumber]) VALUES (3, N'Steve', N'Bernard', CAST(N'1988-12-12T00:00:00.000' AS DateTime), N'Male', N'24-Town Hills', N'Brewman', N'Tennesse', N'30115', N'United States', N'9987654321')
INSERT [dbo].[PersonalDetails] ([pdID], [firstName], [lastName], [dateOfBirth], [gender], [streetAddress], [city], [state], [zipCode], [country], [phoneNumber]) VALUES (4, N'Tim', N'Cook', CAST(N'1995-09-05T00:00:00.000' AS DateTime), N'Male', N'9-New Hills', N'Cary', N'North Carolina', N'30224', N'United States', N'8529637417')
INSERT [dbo].[PersonalDetails] ([pdID], [firstName], [lastName], [dateOfBirth], [gender], [streetAddress], [city], [state], [zipCode], [country], [phoneNumber]) VALUES (5, N'Jack', N'Sparrow', CAST(N'1992-01-07T00:00:00.000' AS DateTime), N'Male', N'23-North Street', N'Colombia', N'Florida', N'30414', N'United States', N'7418529631')
INSERT [dbo].[PersonalDetails] ([pdID], [firstName], [lastName], [dateOfBirth], [gender], [streetAddress], [city], [state], [zipCode], [country], [phoneNumber]) VALUES (6, N'Heiley', N'Jr', CAST(N'1991-11-05T00:00:00.000' AS DateTime), N'Female', N'2-Up Mountain Parkway', N'Orlando', N'Florida', N'30329', N'United States', N'3216549874')
INSERT [dbo].[PersonalDetails] ([pdID], [firstName], [lastName], [dateOfBirth], [gender], [streetAddress], [city], [state], [zipCode], [country], [phoneNumber]) VALUES (7, N'Yasmin', N'Habibi', CAST(N'1995-09-02T00:00:00.000' AS DateTime), N'Female', N'2564-Brewman Road', N'Douglasville', N'Georgia', N'30455', N'United States', N'9874561234')
INSERT [dbo].[PersonalDetails] ([pdID], [firstName], [lastName], [dateOfBirth], [gender], [streetAddress], [city], [state], [zipCode], [country], [phoneNumber]) VALUES (8, N'Mike', N'John', CAST(N'1985-09-08T00:00:00.000' AS DateTime), N'Male', N'65-South Street', N'Greenland', N'South Carolina', N'30824', N'United States', N'6541239877')
GO
INSERT [dbo].[Specialities] ([specialityID], [speciality]) VALUES (1, N'General Surgery')
INSERT [dbo].[Specialities] ([specialityID], [speciality]) VALUES (2, N'Primary Care')
GO
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Alaska', N'AK')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Alabama', N'AL')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Arkansas', N'AR')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Arizona', N'AZ')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'California', N'CA')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Colorado', N'CO')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Connecticut', N'CT')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'District of Columbia', N'DC')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Delaware', N'DE')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Florida', N'FL')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Georgia', N'GA')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Hawaii', N'HI')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Iowa', N'IA')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Idaho', N'ID')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Illinois', N'IL')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Indiana', N'IN')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Kansas', N'KS')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Kentucky', N'KY')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Louisiana', N'LA')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Massachusetts', N'MA')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Maryland', N'MD')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Maine', N'ME')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Michigan', N'MI')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Minnesota', N'MN')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Missouri', N'MO')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Mississippi', N'MS')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Montana', N'MT')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'North Carolina', N'NC')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'North Dakota', N'ND')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Nebraska', N'NE')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'New Hampshire', N'NH')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'New Jersey', N'NJ')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'New Mexico', N'NM')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Nevada', N'NV')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'New York', N'NY')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Ohio', N'OH')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Oklahoma', N'OK')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Oregon', N'OR')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Pennsylvania', N'PA')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Puerto Rico', N'PR')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Rhode Island', N'RI')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'South Carolina', N'SC')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'South Dakota', N'SD')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Tennessee', N'TN')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Texas', N'TX')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Utah', N'UT')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Virginia', N'VA')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Virgin Islands', N'VI')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Vermont', N'VT')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Washington', N'WA')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Wisconsin', N'WI')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'West Virginia', N'WV')
INSERT [dbo].[States] ([stateName], [stateCode]) VALUES (N'Wyoming', N'WY')
GO
INSERT [dbo].[Tests] ([testID], [testName]) VALUES (1, N'Xray')
INSERT [dbo].[Tests] ([testID], [testName]) VALUES (2, N'Blood sugar test')
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Visit_Doctor] FOREIGN KEY([appointmentID])
REFERENCES [dbo].[Appointment] ([appointmentID])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Visit_Doctor]
GO
ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Doctor] FOREIGN KEY([doctorID])
REFERENCES [dbo].[Doctor] ([doctorID])
GO
ALTER TABLE [dbo].[Doctor] CHECK CONSTRAINT [FK_Appointment_Doctor]
GO
ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD  CONSTRAINT [FK_DoctorSpecialities_Doctor] FOREIGN KEY([doctorID])
REFERENCES [dbo].[Doctor] ([doctorID])
GO
ALTER TABLE [dbo].[Doctor] CHECK CONSTRAINT [FK_DoctorSpecialities_Doctor]
GO
ALTER TABLE [dbo].[Nurse]  WITH CHECK ADD  CONSTRAINT [FK_Visit_Nurse] FOREIGN KEY([nurseID])
REFERENCES [dbo].[Nurse] ([nurseID])
GO
ALTER TABLE [dbo].[Nurse] CHECK CONSTRAINT [FK_Visit_Nurse]
GO
ALTER TABLE [dbo].[Patient]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Patient] FOREIGN KEY([patientID])
REFERENCES [dbo].[Patient] ([patientID])
GO
ALTER TABLE [dbo].[Patient] CHECK CONSTRAINT [FK_Appointment_Patient]
GO
ALTER TABLE [dbo].[PersonalDetails]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_PersonalDetails] FOREIGN KEY([pdID])
REFERENCES [dbo].[PersonalDetails] ([pdID])
GO
ALTER TABLE [dbo].[PersonalDetails] CHECK CONSTRAINT [FK_Doctor_PersonalDetails]
GO
ALTER TABLE [dbo].[PersonalDetails]  WITH CHECK ADD  CONSTRAINT [FK_Nurse_PersonalDetails] FOREIGN KEY([pdID])
REFERENCES [dbo].[PersonalDetails] ([pdID])
GO
ALTER TABLE [dbo].[PersonalDetails] CHECK CONSTRAINT [FK_Nurse_PersonalDetails]
GO
ALTER TABLE [dbo].[PersonalDetails]  WITH CHECK ADD  CONSTRAINT [FK_Patient_PersonalDetails] FOREIGN KEY([pdID])
REFERENCES [dbo].[PersonalDetails] ([pdID])
GO
ALTER TABLE [dbo].[PersonalDetails] CHECK CONSTRAINT [FK_Patient_PersonalDetails]
GO
ALTER TABLE [dbo].[PersonalDetails]  WITH CHECK ADD  CONSTRAINT [FK_Users_PersonalDetails] FOREIGN KEY([pdID])
REFERENCES [dbo].[PersonalDetails] ([pdID])
GO
ALTER TABLE [dbo].[PersonalDetails] CHECK CONSTRAINT [FK_Users_PersonalDetails]
GO
ALTER TABLE [dbo].[Specialities]  WITH CHECK ADD  CONSTRAINT [FK_DoctorSpecialities_Specialities] FOREIGN KEY([specialityID])
REFERENCES [dbo].[Specialities] ([specialityID])
GO
ALTER TABLE [dbo].[Specialities] CHECK CONSTRAINT [FK_DoctorSpecialities_Specialities]
GO
ALTER TABLE [dbo].[Tests]  WITH CHECK ADD  CONSTRAINT [FK_PatientTests_Tests] FOREIGN KEY([testID])
REFERENCES [dbo].[Tests] ([testID])
GO
ALTER TABLE [dbo].[Tests] CHECK CONSTRAINT [FK_PatientTests_Tests]
GO
ALTER TABLE [dbo].[Visit]  WITH CHECK ADD  CONSTRAINT [FK_PatientTests_Visit] FOREIGN KEY([visitID])
REFERENCES [dbo].[Visit] ([visitID])
GO
ALTER TABLE [dbo].[Visit] CHECK CONSTRAINT [FK_PatientTests_Visit]
GO
USE [master]
GO
ALTER DATABASE [cs6232-f2f] SET  READ_WRITE 
GO

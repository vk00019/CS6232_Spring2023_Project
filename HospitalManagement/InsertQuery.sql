
SET ANSI_PADDING OFF
GO
INSERT [dbo].[PersonalDetails] ([pdID], [firstName], [lastName], [dateOfBirth], [streetAddress], [city], [state], [zipCode], [country], [phoneNumber]) VALUES (1, 'Tom', 'Brown', '12-6-2000', '245-Beverely Hills', 'Newnan', 'Georgia', '30117', 'United States', '1112223344') 
INSERT [dbo].[PersonalDetails] ([pdID], [firstName], [lastName], [dateOfBirth], [streetAddress], [city], [state], [zipCode], [country], [phoneNumber]) VALUES (2, 'Milly', 'Jane', '1-5-2001', '245-New Hills', 'Carrollton', 'Georgia', '30119', 'United States', '1233453344')
INSERT [dbo].[PersonalDetails] ([pdID], [firstName], [lastName], [dateOfBirth], [streetAddress], [city], [state], [zipCode], [country], [phoneNumber]) VALUES (3, 'Steve', 'Bernard', '12-12-1988', '24-Town Hills', 'Brewman', 'Tennesse', '30115', 'United States', '9987654321') 
INSERT [dbo].[PersonalDetails] ([pdID], [firstName], [lastName], [dateOfBirth], [streetAddress], [city], [state], [zipCode], [country], [phoneNumber]) VALUES (4, 'Tim', 'Cook', '9-5-1995', '9-New Hills', 'Cary', 'North Carolina', '30224', 'United States', '8529637417')
INSERT [dbo].[PersonalDetails] ([pdID], [firstName], [lastName], [dateOfBirth], [streetAddress], [city], [state], [zipCode], [country], [phoneNumber]) VALUES (5, 'Jack', 'Sparrow', '1-7-1992', '23-North Street', 'Colombia', 'Florida', '30414', 'United States', '7418529631') 
INSERT [dbo].[PersonalDetails] ([pdID], [firstName], [lastName], [dateOfBirth], [streetAddress], [city], [state], [zipCode], [country], [phoneNumber]) VALUES (6, 'Heiley', 'Jr', '11-5-1991', '2-Up Mountain Parkway', 'Orlando', 'Florida', '30329', 'United States', '3216549874')
INSERT [dbo].[PersonalDetails] ([pdID], [firstName], [lastName], [dateOfBirth], [streetAddress], [city], [state], [zipCode], [country], [phoneNumber]) VALUES (7, 'Yasmin', 'Habibi', '9-2-1995', '2564-Brewman Road', 'Douglasville', 'Georgia', '30455', 'United States', '9874561234') 
INSERT [dbo].[PersonalDetails] ([pdID], [firstName], [lastName], [dateOfBirth], [streetAddress], [city], [state], [zipCode], [country], [phoneNumber]) VALUES (8, 'Mike', 'John', '9-8-1985', '65-South Street', 'Greenland', 'South Carolina', '30824', 'United States', '6541239877')

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
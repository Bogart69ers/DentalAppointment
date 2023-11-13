CREATE DATABASE AppointmentSys

Use AppointmentSys

create table Patient (
	PatientID int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(255),
	ContactInfo varchar(255),
	InsuranceInfo Text
	);

create table Dentist (
	DentistID int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(255),
	Specialization varchar(255),
	ContactInfo varchar(255) 
	);

create table Appointment (
	AppointmentID int IDENTITY(1,1) Primary Key,
	DateAndTime DATETIME,
	PatientID int,
	DentistID int,
	PurposeDescription nvarchar(max),
	Status nvarchar(20) Check (Status IN ('Scheduled', 'Completed','Canceled'))
	);

Create table UserAccount ( 
	UserID int IDENTITY(1,1) Primary Key,
	Username varchar(50),
	Password varchar(255),
	RoleID int,
	Name varchar(255),
	ContactInfo varchar(255)
	);

CREATE TABLE [dbo].[Role](
	[roleID] [int] IDENTITY(1,1) NOT NULL,
	[roleName] [nvarchar](50) NULL,
	[roleDescription] [nvarchar](100) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[roleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET IDENTITY_INSERT [dbo].[Role] ON 
INSERT [dbo].[Role] ([roleId], [roleName], [roleDescription]) VALUES (1, N'Patient', N'Patient ')
INSERT [dbo].[Role] ([roleId], [roleName], [roleDescription]) VALUES (2, N'Dentist', N'Dentist')
INSERT [dbo].[Role] ([roleId], [roleName], [roleDescription]) VALUES (3, N'Admin', N'Admin')

SET IDENTITY_INSERT [dbo].[Role] OFF

ALTER TABLE Appointment
ADD CONSTRAINT FK_Patient_Appointment FOREIGN KEY (PatientID) REFERENCES Patient(PatientID);

ALTER TABLE Appointment
ADD CONSTRAINT FK_Dentist_Appointment FOREIGN KEY (DentistID) REFERENCES Dentist(DentistID);

---------------------------------------------------------------------------------------------------------------
--(1)create an appointment procedure
Create procedure CreateAppointment
	@PatientID int,
	@DentistID int,
	@DateAndTime DATETIME,
	@PurposeDescription nvarchar(max)
AS BEGIN 
	INSERT INTO Appointment (PatientID, DentistID, DateAndTime, PurposeDescription,Status)
	VALUES(@PatientID,@DentistID,@DateAndTime,@PurposeDescription, 'Scheduled') END;

--(2)Cancel appointment
CREATE PROCEDURE CancelAppointment
    @AppointmentID int
AS BEGIN
    UPDATE Appointment SET Status = 'Canceled' WHERE AppointmentID = @AppointmentID;
END;

--(3)Get appointments for a specific patient
CREATE PROCEDURE GetAppointmentsPatient
    @PatientID int
AS BEGIN
    SELECT * FROM Appointment WHERE PatientID = @PatientID;
END;

--(4)reschedule appointment procedure
CREATE PROCEDURE RescheduleAppointment
    @AppointmentID int,
    @NewDate DATETIME,
    @NewTime TIME
AS BEGIN
    UPDATE Appointment SET DateAndTime = CONCAT(CONVERT(DATE, @NewDate), ' ', @NewTime)
    WHERE AppointmentID = @AppointmentID;
END;

-- (5)Get appointments for a specific dentist
CREATE PROCEDURE GetAppointmentsForDentist
    @DentistID int
AS BEGIN
    SELECT * FROM Appointment WHERE DentistID = @DentistID;
END;


-- (6)Get upcoming appointments for a specific dentist
CREATE PROCEDURE GetUpcomingAppointments
    @DentistID int
AS BEGIN
    SELECT * FROM Appointment
    WHERE DentistID = @DentistID AND DateAndTime >= GETDATE();
END;

-- (7)Get completed appointments for a specific dentist
CREATE PROCEDURE GetCompletedAppointments
    @DentistID int
AS BEGIN
    SELECT * FROM Appointment
    WHERE DentistID = @DentistID AND Status = 'Completed';
END;

-- (8)Get canceled appointments for a specific dentist
CREATE PROCEDURE GetCanceledAppointments
    @DentistID int
AS BEGIN
    SELECT * FROM Appointment WHERE DentistID = @DentistID AND Status = 'Canceled';
END;

-- (9)Update patient information
CREATE PROCEDURE UpdatePatientInfo
    @PatientID int,
    @NewName nvarchar(255),
    @NewContactInfo nvarchar(255)
AS BEGIN
    UPDATE Patient SET Name = @NewName, ContactInfo = @NewContactInfo
    WHERE PatientID = @PatientID;
END;

-- (10)Update dentist information
CREATE PROCEDURE UpdateDentistInfo
    @DentistID int,
    @NewName nvarchar(255),
    @NewSpecialization nvarchar(255),
    @NewContactInfo nvarchar(255)
AS BEGIN
    UPDATE Dentist
    SET Name = @NewName, Specialization = @NewSpecialization, ContactInfo = @NewContactInfo
    WHERE DentistID = @DentistID;
END;
--------------------------------------------------------------------------------------------------
--views
--Create a view to display appointments for a patient, showing appointment details and status
CREATE VIEW PatientAppointmentsView AS
SELECT A.AppointmentID, A.DateAndTime, A.PurposeDescription, A.Status,
       D.Name AS DentistName
FROM Appointment A
JOIN Dentist D ON A.DentistID = D.DentistID;


-- Create a view to display appointments for a dentist, showing appointment details and patient information
CREATE VIEW DentistAppointmentsView AS
SELECT A.AppointmentID, A.DateAndTime, A.PurposeDescription, A.Status,
       P.Name AS PatientName
FROM Appointment A
JOIN Patient P ON A.PatientID = P.PatientID;
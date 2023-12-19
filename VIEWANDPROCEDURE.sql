USE DentalAppointmentSystem

INSERT INTO Roles (RoleName,[Role Discription])VALUES ('Dentist', 'Dentist'),('Admin', 'Admin')

INSERT INTO UserAccount (FirstName, LastName, Username, Password, RoleID, ContactInfo) Values ('Marvin', 'Tatoy','Marvin','1111','1','09950358463')

INSERT INTO Sex (SexName,SexDescription)VALUES ('Male', 'Male'),('Female', 'Female')

INSERT INTO TimeSet(TimeName,TimeDescription)VALUES ('8:00 - 9:00 AM', '8:00 - 9:00 AM'),('10:00 - 11:00 AM', '10:00 - 11:00 AM'),('1:00 - 2:00 PM', '1:00 - 2:00 PM'),('3:00 - 4:00 PM', '3:00 - 4:00 PM')

INSERT INTO [Services](ServiceName,ServiceDiscription)VALUES ('Tooth Extraction', 'Tooth Extraction'),('Teeth Cleaning', 'Teeth Cleaning'),('Root Canal', 'Root Canal'),('Dental Bonding', 'Dental Bonding'),('Dentures', 'Dentures'),('Orthodontics/Braces', 'Orthodontics/Braces')

CREATE VIEW VW_UserAccounts as
SELECT * FROM UserAccount

CREATE VIEW VW_Appointments as
SELECT AppointmentId, Pt.PatientId, CONCAT(Pt.LastName,', ',Pt.FirstName) AS "Patient Name", AppointmentPurpose, Appointments.Email,DateAndTime, Status
FROM Appointments 
JOIN Patient Pt ON Pt.PatientId = Appointments.PatientId 


Create PROCEDURE SP_BookAppointment
    @FirstName VARCHAR(255),
    @LastName VARCHAR(255),
    @ContactNumber VARCHAR(255),
    @Sex VARCHAR(10),
    @Email NVARCHAR(100),
    @PatientName NVARCHAR(100),
    @AppointmentPurpose NVARCHAR(255),
    @DateAndTime NVARCHAR(255),
    @Status NVARCHAR(50),
    @AppointmentEmail NVARCHAR(100)
AS
BEGIN
    DECLARE @PatientId INT
    DECLARE @AppointmentId INT
    INSERT INTO Patient VALUES (@FirstName, @LastName, @ContactNumber, @Sex, @Email)
    SELECT @PatientId = SCOPE_IDENTITY()
    INSERT INTO Appointments VALUES (@PatientId, @PatientName, @AppointmentPurpose, @DateAndTime, @Status, @AppointmentEmail)
    SELECT @AppointmentId = SCOPE_IDENTITY()
    UPDATE Appointments SET PatientId = @PatientId WHERE AppointmentId = @AppointmentId
END

CREATE PROCEDURE SP_NewUserAcc
	@FirstName nVARCHAR(100),
    @LastName nVARCHAR(100),
    @Username nVARCHAR(100),
    @Password nvarchar(255),
    @RoleId int,
    @ContactInfo NVARCHAR(100)
	AS
	DECLARE @UserId INT
	INSERT INTO UserAccount VALUES(@FirstName, @LastName, @Username, @Password, @RoleId, @ContactInfo)
	go


CREATE PROCEDURE SP_DeleteUser
	@UserId INT AS
Delete FROM UserAccount WHERE UserId = @UserId;
GO


CREATE PROCEDURE SP_AcceptAppointment
	@AppointmentId INT,
	@Status nvarchar(100)
	AS	
	UPDATE Appointments SET [Status] = @Status
	WHERE AppointmentId = @AppointmentId
	GO 
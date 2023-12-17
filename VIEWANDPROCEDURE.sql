USE DentalAppointmentSystem

CREATE VIEW VW_UserAccounts as
SELECT * FROM UserAccount

CREATE VIEW VW_Appointments as
SELECT AppointmentId, Pt.PatientId, CONCAT(Pt.LastName,', ',Pt.FirstName) AS "Patient Name", AppointmentPurpose, Appointments.Email,DateAndTime, Status
FROM Appointments 
JOIN Patient Pt ON Pt.PatientId = Appointments.PatientId 


CREATE PROCEDURE SP_CreateAppointment 
@PatientId INT,
@PatientName NVARCHAR(200),
@AppointmentPurpose NVARCHAR(255),
@DateAndTime NVARCHAR(200),
@Status NVARCHAR(100),
@Email NVARCHAR(100),
@FirstName varchar(255),
@LastName varchar(255),
@ContactNumber varchar(255),
@Sex varchar(10)
AS
DECLARE @AppointmentId AS INT
INSERT INTO Appointments VALUES (@PatientId, @PatientName, @AppointmentPurpose, @DateAndTime, @Status, @Email)
INSERT INTO Patient VALUES (@FirstName, @LastName, @ContactNumber, @Sex, @Email)
GO

ALTER PROCEDURE SP_BookAppointment
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



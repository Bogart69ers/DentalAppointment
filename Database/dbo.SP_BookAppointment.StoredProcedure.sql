USE [DentalAppointmentSystem]
GO
/****** Object:  StoredProcedure [dbo].[SP_BookAppointment]    Script Date: 12/18/2023 5:27:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_BookAppointment]
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
GO

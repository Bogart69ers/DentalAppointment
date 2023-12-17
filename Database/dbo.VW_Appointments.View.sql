USE [DentalAppointmentSystem]
GO
/****** Object:  View [dbo].[VW_Appointments]    Script Date: 12/18/2023 5:27:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_Appointments] as
SELECT AppointmentId, Pt.PatientId, CONCAT(Pt.LastName,', ',Pt.FirstName) AS "Patient Name", AppointmentPurpose, Appointments.Email,DateAndTime, Status
FROM Appointments 
JOIN Patient Pt ON Pt.PatientId = Appointments.PatientId 
GO

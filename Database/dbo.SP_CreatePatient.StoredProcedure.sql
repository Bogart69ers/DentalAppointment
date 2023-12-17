USE [DentalAppointmentSystem]
GO
/****** Object:  StoredProcedure [dbo].[SP_CreatePatient]    Script Date: 12/18/2023 5:27:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CreatePatient]
@FirstName varchar(255),
@LastName varchar(255),
@ContactNumber varchar(255),
@Sex varchar(10),
@Email nvarchar(100)
AS 
INSERT INTO Patient Values(@FirstName, @LastName, @ContactNumber, @Sex, @Email)
GO

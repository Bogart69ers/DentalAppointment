USE [DentalAppointmentSystem]
GO
/****** Object:  View [dbo].[VW_UserAccounts]    Script Date: 12/18/2023 5:27:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[VW_UserAccounts] as
SELECT * FROM UserAccount
GO

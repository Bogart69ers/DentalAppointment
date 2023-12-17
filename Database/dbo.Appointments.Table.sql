USE [DentalAppointmentSystem]
GO
/****** Object:  Table [dbo].[Appointments]    Script Date: 12/18/2023 5:27:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointments](
	[AppointmentId] [int] IDENTITY(1,1) NOT NULL,
	[PatientId] [int] NULL,
	[PatientName] [nvarchar](200) NULL,
	[AppointmentPurpose] [varchar](255) NULL,
	[DateAndTime] [nvarchar](200) NULL,
	[Status] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[AppointmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD FOREIGN KEY([PatientId])
REFERENCES [dbo].[Patient] ([PatientId])
GO

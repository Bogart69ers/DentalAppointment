USE [DentalAppointmentSystem]
GO
/****** Object:  Table [dbo].[TimeSet]    Script Date: 12/18/2023 5:27:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TimeSet](
	[TimeId] [int] IDENTITY(1,1) NOT NULL,
	[TimeName] [nvarchar](50) NULL,
	[TimeDescription] [nvarchar](50) NULL,
 CONSTRAINT [PK_TimeSet] PRIMARY KEY CLUSTERED 
(
	[TimeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

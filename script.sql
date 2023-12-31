USE [master]
GO
/****** Object:  Database [DentalAppointmentSystem]    Script Date: 12/18/2023 12:03:57 AM ******/
CREATE DATABASE [DentalAppointmentSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DentalAppointmentSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\DentalAppointmentSystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DentalAppointmentSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\DentalAppointmentSystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [DentalAppointmentSystem] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DentalAppointmentSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DentalAppointmentSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DentalAppointmentSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DentalAppointmentSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DentalAppointmentSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DentalAppointmentSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [DentalAppointmentSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DentalAppointmentSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DentalAppointmentSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DentalAppointmentSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DentalAppointmentSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DentalAppointmentSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DentalAppointmentSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DentalAppointmentSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DentalAppointmentSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DentalAppointmentSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DentalAppointmentSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DentalAppointmentSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DentalAppointmentSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DentalAppointmentSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DentalAppointmentSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DentalAppointmentSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DentalAppointmentSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DentalAppointmentSystem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DentalAppointmentSystem] SET  MULTI_USER 
GO
ALTER DATABASE [DentalAppointmentSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DentalAppointmentSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DentalAppointmentSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DentalAppointmentSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DentalAppointmentSystem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DentalAppointmentSystem] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DentalAppointmentSystem] SET QUERY_STORE = ON
GO
ALTER DATABASE [DentalAppointmentSystem] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [DentalAppointmentSystem]
GO
/****** Object:  Table [dbo].[Appointments]    Script Date: 12/18/2023 12:03:57 AM ******/
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
/****** Object:  Table [dbo].[Patient]    Script Date: 12/18/2023 12:03:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[PatientId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](255) NOT NULL,
	[LastName] [varchar](255) NOT NULL,
	[ContactNumber] [varchar](255) NULL,
	[Sex] [varchar](10) NULL,
	[AppointmentPurpose] [varchar](255) NULL,
	[Email] [nvarchar](100) NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[PatientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 12/18/2023 12:03:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](100) NULL,
	[Role Discription] [nvarchar](100) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Services]    Script Date: 12/18/2023 12:03:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Services](
	[ServiceId] [int] IDENTITY(1,1) NOT NULL,
	[ServiceName] [nvarchar](100) NULL,
	[ServiceDiscription] [nchar](100) NULL,
 CONSTRAINT [PK_Services] PRIMARY KEY CLUSTERED 
(
	[ServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sex]    Script Date: 12/18/2023 12:03:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sex](
	[SexId] [int] IDENTITY(1,1) NOT NULL,
	[SexName] [nvarchar](50) NULL,
	[SexDescription] [nvarchar](50) NULL,
 CONSTRAINT [PK_Sex] PRIMARY KEY CLUSTERED 
(
	[SexId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TimeSet]    Script Date: 12/18/2023 12:03:57 AM ******/
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
/****** Object:  Table [dbo].[UserAccount]    Script Date: 12/18/2023 12:03:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserAccount](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](100) NULL,
	[LastName] [nvarchar](100) NULL,
	[Username] [nvarchar](100) NULL,
	[Password] [nvarchar](255) NULL,
	[RoleID] [int] NULL,
	[ContactInfo] [nvarchar](100) NULL,
 CONSTRAINT [PK_UserAccount] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD FOREIGN KEY([PatientId])
REFERENCES [dbo].[Patient] ([PatientId])
GO
USE [master]
GO
ALTER DATABASE [DentalAppointmentSystem] SET  READ_WRITE 
GO

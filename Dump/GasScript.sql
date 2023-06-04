USE [master]
GO
/****** Object:  Database [DBGasFlowControlManager]    Script Date: 04.06.2023 14:27:38 ******/
CREATE DATABASE [DBGasFlowControlManager]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBGasFlowControlManager', FILENAME = N'C:\App\MSSQL16.MSSQLSERVER\MSSQL\DATA\DBGasFlowControlManager.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DBGasFlowControlManager_log', FILENAME = N'C:\App\MSSQL16.MSSQLSERVER\MSSQL\DATA\DBGasFlowControlManager_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [DBGasFlowControlManager] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBGasFlowControlManager].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBGasFlowControlManager] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBGasFlowControlManager] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBGasFlowControlManager] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBGasFlowControlManager] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBGasFlowControlManager] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBGasFlowControlManager] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBGasFlowControlManager] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBGasFlowControlManager] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBGasFlowControlManager] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBGasFlowControlManager] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBGasFlowControlManager] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBGasFlowControlManager] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBGasFlowControlManager] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBGasFlowControlManager] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBGasFlowControlManager] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DBGasFlowControlManager] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBGasFlowControlManager] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBGasFlowControlManager] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBGasFlowControlManager] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBGasFlowControlManager] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBGasFlowControlManager] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBGasFlowControlManager] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBGasFlowControlManager] SET RECOVERY FULL 
GO
ALTER DATABASE [DBGasFlowControlManager] SET  MULTI_USER 
GO
ALTER DATABASE [DBGasFlowControlManager] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBGasFlowControlManager] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBGasFlowControlManager] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBGasFlowControlManager] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DBGasFlowControlManager] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DBGasFlowControlManager] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DBGasFlowControlManager', N'ON'
GO
ALTER DATABASE [DBGasFlowControlManager] SET QUERY_STORE = ON
GO
ALTER DATABASE [DBGasFlowControlManager] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [DBGasFlowControlManager]
GO
/****** Object:  Table [dbo].[GasCompressors]    Script Date: 04.06.2023 14:27:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GasCompressors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NULL,
	[Manufacturer] [varchar](255) NULL,
	[MaxPressure] [float] NULL,
	[MaxFlowRate] [float] NULL,
	[Efficiency] [float] NULL,
	[InstallationDate] [date] NULL,
	[CurrentFlowRate] [float] NULL,
	[CurrentPressure] [float] NULL,
	[CurrentEfficiency] [float] NULL,
	[Power] [bit] NULL,
 CONSTRAINT [PK__GasCompr__3214EC07C76BF0D3] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Parameters]    Script Date: 04.06.2023 14:27:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parameters](
	[Id] [int] NOT NULL,
	[GasCompressorId] [int] NULL,
	[ParameterName] [varchar](255) NULL,
	[ParameterValue] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ParametersLogs]    Script Date: 04.06.2023 14:27:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ParametersLogs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[UserName] [varchar](255) NULL,
	[LoginDate] [datetime] NULL,
 CONSTRAINT [PK__Paramete__3214EC07E37E4A36] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StatesLogs]    Script Date: 04.06.2023 14:27:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatesLogs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[GasCompressorId] [int] NULL,
	[StateName] [varchar](255) NULL,
	[StartDateTime] [datetime] NULL,
	[EndDateTime] [datetime] NULL,
	[CurrentPower] [float] NULL,
	[CurrentPressure] [float] NULL,
 CONSTRAINT [PK__StatesLo__3214EC071B10346A] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 04.06.2023 14:27:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [varchar](255) NULL,
	[Position] [varchar](255) NULL,
	[Login] [varchar](255) NULL,
	[Password] [varchar](255) NULL,
	[IsAdmin] [bit] NULL,
	[RegistrationDate] [date] NULL,
	[LastLoginDate] [datetime] NULL,
	[Phone] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Derection] [text] NULL,
 CONSTRAINT [PK__Users__3214EC0779B53824] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Parameters]  WITH CHECK ADD  CONSTRAINT [FK__Parameter__GasCo__07C12930] FOREIGN KEY([GasCompressorId])
REFERENCES [dbo].[GasCompressors] ([Id])
GO
ALTER TABLE [dbo].[Parameters] CHECK CONSTRAINT [FK__Parameter__GasCo__07C12930]
GO
ALTER TABLE [dbo].[ParametersLogs]  WITH CHECK ADD  CONSTRAINT [FK__Parameter__UserI__0A9D95DB] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[ParametersLogs] CHECK CONSTRAINT [FK__Parameter__UserI__0A9D95DB]
GO
ALTER TABLE [dbo].[StatesLogs]  WITH CHECK ADD  CONSTRAINT [FK__StatesLog__GasCo__0D7A0286] FOREIGN KEY([GasCompressorId])
REFERENCES [dbo].[GasCompressors] ([Id])
GO
ALTER TABLE [dbo].[StatesLogs] CHECK CONSTRAINT [FK__StatesLog__GasCo__0D7A0286]
GO
USE [master]
GO
ALTER DATABASE [DBGasFlowControlManager] SET  READ_WRITE 
GO

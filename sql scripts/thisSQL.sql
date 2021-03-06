USE [master]
GO
/****** Object:  Database [Minecraft]    Script Date: 28.06.2019 10:59:39 ******/
CREATE DATABASE [Minecraft]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Minecraft', FILENAME = N'C:\Users\patri\Minecraft.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Minecraft_log', FILENAME = N'C:\Users\patri\Minecraft_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Minecraft] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Minecraft].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Minecraft] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Minecraft] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Minecraft] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Minecraft] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Minecraft] SET ARITHABORT OFF 
GO
ALTER DATABASE [Minecraft] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Minecraft] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Minecraft] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Minecraft] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Minecraft] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Minecraft] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Minecraft] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Minecraft] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Minecraft] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Minecraft] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Minecraft] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Minecraft] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Minecraft] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Minecraft] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Minecraft] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Minecraft] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Minecraft] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Minecraft] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Minecraft] SET  MULTI_USER 
GO
ALTER DATABASE [Minecraft] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Minecraft] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Minecraft] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Minecraft] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Minecraft] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Minecraft] SET QUERY_STORE = OFF
GO
USE [Minecraft]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [Minecraft]
GO
/****** Object:  Table [dbo].[Movies]    Script Date: 28.06.2019 10:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movies](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
	[Director] [nvarchar](max) NOT NULL,
	[Year] [int] NOT NULL,
	[Length_Minutes] [int] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table_1]    Script Date: 28.06.2019 10:59:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_1](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[MiddleName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Movies] ON 

INSERT [dbo].[Movies] ([ID], [Title], [Director], [Year], [Length_Minutes]) VALUES (1, N'Toy Story', N'John Lasseter', 1995, 81)
INSERT [dbo].[Movies] ([ID], [Title], [Director], [Year], [Length_Minutes]) VALUES (2, N'A Bug''s Life', N'John Lasseter', 1998, 95)
INSERT [dbo].[Movies] ([ID], [Title], [Director], [Year], [Length_Minutes]) VALUES (3, N'Toy Story 2', N'John Lasseter', 1999, 93)
INSERT [dbo].[Movies] ([ID], [Title], [Director], [Year], [Length_Minutes]) VALUES (4, N'Monsters, Inc', N'Pete Doctor', 2001, 92)
INSERT [dbo].[Movies] ([ID], [Title], [Director], [Year], [Length_Minutes]) VALUES (5, N'Finding Nemo', N'Andrew Stanton', 2003, 107)
INSERT [dbo].[Movies] ([ID], [Title], [Director], [Year], [Length_Minutes]) VALUES (6, N'The Incredibles', N'Brad Bird', 2004, 116)
INSERT [dbo].[Movies] ([ID], [Title], [Director], [Year], [Length_Minutes]) VALUES (7, N'Cars', N'John Lasseter', 2006, 117)
INSERT [dbo].[Movies] ([ID], [Title], [Director], [Year], [Length_Minutes]) VALUES (8, N'Ratatouille', N'Brad Bird', 2007, 115)
INSERT [dbo].[Movies] ([ID], [Title], [Director], [Year], [Length_Minutes]) VALUES (9, N'Wall-E', N'Andrew Stanton', 2008, 104)
INSERT [dbo].[Movies] ([ID], [Title], [Director], [Year], [Length_Minutes]) VALUES (10, N'Up', N'Pete Doctor', 2009, 101)
SET IDENTITY_INSERT [dbo].[Movies] OFF
SET IDENTITY_INSERT [dbo].[Table_1] ON 

INSERT [dbo].[Table_1] ([ID], [FirstName], [MiddleName], [LastName]) VALUES (1, N'patrick', N'brekke', N'johnsen')
SET IDENTITY_INSERT [dbo].[Table_1] OFF
USE [master]
GO
ALTER DATABASE [Minecraft] SET  READ_WRITE 
GO

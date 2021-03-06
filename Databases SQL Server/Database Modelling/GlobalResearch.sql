USE [master]
GO
/****** Object:  Database [GlobalResearch]    Script Date: 8.10.2015 г. 18:07:17 ч. ******/
CREATE DATABASE [GlobalResearch]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GlobalResearch', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\GlobalResearch.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'GlobalResearch_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\GlobalResearch_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [GlobalResearch] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GlobalResearch].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GlobalResearch] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GlobalResearch] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GlobalResearch] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GlobalResearch] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GlobalResearch] SET ARITHABORT OFF 
GO
ALTER DATABASE [GlobalResearch] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GlobalResearch] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GlobalResearch] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GlobalResearch] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GlobalResearch] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GlobalResearch] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GlobalResearch] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GlobalResearch] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GlobalResearch] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GlobalResearch] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GlobalResearch] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GlobalResearch] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GlobalResearch] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GlobalResearch] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GlobalResearch] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GlobalResearch] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GlobalResearch] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GlobalResearch] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GlobalResearch] SET  MULTI_USER 
GO
ALTER DATABASE [GlobalResearch] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GlobalResearch] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GlobalResearch] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GlobalResearch] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [GlobalResearch] SET DELAYED_DURABILITY = DISABLED 
GO
USE [GlobalResearch]
GO
/****** Object:  Table [dbo].[Addresses]    Script Date: 8.10.2015 г. 18:07:17 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Addresses](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[address_text] [ntext] NULL,
	[town_id] [int] NOT NULL,
 CONSTRAINT [PK_Addresses] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Continents]    Script Date: 8.10.2015 г. 18:07:17 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Continents](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Continents] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Country]    Script Date: 8.10.2015 г. 18:07:17 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[continent_id] [int] NOT NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Persons]    Script Date: 8.10.2015 г. 18:07:17 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persons](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nvarchar](100) NOT NULL,
	[last_name] [nvarchar](100) NOT NULL,
	[address_id] [int] NOT NULL,
 CONSTRAINT [PK_Persons] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Towns]    Script Date: 8.10.2015 г. 18:07:17 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Towns](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[country_id] [int] NOT NULL,
 CONSTRAINT [PK_Towns] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Addresses] ON 

INSERT [dbo].[Addresses] ([id], [address_text], [town_id]) VALUES (1, N'some address in Sofia', 1)
INSERT [dbo].[Addresses] ([id], [address_text], [town_id]) VALUES (3, N'some address in Milano', 2)
INSERT [dbo].[Addresses] ([id], [address_text], [town_id]) VALUES (4, N'some address in New York', 3)
SET IDENTITY_INSERT [dbo].[Addresses] OFF
SET IDENTITY_INSERT [dbo].[Continents] ON 

INSERT [dbo].[Continents] ([id], [name]) VALUES (1, N' Asia')
INSERT [dbo].[Continents] ([id], [name]) VALUES (2, N' Africa')
INSERT [dbo].[Continents] ([id], [name]) VALUES (3, N' North America')
INSERT [dbo].[Continents] ([id], [name]) VALUES (4, N' Europe')
INSERT [dbo].[Continents] ([id], [name]) VALUES (5, N' Australia')
INSERT [dbo].[Continents] ([id], [name]) VALUES (6, N' South America')
INSERT [dbo].[Continents] ([id], [name]) VALUES (7, N' Antarctica')
SET IDENTITY_INSERT [dbo].[Continents] OFF
SET IDENTITY_INSERT [dbo].[Country] ON 

INSERT [dbo].[Country] ([id], [name], [continent_id]) VALUES (1, N'Japan', 1)
INSERT [dbo].[Country] ([id], [name], [continent_id]) VALUES (2, N'China', 1)
INSERT [dbo].[Country] ([id], [name], [continent_id]) VALUES (3, N'Tanzania', 2)
INSERT [dbo].[Country] ([id], [name], [continent_id]) VALUES (4, N'USA', 3)
INSERT [dbo].[Country] ([id], [name], [continent_id]) VALUES (5, N'Canada', 3)
INSERT [dbo].[Country] ([id], [name], [continent_id]) VALUES (6, N'Bulgaria', 4)
INSERT [dbo].[Country] ([id], [name], [continent_id]) VALUES (7, N'Italy', 4)
INSERT [dbo].[Country] ([id], [name], [continent_id]) VALUES (8, N'Argentina', 6)
SET IDENTITY_INSERT [dbo].[Country] OFF
SET IDENTITY_INSERT [dbo].[Persons] ON 

INSERT [dbo].[Persons] ([id], [first_name], [last_name], [address_id]) VALUES (1, N'Koko', N'Lozev', 1)
INSERT [dbo].[Persons] ([id], [first_name], [last_name], [address_id]) VALUES (3, N'Paulo', N'Maldini', 3)
INSERT [dbo].[Persons] ([id], [first_name], [last_name], [address_id]) VALUES (4, N'Jhon', N'Jhonson', 4)
SET IDENTITY_INSERT [dbo].[Persons] OFF
SET IDENTITY_INSERT [dbo].[Towns] ON 

INSERT [dbo].[Towns] ([id], [name], [country_id]) VALUES (1, N'Sofia', 6)
INSERT [dbo].[Towns] ([id], [name], [country_id]) VALUES (2, N'Milano', 7)
INSERT [dbo].[Towns] ([id], [name], [country_id]) VALUES (3, N'New York', 4)
INSERT [dbo].[Towns] ([id], [name], [country_id]) VALUES (4, N'Tokio', 1)
SET IDENTITY_INSERT [dbo].[Towns] OFF
ALTER TABLE [dbo].[Addresses]  WITH CHECK ADD  CONSTRAINT [FK_Addresses_Towns] FOREIGN KEY([town_id])
REFERENCES [dbo].[Towns] ([id])
GO
ALTER TABLE [dbo].[Addresses] CHECK CONSTRAINT [FK_Addresses_Towns]
GO
ALTER TABLE [dbo].[Country]  WITH CHECK ADD  CONSTRAINT [FK_Country_Continents] FOREIGN KEY([continent_id])
REFERENCES [dbo].[Continents] ([id])
GO
ALTER TABLE [dbo].[Country] CHECK CONSTRAINT [FK_Country_Continents]
GO
ALTER TABLE [dbo].[Persons]  WITH CHECK ADD  CONSTRAINT [FK_Persons_Addresses] FOREIGN KEY([address_id])
REFERENCES [dbo].[Addresses] ([id])
GO
ALTER TABLE [dbo].[Persons] CHECK CONSTRAINT [FK_Persons_Addresses]
GO
ALTER TABLE [dbo].[Towns]  WITH CHECK ADD  CONSTRAINT [FK_Towns_Country] FOREIGN KEY([country_id])
REFERENCES [dbo].[Country] ([id])
GO
ALTER TABLE [dbo].[Towns] CHECK CONSTRAINT [FK_Towns_Country]
GO
USE [master]
GO
ALTER DATABASE [GlobalResearch] SET  READ_WRITE 
GO

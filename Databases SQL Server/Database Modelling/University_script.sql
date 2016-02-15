USE [master]
GO
/****** Object:  Database [University ]    Script Date: 8.10.2015 г. 14:12:00 ч. ******/
CREATE DATABASE [University ]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'University', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\University .mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'University _log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\University _log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [University ] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [University ].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [University ] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [University ] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [University ] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [University ] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [University ] SET ARITHABORT OFF 
GO
ALTER DATABASE [University ] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [University ] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [University ] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [University ] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [University ] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [University ] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [University ] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [University ] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [University ] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [University ] SET  DISABLE_BROKER 
GO
ALTER DATABASE [University ] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [University ] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [University ] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [University ] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [University ] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [University ] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [University ] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [University ] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [University ] SET  MULTI_USER 
GO
ALTER DATABASE [University ] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [University ] SET DB_CHAINING OFF 
GO
ALTER DATABASE [University ] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [University ] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [University ] SET DELAYED_DURABILITY = DISABLED 
GO
USE [University ]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 8.10.2015 г. 14:12:00 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[profesor_id] [int] NOT NULL,
	[department_id] [int] NOT NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Departments]    Script Date: 8.10.2015 г. 14:12:00 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[faculty_id] [int] NOT NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Faculties]    Script Date: 8.10.2015 г. 14:12:00 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Faculties](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Faculties] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Profesir_Titles]    Script Date: 8.10.2015 г. 14:12:00 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesir_Titles](
	[profesor_id] [int] NOT NULL,
	[title_id] [int] NOT NULL,
 CONSTRAINT [PK_Profesir_Titles] PRIMARY KEY CLUSTERED 
(
	[profesor_id] ASC,
	[title_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Professors]    Script Date: 8.10.2015 г. 14:12:00 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Professors](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[department_id] [int] NOT NULL,
 CONSTRAINT [PK_Professors] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Students]    Script Date: 8.10.2015 г. 14:12:00 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[faculty_id] [int] NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Students_Courses]    Script Date: 8.10.2015 г. 14:12:00 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students_Courses](
	[student_id] [int] NOT NULL,
	[courses_id] [int] NOT NULL,
 CONSTRAINT [PK_Students_Courses] PRIMARY KEY CLUSTERED 
(
	[student_id] ASC,
	[courses_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Titles]    Script Date: 8.10.2015 г. 14:12:00 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Titles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Titles] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Departments] FOREIGN KEY([department_id])
REFERENCES [dbo].[Departments] ([id])
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Departments]
GO
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Professors] FOREIGN KEY([profesor_id])
REFERENCES [dbo].[Professors] ([id])
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Professors]
GO
ALTER TABLE [dbo].[Departments]  WITH CHECK ADD  CONSTRAINT [FK_Departments_Faculties] FOREIGN KEY([faculty_id])
REFERENCES [dbo].[Faculties] ([id])
GO
ALTER TABLE [dbo].[Departments] CHECK CONSTRAINT [FK_Departments_Faculties]
GO
ALTER TABLE [dbo].[Profesir_Titles]  WITH CHECK ADD  CONSTRAINT [FK_Profesir_Titles_Professors] FOREIGN KEY([profesor_id])
REFERENCES [dbo].[Professors] ([id])
GO
ALTER TABLE [dbo].[Profesir_Titles] CHECK CONSTRAINT [FK_Profesir_Titles_Professors]
GO
ALTER TABLE [dbo].[Profesir_Titles]  WITH CHECK ADD  CONSTRAINT [FK_Profesir_Titles_Titles] FOREIGN KEY([title_id])
REFERENCES [dbo].[Titles] ([id])
GO
ALTER TABLE [dbo].[Profesir_Titles] CHECK CONSTRAINT [FK_Profesir_Titles_Titles]
GO
ALTER TABLE [dbo].[Professors]  WITH CHECK ADD  CONSTRAINT [FK_Professors_Departments] FOREIGN KEY([department_id])
REFERENCES [dbo].[Departments] ([id])
GO
ALTER TABLE [dbo].[Professors] CHECK CONSTRAINT [FK_Professors_Departments]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Faculties] FOREIGN KEY([faculty_id])
REFERENCES [dbo].[Faculties] ([id])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Faculties]
GO
ALTER TABLE [dbo].[Students_Courses]  WITH CHECK ADD  CONSTRAINT [FK_Students_Courses_Courses] FOREIGN KEY([courses_id])
REFERENCES [dbo].[Courses] ([id])
GO
ALTER TABLE [dbo].[Students_Courses] CHECK CONSTRAINT [FK_Students_Courses_Courses]
GO
ALTER TABLE [dbo].[Students_Courses]  WITH CHECK ADD  CONSTRAINT [FK_Students_Courses_Students] FOREIGN KEY([student_id])
REFERENCES [dbo].[Students] ([id])
GO
ALTER TABLE [dbo].[Students_Courses] CHECK CONSTRAINT [FK_Students_Courses_Students]
GO
USE [master]
GO
ALTER DATABASE [University ] SET  READ_WRITE 
GO

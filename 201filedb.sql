USE [master]
GO
/****** Object:  Database [201File]    Script Date: 10/03/2017 13:46:48 ******/
CREATE DATABASE [201File]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'201File', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\201File.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'201File_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\201File_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [201File] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [201File].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [201File] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [201File] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [201File] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [201File] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [201File] SET ARITHABORT OFF 
GO
ALTER DATABASE [201File] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [201File] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [201File] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [201File] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [201File] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [201File] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [201File] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [201File] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [201File] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [201File] SET  DISABLE_BROKER 
GO
ALTER DATABASE [201File] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [201File] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [201File] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [201File] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [201File] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [201File] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [201File] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [201File] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [201File] SET  MULTI_USER 
GO
ALTER DATABASE [201File] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [201File] SET DB_CHAINING OFF 
GO
ALTER DATABASE [201File] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [201File] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [201File] SET DELAYED_DURABILITY = DISABLED 
GO
USE [201File]
GO
/****** Object:  Table [dbo].[accounts]    Script Date: 10/03/2017 13:46:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[accounts](
	[account_id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](255) NOT NULL,
	[account_type] [varchar](10) NOT NULL,
 CONSTRAINT [PK_accounts] PRIMARY KEY CLUSTERED 
(
	[account_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[beneficiaries]    Script Date: 10/03/2017 13:46:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[beneficiaries](
	[ben_id] [int] IDENTITY(1,1) NOT NULL,
	[employee_id] [int] NULL,
	[ben_name] [varchar](255) NULL,
	[ben_birthday] [date] NULL,
	[ben_relation] [varchar](255) NULL,
 CONSTRAINT [PK_beneficiaries] PRIMARY KEY CLUSTERED 
(
	[ben_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[children]    Script Date: 10/03/2017 13:46:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[children](
	[child_id] [int] IDENTITY(1,1) NOT NULL,
	[employee_id] [int] NOT NULL,
	[child_name] [varchar](255) NOT NULL,
	[child_birthday] [date] NULL,
 CONSTRAINT [PK_children] PRIMARY KEY CLUSTERED 
(
	[child_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[documents]    Script Date: 10/03/2017 13:46:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[documents](
	[document_id] [int] IDENTITY(1,1) NOT NULL,
	[document_name] [varchar](255) NOT NULL,
	[employee_id] [int] NULL,
	[document_address] [varchar](255) NULL,
 CONSTRAINT [PK_documents] PRIMARY KEY CLUSTERED 
(
	[document_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[employee_ym_evals]    Script Date: 10/03/2017 13:46:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[employee_ym_evals](
	[eval_id] [int] IDENTITY(1,1) NOT NULL,
	[employee_id] [int] NOT NULL,
	[score] [decimal](2, 2) NULL,
	[date] [date] NULL,
	[status] [varchar](10) NULL,
	[remarks] [text] NULL,
 CONSTRAINT [PK_employee_ym_evals] PRIMARY KEY CLUSTERED 
(
	[eval_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[employee201files]    Script Date: 10/03/2017 13:46:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[employee201files](
	[employee_id] [int] IDENTITY(1,1) NOT NULL,
	[last_name] [varchar](255) NOT NULL,
	[first_name] [varchar](255) NOT NULL,
	[middle_name] [varchar](20) NOT NULL,
	[status] [varchar](255) NOT NULL,
	[tin_number] [varchar](15) NULL,
	[sss_number] [varchar](10) NULL,
	[philhealth_number] [varchar](15) NULL,
	[pagibig_number] [varchar](15) NULL,
	[RTN] [varchar](15) NULL,
	[HDMF_MID_number] [varchar](15) NULL,
	[date_hired] [date] NULL,
	[company_group] [varchar](255) NULL,
	[department] [varchar](255) NULL,
	[position] [varchar](255) NULL,
	[rank] [varchar](255) NULL,
	[birthday] [date] NULL,
	[birth_place] [varchar](255) NULL,
	[civil_status] [varchar](10) NULL,
	[present_address] [varchar](255) NULL,
	[permanent_address] [varchar](255) NULL,
	[email] [varchar](255) NULL,
	[contact_number] [varchar](20) NULL,
	[telephone_number] [varchar](20) NULL,
	[fathers_name] [varchar](255) NULL,
	[mothers_name] [varchar](255) NULL,
	[spouse_name] [varchar](255) NULL,
	[spouse_birthday] [date] NULL,
	[nextofkin_name] [varchar](255) NULL,
	[nextofkin_birthday] [date] NULL,
	[status_reason] [varchar](max) NULL,
	[statusreason_date] [date] NULL,
	[picture_address] [varchar](255) NULL,
 CONSTRAINT [PK_employee201files] PRIMARY KEY CLUSTERED 
(
	[employee_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[logs]    Script Date: 10/03/2017 13:46:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[logs](
	[log_id] [int] IDENTITY(1,1) NOT NULL,
	[time_stamp] [date] NULL,
	[activity_name] [varchar](255) NULL,
	[account_id] [int] NOT NULL,
 CONSTRAINT [PK_logs] PRIMARY KEY CLUSTERED 
(
	[log_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[beneficiaries]  WITH CHECK ADD  CONSTRAINT [FK_beneficiaries_employee201files] FOREIGN KEY([employee_id])
REFERENCES [dbo].[employee201files] ([employee_id])
GO
ALTER TABLE [dbo].[beneficiaries] CHECK CONSTRAINT [FK_beneficiaries_employee201files]
GO
ALTER TABLE [dbo].[children]  WITH CHECK ADD  CONSTRAINT [FK_children_employee201files] FOREIGN KEY([employee_id])
REFERENCES [dbo].[employee201files] ([employee_id])
GO
ALTER TABLE [dbo].[children] CHECK CONSTRAINT [FK_children_employee201files]
GO
ALTER TABLE [dbo].[documents]  WITH CHECK ADD  CONSTRAINT [FK_documents_employee201files] FOREIGN KEY([employee_id])
REFERENCES [dbo].[employee201files] ([employee_id])
GO
ALTER TABLE [dbo].[documents] CHECK CONSTRAINT [FK_documents_employee201files]
GO
ALTER TABLE [dbo].[employee_ym_evals]  WITH CHECK ADD  CONSTRAINT [FK_employee_ym_evals_employee201files] FOREIGN KEY([employee_id])
REFERENCES [dbo].[employee201files] ([employee_id])
GO
ALTER TABLE [dbo].[employee_ym_evals] CHECK CONSTRAINT [FK_employee_ym_evals_employee201files]
GO
ALTER TABLE [dbo].[logs]  WITH CHECK ADD  CONSTRAINT [FK_logs_accounts] FOREIGN KEY([account_id])
REFERENCES [dbo].[accounts] ([account_id])
GO
ALTER TABLE [dbo].[logs] CHECK CONSTRAINT [FK_logs_accounts]
GO
USE [master]
GO
ALTER DATABASE [201File] SET  READ_WRITE 
GO

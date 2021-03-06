USE [master]
GO
/****** Object:  Database [AWBM]    Script Date: 10/28/2018 8:20:46 PM ******/
CREATE DATABASE [AWBM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AWBM', FILENAME = N'/var/opt/mssql/data/AWBM.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AWBM_log', FILENAME = N'/var/opt/mssql/data/AWBM_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [AWBM] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AWBM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AWBM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AWBM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AWBM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AWBM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AWBM] SET ARITHABORT OFF 
GO
ALTER DATABASE [AWBM] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AWBM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AWBM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AWBM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AWBM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AWBM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AWBM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AWBM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AWBM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AWBM] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AWBM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AWBM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AWBM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AWBM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AWBM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AWBM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AWBM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AWBM] SET RECOVERY FULL 
GO
ALTER DATABASE [AWBM] SET  MULTI_USER 
GO
ALTER DATABASE [AWBM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AWBM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AWBM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AWBM] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AWBM] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'AWBM', N'ON'
GO
ALTER DATABASE [AWBM] SET QUERY_STORE = OFF
GO
USE [AWBM]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [AWBM]
GO
/****** Object:  Table [dbo].[mst_category]    Script Date: 10/28/2018 8:21:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mst_category](
	[id] [nvarchar](50) NOT NULL,
	[insert_id] [nvarchar](50) NOT NULL,
	[insert_date] [datetime] NOT NULL,
	[insert_screen] [nvarchar](100) NOT NULL,
	[update_id] [nvarchar](50) NOT NULL,
	[update_date] [datetime] NOT NULL,
	[update_screen] [nvarchar](100) NOT NULL,
	[delete_id] [nvarchar](50) NULL,
	[delete_date] [datetime] NULL,
	[delete_screen] [nvarchar](100) NULL,
	[delete_flg] [bit] NULL,
	[language_id] [nvarchar](50) NOT NULL,
	[category_id] [nvarchar](3) NOT NULL,
	[category_name] [nvarchar](150) NOT NULL,
	[category_active] [bit] NOT NULL,
 CONSTRAINT [PK_mst_category] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[mst_language]    Script Date: 10/28/2018 8:21:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mst_language](
	[id] [nvarchar](50) NOT NULL,
	[insert_id] [nvarchar](50) NOT NULL,
	[insert_date] [datetime] NOT NULL,
	[insert_screen] [nvarchar](100) NOT NULL,
	[update_id] [nvarchar](50) NOT NULL,
	[update_date] [datetime] NOT NULL,
	[update_screen] [nvarchar](100) NOT NULL,
	[delete_id] [nvarchar](50) NULL,
	[delete_date] [datetime] NULL,
	[delete_screen] [nvarchar](100) NULL,
	[delete_flg] [bit] NULL,
	[language_code] [nvarchar](10) NOT NULL,
	[language_name] [nvarchar](50) NOT NULL,
	[language_active] [bit] NOT NULL,
 CONSTRAINT [PK_mst_language] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[mst_resource]    Script Date: 10/28/2018 8:21:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mst_resource](
	[id] [nvarchar](50) NOT NULL,
	[insert_id] [nvarchar](50) NOT NULL,
	[insert_date] [datetime] NOT NULL,
	[insert_screen] [nvarchar](100) NOT NULL,
	[update_id] [nvarchar](50) NOT NULL,
	[update_date] [datetime] NOT NULL,
	[update_screen] [nvarchar](100) NOT NULL,
	[delete_id] [nvarchar](50) NULL,
	[delete_date] [datetime] NULL,
	[delete_screen] [nvarchar](100) NULL,
	[delete_flg] [bit] NULL,
	[language_id] [nvarchar](50) NOT NULL,
	[screen_code] [nvarchar](50) NOT NULL,
	[resource_code] [nvarchar](50) NOT NULL,
	[resource_value] [nvarchar](max) NOT NULL,
	[resource_active] [bit] NOT NULL,
 CONSTRAINT [PK_mst_resource] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[mst_user]    Script Date: 10/28/2018 8:21:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mst_user](
	[id] [nvarchar](50) NOT NULL,
	[insert_id] [nvarchar](50) NOT NULL,
	[insert_date] [datetime] NOT NULL,
	[insert_screen] [nvarchar](100) NOT NULL,
	[update_id] [nvarchar](50) NOT NULL,
	[update_date] [datetime] NOT NULL,
	[update_screen] [nvarchar](100) NOT NULL,
	[delete_id] [nvarchar](50) NULL,
	[delete_date] [datetime] NULL,
	[delete_screen] [nvarchar](100) NULL,
	[delete_flg] [bit] NULL,
	[user_name] [nvarchar](150) NOT NULL,
	[user_pass] [nvarchar](150) NOT NULL,
	[user_type] [nvarchar](3) NOT NULL,
	[full_name] [nvarchar](200) NOT NULL,
	[sex] [nvarchar](3) NOT NULL,
	[dob] [date] NOT NULL,
	[phone] [nvarchar](50) NOT NULL,
	[address] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_mst_user] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[mst_user] ([id], [insert_id], [insert_date], [insert_screen], [update_id], [update_date], [update_screen], [delete_id], [delete_date], [delete_screen], [delete_flg], [user_name], [user_pass], [user_type], [full_name], [sex], [dob], [phone], [address]) VALUES (N'a6fd1f1e-ebc1-483d-8231-d2cf58056a96', N'a6fd1f1e-ebc1-483d-8231-d2cf58056a96', CAST(N'2018-10-25T22:57:39.317' AS DateTime), N'Manual Insert', N'a6fd1f1e-ebc1-483d-8231-d2cf58056a96', CAST(N'2018-10-25T22:57:39.317' AS DateTime), N'Manual Insert', NULL, NULL, NULL, 0, N'YwBRAEIAMQBBAEcARQBBAGIAZwBCAG4AQQBIAFkAQQBiAHcAQQA9AA==', N'YwBRAEIAMQBBAEcARQBBAGIAZwBCAG4AQQBGADgAQQBjAGcAQgB2AEEARwAwAEEAWAB3AEEAeABBAEQASQBBAE0AQQBBADUAQQBBAD0APQA=', N'001', N'Võ Nhật Quang', N'001', CAST(N'2018-10-25' AS Date), N'0965.432.350', N'295/11B Nơ Trang Long, Phường 13, Quận Bình Thạnh, Tp.Hồ Chí Minh')
ALTER TABLE [dbo].[mst_category] ADD  CONSTRAINT [DF_mst_category_category_active]  DEFAULT ((1)) FOR [category_active]
GO
ALTER TABLE [dbo].[mst_language] ADD  CONSTRAINT [DF_mst_language_language_active]  DEFAULT ((1)) FOR [language_active]
GO
ALTER TABLE [dbo].[mst_resource] ADD  CONSTRAINT [DF_mst_resource_resource_active]  DEFAULT ((1)) FOR [resource_active]
GO
ALTER TABLE [dbo].[mst_user] ADD  CONSTRAINT [DF_mst_user_delete_flg]  DEFAULT ((0)) FOR [delete_flg]
GO
/****** Object:  StoredProcedure [dbo].[SelectAllUser]    Script Date: 10/28/2018 8:21:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SelectAllUser]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM mst_user FOR JSON AUTO;
END
GO
USE [master]
GO
ALTER DATABASE [AWBM] SET  READ_WRITE 
GO

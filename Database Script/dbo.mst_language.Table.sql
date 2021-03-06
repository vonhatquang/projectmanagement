USE [AWBM]
GO
/****** Object:  Table [dbo].[mst_language]    Script Date: 10/31/2018 9:27:31 AM ******/
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
ALTER TABLE [dbo].[mst_language] ADD  CONSTRAINT [DF_mst_language_language_active]  DEFAULT ((1)) FOR [language_active]
GO

USE [AWBM]
GO
/****** Object:  Table [dbo].[mst_resource]    Script Date: 10/31/2018 9:27:31 AM ******/
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
ALTER TABLE [dbo].[mst_resource] ADD  CONSTRAINT [DF_mst_resource_resource_active]  DEFAULT ((1)) FOR [resource_active]
GO

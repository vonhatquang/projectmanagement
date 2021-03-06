USE [AWBM]
GO
/****** Object:  Table [dbo].[mst_user]    Script Date: 10/31/2018 9:27:32 AM ******/
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
ALTER TABLE [dbo].[mst_user] ADD  CONSTRAINT [DF_mst_user_delete_flg]  DEFAULT ((0)) FOR [delete_flg]
GO

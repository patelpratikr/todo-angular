USE [Blogs]
GO
/****** Object:  Table [dbo].[Blogs]    Script Date: 17-06-2020 21:33:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Blogs](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) NULL,
	[Completed] [bit] NULL,
 CONSTRAINT [PK_Blogs] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Blogs] ON 
GO
INSERT [dbo].[Blogs] ([ID], [Title], [Completed]) VALUES (1, N'Blog 1', 1)
GO
INSERT [dbo].[Blogs] ([ID], [Title], [Completed]) VALUES (2, N'Blog 2', 0)
GO
INSERT [dbo].[Blogs] ([ID], [Title], [Completed]) VALUES (3, N'Blog 3', 1)
GO
INSERT [dbo].[Blogs] ([ID], [Title], [Completed]) VALUES (4, N'Blog 4', 0)
GO
SET IDENTITY_INSERT [dbo].[Blogs] OFF
GO

USE [db_marcom]
GO
/****** Object:  Table [dbo].[m_company]    Script Date: 21/09/2020 14:20:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[m_company](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[code] [varchar](50) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[address] [varchar](255) NULL,
	[phone] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[is_delete] [bit] NOT NULL,
	[created_by] [varchar](50) NOT NULL,
	[created_date] [datetime] NOT NULL,
	[updated_by] [varchar](50) NULL,
	[updated_date] [datetime] NULL,
 CONSTRAINT [PK_m_company] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[m_employee]    Script Date: 21/09/2020 14:20:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[m_employee](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[employee_number] [varchar](50) NOT NULL,
	[first_name] [varchar](50) NOT NULL,
	[last_name] [varchar](50) NULL,
	[m_company_id] [int] NULL,
	[email] [varchar](150) NULL,
	[is_delete] [bit] NOT NULL,
	[created_by] [varchar](50) NOT NULL,
	[created_date] [datetime] NOT NULL,
	[updated_by] [varchar](50) NULL,
	[updated_date] [datetime] NULL,
 CONSTRAINT [PK_m_employee] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[m_menu]    Script Date: 21/09/2020 14:20:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[m_menu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[code] [varchar](50) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[controller] [varchar](150) NOT NULL,
	[parent_id] [int] NULL,
	[is_delete] [bit] NOT NULL,
	[created_by] [varchar](50) NOT NULL,
	[created_date] [datetime] NOT NULL,
	[updated_by] [varchar](50) NULL,
	[updated_date] [datetime] NULL,
 CONSTRAINT [PK_m_menu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[m_menu_access]    Script Date: 21/09/2020 14:20:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[m_menu_access](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[m_role_id] [int] NOT NULL,
	[m_menu_id] [int] NOT NULL,
	[is_delete] [bit] NOT NULL,
	[created_by] [varchar](50) NOT NULL,
	[created_date] [datetime] NOT NULL,
	[updated_by] [varchar](50) NULL,
	[updated_date] [datetime] NULL,
 CONSTRAINT [PK_m_menu_access] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[m_product]    Script Date: 21/09/2020 14:20:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[m_product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[code] [varchar](50) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[description] [varchar](255) NULL,
	[is_delete] [bit] NOT NULL,
	[created_by] [varchar](50) NOT NULL,
	[created_date] [datetime] NOT NULL,
	[updated_by] [varchar](50) NULL,
	[updated_date] [datetime] NULL,
 CONSTRAINT [PK_m_product] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[m_role]    Script Date: 21/09/2020 14:20:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[m_role](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[code] [varchar](50) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[description] [varchar](255) NOT NULL,
	[is_delete] [bit] NOT NULL,
	[created_by] [varchar](50) NOT NULL,
	[created_date] [datetime] NOT NULL,
	[updated_by] [varchar](50) NULL,
	[updated_date] [datetime] NULL,
 CONSTRAINT [PK_m_role] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[m_souvenir]    Script Date: 21/09/2020 14:20:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[m_souvenir](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[code] [varchar](50) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[description] [varchar](255) NULL,
	[m_unit_id] [int] NOT NULL,
	[is_delete] [bit] NOT NULL,
	[created_by] [varchar](50) NOT NULL,
	[created_date] [datetime] NOT NULL,
	[updated_by] [varchar](50) NULL,
	[updated_date] [datetime] NULL,
 CONSTRAINT [PK_m_souvenir] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[m_unit]    Script Date: 21/09/2020 14:20:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[m_unit](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[code] [varchar](50) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[description] [varchar](255) NULL,
	[is_delete] [bit] NOT NULL,
	[created_by] [varchar](50) NOT NULL,
	[created_date] [datetime] NOT NULL,
	[updated_by] [varchar](50) NULL,
	[updated_date] [datetime] NULL,
 CONSTRAINT [PK_m_unit] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[m_user]    Script Date: 21/09/2020 14:20:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[m_user](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[m_role_id] [int] NOT NULL,
	[m_employee_id] [int] NOT NULL,
	[is_delete] [bit] NOT NULL,
	[created_by] [varchar](50) NOT NULL,
	[created_date] [datetime] NOT NULL,
	[updated_by] [varchar](50) NULL,
	[updated_date] [datetime] NULL,
 CONSTRAINT [PK_m_user] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[t_design]    Script Date: 21/09/2020 14:20:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_design](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[code] [varchar](50) NOT NULL,
	[t_event_id] [int] NOT NULL,
	[title_header] [varchar](255) NOT NULL,
	[request_by] [int] NOT NULL,
	[request_date] [datetime] NOT NULL,
	[approved_by] [int] NULL,
	[approved_date] [datetime] NULL,
	[assign_to] [int] NULL,
	[close_date] [datetime] NULL,
	[note] [varchar](255) NULL,
	[status] [int] NULL,
	[reject_reason] [varchar](255) NULL,
	[is_delete] [bit] NULL,
	[created_by] [varchar](50) NOT NULL,
	[created_date] [datetime] NOT NULL,
	[updated_by] [varchar](50) NULL,
	[updated_date] [datetime] NULL,
 CONSTRAINT [PK_t_design] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[t_design_item]    Script Date: 21/09/2020 14:20:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_design_item](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[t_design_id] [int] NOT NULL,
	[m_product_id] [int] NOT NULL,
	[title_item] [varchar](255) NOT NULL,
	[request_pic] [int] NOT NULL,
	[start_date] [datetime] NULL,
	[end_date] [datetime] NULL,
	[request_due_date] [datetime] NULL,
	[note] [varchar](255) NULL,
	[is_delete] [bit] NULL,
	[created_by] [varchar](50) NOT NULL,
	[created_date] [datetime] NOT NULL,
	[updated_by] [varchar](50) NULL,
	[updated_date] [datetime] NULL,
 CONSTRAINT [PK_t_design_item] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[t_design_item_file]    Script Date: 21/09/2020 14:20:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_design_item_file](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[t_design_item_id] [int] NOT NULL,
	[filename] [varchar](100) NULL,
	[size] [varchar](11) NULL,
	[extention] [varchar](11) NULL,
	[is_delete] [bit] NULL,
	[created_by] [varchar](50) NOT NULL,
	[created_date] [datetime] NOT NULL,
	[updated_by] [varchar](50) NULL,
	[updated_date] [datetime] NULL,
 CONSTRAINT [PK_t_design_item_file] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[t_event]    Script Date: 21/09/2020 14:20:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_event](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[code] [varchar](50) NOT NULL,
	[event_name] [varchar](255) NOT NULL,
	[start_date] [datetime] NULL,
	[end_date] [datetime] NULL,
	[place] [varchar](255) NULL,
	[budget] [bigint] NULL,
	[request_by] [int] NOT NULL,
	[request_date] [datetime] NOT NULL,
	[approved_by] [int] NULL,
	[approved_date] [datetime] NULL,
	[assign_to] [int] NULL,
	[closed_date] [datetime] NULL,
	[note] [varchar](255) NULL,
	[status] [int] NULL,
	[reject_reason] [varchar](255) NULL,
	[is_delete] [bit] NULL,
	[craeted_by] [varchar](50) NULL,
	[created_date] [datetime] NULL,
	[updated_by] [varchar](50) NULL,
	[updated_date] [datetime] NULL,
 CONSTRAINT [PK_t_event] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[t_promotion]    Script Date: 21/09/2020 14:20:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_promotion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[code] [varchar](50) NOT NULL,
	[flag_design] [char](1) NOT NULL,
	[title] [varchar](255) NOT NULL,
	[t_event_id] [int] NOT NULL,
	[t_design_id] [varchar](11) NULL,
	[request_by] [int] NULL,
	[request_date] [datetime] NULL,
	[approved_by] [int] NULL,
	[approved_date] [datetime] NULL,
	[assign_to] [int] NULL,
	[close_date] [datetime] NULL,
	[note] [varchar](255) NULL,
	[status] [int] NULL,
	[reject_reason] [varchar](255) NULL,
	[is_delete] [bit] NULL,
	[created_by] [varchar](50) NOT NULL,
	[created_date] [datetime] NOT NULL,
	[updated_by] [varchar](50) NULL,
	[updated_date] [datetime] NULL,
 CONSTRAINT [PK_t_promotion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[t_promotion_item]    Script Date: 21/09/2020 14:20:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_promotion_item](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[t_promotion_id] [int] NOT NULL,
	[t_design_item_id] [int] NULL,
	[m_product_id] [varchar](11) NOT NULL,
	[title] [varchar](255) NOT NULL,
	[request_pic] [int] NOT NULL,
	[start_date] [datetime] NULL,
	[end_date] [datetime] NULL,
	[request_due_date] [datetime] NULL,
	[qty] [bigint] NULL,
	[todo] [int] NOT NULL,
	[note] [varchar](255) NULL,
	[is_delete] [bit] NULL,
	[created_by] [varchar](50) NOT NULL,
	[created_date] [datetime] NOT NULL,
	[updated_by] [varchar](50) NULL,
	[updated_date] [datetime] NULL,
 CONSTRAINT [PK_t_promotion_item] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[t_promotion_item_file]    Script Date: 21/09/2020 14:20:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_promotion_item_file](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[t_promotion_id] [int] NOT NULL,
	[filename] [varchar](100) NULL,
	[size] [varchar](11) NULL,
	[extention] [varchar](11) NULL,
	[start_date] [datetime] NULL,
	[end_date] [datetime] NULL,
	[request_due_date] [datetime] NULL,
	[qty] [bigint] NULL,
	[todo] [int] NOT NULL,
	[note] [varchar](255) NULL,
	[is_delete] [bit] NULL,
	[created_by] [varchar](50) NOT NULL,
	[created_date] [datetime] NOT NULL,
	[updated_by] [varchar](50) NULL,
	[updated_date] [datetime] NULL,
 CONSTRAINT [PK_t_promotion_item_file] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[t_souvenir]    Script Date: 21/09/2020 14:20:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_souvenir](
	[id] [int] NOT NULL,
	[code] [varchar](50) NOT NULL,
	[type] [varchar](11) NOT NULL,
	[t_event_id] [int] NULL,
	[request_by] [int] NOT NULL,
	[request_date] [datetime] NULL,
	[request_due_date] [datetime] NULL,
	[approved_by] [int] NULL,
	[approved_date] [datetime] NULL,
	[received_by] [int] NULL,
	[received_date] [datetime] NULL,
	[settlement_by] [int] NULL,
	[settlement_date] [datetime] NULL,
	[settlement_approved_by] [int] NULL,
	[settlement_approved_date] [datetime] NULL,
	[status] [int] NULL,
	[note] [varchar](255) NULL,
	[reject_reason] [varchar](255) NULL,
	[is_delete] [bit] NULL,
	[created_by] [bigint] NULL,
	[created_date] [datetime] NULL,
	[updated_by] [bigint] NULL,
	[updated_date] [datetime] NULL,
 CONSTRAINT [PK_t_souvenir] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[t_souvenir_item]    Script Date: 21/09/2020 14:20:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_souvenir_item](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[t_souvenir_id] [int] NOT NULL,
	[m_souvenir_id] [int] NOT NULL,
	[qty] [bigint] NULL,
	[qty_settlemeny] [bigint] NULL,
	[note] [varchar](255) NOT NULL,
	[is_delete] [bit] NULL,
	[created_by] [bigint] NULL,
	[created_date] [datetime] NULL,
	[updated_by] [bigint] NULL,
	[updated_date] [datetime] NULL,
 CONSTRAINT [PK_t_souvenir_item] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[m_product] ON 

INSERT [dbo].[m_product] ([id], [code], [name], [description], [is_delete], [created_by], [created_date], [updated_by], [updated_date]) VALUES (1, N'PR0001', N'Brosur', N'Print Kertas ', 0, N'Administrator', CAST(N'2020-09-21T14:06:19.610' AS DateTime), N'Administrator', CAST(N'2020-09-21T14:08:39.417' AS DateTime))
SET IDENTITY_INSERT [dbo].[m_product] OFF
SET IDENTITY_INSERT [dbo].[m_role] ON 

INSERT [dbo].[m_role] ([id], [code], [name], [description], [is_delete], [created_by], [created_date], [updated_by], [updated_date]) VALUES (1, N'RO0001', N'Administrator ', N'Admin', 1, N'Administrator', CAST(N'2020-09-11T09:57:42.317' AS DateTime), N'Administrator', CAST(N'2020-09-21T14:07:31.360' AS DateTime))
INSERT [dbo].[m_role] ([id], [code], [name], [description], [is_delete], [created_by], [created_date], [updated_by], [updated_date]) VALUES (2, N'RO0002', N'Staff ', N'Staff Markom', 0, N'Administrator', CAST(N'2020-09-14T06:41:29.583' AS DateTime), N'Administrator', CAST(N'2020-09-18T13:05:37.427' AS DateTime))
INSERT [dbo].[m_role] ([id], [code], [name], [description], [is_delete], [created_by], [created_date], [updated_by], [updated_date]) VALUES (3, N'RO0003', N'Requester', N'Req', 0, N'Administrator', CAST(N'2020-09-14T08:02:48.673' AS DateTime), N'Administrator', CAST(N'2020-09-18T13:07:21.803' AS DateTime))
INSERT [dbo].[m_role] ([id], [code], [name], [description], [is_delete], [created_by], [created_date], [updated_by], [updated_date]) VALUES (4, N'RO0004', N'Staff 1', N'Staff', 0, N'Administrator', CAST(N'2020-09-21T11:32:55.023' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[m_role] OFF
SET IDENTITY_INSERT [dbo].[m_unit] ON 

INSERT [dbo].[m_unit] ([id], [code], [name], [description], [is_delete], [created_by], [created_date], [updated_by], [updated_date]) VALUES (1, N'UN0001', N'Pieces', N'Pcs', 0, N'Administrator', CAST(N'2020-09-18T13:27:24.563' AS DateTime), N'Administrator', CAST(N'2020-09-18T14:10:36.367' AS DateTime))
INSERT [dbo].[m_unit] ([id], [code], [name], [description], [is_delete], [created_by], [created_date], [updated_by], [updated_date]) VALUES (2, N'UN0002', N'Kilogram', N'Kg', 1, N'Administrator', CAST(N'2020-09-18T14:05:14.967' AS DateTime), N'Administrator', CAST(N'2020-09-18T14:19:30.327' AS DateTime))
SET IDENTITY_INSERT [dbo].[m_unit] OFF

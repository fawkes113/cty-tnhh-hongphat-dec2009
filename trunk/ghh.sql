/****** Object:  Default [DF_AGENT_KIND_Deleted]    Script Date: 01/07/2010 23:36:29 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_AGENT_KIND_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[AGENT_KIND]'))
Begin
ALTER TABLE [dbo].[AGENT_KIND] DROP CONSTRAINT [DF_AGENT_KIND_Deleted]

End
GO
/****** Object:  Default [DF_AGENT_Deleted]    Script Date: 01/07/2010 23:36:29 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_AGENT_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[AGENTS]'))
Begin
ALTER TABLE [dbo].[AGENTS] DROP CONSTRAINT [DF_AGENT_Deleted]

End
GO
/****** Object:  Default [DF_BUY_PRICE_BuyPrice]    Script Date: 01/07/2010 23:36:29 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_BUY_PRICE_BuyPrice]') AND parent_object_id = OBJECT_ID(N'[dbo].[BUY_PRICE]'))
Begin
ALTER TABLE [dbo].[BUY_PRICE] DROP CONSTRAINT [DF_BUY_PRICE_BuyPrice]

End
GO
/****** Object:  Default [DF_BUY_PRICE_Deleted]    Script Date: 01/07/2010 23:36:29 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_BUY_PRICE_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[BUY_PRICE]'))
Begin
ALTER TABLE [dbo].[BUY_PRICE] DROP CONSTRAINT [DF_BUY_PRICE_Deleted]

End
GO
/****** Object:  Default [DF_Dept_OldDebtValue]    Script Date: 01/07/2010 23:36:29 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Dept_OldDebtValue]') AND parent_object_id = OBJECT_ID(N'[dbo].[DEBT]'))
Begin
ALTER TABLE [dbo].[DEBT] DROP CONSTRAINT [DF_Dept_OldDebtValue]

End
GO
/****** Object:  Default [DF_Dept_NewDebtValue]    Script Date: 01/07/2010 23:36:29 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Dept_NewDebtValue]') AND parent_object_id = OBJECT_ID(N'[dbo].[DEBT]'))
Begin
ALTER TABLE [dbo].[DEBT] DROP CONSTRAINT [DF_Dept_NewDebtValue]

End
GO
/****** Object:  Default [DF_Dept_Payment]    Script Date: 01/07/2010 23:36:29 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Dept_Payment]') AND parent_object_id = OBJECT_ID(N'[dbo].[DEBT]'))
Begin
ALTER TABLE [dbo].[DEBT] DROP CONSTRAINT [DF_Dept_Payment]

End
GO
/****** Object:  Default [DF_Dept_CurrentDebtValue]    Script Date: 01/07/2010 23:36:29 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Dept_CurrentDebtValue]') AND parent_object_id = OBJECT_ID(N'[dbo].[DEBT]'))
Begin
ALTER TABLE [dbo].[DEBT] DROP CONSTRAINT [DF_Dept_CurrentDebtValue]

End
GO
/****** Object:  Default [DF_Dept_Deleted]    Script Date: 01/07/2010 23:36:29 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Dept_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[DEBT]'))
Begin
ALTER TABLE [dbo].[DEBT] DROP CONSTRAINT [DF_Dept_Deleted]

End
GO
/****** Object:  Default [DF_Employee_Salary]    Script Date: 01/07/2010 23:36:29 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Employee_Salary]') AND parent_object_id = OBJECT_ID(N'[dbo].[EMPLOYEES]'))
Begin
ALTER TABLE [dbo].[EMPLOYEES] DROP CONSTRAINT [DF_Employee_Salary]

End
GO
/****** Object:  Default [DF_Employee_Deleted]    Script Date: 01/07/2010 23:36:29 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Employee_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[EMPLOYEES]'))
Begin
ALTER TABLE [dbo].[EMPLOYEES] DROP CONSTRAINT [DF_Employee_Deleted]

End
GO
/****** Object:  Default [DF_ITEM_Deleted]    Script Date: 01/07/2010 23:36:29 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_ITEM_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[ITEMS]'))
Begin
ALTER TABLE [dbo].[ITEMS] DROP CONSTRAINT [DF_ITEM_Deleted]

End
GO
/****** Object:  Default [DF_ITEM_TotalQuantity]    Script Date: 01/07/2010 23:36:29 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_ITEM_TotalQuantity]') AND parent_object_id = OBJECT_ID(N'[dbo].[ITEMS]'))
Begin
ALTER TABLE [dbo].[ITEMS] DROP CONSTRAINT [DF_ITEM_TotalQuantity]

End
GO
/****** Object:  Default [DF_OrderDetail_Quantity]    Script Date: 01/07/2010 23:36:29 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_OrderDetail_Quantity]') AND parent_object_id = OBJECT_ID(N'[dbo].[ORDER_DETAILS]'))
Begin
ALTER TABLE [dbo].[ORDER_DETAILS] DROP CONSTRAINT [DF_OrderDetail_Quantity]

End
GO
/****** Object:  Default [DF_OrderDetail_Deleted]    Script Date: 01/07/2010 23:36:29 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_OrderDetail_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[ORDER_DETAILS]'))
Begin
ALTER TABLE [dbo].[ORDER_DETAILS] DROP CONSTRAINT [DF_OrderDetail_Deleted]

End
GO
/****** Object:  Default [DF_ORDERS_Total]    Script Date: 01/07/2010 23:36:29 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_ORDERS_Total]') AND parent_object_id = OBJECT_ID(N'[dbo].[ORDERS]'))
Begin
ALTER TABLE [dbo].[ORDERS] DROP CONSTRAINT [DF_ORDERS_Total]

End
GO
/****** Object:  Default [DF_ORDERS_Pay]    Script Date: 01/07/2010 23:36:29 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_ORDERS_Pay]') AND parent_object_id = OBJECT_ID(N'[dbo].[ORDERS]'))
Begin
ALTER TABLE [dbo].[ORDERS] DROP CONSTRAINT [DF_ORDERS_Pay]

End
GO
/****** Object:  Default [DF_SELL_PRICE_SellPrice]    Script Date: 01/07/2010 23:36:29 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_SELL_PRICE_SellPrice]') AND parent_object_id = OBJECT_ID(N'[dbo].[SELL_PRICE]'))
Begin
ALTER TABLE [dbo].[SELL_PRICE] DROP CONSTRAINT [DF_SELL_PRICE_SellPrice]

End
GO
/****** Object:  Default [DF_SELL_PRICE_Deleted]    Script Date: 01/07/2010 23:36:29 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_SELL_PRICE_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[SELL_PRICE]'))
Begin
ALTER TABLE [dbo].[SELL_PRICE] DROP CONSTRAINT [DF_SELL_PRICE_Deleted]

End
GO
/****** Object:  Default [DF_USER_Deleted]    Script Date: 01/07/2010 23:36:29 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_USER_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[USERS]'))
Begin
ALTER TABLE [dbo].[USERS] DROP CONSTRAINT [DF_USER_Deleted]

End
GO
/****** Object:  Table [dbo].[AGENT_KIND]    Script Date: 01/07/2010 23:36:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AGENT_KIND]') AND type in (N'U'))
DROP TABLE [dbo].[AGENT_KIND]
GO
/****** Object:  Table [dbo].[AGENTS]    Script Date: 01/07/2010 23:36:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AGENTS]') AND type in (N'U'))
DROP TABLE [dbo].[AGENTS]
GO
/****** Object:  Table [dbo].[RETURNED_ITEM_DETAILS]    Script Date: 01/07/2010 23:36:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RETURNED_ITEM_DETAILS]') AND type in (N'U'))
DROP TABLE [dbo].[RETURNED_ITEM_DETAILS]
GO
/****** Object:  Table [dbo].[USERS]    Script Date: 01/07/2010 23:36:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[USERS]') AND type in (N'U'))
DROP TABLE [dbo].[USERS]
GO
/****** Object:  Table [dbo].[SELL_PRICE]    Script Date: 01/07/2010 23:36:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SELL_PRICE]') AND type in (N'U'))
DROP TABLE [dbo].[SELL_PRICE]
GO
/****** Object:  Table [dbo].[PARTNERS]    Script Date: 01/07/2010 23:36:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PARTNERS]') AND type in (N'U'))
DROP TABLE [dbo].[PARTNERS]
GO
/****** Object:  Table [dbo].[ORDERS]    Script Date: 01/07/2010 23:36:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDERS]') AND type in (N'U'))
DROP TABLE [dbo].[ORDERS]
GO
/****** Object:  Table [dbo].[ORDER_DETAILS]    Script Date: 01/07/2010 23:36:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDER_DETAILS]') AND type in (N'U'))
DROP TABLE [dbo].[ORDER_DETAILS]
GO
/****** Object:  Table [dbo].[ITEMS]    Script Date: 01/07/2010 23:36:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ITEMS]') AND type in (N'U'))
DROP TABLE [dbo].[ITEMS]
GO
/****** Object:  Table [dbo].[EMPLOYEES]    Script Date: 01/07/2010 23:36:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EMPLOYEES]') AND type in (N'U'))
DROP TABLE [dbo].[EMPLOYEES]
GO
/****** Object:  Table [dbo].[DEBT]    Script Date: 01/07/2010 23:36:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DEBT]') AND type in (N'U'))
DROP TABLE [dbo].[DEBT]
GO
/****** Object:  Table [dbo].[BUY_PRICE]    Script Date: 01/07/2010 23:36:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BUY_PRICE]') AND type in (N'U'))
DROP TABLE [dbo].[BUY_PRICE]
GO
/****** Object:  Table [dbo].[BUY_PRICE]    Script Date: 01/07/2010 23:36:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BUY_PRICE]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BUY_PRICE](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ItemId] [int] NOT NULL,
	[PartnerId] [int] NOT NULL,
	[BuyPrice] [decimal](18, 0) NOT NULL,
	[CreatedBy] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ModifiedDate] [datetime] NULL,
	[Deleted] [int] NOT NULL,
 CONSTRAINT [PK_BUY_PRICE] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[BUY_PRICE] ON
INSERT [dbo].[BUY_PRICE] ([Id], [ItemId], [PartnerId], [BuyPrice], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Deleted]) VALUES (1, 1, 2, CAST(5000 AS Decimal(18, 0)), N'ghaiha', CAST(0x00009D6900000000 AS DateTime), N'5/1/2010 12:00:00 AM', CAST(0x00009D6900000000 AS DateTime), 0)
INSERT [dbo].[BUY_PRICE] ([Id], [ItemId], [PartnerId], [BuyPrice], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Deleted]) VALUES (2, 1, 3, CAST(5500 AS Decimal(18, 0)), N'ghaiha', CAST(0x00009D6900000000 AS DateTime), N'5/1/2010 12:00:00 AM', CAST(0x00009D6900000000 AS DateTime), 0)
INSERT [dbo].[BUY_PRICE] ([Id], [ItemId], [PartnerId], [BuyPrice], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Deleted]) VALUES (3, 2, 1, CAST(6000 AS Decimal(18, 0)), N'ghaiha', CAST(0x00009D6900000000 AS DateTime), N'5/1/2010 12:00:00 AM', CAST(0x00009D6900000000 AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[BUY_PRICE] OFF
/****** Object:  Table [dbo].[DEBT]    Script Date: 01/07/2010 23:36:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DEBT]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[DEBT](
	[DebtId] [int] IDENTITY(1,1) NOT NULL,
	[OldDebtValue] [decimal](18, 0) NOT NULL,
	[NewDebtValue] [decimal](18, 0) NOT NULL,
	[Payment] [decimal](18, 0) NOT NULL,
	[CurrentDebtValue] [decimal](18, 0) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[Deleted] [int] NOT NULL,
	[CreatedBy] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[CreateDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ModifiedDate] [datetime] NULL,
	[DebtKind] [int] NOT NULL,
	[Note] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_Dept] PRIMARY KEY CLUSTERED 
(
	[DebtId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[DEBT] ON
INSERT [dbo].[DEBT] ([DebtId], [OldDebtValue], [NewDebtValue], [Payment], [CurrentDebtValue], [CustomerId], [Deleted], [CreatedBy], [CreateDate], [ModifiedBy], [ModifiedDate], [DebtKind], [Note]) VALUES (2, CAST(0 AS Decimal(18, 0)), CAST(1000000 AS Decimal(18, 0)), CAST(500000 AS Decimal(18, 0)), CAST(1000000 AS Decimal(18, 0)), 1, 1, N'ghaiha', CAST(0x00009D6900000000 AS DateTime), N'', CAST(0x00009D6900000000 AS DateTime), 0, NULL)
INSERT [dbo].[DEBT] ([DebtId], [OldDebtValue], [NewDebtValue], [Payment], [CurrentDebtValue], [CustomerId], [Deleted], [CreatedBy], [CreateDate], [ModifiedBy], [ModifiedDate], [DebtKind], [Note]) VALUES (5, CAST(1000000 AS Decimal(18, 0)), CAST(500000 AS Decimal(18, 0)), CAST(500000 AS Decimal(18, 0)), CAST(500000 AS Decimal(18, 0)), 1, 0, N'ghaiha', CAST(0x00009D6900000000 AS DateTime), N'ghaiha', CAST(0x00009D6900000000 AS DateTime), 0, NULL)
SET IDENTITY_INSERT [dbo].[DEBT] OFF
/****** Object:  Table [dbo].[EMPLOYEES]    Script Date: 01/07/2010 23:36:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EMPLOYEES]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EMPLOYEES](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeName] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Salary] [decimal](18, 0) NOT NULL,
	[Deleted] [int] NOT NULL,
	[Position] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[EMPLOYEES] ON
INSERT [dbo].[EMPLOYEES] ([EmployeeId], [EmployeeName], [Salary], [Deleted], [Position]) VALUES (1, N'Hai ha', CAST(100000 AS Decimal(18, 0)), 0, N'GiamDoc')
SET IDENTITY_INSERT [dbo].[EMPLOYEES] OFF
/****** Object:  Table [dbo].[ITEMS]    Script Date: 01/07/2010 23:36:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ITEMS]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ITEMS](
	[ItemId] [int] IDENTITY(1,1) NOT NULL,
	[ItemName] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[CreatedBy] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ModifiedDate] [datetime] NULL,
	[Deleted] [int] NOT NULL,
	[TotalQuantity] [decimal](18, 0) NOT NULL,
	[Measurement] [nvarchar](150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_ITEM] PRIMARY KEY CLUSTERED 
(
	[ItemId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[ITEMS] ON
INSERT [dbo].[ITEMS] ([ItemId], [ItemName], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Deleted], [TotalQuantity], [Measurement]) VALUES (1, N'Ac gap nhap', N'ghaiha', CAST(0x00009D6900000000 AS DateTime), N'5/1/2010 12:00:00 AM', CAST(0x00009D6900000000 AS DateTime), 0, CAST(0 AS Decimal(18, 0)), N'Dream/wave')
INSERT [dbo].[ITEMS] ([ItemId], [ItemName], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Deleted], [TotalQuantity], [Measurement]) VALUES (2, N'bac dan 6000', N'ghaiha', CAST(0x00009D6900000000 AS DateTime), N'5/1/2010 12:00:00 AM', CAST(0x00009D6900000000 AS DateTime), 0, CAST(0 AS Decimal(18, 0)), N'Drean/wave')
INSERT [dbo].[ITEMS] ([ItemId], [ItemName], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Deleted], [TotalQuantity], [Measurement]) VALUES (3, N'Bo noi', N'ghaiha', CAST(0x00009D6900000000 AS DateTime), N'5/1/2010 12:00:00 AM', CAST(0x00009D6900000000 AS DateTime), 0, CAST(0 AS Decimal(18, 0)), N'Cub 50/70')
INSERT [dbo].[ITEMS] ([ItemId], [ItemName], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Deleted], [TotalQuantity], [Measurement]) VALUES (4, N'Cao su gac chan', N'ghaiha', CAST(0x00009D6900000000 AS DateTime), N'5/1/2010 12:00:00 AM', CAST(0x00009D6900000000 AS DateTime), 0, CAST(0 AS Decimal(18, 0)), N'DR/W/Cup')
SET IDENTITY_INSERT [dbo].[ITEMS] OFF
/****** Object:  Table [dbo].[ORDER_DETAILS]    Script Date: 01/07/2010 23:36:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDER_DETAILS]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ORDER_DETAILS](
	[OrderDetailId] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NOT NULL,
	[ItemId] [int] NOT NULL,
	[Quantity] [decimal](18, 0) NOT NULL,
	[IdPrice] [int] NOT NULL,
	[CreateBy] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[CreateDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ModifiedDate] [datetime] NULL,
	[Deleted] [int] NOT NULL,
	[Note] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[OrderDetailId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[ORDER_DETAILS] ON
INSERT [dbo].[ORDER_DETAILS] ([OrderDetailId], [OrderId], [ItemId], [Quantity], [IdPrice], [CreateBy], [CreateDate], [ModifiedBy], [ModifiedDate], [Deleted], [Note]) VALUES (1, 1, 1, CAST(50 AS Decimal(18, 0)), 1, N'ghaiha', CAST(0x00009D6900000000 AS DateTime), N'5/1/2010 12:00:00 AM', CAST(0x00009D6900000000 AS DateTime), 0, NULL)
INSERT [dbo].[ORDER_DETAILS] ([OrderDetailId], [OrderId], [ItemId], [Quantity], [IdPrice], [CreateBy], [CreateDate], [ModifiedBy], [ModifiedDate], [Deleted], [Note]) VALUES (2, 1, 2, CAST(10 AS Decimal(18, 0)), 2, N'ghaiha', CAST(0x00009D6900000000 AS DateTime), N'5/1/2010 12:00:00 AM', CAST(0x00009D6900000000 AS DateTime), 0, NULL)
SET IDENTITY_INSERT [dbo].[ORDER_DETAILS] OFF
/****** Object:  Table [dbo].[ORDERS]    Script Date: 01/07/2010 23:36:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDERS]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ORDERS](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[OrderKind] [int] NOT NULL,
	[CustomerId] [int] NOT NULL,
	[CreatedBy] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ModifiedDate] [datetime] NULL,
	[Total] [decimal](18, 0) NOT NULL,
	[Pay] [decimal](18, 0) NOT NULL,
	[Status] [int] NOT NULL,
	[Note] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_ORDERS] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[ORDERS] ON
INSERT [dbo].[ORDERS] ([OrderId], [OrderKind], [CustomerId], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Total], [Pay], [Status], [Note]) VALUES (1, 0, 1, N'ghaiha', CAST(0x00009D6900000000 AS DateTime), N'ghaiha', CAST(0x00009D8800000000 AS DateTime), CAST(800000 AS Decimal(18, 0)), CAST(500000 AS Decimal(18, 0)), 1, N'XUAT...')
SET IDENTITY_INSERT [dbo].[ORDERS] OFF
/****** Object:  Table [dbo].[PARTNERS]    Script Date: 01/07/2010 23:36:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PARTNERS]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PARTNERS](
	[PartnerId] [int] IDENTITY(1,1) NOT NULL,
	[PartnerName] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Address] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[PhoneNumber] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_PARTNER] PRIMARY KEY CLUSTERED 
(
	[PartnerId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[PARTNERS] ON
INSERT [dbo].[PARTNERS] ([PartnerId], [PartnerName], [Address], [PhoneNumber]) VALUES (2, N'Partner 1', N'123 Cai j do', N'999999')
INSERT [dbo].[PARTNERS] ([PartnerId], [PartnerName], [Address], [PhoneNumber]) VALUES (3, N'Partner 2', N'456 Nha tui', N'777777')
SET IDENTITY_INSERT [dbo].[PARTNERS] OFF
/****** Object:  Table [dbo].[SELL_PRICE]    Script Date: 01/07/2010 23:36:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SELL_PRICE]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[SELL_PRICE](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ItemId] [int] NOT NULL,
	[AgentId] [int] NOT NULL,
	[SellPrice] [decimal](18, 0) NOT NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ModifiedBy] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ModifiedDate] [datetime] NULL,
	[Deleted] [int] NOT NULL,
 CONSTRAINT [PK_SELL_PRICE] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[SELL_PRICE] ON
INSERT [dbo].[SELL_PRICE] ([Id], [ItemId], [AgentId], [SellPrice], [CreatedDate], [CreatedBy], [ModifiedBy], [ModifiedDate], [Deleted]) VALUES (1, 1, 1, CAST(7500 AS Decimal(18, 0)), CAST(0x00009D6900000000 AS DateTime), N'ghaiha', N'5/1/2010 12:00:00 AM', CAST(0x00009D6900000000 AS DateTime), 0)
INSERT [dbo].[SELL_PRICE] ([Id], [ItemId], [AgentId], [SellPrice], [CreatedDate], [CreatedBy], [ModifiedBy], [ModifiedDate], [Deleted]) VALUES (2, 2, 1, CAST(7000 AS Decimal(18, 0)), CAST(0x00009D6900000000 AS DateTime), N'ghaiha', N'5/1/2010 12:00:00 AM', CAST(0x00009D6900000000 AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[SELL_PRICE] OFF
/****** Object:  Table [dbo].[USERS]    Script Date: 01/07/2010 23:36:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[USERS]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[USERS](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[UserPassword] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Deleted] [int] NOT NULL,
	[EmployeeId] [int] NOT NULL,
 CONSTRAINT [PK_USER] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[USERS] ON
INSERT [dbo].[USERS] ([UserId], [UserName], [UserPassword], [Deleted], [EmployeeId]) VALUES (1, N'ghaiha', N'ghaiha', 0, 1)
SET IDENTITY_INSERT [dbo].[USERS] OFF
/****** Object:  Table [dbo].[RETURNED_ITEM_DETAILS]    Script Date: 01/07/2010 23:36:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RETURNED_ITEM_DETAILS]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[RETURNED_ITEM_DETAILS](
	[OrderDetailId] [int] NOT NULL,
	[Quantity] [decimal](18, 0) NOT NULL,
	[ReturnDate] [datetime] NOT NULL,
	[Note] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_RETURN_ITEM_DETAILS] PRIMARY KEY CLUSTERED 
(
	[OrderDetailId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[RETURNED_ITEM_DETAILS] ([OrderDetailId], [Quantity], [ReturnDate], [Note]) VALUES (1, CAST(20 AS Decimal(18, 0)), CAST(0x00009D6900000000 AS DateTime), N'tra ve')
/****** Object:  Table [dbo].[AGENTS]    Script Date: 01/07/2010 23:36:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AGENTS]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[AGENTS](
	[AgentId] [int] IDENTITY(1,1) NOT NULL,
	[AgentName] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[CreatedBy] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ModifiedDate] [datetime] NULL,
	[IdAgentKind] [int] NOT NULL,
	[Deleted] [int] NOT NULL,
 CONSTRAINT [PK_AGENT] PRIMARY KEY CLUSTERED 
(
	[AgentId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[AGENTS] ON
INSERT [dbo].[AGENTS] ([AgentId], [AgentName], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [IdAgentKind], [Deleted]) VALUES (1, N'Anh Manh', N'5/1/2010 12:00:00 AM', CAST(0x00009D6900000000 AS DateTime), N'5/1/2010 12:00:00 AM', CAST(0x00009D6900000000 AS DateTime), 1, 0)
INSERT [dbo].[AGENTS] ([AgentId], [AgentName], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [IdAgentKind], [Deleted]) VALUES (2, N'tan Dalat', N'5/1/2010 12:00:00 AM', CAST(0x00009D6900000000 AS DateTime), N'5/1/2010 12:00:00 AM', CAST(0x00009D6900000000 AS DateTime), 2, 0)
SET IDENTITY_INSERT [dbo].[AGENTS] OFF
/****** Object:  Table [dbo].[AGENT_KIND]    Script Date: 01/07/2010 23:36:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AGENT_KIND]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[AGENT_KIND](
	[IdAgentKind] [int] IDENTITY(1,1) NOT NULL,
	[AgentKindName] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[CreatedBy] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[CratedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ModifiedDate] [datetime] NULL,
	[Deleted] [int] NOT NULL,
 CONSTRAINT [PK_AGENT_KIND] PRIMARY KEY CLUSTERED 
(
	[IdAgentKind] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[AGENT_KIND] ON
INSERT [dbo].[AGENT_KIND] ([IdAgentKind], [AgentKindName], [CreatedBy], [CratedDate], [ModifiedBy], [ModifiedDate], [Deleted]) VALUES (1, N'Dai_ly_cap1', N'ghaiha', CAST(0x00009D6900000000 AS DateTime), N'5/1/2010 12:00:00 AM', CAST(0x00009D6900000000 AS DateTime), 0)
INSERT [dbo].[AGENT_KIND] ([IdAgentKind], [AgentKindName], [CreatedBy], [CratedDate], [ModifiedBy], [ModifiedDate], [Deleted]) VALUES (2, N'Dai_ly_cap1', N'ghaiha', CAST(0x00009D6900000000 AS DateTime), N'5/1/2010 12:00:00 AM', CAST(0x00009D6900000000 AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[AGENT_KIND] OFF
/****** Object:  Default [DF_AGENT_KIND_Deleted]    Script Date: 01/07/2010 23:36:29 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_AGENT_KIND_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[AGENT_KIND]'))
Begin
ALTER TABLE [dbo].[AGENT_KIND] ADD  CONSTRAINT [DF_AGENT_KIND_Deleted]  DEFAULT ((0)) FOR [Deleted]

End
GO
/****** Object:  Default [DF_AGENT_Deleted]    Script Date: 01/07/2010 23:36:29 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_AGENT_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[AGENTS]'))
Begin
ALTER TABLE [dbo].[AGENTS] ADD  CONSTRAINT [DF_AGENT_Deleted]  DEFAULT ((0)) FOR [Deleted]

End
GO
/****** Object:  Default [DF_BUY_PRICE_BuyPrice]    Script Date: 01/07/2010 23:36:29 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_BUY_PRICE_BuyPrice]') AND parent_object_id = OBJECT_ID(N'[dbo].[BUY_PRICE]'))
Begin
ALTER TABLE [dbo].[BUY_PRICE] ADD  CONSTRAINT [DF_BUY_PRICE_BuyPrice]  DEFAULT ((0)) FOR [BuyPrice]

End
GO
/****** Object:  Default [DF_BUY_PRICE_Deleted]    Script Date: 01/07/2010 23:36:29 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_BUY_PRICE_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[BUY_PRICE]'))
Begin
ALTER TABLE [dbo].[BUY_PRICE] ADD  CONSTRAINT [DF_BUY_PRICE_Deleted]  DEFAULT ((0)) FOR [Deleted]

End
GO
/****** Object:  Default [DF_Dept_OldDebtValue]    Script Date: 01/07/2010 23:36:29 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Dept_OldDebtValue]') AND parent_object_id = OBJECT_ID(N'[dbo].[DEBT]'))
Begin
ALTER TABLE [dbo].[DEBT] ADD  CONSTRAINT [DF_Dept_OldDebtValue]  DEFAULT ((0)) FOR [OldDebtValue]

End
GO
/****** Object:  Default [DF_Dept_NewDebtValue]    Script Date: 01/07/2010 23:36:29 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Dept_NewDebtValue]') AND parent_object_id = OBJECT_ID(N'[dbo].[DEBT]'))
Begin
ALTER TABLE [dbo].[DEBT] ADD  CONSTRAINT [DF_Dept_NewDebtValue]  DEFAULT ((0)) FOR [NewDebtValue]

End
GO
/****** Object:  Default [DF_Dept_Payment]    Script Date: 01/07/2010 23:36:29 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Dept_Payment]') AND parent_object_id = OBJECT_ID(N'[dbo].[DEBT]'))
Begin
ALTER TABLE [dbo].[DEBT] ADD  CONSTRAINT [DF_Dept_Payment]  DEFAULT ((0)) FOR [Payment]

End
GO
/****** Object:  Default [DF_Dept_CurrentDebtValue]    Script Date: 01/07/2010 23:36:29 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Dept_CurrentDebtValue]') AND parent_object_id = OBJECT_ID(N'[dbo].[DEBT]'))
Begin
ALTER TABLE [dbo].[DEBT] ADD  CONSTRAINT [DF_Dept_CurrentDebtValue]  DEFAULT ((0)) FOR [CurrentDebtValue]

End
GO
/****** Object:  Default [DF_Dept_Deleted]    Script Date: 01/07/2010 23:36:29 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Dept_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[DEBT]'))
Begin
ALTER TABLE [dbo].[DEBT] ADD  CONSTRAINT [DF_Dept_Deleted]  DEFAULT ((0)) FOR [Deleted]

End
GO
/****** Object:  Default [DF_Employee_Salary]    Script Date: 01/07/2010 23:36:29 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Employee_Salary]') AND parent_object_id = OBJECT_ID(N'[dbo].[EMPLOYEES]'))
Begin
ALTER TABLE [dbo].[EMPLOYEES] ADD  CONSTRAINT [DF_Employee_Salary]  DEFAULT ((0)) FOR [Salary]

End
GO
/****** Object:  Default [DF_Employee_Deleted]    Script Date: 01/07/2010 23:36:29 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Employee_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[EMPLOYEES]'))
Begin
ALTER TABLE [dbo].[EMPLOYEES] ADD  CONSTRAINT [DF_Employee_Deleted]  DEFAULT ((0)) FOR [Deleted]

End
GO
/****** Object:  Default [DF_ITEM_Deleted]    Script Date: 01/07/2010 23:36:29 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_ITEM_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[ITEMS]'))
Begin
ALTER TABLE [dbo].[ITEMS] ADD  CONSTRAINT [DF_ITEM_Deleted]  DEFAULT ((0)) FOR [Deleted]

End
GO
/****** Object:  Default [DF_ITEM_TotalQuantity]    Script Date: 01/07/2010 23:36:29 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_ITEM_TotalQuantity]') AND parent_object_id = OBJECT_ID(N'[dbo].[ITEMS]'))
Begin
ALTER TABLE [dbo].[ITEMS] ADD  CONSTRAINT [DF_ITEM_TotalQuantity]  DEFAULT ((0)) FOR [TotalQuantity]

End
GO
/****** Object:  Default [DF_OrderDetail_Quantity]    Script Date: 01/07/2010 23:36:29 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_OrderDetail_Quantity]') AND parent_object_id = OBJECT_ID(N'[dbo].[ORDER_DETAILS]'))
Begin
ALTER TABLE [dbo].[ORDER_DETAILS] ADD  CONSTRAINT [DF_OrderDetail_Quantity]  DEFAULT ((0)) FOR [Quantity]

End
GO
/****** Object:  Default [DF_OrderDetail_Deleted]    Script Date: 01/07/2010 23:36:29 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_OrderDetail_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[ORDER_DETAILS]'))
Begin
ALTER TABLE [dbo].[ORDER_DETAILS] ADD  CONSTRAINT [DF_OrderDetail_Deleted]  DEFAULT ((0)) FOR [Deleted]

End
GO
/****** Object:  Default [DF_ORDERS_Total]    Script Date: 01/07/2010 23:36:29 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_ORDERS_Total]') AND parent_object_id = OBJECT_ID(N'[dbo].[ORDERS]'))
Begin
ALTER TABLE [dbo].[ORDERS] ADD  CONSTRAINT [DF_ORDERS_Total]  DEFAULT ((0)) FOR [Total]

End
GO
/****** Object:  Default [DF_ORDERS_Pay]    Script Date: 01/07/2010 23:36:29 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_ORDERS_Pay]') AND parent_object_id = OBJECT_ID(N'[dbo].[ORDERS]'))
Begin
ALTER TABLE [dbo].[ORDERS] ADD  CONSTRAINT [DF_ORDERS_Pay]  DEFAULT ((0)) FOR [Pay]

End
GO
/****** Object:  Default [DF_SELL_PRICE_SellPrice]    Script Date: 01/07/2010 23:36:29 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_SELL_PRICE_SellPrice]') AND parent_object_id = OBJECT_ID(N'[dbo].[SELL_PRICE]'))
Begin
ALTER TABLE [dbo].[SELL_PRICE] ADD  CONSTRAINT [DF_SELL_PRICE_SellPrice]  DEFAULT ((0)) FOR [SellPrice]

End
GO
/****** Object:  Default [DF_SELL_PRICE_Deleted]    Script Date: 01/07/2010 23:36:29 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_SELL_PRICE_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[SELL_PRICE]'))
Begin
ALTER TABLE [dbo].[SELL_PRICE] ADD  CONSTRAINT [DF_SELL_PRICE_Deleted]  DEFAULT ((0)) FOR [Deleted]

End
GO
/****** Object:  Default [DF_USER_Deleted]    Script Date: 01/07/2010 23:36:29 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_USER_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[USERS]'))
Begin
ALTER TABLE [dbo].[USERS] ADD  CONSTRAINT [DF_USER_Deleted]  DEFAULT ((0)) FOR [Deleted]

End
GO

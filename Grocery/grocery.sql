USE [master]
GO
/****** Object:  Database [Grocery]    Script Date: 10/18/2019 12:04:57 PM ******/
CREATE DATABASE [Grocery]
GO

USE [Grocery]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 10/18/2019 12:04:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[id] [int] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[email] [varchar](50) NULL,
	[phone] [varchar](11) NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 10/18/2019 12:04:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[id] [int] NOT NULL,
	[customer_id] [int] NOT NULL,
	[order_date] [date] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order_Details]    Script Date: 10/18/2019 12:04:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order_Details](
	[order_id] [int] NOT NULL,
	[product_id] [varchar](50) NOT NULL,
	[amount] [int] NOT NULL,
 CONSTRAINT [PK_Order_Details] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC,
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 10/18/2019 12:04:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[id] [varchar](50) NOT NULL,
	[supplier_id] [int] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[description] [varchar](200) NULL,
	[price] [float] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 10/18/2019 12:04:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[id] [int] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[address] [varchar](100) NOT NULL,
	[website] [varchar](50) NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Customer] ([id], [name], [email], [phone]) VALUES (123456789, N'John Smith', N'jsmith@gmail.com', N'019650911')
INSERT [dbo].[Customer] ([id], [name], [email], [phone]) VALUES (333445555, N'Franklin Wong', NULL, N'019551208')
INSERT [dbo].[Customer] ([id], [name], [email], [phone]) VALUES (987654321, N'Jennifer Wallace', NULL, N'019410620')
INSERT [dbo].[Customer] ([id], [name], [email], [phone]) VALUES (987987987, N'Ahmed', N'ah@gmail.com', N'019690329')
INSERT [dbo].[Order] ([id], [customer_id], [order_date], [Status]) VALUES (1, 123456789, CAST(N'2019-10-18' AS Date), 0)
INSERT [dbo].[Order] ([id], [customer_id], [order_date], [Status]) VALUES (2, 333445555, CAST(N'2019-10-15' AS Date), 0)
INSERT [dbo].[Order] ([id], [customer_id], [order_date], [Status]) VALUES (3, 987654321, CAST(N'2019-10-20' AS Date), 0)
INSERT [dbo].[Order_Details] ([order_id], [product_id], [amount]) VALUES (1, N'B07YSMKN3K', 2)
INSERT [dbo].[Order_Details] ([order_id], [product_id], [amount]) VALUES (1, N'B50202300', 1)
INSERT [dbo].[Order_Details] ([order_id], [product_id], [amount]) VALUES (2, N'B005AK78LE', 5)
INSERT [dbo].[Order_Details] ([order_id], [product_id], [amount]) VALUES (3, N'B002LML46O', 2)
INSERT [dbo].[Product] ([id], [supplier_id], [name], [description], [price]) VALUES (N'B002LML46O', 3, N'Parmesan Vegetarian', N'Belgioioso, Parmesan Vegetarian', 24.9)
INSERT [dbo].[Product] ([id], [supplier_id], [name], [description], [price]) VALUES (N'B005AK75KI', 1, N'Hazelnut Oil', N'Roland Hazelnut Oil is flavorful oil with a strong, nutty flavor Its color runs from gold to amberIt is imported from France', 9.71)
INSERT [dbo].[Product] ([id], [supplier_id], [name], [description], [price]) VALUES (N'B005AK78LE', 1, N'Pure Sesame Oil', N'
Roland Sesame Oil is made from toasted, white sesame seeds. It has a dark, amber color and has a distinct, nutlike, aromatic flavor.', 32.62)
INSERT [dbo].[Product] ([id], [supplier_id], [name], [description], [price]) VALUES (N'B005MIWPGC', 2, N'All Natural Pure Vanilla Extract', NULL, 35.15)
INSERT [dbo].[Product] ([id], [supplier_id], [name], [description], [price]) VALUES (N'B01GHTS0IQ', 4, N'Chewy Chocolate Chip Cookies, Brownie', N' Created to be soft and chewy like they just came out of the oven, these crowd-pleasing cookies come filled with brownie and real chocolate chips to satisfy any sweet tooth.', 6.02)
INSERT [dbo].[Product] ([id], [supplier_id], [name], [description], [price]) VALUES (N'B07YSMKN3K', 4, N'Oreo Golden Double Stuf Sandwich Cookies', N'Twist `em, dunk `em, share `em, or enjoy them all on your own.', 1.99)
INSERT [dbo].[Product] ([id], [supplier_id], [name], [description], [price]) VALUES (N'B50202300', 3, N'Fresh Mozzarella Log', N'his convenient 1 pound log shape is ideal for slicing and layering atop lasagna or drizzled with olive oil and fresh basil.', 7.2)
INSERT [dbo].[Supplier] ([id], [name], [address], [website]) VALUES (1, N'Roland', N'New York, NY 10010
', N'www.rolandfood.com
')
INSERT [dbo].[Supplier] ([id], [name], [address], [website]) VALUES (2, N'Mccormick
', N'Hunt Valley, MD 21031-1100
', N'www.mccormickgourmet.com
')
INSERT [dbo].[Supplier] ([id], [name], [address], [website]) VALUES (3, N'Belgioioso Cheese, Inc.', N'American Fork, Utah 84003 U.S.A
', NULL)
INSERT [dbo].[Supplier] ([id], [name], [address], [website]) VALUES (4, N'Nabisco', N'P.O. Box 226497 Doral, FL 33222-6497
', N'www.nabisco.com
')
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Customer] FOREIGN KEY([customer_id])
REFERENCES [dbo].[Customer] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Customer]
GO
ALTER TABLE [dbo].[Order_Details]  WITH CHECK ADD  CONSTRAINT [FK_Order_Details_Order] FOREIGN KEY([order_id])
REFERENCES [dbo].[Order] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Order_Details] CHECK CONSTRAINT [FK_Order_Details_Order]
GO
ALTER TABLE [dbo].[Order_Details]  WITH CHECK ADD  CONSTRAINT [FK_Order_Details_Product] FOREIGN KEY([product_id])
REFERENCES [dbo].[Product] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Order_Details] CHECK CONSTRAINT [FK_Order_Details_Product]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Supplier] FOREIGN KEY([supplier_id])
REFERENCES [dbo].[Supplier] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Supplier]
GO
USE [master]
GO
ALTER DATABASE [Grocery] SET  READ_WRITE 
GO

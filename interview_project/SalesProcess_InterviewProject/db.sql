USE [SalesProcess]
GO
/****** Object:  StoredProcedure [dbo].[spUpdateCustomer]    Script Date: 4/28/2023 12:39:07 PM ******/
DROP PROCEDURE IF EXISTS [dbo].[spUpdateCustomer]
GO
/****** Object:  StoredProcedure [dbo].[spInsertCustomer]    Script Date: 4/28/2023 12:39:07 PM ******/
DROP PROCEDURE IF EXISTS [dbo].[spInsertCustomer]
GO
/****** Object:  StoredProcedure [dbo].[spGetOpenCustomerOrders]    Script Date: 4/28/2023 12:39:07 PM ******/
DROP PROCEDURE IF EXISTS [dbo].[spGetOpenCustomerOrders]
GO
/****** Object:  StoredProcedure [dbo].[spGetItemPrice]    Script Date: 4/28/2023 12:39:07 PM ******/
DROP PROCEDURE IF EXISTS [dbo].[spGetItemPrice]
GO
/****** Object:  StoredProcedure [dbo].[spGetItemList]    Script Date: 4/28/2023 12:39:07 PM ******/
DROP PROCEDURE IF EXISTS [dbo].[spGetItemList]
GO
/****** Object:  StoredProcedure [dbo].[spGetCustomerOrderTotal]    Script Date: 4/28/2023 12:39:07 PM ******/
DROP PROCEDURE IF EXISTS [dbo].[spGetCustomerOrderTotal]
GO
/****** Object:  StoredProcedure [dbo].[spGetCustomerList]    Script Date: 4/28/2023 12:39:07 PM ******/
DROP PROCEDURE IF EXISTS [dbo].[spGetCustomerList]
GO
/****** Object:  StoredProcedure [dbo].[spGetCustomerDetail]    Script Date: 4/28/2023 12:39:07 PM ******/
DROP PROCEDURE IF EXISTS [dbo].[spGetCustomerDetail]
GO
/****** Object:  StoredProcedure [dbo].[spGetAllCustomerOrders]    Script Date: 4/28/2023 12:39:07 PM ******/
DROP PROCEDURE IF EXISTS [dbo].[spGetAllCustomerOrders]
GO
/****** Object:  StoredProcedure [dbo].[spDeleteCustomer]    Script Date: 4/28/2023 12:39:07 PM ******/
DROP PROCEDURE IF EXISTS [dbo].[spDeleteCustomer]
GO
/****** Object:  StoredProcedure [dbo].[spCreateOrder]    Script Date: 4/28/2023 12:39:07 PM ******/
DROP PROCEDURE IF EXISTS [dbo].[spCreateOrder]
GO
/****** Object:  StoredProcedure [dbo].[spAddOrderItem]    Script Date: 4/28/2023 12:39:07 PM ******/
DROP PROCEDURE IF EXISTS [dbo].[spAddOrderItem]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CustomerOrderItem]') AND type in (N'U'))
ALTER TABLE [dbo].[CustomerOrderItem] DROP CONSTRAINT IF EXISTS [FK_Item_CustomerOrderItem]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CustomerOrderItem]') AND type in (N'U'))
ALTER TABLE [dbo].[CustomerOrderItem] DROP CONSTRAINT IF EXISTS [FK_CustomerOrder_CustomerOrderItem]
GO
/****** Object:  Table [dbo].[OrderStatus]    Script Date: 4/28/2023 12:39:07 PM ******/
DROP TABLE IF EXISTS [dbo].[OrderStatus]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 4/28/2023 12:39:07 PM ******/
DROP TABLE IF EXISTS [dbo].[Item]
GO
/****** Object:  Table [dbo].[CustomerOrderItem]    Script Date: 4/28/2023 12:39:07 PM ******/
DROP TABLE IF EXISTS [dbo].[CustomerOrderItem]
GO
/****** Object:  Table [dbo].[CustomerOrder]    Script Date: 4/28/2023 12:39:07 PM ******/
DROP TABLE IF EXISTS [dbo].[CustomerOrder]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 4/28/2023 12:39:07 PM ******/
DROP TABLE IF EXISTS [dbo].[Customer]
GO
/****** Object:  UserDefinedFunction [dbo].[ufnOrderTotal]    Script Date: 4/28/2023 12:39:07 PM ******/
DROP FUNCTION IF EXISTS [dbo].[ufnOrderTotal]
GO
/****** Object:  UserDefinedFunction [dbo].[ufnCustomerOrderTotal]    Script Date: 4/28/2023 12:39:07 PM ******/
DROP FUNCTION IF EXISTS [dbo].[ufnCustomerOrderTotal]
GO
USE [master]
GO
/****** Object:  Database [SalesProcess]    Script Date: 4/28/2023 12:39:07 PM ******/
DROP DATABASE IF EXISTS [SalesProcess]
GO
/****** Object:  Database [SalesProcess]    Script Date: 4/28/2023 12:39:07 PM ******/
CREATE DATABASE [SalesProcess]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SalesProcess', FILENAME = N'C:\localdb\SalesProcess.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SalesProcess_log', FILENAME = N'C:\localdb\SalesProcess_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [SalesProcess] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SalesProcess].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SalesProcess] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SalesProcess] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SalesProcess] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SalesProcess] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SalesProcess] SET ARITHABORT OFF 
GO
ALTER DATABASE [SalesProcess] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SalesProcess] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SalesProcess] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SalesProcess] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SalesProcess] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SalesProcess] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SalesProcess] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SalesProcess] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SalesProcess] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SalesProcess] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SalesProcess] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SalesProcess] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SalesProcess] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SalesProcess] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SalesProcess] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SalesProcess] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SalesProcess] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SalesProcess] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SalesProcess] SET  MULTI_USER 
GO
ALTER DATABASE [SalesProcess] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SalesProcess] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SalesProcess] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SalesProcess] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SalesProcess] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SalesProcess] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SalesProcess] SET QUERY_STORE = ON
GO
ALTER DATABASE [SalesProcess] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
ALTER AUTHORIZATION ON DATABASE::[SalesProcess] TO [WIN\karlp]
GO
USE [SalesProcess]
GO
/****** Object:  UserDefinedFunction [dbo].[ufnCustomerOrderTotal]    Script Date: 4/28/2023 12:39:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ufnCustomerOrderTotal](@OrderId int)
RETURNS decimal(18,2)
AS
BEGIN
    DECLARE @returnVal decimal(18,2);

    SELECT @returnVal = SUM(o.Qty * o.Price)
	FROM CustomerOrderItem o
	WHERE o.OrderId = @OrderId

    RETURN @returnVal;
END;
GO
ALTER AUTHORIZATION ON [dbo].[ufnCustomerOrderTotal] TO  SCHEMA OWNER 
GO
/****** Object:  UserDefinedFunction [dbo].[ufnOrderTotal]    Script Date: 4/28/2023 12:39:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ufnOrderTotal](@OrderId int)
RETURNS decimal(18,2)
AS
BEGIN
    DECLARE @returnVal decimal(18,2);

    SELECT @returnVal = SUM(o.Qty * o.Price)
	FROM OrderItem o
	WHERE o.OrderId = @OrderId

    RETURN @returnVal;
END;
GO
ALTER AUTHORIZATION ON [dbo].[ufnOrderTotal] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 4/28/2023 12:39:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Address] [nvarchar](100) NULL,
	[City] [nvarchar](50) NULL,
	[State] [nvarchar](50) NULL,
	[ZipCode] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[Customer] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[CustomerOrder]    Script Date: 4/28/2023 12:39:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerOrder](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[ShipDttm] [datetime] NOT NULL,
	[OrderTotal]  AS ([dbo].[ufnCustomerOrderTotal]([Id])),
	[Status] [int] NOT NULL,
 CONSTRAINT [PK__Customer__3214EC07501CCB7F] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[CustomerOrder] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[CustomerOrderItem]    Script Date: 4/28/2023 12:39:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerOrderItem](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NULL,
	[ItemId] [int] NULL,
	[Qty] [int] NULL,
	[Price] [decimal](18, 0) NULL,
	[Total]  AS ([Qty]*[Price]),
 CONSTRAINT [PK__OrderDet__3214EC074C20FFFF] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[CustomerOrderItem] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Item]    Script Date: 4/28/2023 12:39:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ItemNumber] [nvarchar](50) NULL,
	[ItemName] [nvarchar](50) NULL,
	[ItemPrice] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[Item] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[OrderStatus]    Script Date: 4/28/2023 12:39:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderStatus](
	[OrderStatusId] [int] NOT NULL,
	[OrderStatusName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_OrderStatus] PRIMARY KEY CLUSTERED 
(
	[OrderStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[OrderStatus] TO  SCHEMA OWNER 
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 
GO
INSERT [dbo].[Customer] ([Id], [FirstName], [LastName], [Address], [City], [State], [ZipCode]) VALUES (1, N'Michael', N'Jordan', N'1901 W Madison St.', N'Chicago', N'IL', N'60612')
GO
INSERT [dbo].[Customer] ([Id], [FirstName], [LastName], [Address], [City], [State], [ZipCode]) VALUES (3, N'Patrick', N'Ewing', N'4 Pennsylvania Plaza', N'New York', N'NY', N'10001')
GO
INSERT [dbo].[Customer] ([Id], [FirstName], [LastName], [Address], [City], [State], [ZipCode]) VALUES (4, N'Dennis', N'Rodman', N' 2645 Woodward Ave', N'Detroit', N'MI', N'48201')
GO
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[CustomerOrder] ON 
GO
INSERT [dbo].[CustomerOrder] ([Id], [CustomerId], [ShipDttm], [Status]) VALUES (1, 4, CAST(N'2023-04-28T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[CustomerOrder] ([Id], [CustomerId], [ShipDttm], [Status]) VALUES (2, 4, CAST(N'2023-04-28T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[CustomerOrder] ([Id], [CustomerId], [ShipDttm], [Status]) VALUES (3, 4, CAST(N'2023-04-28T00:00:00.000' AS DateTime), 1)
GO
SET IDENTITY_INSERT [dbo].[CustomerOrder] OFF
GO
SET IDENTITY_INSERT [dbo].[CustomerOrderItem] ON 
GO
INSERT [dbo].[CustomerOrderItem] ([Id], [OrderId], [ItemId], [Qty], [Price]) VALUES (1, 1, 5, 4, CAST(150 AS Decimal(18, 0)))
GO
INSERT [dbo].[CustomerOrderItem] ([Id], [OrderId], [ItemId], [Qty], [Price]) VALUES (2, 1, 6, 1, CAST(75 AS Decimal(18, 0)))
GO
INSERT [dbo].[CustomerOrderItem] ([Id], [OrderId], [ItemId], [Qty], [Price]) VALUES (3, 1, 5, 1, CAST(150 AS Decimal(18, 0)))
GO
INSERT [dbo].[CustomerOrderItem] ([Id], [OrderId], [ItemId], [Qty], [Price]) VALUES (4, 1, 7, 2, CAST(1000 AS Decimal(18, 0)))
GO
SET IDENTITY_INSERT [dbo].[CustomerOrderItem] OFF
GO
SET IDENTITY_INSERT [dbo].[Item] ON 
GO
INSERT [dbo].[Item] ([Id], [ItemNumber], [ItemName], [ItemPrice]) VALUES (1, N'1000', N'Air Jordan Shoes', CAST(200.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Item] ([Id], [ItemNumber], [ItemName], [ItemPrice]) VALUES (2, N'1001', N'Chicago Area Mansion', CAST(25000000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Item] ([Id], [ItemNumber], [ItemName], [ItemPrice]) VALUES (3, N'1002', N'Corvette', CAST(250000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Item] ([Id], [ItemNumber], [ItemName], [ItemPrice]) VALUES (4, N'2001', N'Manhattan Penthouse', CAST(10000000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Item] ([Id], [ItemNumber], [ItemName], [ItemPrice]) VALUES (5, N'2001', N'Reebok Pumps Shoes', CAST(150.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Item] ([Id], [ItemNumber], [ItemName], [ItemPrice]) VALUES (6, N'2002', N'Official NBA Basketball', CAST(75.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Item] ([Id], [ItemNumber], [ItemName], [ItemPrice]) VALUES (7, N'2003', N'NBA Playoff Ticket', CAST(1000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Item] ([Id], [ItemNumber], [ItemName], [ItemPrice]) VALUES (8, N'2004', N'Lebron James Autograph', CAST(250.00 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[Item] OFF
GO
INSERT [dbo].[OrderStatus] ([OrderStatusId], [OrderStatusName]) VALUES (1, N'Open')
GO
INSERT [dbo].[OrderStatus] ([OrderStatusId], [OrderStatusName]) VALUES (2, N'Pending')
GO
INSERT [dbo].[OrderStatus] ([OrderStatusId], [OrderStatusName]) VALUES (3, N'Shipped')
GO
INSERT [dbo].[OrderStatus] ([OrderStatusId], [OrderStatusName]) VALUES (4, N'Complete')
GO
INSERT [dbo].[OrderStatus] ([OrderStatusId], [OrderStatusName]) VALUES (5, N'Cancelled')
GO
INSERT [dbo].[OrderStatus] ([OrderStatusId], [OrderStatusName]) VALUES (6, N'Returned')
GO
ALTER TABLE [dbo].[CustomerOrderItem]  WITH CHECK ADD  CONSTRAINT [FK_CustomerOrder_CustomerOrderItem] FOREIGN KEY([OrderId])
REFERENCES [dbo].[CustomerOrder] ([Id])
GO
ALTER TABLE [dbo].[CustomerOrderItem] CHECK CONSTRAINT [FK_CustomerOrder_CustomerOrderItem]
GO
ALTER TABLE [dbo].[CustomerOrderItem]  WITH CHECK ADD  CONSTRAINT [FK_Item_CustomerOrderItem] FOREIGN KEY([ItemId])
REFERENCES [dbo].[Item] ([Id])
GO
ALTER TABLE [dbo].[CustomerOrderItem] CHECK CONSTRAINT [FK_Item_CustomerOrderItem]
GO
/****** Object:  StoredProcedure [dbo].[spAddOrderItem]    Script Date: 4/28/2023 12:39:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spAddOrderItem] (@OrderId int, @ItemId int, @Qty int, @Price decimal(18,2))
AS

BEGIN

	INSERT INTO dbo.CustomerOrderItem
	(OrderId,ItemId,Qty,Price)
	VALUES
	(@OrderId,@ItemId,@Qty,@Price)

END

GO
ALTER AUTHORIZATION ON [dbo].[spAddOrderItem] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[spCreateOrder]    Script Date: 4/28/2023 12:39:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCreateOrder] (@CustomerId INT, @ShipDttm DateTime, 
	@ItemId int, @Qty int, @Price decimal(18,2))
AS

BEGIN

	BEGIN TRANSACTION

		INSERT INTO dbo.CustomerOrder 
		(CustomerId, ShipDttm, Status)
		VALUES (@CustomerId, @ShipDttm, 1)

		if @@error != 0 raiserror('Script failed', 20, -1) 

		DECLARE @NewId INT
		SELECT @NewId = SCOPE_IDENTITY()

		if @@error != 0 raiserror('Script failed', 20, -1) 
 
		INSERT INTO dbo.CustomerOrderItem
		(OrderId,ItemId,Qty,Price)
		VALUES
		(@NewId,@ItemId,@Qty,@Price)

		if @@error != 0 raiserror('Script failed', 20, -1) 

	COMMIT TRANSACTION

END

GO
ALTER AUTHORIZATION ON [dbo].[spCreateOrder] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[spDeleteCustomer]    Script Date: 4/28/2023 12:39:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDeleteCustomer](@Id int)
AS
BEGIN
    DELETE FROM Customer 
    WHERE Id = @Id
END
GO
ALTER AUTHORIZATION ON [dbo].[spDeleteCustomer] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[spGetAllCustomerOrders]    Script Date: 4/28/2023 12:39:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetAllCustomerOrders] 
AS
BEGIN
	SELECT CustomerName = (c.FirstName + ' ' + c.LastName), ItemDescription = (SELECT ItemNumber + ItemName AS 'ItemDescription' FROM Item WHERE Id = i.Id),
	i.Qty, i.Price, i.Total, o.ShipDttm, o.Id as 'OrderId', o.OrderTotal, 
	OrderStatus = (SELECT TOP 1 OrderStatusName FROM OrderStatus WHERE OrderStatusId = o.Status)
	FROM CustomerOrder o, CustomerOrderItem i, Customer c
	WHERE o.Id = I.OrderId  
	AND c.Id = o.CustomerId


END

GO
ALTER AUTHORIZATION ON [dbo].[spGetAllCustomerOrders] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[spGetCustomerDetail]    Script Date: 4/28/2023 12:39:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetCustomerDetail] (@CustomerId INT)
AS
BEGIN
	SELECT Id, FirstName, LastName,
	Address, City, State,
	ZipCode
	FROM Customer
	WHERE Id = @CustomerId
END

GO
ALTER AUTHORIZATION ON [dbo].[spGetCustomerDetail] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[spGetCustomerList]    Script Date: 4/28/2023 12:39:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetCustomerList]
AS
BEGIN
	SELECT Id, FirstName, LastName,
	Address, City, State,
	ZipCode
	FROM dbo.Customer
END

GO
ALTER AUTHORIZATION ON [dbo].[spGetCustomerList] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[spGetCustomerOrderTotal]    Script Date: 4/28/2023 12:39:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[spGetCustomerOrderTotal] (@CustomerId INT)
AS
BEGIN
	SELECT o.OrderTotal
	FROM CustomerOrder o
	WHERE o.Status = 1
	AND o.CustomerId = @CustomerId

END

GO
ALTER AUTHORIZATION ON [dbo].[spGetCustomerOrderTotal] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[spGetItemList]    Script Date: 4/28/2023 12:39:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetItemList]
AS
BEGIN

	SELECT Id = 0, 'ItemDescription' = ''
	UNION
	SELECT Id, ItemNumber + ' - ' + ItemName as 'ItemDescription'
	FROM dbo.Item
END

GO
ALTER AUTHORIZATION ON [dbo].[spGetItemList] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[spGetItemPrice]    Script Date: 4/28/2023 12:39:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetItemPrice] (@Id INT)
AS
BEGIN

	SELECT ItemPrice
	FROM dbo.Item
	WHERE Id = @Id

END


GO
ALTER AUTHORIZATION ON [dbo].[spGetItemPrice] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[spGetOpenCustomerOrders]    Script Date: 4/28/2023 12:39:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetOpenCustomerOrders] (@CustomerId INT)
AS
BEGIN
	SELECT ItemDescription = (SELECT ItemNumber + ItemName AS 'ItemDescription' FROM Item WHERE Id = i.Id),
	 i.Qty, i.Price, i.Total, o.ShipDttm, o.Id as 'OrderId'
	FROM CustomerOrder o, CustomerOrderItem i
	WHERE o.Id = I.OrderId  
	AND o.Status = 1
	AND o.CustomerId = @CustomerId

END

GO
ALTER AUTHORIZATION ON [dbo].[spGetOpenCustomerOrders] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[spInsertCustomer]    Script Date: 4/28/2023 12:39:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertCustomer](@FirstName nvarchar(50), @LastName nvarchar(50), 
  @Address nvarchar(100), @City nvarchar(50), @State nvarchar(50), 
  @ZipCode nvarchar(10), @NewId int output)
AS
BEGIN
    INSERT INTO Customer (FirstName, LastName, Address, City, State, ZipCode)
    VALUES  (@FirstName, @LastName, @Address, @City, @State, @ZipCode)

    SELECT @NewId = SCOPE_IDENTITY()
    SELECT @NewId AS NewId
END


GO
ALTER AUTHORIZATION ON [dbo].[spInsertCustomer] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[spUpdateCustomer]    Script Date: 4/28/2023 12:39:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdateCustomer](@Id int, @FirstName nvarchar(50), @LastName nvarchar(50), 
  @Address nvarchar(100), @City nvarchar(50), @State nvarchar(50), @ZipCode nvarchar(10))
AS
BEGIN
    UPDATE Customer 
    SET FirstName = @FirstName, LastName = @LastName, Address = @Address, 
    City = @City, State = @State, ZipCode = @ZipCode
    WHERE Id = @Id
END
GO
ALTER AUTHORIZATION ON [dbo].[spUpdateCustomer] TO  SCHEMA OWNER 
GO
USE [master]
GO
ALTER DATABASE [SalesProcess] SET  READ_WRITE 
GO

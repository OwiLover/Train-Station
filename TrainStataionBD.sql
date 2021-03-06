USE [master]
GO
/****** Object:  Database [TrainStation]    Script Date: 13.02.2022 23:13:45 ******/
CREATE DATABASE [TrainStation]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TrainStation', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TrainStation.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TrainStation_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TrainStation_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TrainStation] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TrainStation].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TrainStation] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TrainStation] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TrainStation] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TrainStation] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TrainStation] SET ARITHABORT OFF 
GO
ALTER DATABASE [TrainStation] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TrainStation] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TrainStation] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TrainStation] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TrainStation] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TrainStation] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TrainStation] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TrainStation] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TrainStation] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TrainStation] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TrainStation] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TrainStation] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TrainStation] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TrainStation] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TrainStation] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TrainStation] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TrainStation] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TrainStation] SET RECOVERY FULL 
GO
ALTER DATABASE [TrainStation] SET  MULTI_USER 
GO
ALTER DATABASE [TrainStation] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TrainStation] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TrainStation] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TrainStation] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TrainStation] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TrainStation] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TrainStation', N'ON'
GO
ALTER DATABASE [TrainStation] SET QUERY_STORE = OFF
GO
USE [TrainStation]
GO
/****** Object:  Table [dbo].[Administrator]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administrator](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[First] [varchar](50) NULL,
	[Second] [varchar](50) NULL,
	[Birth] [date] NULL,
	[Gender] [char](1) NULL,
	[DocNum] [int] NULL,
	[IdAuth] [int] NULL,
 CONSTRAINT [PK_Administrator] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Auth]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Auth](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Login] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Auth] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[City]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[City](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cityName] [char](20) NULL,
	[cityCost] [money] NULL,
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Director]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Director](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[First] [varchar](50) NULL,
	[Second] [varchar](50) NULL,
	[Birth] [date] NULL,
	[Gender] [char](1) NULL,
	[DocNum] [int] NULL,
	[IdAuth] [int] NULL,
 CONSTRAINT [PK_Director] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](30) NULL,
	[Price] [money] NULL,
	[Storage] [int] NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Model]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Model](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ModelName] [char](20) NULL,
	[costModel] [money] NULL,
 CONSTRAINT [PK_Model_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ModelTrain]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ModelTrain](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idModel] [int] NULL,
	[trainName] [nchar](30) NULL,
 CONSTRAINT [PK_Model] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Moderator]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Moderator](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[First] [varchar](50) NULL,
	[Second] [varchar](50) NULL,
	[Birth] [date] NULL,
	[Gender] [char](1) NULL,
	[DocNum] [int] NULL,
	[IdAuth] [int] NULL,
 CONSTRAINT [PK_Сontroller] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdPassenger] [int] NULL,
	[IdTrip] [int] NULL,
	[IdVagons] [int] NULL,
	[IdSched] [int] NULL,
	[Cost] [money] NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Passenger]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Passenger](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[First] [varchar](50) NOT NULL,
	[Second] [varchar](50) NOT NULL,
	[Birth] [date] NOT NULL,
	[Gender] [char](1) NOT NULL,
	[DocNum] [int] NOT NULL,
	[IdAuth] [int] NOT NULL,
 CONSTRAINT [PK_Passenger] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Schedule]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Schedule](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdModerator] [int] NULL,
	[IdTrip] [int] NULL,
	[Departure] [datetime] NULL,
	[Arrival] [datetime] NULL,
	[Duration]  AS (datediff(minute,[Departure],[Arrival])),
 CONSTRAINT [PK_Schedule] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShopList]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShopList](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idPass] [int] NOT NULL,
	[idItems] [int] NOT NULL,
	[counter] [int] NOT NULL,
	[idTrip] [int] NULL,
	[idOrder] [int] NULL,
 CONSTRAINT [PK_ShopList] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trip]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trip](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdTrain] [int] NULL,
	[IdDestinationCity] [int] NULL,
	[Name] [varchar](30) NULL,
	[Line] [int] NULL,
 CONSTRAINT [PK_Trip] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vagon]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vagon](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[vagonCost] [money] NULL,
	[Seats] [int] NULL,
	[Name] [nchar](20) NULL,
 CONSTRAINT [PK_ModelTrain] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vagons]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vagons](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idVagon] [int] NULL,
	[idTrain] [int] NULL,
 CONSTRAINT [PK_Vagons] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Administrator]  WITH CHECK ADD  CONSTRAINT [FK_Administrator_Auth] FOREIGN KEY([IdAuth])
REFERENCES [dbo].[Auth] ([Id])
GO
ALTER TABLE [dbo].[Administrator] CHECK CONSTRAINT [FK_Administrator_Auth]
GO
ALTER TABLE [dbo].[Director]  WITH CHECK ADD  CONSTRAINT [FK_Director_Auth] FOREIGN KEY([IdAuth])
REFERENCES [dbo].[Auth] ([Id])
GO
ALTER TABLE [dbo].[Director] CHECK CONSTRAINT [FK_Director_Auth]
GO
ALTER TABLE [dbo].[ModelTrain]  WITH CHECK ADD  CONSTRAINT [FK_ModelTrain_Model] FOREIGN KEY([idModel])
REFERENCES [dbo].[Model] ([id])
GO
ALTER TABLE [dbo].[ModelTrain] CHECK CONSTRAINT [FK_ModelTrain_Model]
GO
ALTER TABLE [dbo].[Moderator]  WITH CHECK ADD  CONSTRAINT [FK_Сontroller_Auth] FOREIGN KEY([IdAuth])
REFERENCES [dbo].[Auth] ([Id])
GO
ALTER TABLE [dbo].[Moderator] CHECK CONSTRAINT [FK_Сontroller_Auth]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Order_Passenger] FOREIGN KEY([IdPassenger])
REFERENCES [dbo].[Passenger] ([Id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Order_Passenger]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Order_Trip] FOREIGN KEY([IdTrip])
REFERENCES [dbo].[Trip] ([Id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Order_Trip]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Vagons] FOREIGN KEY([IdVagons])
REFERENCES [dbo].[Vagons] ([id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Vagons]
GO
ALTER TABLE [dbo].[Passenger]  WITH CHECK ADD  CONSTRAINT [PassengerAuth] FOREIGN KEY([IdAuth])
REFERENCES [dbo].[Auth] ([Id])
GO
ALTER TABLE [dbo].[Passenger] CHECK CONSTRAINT [PassengerAuth]
GO
ALTER TABLE [dbo].[Schedule]  WITH CHECK ADD  CONSTRAINT [FK_Schedule_Trip] FOREIGN KEY([IdTrip])
REFERENCES [dbo].[Trip] ([Id])
GO
ALTER TABLE [dbo].[Schedule] CHECK CONSTRAINT [FK_Schedule_Trip]
GO
ALTER TABLE [dbo].[Schedule]  WITH CHECK ADD  CONSTRAINT [FK_Schedule_Сontroller] FOREIGN KEY([IdModerator])
REFERENCES [dbo].[Moderator] ([Id])
GO
ALTER TABLE [dbo].[Schedule] CHECK CONSTRAINT [FK_Schedule_Сontroller]
GO
ALTER TABLE [dbo].[ShopList]  WITH CHECK ADD  CONSTRAINT [FK_ShopList_Item] FOREIGN KEY([idItems])
REFERENCES [dbo].[Item] ([Id])
GO
ALTER TABLE [dbo].[ShopList] CHECK CONSTRAINT [FK_ShopList_Item]
GO
ALTER TABLE [dbo].[ShopList]  WITH CHECK ADD  CONSTRAINT [FK_ShopList_Trip] FOREIGN KEY([idTrip])
REFERENCES [dbo].[Trip] ([Id])
GO
ALTER TABLE [dbo].[ShopList] CHECK CONSTRAINT [FK_ShopList_Trip]
GO
ALTER TABLE [dbo].[Trip]  WITH CHECK ADD  CONSTRAINT [FK_Trip_City] FOREIGN KEY([IdDestinationCity])
REFERENCES [dbo].[City] ([id])
GO
ALTER TABLE [dbo].[Trip] CHECK CONSTRAINT [FK_Trip_City]
GO
ALTER TABLE [dbo].[Trip]  WITH CHECK ADD  CONSTRAINT [FK_Trip_ModelTrain] FOREIGN KEY([IdTrain])
REFERENCES [dbo].[ModelTrain] ([id])
GO
ALTER TABLE [dbo].[Trip] CHECK CONSTRAINT [FK_Trip_ModelTrain]
GO
ALTER TABLE [dbo].[Vagons]  WITH CHECK ADD  CONSTRAINT [FK_Vagons_ModelTrain] FOREIGN KEY([idTrain])
REFERENCES [dbo].[ModelTrain] ([id])
GO
ALTER TABLE [dbo].[Vagons] CHECK CONSTRAINT [FK_Vagons_ModelTrain]
GO
ALTER TABLE [dbo].[Vagons]  WITH CHECK ADD  CONSTRAINT [FK_Vagons_Vagon] FOREIGN KEY([idVagon])
REFERENCES [dbo].[Vagon] ([id])
GO
ALTER TABLE [dbo].[Vagons] CHECK CONSTRAINT [FK_Vagons_Vagon]
GO
/****** Object:  StoredProcedure [dbo].[addCity]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[addCity]

@CityName char(20),
@Cost money

AS

INSERT INTO City (cityName,cityCost)
VALUES (@CityName, @Cost)
GO
/****** Object:  StoredProcedure [dbo].[addItem]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[addItem]
@ItemName varchar(30),
@Storage int,
@Cost money
AS
INSERT INTO Item (Name, Storage, Price) VALUES (@ItemName, @Storage, @Cost)
GO
/****** Object:  StoredProcedure [dbo].[addModel]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[addModel]
@ModelName char(20),
@Cost money
AS

INSERT INTO Model (ModelName ,costModel) VALUES (@ModelName, @Cost)
GO
/****** Object:  StoredProcedure [dbo].[AddSched]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddSched]
@IdModer int,
@TripName varchar(30),
@Departure datetime,
@Arrival datetime

AS

INSERT INTO Schedule (IdModerator, IdTrip, Departure, Arrival)
VALUES (@IdModer, (SELECT Trip.Id FROM Trip WHERE Trip.Name=@TripName), @Departure, @Arrival)
GO
/****** Object:  StoredProcedure [dbo].[addTrain]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[addTrain]
@TrainName nchar(30),
@ModelName nchar(20)
AS

INSERT INTO ModelTrain (trainName, idModel) VALUES (@TrainName, (SELECT Model.id FROM Model WHERE Model.ModelName=@ModelName));
GO
/****** Object:  StoredProcedure [dbo].[AddTrip]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddTrip]

@TrainName nchar(30),
@CityName nchar(20),
@TripName varchar(30),
@Line int

AS

INSERT INTO Trip (IdTrain, IdDestinationCity, Name, Line)
VALUES ((SELECT MT.id FROM ModelTrain MT
WHERE MT.trainName=@TrainName),(SELECT C.id FROM City C
WHERE C.cityName =@CityName), @TripName, @Line)
GO
/****** Object:  StoredProcedure [dbo].[addVagon]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[addVagon]

@VagonName nchar(20),
@Seats int,
@Price money

AS

INSERT INTO Vagon (Name, Seats, vagonCost) VALUES (@VagonName, @Seats, @Price)
GO
/****** Object:  StoredProcedure [dbo].[costCity]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[costCity]

@CityName char(20),
@Cost money

AS

UPDATE City SET cityCost =@Cost WHERE City.cityName = @CityName;
GO
/****** Object:  StoredProcedure [dbo].[deleteAdmin]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[deleteAdmin]

@IdAdmin int

AS
INSERT INTO Passenger SELECT First, Second, Birth, Gender, DocNum, IdAuth FROM Administrator WHERE Administrator.Id = @IdAdmin

DELETE FROM Administrator WHERE Id = @IdAdmin
GO
/****** Object:  StoredProcedure [dbo].[deleteCity]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[deleteCity]
@IdCity int

AS

DELETE FROM Orders WHERE Orders.IdTrip IN (select Trip.Id FROM Trip JOIN City on City.id=Trip.IdDestinationCity WHERE City.id=@IdCity)
DELETE FROM Schedule WHERE IdTrip IN (select Trip.Id FROM Trip JOIN City on City.id=Trip.IdDestinationCity WHERE City.id=@IdCity)
DELETE FROM Trip WHERE Trip.IdDestinationCity=@IdCity

DELETE FROM City WHERE City.id=@IdCity
GO
/****** Object:  StoredProcedure [dbo].[deleteItem]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[deleteItem]
@IdItem int
AS

DELETE FROM ShopList WHERE ShopList.idItems=@IdItem
DELETE FROM Item WHERE Item.Id=@IdItem
GO
/****** Object:  StoredProcedure [dbo].[deleteModel]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[deleteModel]
@IdModel int
AS

DELETE FROM Orders 
DELETE FROM Orders WHERE Orders.IdTrip IN (SELECT T.Id FROM Trip T JOIN ModelTrain MT on MT.id=T.IdTrain WHERE MT.idModel=@IdModel)
DELETE FROM ShopList WHERE ShopList.idTrip IN (SELECT T.Id FROM Trip T JOIN ModelTrain MT on MT.id=T.IdTrain WHERE MT.idModel=@IdModel)
DELETE FROM Schedule WHERE Schedule.IdTrip IN (SELECT T.Id FROM Trip T JOIN ModelTrain MT on MT.id=T.IdTrain WHERE MT.idModel=@IdModel)
DELETE FROM Trip WHERE Trip.IdTrain IN (SELECT ModelTrain.idModel FROM ModelTrain WHERE ModelTrain.idModel=@IdModel)
DELETE FROM Vagons WHERE Vagons.idTrain IN (SELECT ModelTrain.idModel FROM ModelTrain WHERE ModelTrain.idModel=@IdModel)
DELETE FROM ModelTrain WHERE ModelTrain.idModel = @IdModel
DELETE FROM Model WHERE Model.id = @IdModel
GO
/****** Object:  StoredProcedure [dbo].[deleteModer]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[deleteModer]
@IdModer int

AS
INSERT INTO Passenger SELECT First, Second, Birth, Gender, DocNum, IdAuth FROM Moderator WHERE Moderator.Id = @IdModer
DELETE FROM Schedule WHERE Schedule.IdModerator=@IdModer
DELETE FROM Moderator WHERE Id = @IdModer
GO
/****** Object:  StoredProcedure [dbo].[deleteOrder]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[deleteOrder]
@IdOrder int

AS

DELETE FROM Orders WHERE Orders.Id=@IdOrder

DELETE FROM ShopList WHERE ShopList.idOrder =@IdOrder
GO
/****** Object:  StoredProcedure [dbo].[deleteSched]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[deleteSched]
@IdSched int

AS

DELETE FROM Schedule WHERE Schedule.Id=@IdSched
GO
/****** Object:  StoredProcedure [dbo].[deleteTrains]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[deleteTrains]
@IdTrain int

AS

DELETE FROM Orders WHERE Orders.IdTrip IN (SELECT T.Id FROM Trip T WHERE T.IdTrain=@IdTrain)
DELETE FROM ShopList WHERE ShopList.idTrip IN (SELECT T.Id FROM Trip T WHERE T.IdTrain=@IdTrain)
DELETE FROM Schedule WHERE Schedule.IdTrip IN (SELECT T.Id FROM Trip T WHERE T.IdTrain=@IdTrain)
DELETE FROM Trip WHERE Trip.IdTrain =@IdTrain
DELETE FROM Vagons WHERE Vagons.idTrain =@IdTrain
DELETE FROM ModelTrain WHERE ModelTrain.id = @IdTrain
GO
/****** Object:  StoredProcedure [dbo].[DeleteTrip]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteTrip]
@IdTrip int

AS
DELETE FROM ShopList WHERE ShopList.idTrip=@IdTrip
DELETE FROM Orders WHERE Orders.IdTrip=@IdTrip
DELETE FROM Schedule WHERE Schedule.IdTrip=@IdTrip
DELETE FROM Trip where Id = @IdTrip
GO
/****** Object:  StoredProcedure [dbo].[deleteVagon]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[deleteVagon]
@IdVagons int

AS

DELETE FROM ShopList WHERE idOrder in (SELECT Orders.Id FROM ORDERS JOIN Vagons on Vagons.id = Orders.IdVagons WHERE Vagons.id=@IdVagons)
DELETE FROM Orders WHERE IdVagons = @IdVagons
DELETE FROM Vagons WHERE id = @IdVagons
GO
/****** Object:  StoredProcedure [dbo].[ItemHistory]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ItemHistory]
@idPass int,
@idTrip int,
@idOrder int
AS
SELECT I.Name, Sh.counter, I.Price * Sh.counter FROM ShopList Sh
JOIN Item I on I.Id = Sh.idItems
JOIN Orders O on O.Id=Sh.idOrder
WHERE Sh.idPass=@idPass AND Sh.idTrip=@IdTrip AND O.Id = @idOrder;
GO
/****** Object:  StoredProcedure [dbo].[MakeAdmin]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MakeAdmin]
	@IdAuth int
	
AS
INSERT INTO Administrator SELECT First, Second, Birth, Gender, DocNum, IdAuth FROM Passenger WHERE IdAuth = @IdAuth

DELETE FROM Orders WHERE IdPassenger = (SELECT Id FROM Passenger WHERE IdAuth = @IdAuth)
DELETE FROM ShopList WHERE IdPass = (SELECT Id FROM Passenger WHERE IdAuth = @IdAuth)

DELETE FROM Passenger WHERE IdAuth = @IdAuth

GO
/****** Object:  StoredProcedure [dbo].[MakeModer]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MakeModer]
	@IdAuth int
	
AS
INSERT INTO Moderator SELECT First, Second, Birth, Gender, DocNum, IdAuth FROM Passenger WHERE IdAuth = @IdAuth

DELETE FROM Orders WHERE IdPassenger = (SELECT Id FROM Passenger WHERE IdAuth = @IdAuth)
DELETE FROM ShopList WHERE IdPass = (SELECT Id FROM Passenger WHERE IdAuth = @IdAuth)

DELETE FROM Passenger WHERE IdAuth = @IdAuth
GO
/****** Object:  StoredProcedure [dbo].[MakeOrder]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MakeOrder]
	@IdTrip int,
	@IdPass int,
	@IdVagons int,
	@IdSched int,
	@Cost money
AS
BEGIN
	SET NOCOUNT ON
INSERT INTO Orders (IdTrip, IdPassenger, IdVagons, IdSched, Cost)
VALUES (@IdTrip, @IdPass, @IdVagons, @IdSched, @Cost)

SELECT SCOPE_IDENTITY()
END
GO
/****** Object:  StoredProcedure [dbo].[MakeShoplist]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MakeShoplist]
@IdPass int, 
@IdItem int,
@count int,
@IdTrip int,
@IdOrder int

AS

INSERT INTO ShopList (idPass, idItems, counter, idTrip, idOrder)
VALUES (@IdPass, @IdItem, @count, @IdTrip, @IdOrder)
GO
/****** Object:  StoredProcedure [dbo].[OrderInfo]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OrderInfo]

@IdPassenger int

AS

SELECT Sch.Departure, T.Line, C.cityName, M.ModelName, V.Name, O.Cost, T.Id, O.Id FROM Orders O
JOIN Trip T on T.Id=O.IdTrip
JOIN City C on C.id=T.IdDestinationCity
JOIN Schedule Sch on Sch.Id = O.IdSched
JOIN ModelTrain MT on MT.id=T.IdTrain
JOIN Model M on M.id=MT.idModel
JOIN Vagons Vg on Vg.id=O.IdVagons
JOIN Vagon V on V.id=Vg.idVagon
WHERE O.IdPassenger=@IdPassenger
GO
/****** Object:  StoredProcedure [dbo].[SchedUpdate]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SchedUpdate] 

@CityName char(20),
@Line int,
@Train nchar(30),
@IdSched int,
@Depart datetime,
@Arriv datetime
AS

UPDATE Trip
SET Line = @Line, IdTrain = (SELECT MT.id FROM ModelTrain MT WHERE MT.trainName=@Train), IdDestinationCity = (SELECT City.id FROM City WHERE City.cityName=@CityName)
WHERE Trip.Id = (SELECT IdTrip FROM Schedule WHERE Schedule.Id=@IdSched)

UPDATE Schedule

SET Departure = @Depart, Arrival = @Arriv
WHERE Schedule.Id = @IdSched
GO
/****** Object:  StoredProcedure [dbo].[TripDateList]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TripDateList]
AS
SELECT DISTINCT CONVERT (VARCHAR(10),Sch.Departure,104)  FROM Trip T
	JOIN City C on C.id=T.IdDestinationCity
	JOIN ModelTrain MT on MT.id=T.IdTrain
	JOIN Model M on M.id= MT.idModel
	JOIN Vagons Vg on Vg.idTrain=MT.id
	JOIN Vagon V on V.id=Vg.idVagon
	JOIN Schedule Sch on Sch.IdTrip=T.Id
	Group by C.cityName, Sch.Departure, Sch.Duration, M.ModelName, V.Name
GO
/****** Object:  StoredProcedure [dbo].[TripInfo]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TripInfo]

AS
SELECT C.cityName, Sch.Departure, Sch.Duration, M.ModelName, V.Name, SUM(C.cityCost + M.costModel + V.vagonCost)/COUNT(V.vagonCost), SUM (V.Seats)- (SELECT COUNT(O.Id) FROM Orders O WHERE O.IdTrip=T.Id AND O.IdSched= Sch.Id AND O.IdVagons=Vg.id) , T.Id, Vg.id, Sch.Id FROM Trip T
	JOIN City C on C.id=T.IdDestinationCity
	JOIN ModelTrain MT on MT.id=T.IdTrain
	JOIN Model M on M.id= MT.idModel
	JOIN Vagons Vg on Vg.idTrain=MT.id
	JOIN Vagon V on V.id=Vg.idVagon
	JOIN Schedule Sch on Sch.IdTrip=T.Id
	Group by C.cityName, Sch.Departure, Sch.Duration, M.ModelName, V.Name, V.Seats, T.Id, Vg.id, Sch.Id
GO
/****** Object:  StoredProcedure [dbo].[TripInfoChoose]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TripInfoChoose]
 @WhatINeed CHAR(20)
AS
SELECT DISTINCT @WhatINeed FROM Trip T
	JOIN City C on C.id=T.IdDestinationCity
	JOIN ModelTrain MT on MT.id=T.IdTrain
	JOIN Model M on M.id= MT.idModel
	JOIN Vagons Vg on Vg.idTrain=MT.idVagons
	JOIN Vagon V on V.id=Vg.idVagon
	JOIN Schedule Sch on Sch.IdTrip=T.Id
	Group by C.cityName, Sch.Departure, Sch.Duration, M.ModelName, V.Name
GO
/****** Object:  StoredProcedure [dbo].[TripModelList]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TripModelList]
AS
SELECT DISTINCT M.ModelName FROM Trip T
	JOIN City C on C.id=T.IdDestinationCity
	JOIN ModelTrain MT on MT.id=T.IdTrain
	JOIN Model M on M.id= MT.idModel
	JOIN Vagons Vg on Vg.idTrain=MT.id
	JOIN Vagon V on V.id=Vg.idVagon
	JOIN Schedule Sch on Sch.IdTrip=T.Id
	Group by C.cityName, Sch.Departure, Sch.Duration, M.ModelName, V.Name
GO
/****** Object:  StoredProcedure [dbo].[TripNameList]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TripNameList]
AS
SELECT DISTINCT C.cityName FROM Trip T
	JOIN City C on C.id=T.IdDestinationCity
	JOIN ModelTrain MT on MT.id=T.IdTrain
	JOIN Model M on M.id= MT.idModel
	JOIN Vagons Vg on Vg.idTrain=MT.id
	JOIN Vagon V on V.id=Vg.idVagon
	JOIN Schedule Sch on Sch.IdTrip=T.Id
	Group by C.cityName, Sch.Departure, Sch.Duration, M.ModelName, V.Name
GO
/****** Object:  StoredProcedure [dbo].[TripVagonList]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TripVagonList]
AS
SELECT DISTINCT V.Name FROM Trip T
	JOIN City C on C.id=T.IdDestinationCity
	JOIN ModelTrain MT on MT.id=T.IdTrain
	JOIN Model M on M.id= MT.idModel
	JOIN Vagons Vg on Vg.idTrain=MT.id
	JOIN Vagon V on V.id=Vg.idVagon
	JOIN Schedule Sch on Sch.IdTrip=T.Id
	Group by C.cityName, Sch.Departure, Sch.Duration, M.ModelName, V.Name
GO
/****** Object:  StoredProcedure [dbo].[updateItem]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updateItem]
@ItemName varchar(30),
@Cost money,
@Storage int
AS
UPDATE Item SET Price = @Cost, Storage = @Storage WHERE Name = @ItemName
GO
/****** Object:  StoredProcedure [dbo].[updateModel]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updateModel]

@ModelName char(20),
@Cost money
AS

UPDATE Model SET costModel =@Cost WHERE Model.ModelName =@ModelName
GO
/****** Object:  StoredProcedure [dbo].[updateVagons]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updateVagons]
@VagonName nchar(20),
@Seats int,
@Cost money

AS

UPDATE Vagon SET vagonCost = @Cost, Seats = @Seats WHERE Vagon.Name = @VagonName
GO
/****** Object:  StoredProcedure [dbo].[vagonDelete]    Script Date: 13.02.2022 23:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[vagonDelete]

@IdVagon int

AS

DELETE FROM ShopList WHERE idOrder = (SELECT Orders.id FROM Orders JOIN Vagons V on V.id=Orders.IdVagons WHERE V.idVagon=@IdVagon)
DELETE FROM Orders WHERE IdVagons = (SELECT Vagons.Id FROM Vagons WHERE Vagons.idVagon=@IdVagon)
DELETE FROM Vagons WHERE idVagon = @IdVagon
DELETE FROM Vagon WHERE id = @IdVagon
GO
USE [master]
GO
ALTER DATABASE [TrainStation] SET  READ_WRITE 
GO

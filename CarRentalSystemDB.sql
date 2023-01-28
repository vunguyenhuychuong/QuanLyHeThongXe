CREATE DATABASE CarRentalSystemDB
GO

USE CarRentalSystemDB
GO

CREATE TABLE CarProducer(
	ProducerID NVARCHAR(25) NOT NULL PRIMARY KEY, 
	ProcuderName NVARCHAR(50) NOT NULL, 
	Address NVARCHAR(100) NOT NULL, 
	Country NVARCHAR(25) NOT NULL
);
GO

CREATE TABLE Car(
	CarID NVARCHAR(25) NOT NULL PRIMARY KEY, 
	CarName NVARCHAR(50) NOT NULL, 
	CarModelYear int, 
	Color NVARCHAR(25) NOT NULL , 
	Capacity INT, 
	Description NVARCHAR(250) NOT NULL, 
	ImportDate DATETIME, 
	RentPrice DECIMAL, 
	Status INT,
	ProducerID NVARCHAR(25) REFERENCES [CarProducer](ProducerID) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

CREATE TABLE Customer (
	CustomerID NVARCHAR(25) NOT NULL PRIMARY KEY, 
	CustomerName NVARCHAR(100) NOT NULL, 
	Mobile NVARCHAR(20) NOT NULL,  
	CustomerEmail NVARCHAR(50) NOT NULL, 
 	CustomerPassword NVARCHAR(50) NOT NULL, 
	IdentityCard NVARCHAR(50) NOT NULL, 
	LicenceNumber NVARCHAR(50) NOT NULL, 
	LicenceDate DATETIME
);
GO

CREATE TABLE CarRental (
	CustomerID NVARCHAR(25) REFERENCES [Customer](CustomerID ) ON DELETE CASCADE ON UPDATE CASCADE, 
	CarID NVARCHAR(25) REFERENCES [Car](CarID ) ON DELETE CASCADE ON UPDATE CASCADE, 
	PickupDate DATETIME, 
	ReturnDate DATETIME, 
	RentPrice DECIMAL, 
	PRIMARY KEY (CustomerID, CarID, PickupDate, ReturnDate)
);
GO

CREATE TABLE Review (
	CustomerID NVARCHAR(25) REFERENCES [Customer](CustomerID ) ON DELETE CASCADE ON UPDATE CASCADE, 
	CarID NVARCHAR(25) REFERENCES [Car](CarID ) ON DELETE CASCADE ON UPDATE CASCADE,  
	ReviewStar INT, 
	Comment NVARCHAR(250),
	PRIMARY KEY (CustomerID, CarID)
);
GO

CREATE TABLE StaffAccount 
(
 	StaffID NVARCHAR(25) PRIMARY KEY,
 	FullName NVARCHAR(250) NOT NULL,
 	Email NVARCHAR(250) NOT NULL, 
 	Password NVARCHAR(50), 
 	Role int
);
GO


USE [CarRentalSystemDB]
GO

INSERT [dbo].[CarProducer] ([ProducerID], [ProcuderName], [Address], [Country]) VALUES (N'P00001', N'Toyota', N'1 Toyota-Cho, Toyota City, Aichi Prefecture 471-8571', N'Japan')
GO
INSERT [dbo].[CarProducer] ([ProducerID], [ProcuderName], [Address], [Country]) VALUES (N'P00002', N'Mercedes Benz', N'693 Quang Trung Street, Ward 8, Go Vap District, HCMC', N'Viet Nam')
GO
INSERT [dbo].[CarProducer] ([ProducerID], [ProcuderName], [Address], [Country]) VALUES (N'P00003', N'Land Cruiser Exporters', N'Lot 47 D11 Street, Phuoc Dong Industrial Park, Go Dau District, Tay Ninh Province', N'Viet Nam')
GO
INSERT [dbo].[CarProducer] ([ProducerID], [ProcuderName], [Address], [Country]) VALUES (N'P00004', N'Volvo', N'VAK building Gunnar Engellaus väg Göteborg', N'Sweden ')
GO
INSERT [dbo].[CarProducer] ([ProducerID], [ProcuderName], [Address], [Country]) VALUES (N'P00005', N'Volkswagen ', N'Berliner Ring 2, 38440 Wolfsburg', N'Germany')
GO


INSERT [dbo].[Car] ([CarID], [CarName], [CarModelYear], [Color], [Capacity], [Description], [ImportDate], [RentPrice], [Status], [ProducerID]) VALUES (N'CA0001', N'Mercedes-Benz GLB 200 AMG ', 2021, N'Bkue', 7, N'Mercedes-Benz GLB 200 AMG ', CAST(N'2021-01-01T00:00:00.000' AS DateTime), CAST(100 AS Decimal(18, 0)), 1, N'P00002')
GO
INSERT [dbo].[Car] ([CarID], [CarName], [CarModelYear], [Color], [Capacity], [Description], [ImportDate], [RentPrice], [Status], [ProducerID]) VALUES (N'CA0002', N'Mercedes-Benz GLB 35 4MATIC', 2022, N'White', 4, N'Mercedes-Benz GLB 35 4MATIC', CAST(N'2022-01-01T00:00:00.000' AS DateTime), CAST(120 AS Decimal(18, 0)), 1, N'P00002')
GO
INSERT [dbo].[Car] ([CarID], [CarName], [CarModelYear], [Color], [Capacity], [Description], [ImportDate], [RentPrice], [Status], [ProducerID]) VALUES (N'CA0003', N'Mercedes-Benz E 180 ', 2022, N'Brown', 7, N'Mercedes-Benz E 180 ', CAST(N'2022-01-02T00:00:00.000' AS DateTime), CAST(130 AS Decimal(18, 0)), 1, N'P00002')
GO
INSERT [dbo].[Car] ([CarID], [CarName], [CarModelYear], [Color], [Capacity], [Description], [ImportDate], [RentPrice], [Status], [ProducerID]) VALUES (N'CA0004', N'Mercedes-Benz E 300 AMG ', 2022, N'Red', 7, N'Mercedes-Benz E 300 AMG ', CAST(N'2022-01-06T00:00:00.000' AS DateTime), CAST(120 AS Decimal(18, 0)), 1, N'P00002')
GO
INSERT [dbo].[Car] ([CarID], [CarName], [CarModelYear], [Color], [Capacity], [Description], [ImportDate], [RentPrice], [Status], [ProducerID]) VALUES (N'CA0005', N'Toyota Innova E 2.0MT', 2022, N'White', 4, N'Innova E 2.0MT', CAST(N'2022-01-09T00:00:00.000' AS DateTime), CAST(120 AS Decimal(18, 0)), 1, N'P00001')
GO
INSERT [dbo].[Car] ([CarID], [CarName], [CarModelYear], [Color], [Capacity], [Description], [ImportDate], [RentPrice], [Status], [ProducerID]) VALUES (N'CA0006', N'Toyota Innova Venturer', 2022, N'Red', 7, N'Toyota Innova Venturer', CAST(N'2022-09-20T00:00:00.000' AS DateTime), CAST(125 AS Decimal(18, 0)), 1, N'P00001')
GO
INSERT [dbo].[Car] ([CarID], [CarName], [CarModelYear], [Color], [Capacity], [Description], [ImportDate], [RentPrice], [Status], [ProducerID]) VALUES (N'CA0007', N'Volkswagen Teramont 2021', 2021, N'White', 7, N'Volkswagen Teramont 2021', CAST(N'2021-06-06T00:00:00.000' AS DateTime), CAST(120 AS Decimal(18, 0)), 1, N'P00005')
GO
INSERT [dbo].[Car] ([CarID], [CarName], [CarModelYear], [Color], [Capacity], [Description], [ImportDate], [RentPrice], [Status], [ProducerID]) VALUES (N'CA0008', N'Volkswagen The New Tiguan', 2022, N'Blue', 7, N'Volkswagen The New Tiguan', CAST(N'2022-09-01T00:00:00.000' AS DateTime), CAST(120 AS Decimal(18, 0)), 1, N'P00005')
GO
INSERT [dbo].[Car] ([CarID], [CarName], [CarModelYear], [Color], [Capacity], [Description], [ImportDate], [RentPrice], [Status], [ProducerID]) VALUES (N'CA0009', N'GLC 200 Mercedes-Benz', 2022, N'Brown', 7, N'GLC 200 Mercedes-Benz', CAST(N'2022-01-01T00:00:00.000' AS DateTime), CAST(120 AS Decimal(18, 0)), 1, N'P00002')
GO
INSERT [dbo].[Car] ([CarID], [CarName], [CarModelYear], [Color], [Capacity], [Description], [ImportDate], [RentPrice], [Status], [ProducerID]) VALUES (N'CA0010', N'Mercedes C200 Avantgarde Plus', 2023, N'White', 7, N'Mercedes C200 Avantgarde Plus', CAST(N'2023-01-01T00:00:00.000' AS DateTime), CAST(150 AS Decimal(18, 0)), 1, N'P00002')
GO



INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [Mobile], [CustomerEmail], [CustomerPassword], [IdentityCard], [LicenceNumber], [LicenceDate]) VALUES (N'C00001', N'Alexander Swearingen', N'0903991395', N'AlexanderSwearingen@FURentelSystem.com',  N'abc@123', N'2219304555', N'12355555', CAST(N'2015-12-12T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [Mobile], [CustomerEmail], [CustomerPassword],  [IdentityCard], [LicenceNumber], [LicenceDate]) VALUES (N'C00002', N'Mohamed Maher Ata', N'0909444445', N'MohamedMaherAta@FURentalSystem.com', N'abc@123', N'2593586668', N'12355556', CAST(N'2018-06-19T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [Mobile], [CustomerEmail], [CustomerPassword],  [IdentityCard], [LicenceNumber], [LicenceDate]) VALUES (N'C00003', N'Praveen Kumar Rajendran', N'0993399449', N'PraveenKumarRajendran@FURetalSystem.com', N'abc@123', N'2893334533', N'34578902', CAST(N'2019-07-23T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [Mobile], [CustomerEmail], [CustomerPassword],  [IdentityCard], [LicenceNumber], [LicenceDate]) VALUES (N'C00004', N'Sean Drewry', N'0964443332', N'SeanDrewry@FURentalSystem.com', N'abc@123', N'2384445593', N'34557990', CAST(N'2020-03-06T00:00:00.000' AS DateTime))
GO



INSERT [dbo].[CarRental] ([CustomerID], [CarID], [PickupDate], [ReturnDate], [RentPrice]) VALUES (N'C00001', N'CA0001', CAST(N'2022-12-01T00:00:00.000' AS DateTime), CAST(N'2022-12-09T00:00:00.000' AS DateTime), CAST(120 AS Decimal(18, 0)))
GO
INSERT [dbo].[CarRental] ([CustomerID], [CarID], [PickupDate], [ReturnDate], [RentPrice]) VALUES (N'C00001', N'CA0001', CAST(N'2023-01-16T00:00:00.000' AS DateTime), CAST(N'2023-01-19T00:00:00.000' AS DateTime), CAST(120 AS Decimal(18, 0)))
GO
INSERT [dbo].[CarRental] ([CustomerID], [CarID], [PickupDate], [ReturnDate], [RentPrice]) VALUES (N'C00002', N'CA0001', CAST(N'2022-12-10T00:00:00.000' AS DateTime), CAST(N'2022-12-15T00:00:00.000' AS DateTime), CAST(120 AS Decimal(18, 0)))
GO
INSERT [dbo].[CarRental] ([CustomerID], [CarID], [PickupDate], [ReturnDate], [RentPrice]) VALUES (N'C00002', N'CA0002', CAST(N'2022-12-05T00:00:00.000' AS DateTime), CAST(N'2022-12-06T00:00:00.000' AS DateTime), CAST(120 AS Decimal(18, 0)))
GO
INSERT [dbo].[CarRental] ([CustomerID], [CarID], [PickupDate], [ReturnDate], [RentPrice]) VALUES (N'C00003', N'CA0001', CAST(N'2023-01-01T00:00:00.000' AS DateTime), CAST(N'2023-01-15T00:00:00.000' AS DateTime), CAST(120 AS Decimal(18, 0)))
GO



INSERT [dbo].[Review] ([CustomerID], [CarID], [ReviewStar], [Comment]) VALUES (N'C00001', N'CA0001', 10, N'Good')
GO
INSERT [dbo].[Review] ([CustomerID], [CarID], [ReviewStar], [Comment]) VALUES (N'C00002', N'CA0001', 9, N'Good')
GO
INSERT [dbo].[Review] ([CustomerID], [CarID], [ReviewStar], [Comment]) VALUES (N'C00002', N'CA0002', 10, N'OK')
GO


INSERT [dbo].[StaffAccount] ([StaffID], [FullName], [Email], [Password], [Role]) VALUES (N'NV0005', N'Technical Manager', N'TechnicalManager@FURentalSystem.com', N'abc@123', 1)
GO
INSERT [dbo].[StaffAccount] ([StaffID], [FullName], [Email], [Password], [Role]) VALUES (N'NV0006', N'HR Manager', N'HRManager@FURentalSystem.com', N'abc@123', 1)
GO
INSERT [dbo].[StaffAccount] ([StaffID], [FullName], [Email], [Password], [Role]) VALUES (N'NV0007', N'HR Staff 1', N'Staff1@FURentalSystem.com', N'abc@123', 2)
GO
INSERT [dbo].[StaffAccount] ([StaffID], [FullName], [Email], [Password], [Role]) VALUES (N'NV0008', N'HR Staff 2', N'Staff2@FURentalSystem.com', N'abc@123', 2)
GO
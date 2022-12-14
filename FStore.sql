USE master
CREATE DATABASE FStore
GO

USE FStore
GO

CREATE TABLE Member(
	MemberId INT NOT NULL,
	Email VARCHAR(100) NOT NULL,
	CompanyName VARCHAR(40) NOT NULL,
	City VARCHAR(15) NOT NULL,
	Country VARCHAR(15) NOT NULL,
	Password VARCHAR(30) NOT NULL,
	CONSTRAINT PK_Member PRIMARY KEY CLUSTERED(MemberId) 
	WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT INTO Member(MemberId, Email, CompanyName, City, Country, Password) VALUES (1, 'admin@fstore.com', 'ABC Company', 'Ho Chi Minh', 'Vietnam', 'admin@@')


CREATE TABLE Product(
	ProductId INT NOT NULL,
	CategoryId INT NOT NULL,
	ProductName VARCHAR(40) NOT NULL,
	Weight VARCHAR(20) NOT NULL,
	UnitPrice MONEY NOT NULL,
	UnitsInStock INT NOT NULL,
	CONSTRAINT PK_Product PRIMARY KEY CLUSTERED (ProductId)
	WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [Order](
	OrderId INT NOT NULL,
	MemberId INT NOT NULL,
	OrderDate DATETIME NOT NULL,
	RequiredDate DATETIME,
	ShippedDate DATETIME,
	Freight MONEY,
	CONSTRAINT PK_Order PRIMARY KEY CLUSTERED(OrderId)
	WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
	CONSTRAINT FK_Order FOREIGN KEY(MemberId) REFERENCES Member(MemberId) ON UPDATE CASCADE ON DELETE CASCADE
) ON [PRIMARY]
GO

CREATE TABLE Detail(
	OrderId INT NOT NULL,
	ProductId INT NOT NULL,
	UnitPrice MONEY NOT NULL,
	Quantity INT NOT NULL,
	Discount FLOAT NOT NULL,
	CONSTRAINT PK_Detail PRIMARY KEY CLUSTERED(OrderId, ProductId)
	WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
	CONSTRAINT FK_Detail_Order FOREIGN KEY (OrderId) REFERENCES [Order](OrderId) ON UPDATE CASCADE ON DELETE CASCADE,
	CONSTRAINT FK_Detail_ProductId FOREIGN KEY (ProductId) REFERENCES Product(ProductId)
) ON [PRIMARY]
GO

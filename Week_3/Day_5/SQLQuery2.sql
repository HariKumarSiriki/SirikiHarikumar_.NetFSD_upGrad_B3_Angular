CREATE DATABASE EcommDb


USE EcommDb;


CREATE TABLE Categories
(
CategoryId INT PRIMARY KEY,
CategoryName VARCHAR(50)
)

INSERT INTO Categories VALUES
(1,'Cars'),
(2,'Bikes'),
(3,'Electric')

SELECT * FROM Categories;

CREATE TABLE Products
(
ProductId INT PRIMARY KEY,
ProductName VARCHAR(50),
CategoryId INT,
ModelYear INT,
ListPrice DECIMAL(10,2),
FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId)
)
INSERT INTO Products VALUES
(1,'Civic',1,2023,20000),
(2,'Creta',1,2024,25000),
(3,'Yamaha',2,2023,5000)

SELECT * FROM Products;

CREATE TABLE Customers
(
CustomerId INT PRIMARY KEY,
FirstName VARCHAR(50),
LastName VARCHAR(50),
City VARCHAR(50)
)

INSERT INTO Customers VALUES
(1,'Rahul','Kumar','Hyderabad'),
(2,'Sneha','Reddy','Vizag'),
(3,'Amit','Sharma','Delhi')

SELECT * FROM Customers


CREATE TABLE Stores
(
StoreId INT PRIMARY KEY,
StoreName VARCHAR(50),
City VARCHAR(50)
)
INSERT INTO Stores VALUES
(1,'AutoStore','Hyderabad'),
(2,'CityStore','Vizag')

SELECT * FROM Stores;

CREATE TABLE Orders
(
OrderId INT PRIMARY KEY,
CustomerId INT,
StoreId INT,
OrderDate DATE,
FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId),
FOREIGN KEY (StoreId) REFERENCES Stores(StoreId)
)
INSERT INTO Orders VALUES
(1,1,1,'2024-01-10'),
(2,2,2,'2024-01-15')

SELECT * FROM Orders;

CREATE TABLE OrderItems
(
ItemId INT PRIMARY KEY,
OrderId INT,
ProductId INT,
Quantity INT,
Price DECIMAL(10,2),
FOREIGN KEY (OrderId) REFERENCES Orders(OrderId),
FOREIGN KEY (ProductId) REFERENCES Products(ProductId)
)
INSERT INTO OrderItems VALUES
(1,1,1,1,20000),
(2,2,3,2,10000)

SELECT*FROM OrderItems



---PROBLEM1

SELECT 
p.ProductName,
c.CategoryName,
p.ModelYear,
p.ListPrice
FROM Products p
INNER JOIN Categories c
ON p.CategoryId = c.CategoryId

SELECT *
FROM Customers
WHERE City = 'Vizag'


SELECT 
c.CategoryName,
COUNT(p.ProductId) AS TotalProducts
FROM Categories c
LEFT JOIN Products p
ON c.CategoryId = p.CategoryId
GROUP BY c.CategoryName




---problem2

CREATE VIEW ProductDetails
AS
SELECT 
p.ProductName,
c.CategoryName,
p.ModelYear,
p.ListPrice
FROM Products p
JOIN Categories c
ON p.CategoryId = c.CategoryId

SELECT * FROM ProductDetails


CREATE VIEW OrderDetails
AS
SELECT
o.OrderId,
c.FirstName AS StaffFirstName,
c.LastName AS StaffLastName,
s.StoreName,
o.OrderDate
FROM Orders o
JOIN Customers c
ON o.CustomerId = c.CustomerId
JOIN Stores s
ON o.StoreId = s.StoreId

SELECT * FROM OrderDetails


CREATE INDEX idxProductCategory
ON Products(CategoryId)

CREATE INDEX idxProductBrand
ON Products(ProductId)

CREATE INDEX idxOrderCustomer
ON Orders(CustomerId)

CREATE INDEX idxOrderStore
ON Orders(StoreId)

SELECT *
FROM Orders
WHERE CustomerId = 2
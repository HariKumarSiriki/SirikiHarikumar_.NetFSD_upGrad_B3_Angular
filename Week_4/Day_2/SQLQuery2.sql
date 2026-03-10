
USE RetaiDb


CREATE TABLE Products (
    ProductId INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Price DECIMAL(10,2),
    StockQuantity INT
);

INSERT INTO Products VALUES
(1,'Laptop',50000,10),
(2,'Mouse',500,50),
(3,'Keyboard',1200,30),
(4,'Monitor',15000,15);
SELECT* FROM Products


CREATE TABLE Customers (
    CustomerId INT PRIMARY KEY,
    CustomerName VARCHAR(100),
    Email VARCHAR(100)
);

INSERT INTO Customers VALUES
(1,'Rahul','rahul@gmail.com'),
(2,'Mani','mani@gmail.com'),
(3,'Hari','hari@gmail.com');

SELECT * FROM Customers


CREATE TABLE Orders (
    OrderId INT PRIMARY KEY,
    CustomerId INT,
    OrderDate DATE,
    OrderStatus INT,
    FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId)
);
INSERT INTO Orders VALUES
(101,1,'2026-03-10',1),
(102,2,'2026-03-10',1);

SELECT * FROM Orders


CREATE TABLE OrderItems (
    OrderItemId INT PRIMARY KEY,
    OrderId INT,
    ProductId INT,
    Quantity INT,
    Price DECIMAL(10,2),

    FOREIGN KEY (OrderId) REFERENCES Orders(OrderId),
    FOREIGN KEY (ProductId) REFERENCES Products(ProductId)
);

INSERT INTO OrderItems VALUES
(1,101,1,1,50000),
(2,101,2,2,500),
(3,102,3,1,1200);

SELECT * FROM OrderItems




---PROBLEM1

CREATE TRIGGER ReduceStock
ON OrderItems
AFTER INSERT
AS
BEGIN

UPDATE Products
SET StockQuantity = StockQuantity - inserted.Quantity
FROM Products
JOIN inserted
ON Products.ProductId = inserted.ProductId

IF EXISTS (SELECT * FROM Products WHERE StockQuantity < 0)
BEGIN
PRINT 'Stock not available'
ROLLBACK TRANSACTION
END

END

BEGIN TRANSACTION

INSERT INTO Orders
VALUES (103,1,'2026-03-11',1)

INSERT INTO OrderItems
VALUES (4,103,1,2,50000)
COMMIT


SELECT * FROM Products;
SELECT * FROM Orders;
SELECT * FROM OrderItems;

BEGIN TRANSACTION

INSERT INTO Orders
VALUES (105,1,'2026-03-11',1)

INSERT INTO OrderItems
VALUES (6,105,1,50,50000)

COMMIT



----PROBLEM2


BEGIN TRANSACTION

SAVE TRANSACTION BeforeRestore

BEGIN TRY

UPDATE Products
SET StockQuantity = StockQuantity + OrderItems.Quantity
FROM Products
JOIN OrderItems
ON Products.ProductId = OrderItems.ProductId
WHERE OrderItems.OrderId = 103

UPDATE Orders
SET OrderStatus = 3
WHERE OrderId = 103

COMMIT

PRINT 'Order cancelled successfully'

END TRY

BEGIN CATCH

ROLLBACK TRANSACTION BeforeRestore
PRINT 'Error while cancelling order'

END CATCH


SELECT * FROM Products
SELECT * FROM Orders
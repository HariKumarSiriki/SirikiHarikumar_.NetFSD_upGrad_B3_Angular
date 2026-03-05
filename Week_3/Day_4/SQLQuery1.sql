CREATE DATABASE autoDB;

USE autoDB;


CREATE TABLE categories(
    categoryId INT PRIMARY KEY,
    categoryname VARCHAR(100)
);


INSERT INTO categories VALUES
(1,'Cars'),
(2,'Bikes'),
(3,'Accessories');

SELECT * FROM categories;

CREATE TABLE products(
    productId INT PRIMARY KEY,
    productName VARCHAR(100),
    categoryId INT,
    modelYear INT,
    list_price DECIMAL(10,2),
    FOREIGN KEY(categoryId) REFERENCES categories(categoryId)
);

INSERT INTO products VALUES
(1,'Speed Bike',2,2017,15000),
(2,'Mountain Bike',2,2018,8000),
(3,'Road Bike',2,2019,12000),
(4,'Car Helmet',3,2018,2000),
(5,'Racing Car',1,2020,25000);

SELECT * FROM products;

CREATE TABLE customers(
    customerId INT PRIMARY KEY,
    firstName VARCHAR(50),
    lastName VARCHAR(50)
);

INSERT INTO customers VALUES
(1,'Ravi','Kumar'),
(2,'Anita','Sharma'),
(3,'Rahul','Reddy'),
(4,'Sneha','Patel');

SELECT * FROM customers


CREATE TABLE orders(
    orderId INT PRIMARY KEY,
    customerId INT,
    orderStatus INT,
    orderDate DATE,
    requiredDate DATE,
    shippedDate DATE,
    storeId INT,
    FOREIGN KEY(customerId) REFERENCES customers(customerId)
);
INSERT INTO orders VALUES
(1,1,1,'2024-01-10','2024-01-15','2024-01-14',1),
(2,2,1,'2024-02-12','2024-02-18','2024-02-17',1),
(3,3,2,'2024-03-10','2024-03-15','2024-03-14',2);

SELECT * FROM orders;

CREATE TABLE order_items(
    orderId INT,
    productId INT,
    quantity INT,
    listPrice DECIMAL(10,2),
    discount DECIMAL(5,2),
    PRIMARY KEY(orderId, productId)
);
INSERT INTO order_items VALUES
(1,1,1,15000,500),
(1,4,2,2000,100),
(2,3,1,12000,200);

SELECT * FROM order_items

CREATE TABLE stores(
    storeId INT PRIMARY KEY,
    storeName VARCHAR(100)
);

INSERT INTO stores VALUES
(1,'Hyderabad Store'),
(2,'Bangalore Store');

SELECT * FROM stores

CREATE TABLE stocks(
    storeId INT,
    productId INT,
    quantity INT,
    PRIMARY KEY(storeId, productId)
);

INSERT INTO stocks VALUES
(1,1,10),
(1,3,5),
(2,2,0),
(2,4,8);

SELECT * FROM stocks



--PROBLEM1
SELECT productName,modelYear, list_price,

list_price -
(
SELECT AVG(list_price)
FROM products
WHERE categoryId = p.categoryId
) AS priceDifference

FROM products p

WHERE list_price >
(
SELECT AVG(list_price)
FROM products
WHERE categoryId = p.categoryId
);

----problem 4



SELECT 
    c.firstName,
    c.lastName,
    ISNULL(
        (
            SELECT SUM(oi.quantity * oi.listPrice)
            FROM orders o
            JOIN order_items oi 
            ON o.orderId = oi.orderId
            WHERE o.customerId = c.customerId
        ),
    ) AS totalOrderValue,
    CASE
        WHEN (
            SELECT SUM(oi.quantity * oi.listPrice)
            FROM orders o
            JOIN order_items oi ON o.orderId = oi.orderId
            WHERE o.customerId = c.customerId
        ) > 10000 THEN 'Premium'
        WHEN (
            SELECT SUM(oi.quantity * oi.listPrice)
            FROM orders o
            JOIN order_items oi ON o.orderId = oi.orderId
            WHERE o.customerId = c.customerId
        ) BETWEEN 5000 AND 10000 THEN 'Regular'
        ELSE 'Basic'
    END AS customer_type
FROM customers c
WHERE c.customerId IN (SELECT customerId FROM orders)

UNION
SELECT 
    c.firstName,
    c.lastName,
    0 AS total_order_value,
    'No Orders' AS customer_type

FROM customers c
WHERE c.customerId NOT IN (SELECT customerId FROM orders);







--problem3
SELECT storeName
FROM stores
WHERE storeId IN
(
    SELECT storeId
    FROM orders
    WHERE orderId IN
    (
        SELECT orderId
        FROM order_items
    )
);

SELECT productId
FROM order_items

INTERSECT

SELECT productId
FROM stocks;


SELECT productId
FROM order_items

EXCEPT

SELECT productId
FROM stocks;


SELECT 
s.storeName,
p.productName,
SUM(oi.quantity) AS total_quantity_sold
FROM order_items oi
JOIN orders o
ON oi.orderId = o.orderId
JOIN stores s
ON o.storeId = s.storeId
JOIN products p
ON oi.productId = p.productId
GROUP BY s.storeName, p.productName;



SELECT 
p.productName,
SUM((oi.quantity * oi.listPrice) - oi.discount) AS total_revenue
FROM order_items oi
JOIN products p
ON oi.productId = p.productId
GROUP BY p.productName;








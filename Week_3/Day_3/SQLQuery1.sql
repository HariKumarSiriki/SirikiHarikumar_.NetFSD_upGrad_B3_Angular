CREATE DATABASE StoreDb;

USE StoreDb;


--Problem 1 - Basic Customer Order Report--

CREATE TABLE customers (
customer_id INT PRIMARY KEY,
first_name VARCHAR(50),
last_name VARCHAR(50)
);

INSERT INTO customers VALUES
(1,'Ravi','Kumar'),
(2,'Anita','Sharma'),
(3,'Rahul','Reddy'),
(4,'Sneha','Patel');

SELECT * FROM customers;



CREATE TABLE orders (
order_id INT PRIMARY KEY,
customer_id INT,
storeId INT,
order_date DATE,
order_status VARCHAR(50),
FOREIGN KEY (customer_id) REFERENCES customers(customer_id),
FOREIGN KEY (storeId) REFERENCES stores(storeId)
);


INSERT INTO orders VALUES
(101,1,1,'2024-02-10','pending'),
(102,2,2,'2024-02-11','completed'),
(103,3,1,'2024-02-12','pending'),
(104,1,1,'2024-02-15','completed'),
(105,4,2,'2024-02-18','pending');

SELECT * FROM orders;

SELECT c.first_name, 
c.last_name,
o.order_id, 
o.order_date,
o.order_status
FROM customers c
INNER JOIN orders o
ON c.customer_id = o.customer_id
WHERE o.order_status = 'pending' OR o.order_status = 'completed'
ORDER BY o.order_date DESC;




--Product Price Listing by Category--

CREATE TABLE brands (
brandId INT PRIMARY KEY,
brandName VARCHAR(50)
);
INSERT INTO brands VALUES
(1,'Nike'),
(2,'Adidas'),
(3,'Puma');
SELECT * FROM brands;



CREATE TABLE categories (
categoryId INT PRIMARY KEY,
categoryName VARCHAR(50)
);

INSERT INTO categories VALUES
(1,'Shoes'),
(2,'Clothing'),
(3,'Accessories');

SELECT * FROM categories;

CREATE TABLE products (
productId INT PRIMARY KEY,
productName VARCHAR(100),
brandId INT,
categoryId INT,
modelYear INT,
listPrice DECIMAL(10,2),
FOREIGN KEY (brandId) REFERENCES brands(brandId),
FOREIGN KEY (categoryId) REFERENCES categories(categoryId)
);

INSERT INTO products VALUES
(101,'Running Shoes',1,1,2023,800),
(102,'Sports T-Shirt',2,2,2023,450),
(103,'Training Shoes',2,1,2024,900),
(104,'Cap',3,3,2023,300),
(105,'Jacket',1,2,2024,1200);


SELECT p.productName,
       b.brandName,
       c.categoryName,
       p.modelYear,
       p.listPrice
FROM products p
INNER JOIN brands b
ON p.brandId = b.brandId
INNER JOIN categories c
ON p.categoryId = c.categoryId
WHERE p.listPrice > 500
ORDER BY p.listPrice ASC;




--Store Wise Sales Summary--

CREATE TABLE stores (
storeId INT PRIMARY KEY,
storeName VARCHAR(100)
);

INSERT INTO stores VALUES
(1,'City Store'),
(2,'Central Store'),
(3,'Village Store');

SELECT * FROM stores;
CREATE TABLE orderItems (
orderId INT,
quantity INT,
listPrice DECIMAL(10,2),
discount DECIMAL(4,2),
FOREIGN KEY (orderId) REFERENCES orders(order_id)
);


INSERT INTO orderItems VALUES
(101,2,500,0.10),
(102,1,1000,0.05),
(104,3,400,0.00);
SELECT * FROM orderItems;


 
SELECT s.storeName,
SUM(oi.quantity * oi.listPrice * (1 - oi.discount)) AS total_sales
FROM stores s
INNER JOIN orders o
ON s.storeId = o.customer_id
INNER JOIN orderItems oi
ON o.order_id = oi.orderId
WHERE o.order_status = 'completed'
GROUP BY s.storeName
ORDER BY total_sales DESC;



CREATE TABLE stocks (
storeId INT,
productid INT,
quantity INT,
FOREIGN KEY (storeId) REFERENCES stores(storeId),
FOREIGN KEY (productid) REFERENCES products(productid)
);


INSERT INTO stocks VALUES
(1,101,50),
(1,102,30),
(2,101,40),
(2,103,20);

SELECT p.productName,
s.storeName,
st.quantity AS stock_quantity,
SUM(oi.quantity) AS total_sold
FROM stocks st
INNER JOIN products p
ON st.productId = p.productId
INNER JOIN stores s
ON st.storeId = s.storeId
LEFT JOIN orderItems oi
ON st.productId = oi.orderId
GROUP BY p.productName, s.storeName, st.quantity
ORDER BY p.productName;
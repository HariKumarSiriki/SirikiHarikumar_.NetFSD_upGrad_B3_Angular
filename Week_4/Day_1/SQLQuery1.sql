--use StoreDb;--

--problem1
CREATE PROCEDURE usp_TotalSalesPerStore
    @storeId INT
AS
BEGIN
    SELECT 
        o.storeId,
        SUM(oi.quantity * oi.listPrice) AS totalSales
    FROM orders o
    JOIN orderItems oi
        ON o.order_Id = oi.orderId
    WHERE o.storeId = @storeId
    GROUP BY o.storeId
END
EXEC usp_TotalSalesPerStore 1


CREATE PROCEDURE uspOrdersByDateRange
    @startDate DATE,
    @endDate DATE
AS
BEGIN
    SELECT *
    FROM orders
    WHERE order_date BETWEEN @startDate AND @endDate
END
EXEC uspOrdersByDateRange '2024-02-01','2024-02-15'

select * from  orders

CREATE FUNCTION fnCalculateDiscountPrice
(
    @price DECIMAL(10,2),
    @discount DECIMAL(5,2)
)
RETURNS DECIMAL(10,2)
AS
BEGIN
    RETURN @price - (@price * @discount)
END
SELECT dbo.fnCalculateDiscountPrice(1000,0.10)



CREATE FUNCTION fnTop5SellingProducts()
RETURNS TABLE
AS
RETURN
(
    SELECT TOP 5
        productId,
        COUNT(productId) AS totalSold
    FROM products
    GROUP BY productId
    ORDER BY totalSold DESC
)
SELECT * FROM dbo.fnTop5SellingProducts()



---problem 2

CREATE TRIGGER trgUpdateStock
ON orderItems
AFTER INSERT
AS
BEGIN
    BEGIN TRY

     
        IF EXISTS (
            SELECT 1
            FROM stocks s
            JOIN inserted i
            ON s.productId = i.productId
            WHERE s.quantity < i.quantity
        )
        BEGIN
            RAISERROR('Stock is insufficient for this product',16,1)
            ROLLBACK TRANSACTION
            RETURN
        END

       
        UPDATE s
        SET s.quantity = s.quantity - i.quantity
        FROM stocks s
        JOIN inserted i
        ON s.productId = i.productId

    END TRY

    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END

INSERT INTO orderItems(orderId,productId,quantity,listPrice,discount)
VALUES (101,1,2,500,0)
SELECT * FROM stocks
WHERE productId = 1


---problem3
CREATE TRIGGER trgValidateOrderStatus
ON orders
AFTER UPDATE
AS
BEGIN
    BEGIN TRY

        IF EXISTS (
            SELECT 1
            FROM inserted
            WHERE order_status = 4
            AND order_date IS NULL
        )
        BEGIN
            RAISERROR ('Shipped date cannot be NULL when order status is Completed',16,1)
            ROLLBACK TRANSACTION
            RETURN
        END

    END TRY

    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END

select*from orders

UPDATE orders
SET order_status = 4
WHERE order_id = 104

UPDATE orders
SET order_status = 4,
    order_date = '2024-01-10'
WHERE order_id = 104



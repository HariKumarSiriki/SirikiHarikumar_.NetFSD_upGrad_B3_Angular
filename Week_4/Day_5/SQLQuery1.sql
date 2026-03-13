CREATE DATABASE Products
USE Products


CREATE TABLE Books (
    BookID INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(150) NOT NULL,
    Stock INT NOT NULL CHECK (Stock >= 0),
    Price DECIMAL(10,2) NOT NULL
);

CREATE TABLE Orders (
    OrderID INT IDENTITY(1,1) PRIMARY KEY,
    BookID INT NOT NULL,
    Quantity INT NOT NULL CHECK (Quantity > 0),
    OrderDate DATETIME2 DEFAULT SYSDATETIME(),
    FOREIGN KEY (BookID) REFERENCES Books(BookID)
);


CREATE PROCEDURE sp_AddNewBook
    @Title NVARCHAR(150),
    @Stock INT,
    @Price DECIMAL(10,2)
AS
BEGIN
    BEGIN TRY

        INSERT INTO Books (Title, Stock, Price)
        VALUES (@Title, @Stock, @Price)

        PRINT 'Book added successfully.'

    END TRY

    BEGIN CATCH
        PRINT 'Error: ' + ERROR_MESSAGE()
    END CATCH
END


SELECT * FROM Books;


EXEC sp_AddNewBook 'SQL Basics', 10, 500
EXEC sp_AddNewBook 'C# Fundamentals', 8, 700
EXEC sp_AddNewBook 'Spring Boot Guide', 6, 900
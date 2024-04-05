USE [ Northwind]
GO

SELECT p.ProductName, SUM(Quantity) AS quantities
FROM Products p
JOIN [Order Details] o
ON p.ProductID = o.ProductID
GROUP BY p.ProductName


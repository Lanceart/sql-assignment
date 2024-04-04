USE [ Northwind]
GO

SELECT OrderDate, ProductName
FROM Orders O1
JOIN [Order Details] O2
ON O1.OrderID = O2.OrderID
JOIN Products p
on p.ProductID = O2.ProductID
Order BY OrderDate
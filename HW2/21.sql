USE [ Northwind]
GO


SELECT c.CompanyName, SUM(Quantity) AS count
FROM Customers c
JOIN Orders O
ON c.CustomerID = O.CustomerID
JOIN [Order Details] O2
ON O2.OrderID = O.OrderID
GROUP BY c.CompanyName
USE [ Northwind]
GO


SELECT c.city, COUNT(*) AS [total products ordered]
FROM Customers c
JOIN Orders o
ON c.CustomerID = o.CustomerID
GROUP BY c.City
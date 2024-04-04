USE [ Northwind]
GO


SELECT City, COUNT(*) AS [number of customer]
FROM Customers c
GROUP BY c.City
HAVING COUNT(*) > 2
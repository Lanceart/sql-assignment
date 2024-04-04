USE [ Northwind]
GO


SELECT c.CompanyName, MAX(O.OrderDate) AS [Most recently Order Date]
FROM Customers c
JOIN Orders O
ON c.CustomerID = O.CustomerID
GROUP BY c.CompanyName

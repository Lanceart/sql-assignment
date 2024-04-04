USE [ Northwind]
GO


SELECT DISTINCT c.CompanyName
FROM Customers c
INNER JOIN Orders O
ON c.CustomerID = O.CustomerID
WHERE O.OrderDate > '1998-01-01'
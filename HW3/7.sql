USE [ Northwind]
GO


SELECT DISTINCT c.CustomerID, CompanyName
FROM Customers c
INNER JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE c.City <> o.ShipCity
USE [ Northwind]
GO


SELECT sh.CompanyName, su.CompanyName
FROM Shippers sh
CROSS JOIN Suppliers su;
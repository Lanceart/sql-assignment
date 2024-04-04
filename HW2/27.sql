USE [ Northwind]
GO

SELECT City, CompanyName, ContactName, 'Customer' AS Type  
FROM Customers

UNION ALL

SELECT City, CompanyName, ContactName, 'Supplier' AS Type  
FROM Suppliers

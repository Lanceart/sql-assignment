USE AdventureWorks2019
go

SELECT DISTINCT ProductSubcategoryID, Color
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL AND Color IS NOT NULL
ORDER BY ProductSubcategoryID, Color;


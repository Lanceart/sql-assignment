USE AdventureWorks2019
GO

SELECT ProductSubcategoryID, COUNT(*) AS CountedProducts
FROM Production.Product p
WHERE p.ProductSubcategoryID IS NOT NULL
GROUP BY p.ProductSubcategoryID
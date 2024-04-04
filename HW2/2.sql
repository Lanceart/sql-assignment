USE AdventureWorks2019
GO

SELECT COUNT(ProductID)
FROM Production.Product p
WHERE p.ProductSubcategoryID IS NOT NULL;

--Answer: 295 products in the Production.Product table that are included in a subcategory.
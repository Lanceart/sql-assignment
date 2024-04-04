USE AdventureWorks2019
GO

SELECT COUNT(*) AS CountedProducts
FROM Production.Product p
WHERE p.ProductSubcategoryID IS NULL

-- Answer: 209 products that do not have a product subcategory
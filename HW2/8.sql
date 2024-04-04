USE AdventureWorks2019
GO

SELECT AVG(Quantity)
FROM Production.ProductInventory
WHERE LocationID = 10
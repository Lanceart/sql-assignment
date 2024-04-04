USE AdventureWorks2019
GO



SELECT  Shelf, ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY  ProductID, Shelf
HAVING SUM(Quantity) < 100;
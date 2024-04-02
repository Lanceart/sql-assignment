USE AdventureWorks2019
go

SELECT ProductID, Name
FROM Production.Product
WHERE ProductID BETWEEN 400 AND 500;

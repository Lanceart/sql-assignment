USE AdventureWorks2019
go

SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE ListPrice = 0;
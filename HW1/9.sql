USE AdventureWorks2019
go

SELECT ProductID, Name, color
FROM Production.Product
WHERE color = 'black' OR color = 'blue';
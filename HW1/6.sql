USE AdventureWorks2019
go

SELECT DISTINCT Name + ' ' +Color as [Name and Color]
FROM Production.Product
WHERE Color IS NOT NULL;


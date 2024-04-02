USE AdventureWorks2019
go

SELECT Name, ListPrice
FROM Production.Product
WHERE Name Like 'A%' or Name Like 'S%'
ORDER BY Name;
USE AdventureWorks2019
go

SELECT *
FROM Production.Product
WHERE Name Like 'SPO[^K]%'
ORDER BY Name;
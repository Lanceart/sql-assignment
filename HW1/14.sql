USE AdventureWorks2019
go

SELECT DISTINCT Color
FROM Production.Product
WHERE Color IS NOT NULL
ORDER BY Color DESC;

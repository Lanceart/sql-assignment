USE AdventureWorks2019
GO


SELECT 'Color' AS [members (rows)], Color , AVG(ListPrice) AS AvgListPrice
FROM Production.Product
WHERE Color IS NOT NULL
GROUP BY Color

UNION ALL

SELECT 'Class' AS [members (rows)], Class , AVG(ListPrice) AS AvgListPrice
FROM Production.Product
WHERE Class IS NOT NULL
GROUP BY Class;

USE AdventureWorks2019
GO

SELECT c.Name AS Country, s.Name AS Province
FROM person. CountryRegion c
INNER JOIN person. StateProvince s
ON c.CountryRegionCode = s.CountryRegionCode
WHERE c.Name IN ('Germany' , 'Canada')
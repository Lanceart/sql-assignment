USE AdventureWorks2019
GO


SELECT c.Name AS Country, s.Name AS Province
FROM person. CountryRegion c
JOIN person. StateProvince s
ON c.CountryRegionCode = s.CountryRegionCode;

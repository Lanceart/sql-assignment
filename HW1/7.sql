USE AdventureWorks2019
go

SELECT 'NAME: ' + Name + '  --  COLOR: ' +  ISNULL(Color,'NULL')
FROM Production.Product
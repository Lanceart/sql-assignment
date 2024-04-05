USE [ Northwind]
GO

SELECT DISTINCT City
FROM Customers
WHERE City IN (
	SELECT DISTINCT City
	FROM Employees
)
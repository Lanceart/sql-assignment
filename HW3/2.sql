USE [ Northwind]
GO


-- Question a
SELECT DISTINCT City
FROM Customers
WHERE City NOT IN (
	SELECT DISTINCT City
	FROM Employees
)

--Question b

SELECT DISTINCT C.City
FROM Customers c
LEFT JOIN Employees e ON C.City = e.City
WHERE e.City IS NULL;

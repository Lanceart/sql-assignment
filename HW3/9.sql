USE [ Northwind]
GO


--Question a, use sub-query
select *
FROM (
	SELECT DISTINCT e.City
	FROM Employees e
) t1
WHERE t1.City NOT IN (
	SELECT DISTINCT o.ShipCity
	FROM Orders o
)


--Question b, not use sub-query
select DISTINCT e.City
FROM Employees e
LEFT JOIN Orders o
ON e.City = o.ShipCity
WHERE o.ShipCity IS NULL
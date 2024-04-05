USE [ Northwind]
GO

--Question a, use join
--I think something wrong with this question

SELECT c.city
FROM Customers c
GROUP BY c.City
HAVING COUNT(*) >= 2



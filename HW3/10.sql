USE [ Northwind]
GO


SELECT *
FROM(
SELECT TOP 1 ShipCity
FROM Orders o1
JOIN [Order Details] o2
ON o1.OrderID = o2.OrderID
GROUP BY ShipCity
ORDER BY COUNT(*) DESC
) t1
WHERE t1.ShipCity IN(
SELECT TOP 1 ShipCity
FROM Orders o1
JOIN [Order Details] o2
ON o1.OrderID = o2.OrderID
GROUP BY ShipCity
ORDER BY SUM(Quantity) DESC
)
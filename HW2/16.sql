USE [ Northwind]
GO


SELECT TOP 5 ShipPostalCode
FROM Orders O1
JOIN [Order Details] O2
ON O1.OrderID = O2.OrderID
WHERE ShipPostalCode IS NOT NULL AND O1.OrderDate >= DATEADD(YEAR, -26, GETDATE())
GROUP BY ShipPostalCode
ORDER BY SUM(Quantity) DESC
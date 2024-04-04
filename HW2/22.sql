USE [ Northwind]
GO


SELECT CustomerID, SUM(Quantity) AS count
From Orders O
JOIN [Order Details] O2
ON O2.OrderID = O.OrderID
GROUP BY O.CustomerID
HAVING SUM(Quantity) > 100
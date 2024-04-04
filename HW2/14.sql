USE [ Northwind]
GO

SELECT ProductName
FROM Products p
JOIN (
	SELECT O1.ProductID
	FROM [Order Details] O1
	JOIN Orders O2
	on O1.OrderID = O2.OrderID
	WHERE O2.OrderDate >= DATEADD(YEAR, -26, GETDATE())
) T
ON p.ProductID = T.ProductID
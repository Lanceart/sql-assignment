USE [ Northwind]
GO


SELECT c.CustomerID
FROM Customers c
WHERE c.CustomerID IN(
	SELECT DISTINCT O2.CustomerID
	FROM [Order Details] O1
	LEFT JOIN Orders O2
	ON O1.OrderID = O2.OrderID
	GROUP BY O1.OrderID, O2.CustomerID
	HAVING COUNT(*) >= 2 
)

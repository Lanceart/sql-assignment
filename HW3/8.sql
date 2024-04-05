USE [ Northwind]
GO


WITH RankedCustomers AS(
 SELECT  
        O1.ProductID, O1.OrderID,O2.CustomerID,
        ROW_NUMBER() OVER (PARTITION BY O1.productID ORDER BY O1.Quantity DESC) AS Rank
FROM 
        [Order Details] O1
    JOIN 
        Orders O2 ON O1.OrderID = O2.OrderID
		
),
Products_T AS(
	SELECT 
        O2.ProductID, 
        AVG(O2.UnitPrice) AS AverageUnitPrice, 
        SUM(O2.Quantity) AS TotalQuantity
    FROM 
        [Order Details] O2
    GROUP BY 
        O2.ProductID
)
select r.ProductID, AverageUnitPrice, City
from RankedCustomers r
LEFT JOIN Customers c
ON c.CustomerID = r.CustomerID
LEFT JOIN Products_T t
ON t.ProductID = r.ProductID
WHERE Rank = 1
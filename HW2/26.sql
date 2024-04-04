SE [ Northwind]
GO

SELECT e1.EmployeeID
FROM Employees e1
JOIN Employees e2
ON e1.EmployeeID = e2.ReportsTo 
GROUP BY e1.EmployeeID
HAVING COUNT(e1.EmployeeID) > 2
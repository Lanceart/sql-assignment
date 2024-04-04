USE [ Northwind]
GO

SELECT e1.LastName +' ' + e1.FirstName AS Name1, e2.LastName + ' ' + e2.FirstName AS Name2
FROM Employees e1
JOIN Employees e2
ON e1.EmployeeID < e2.EmployeeID
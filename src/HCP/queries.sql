CREATE OR ALTER PROC proc_get_company_totals
as
SELECT c.CompanyName,CAST(o.OrderDate as date) as OrderDate,od.UnitPrice,od.Quantity,od.Discount,
(od.Quantity*od.UnitPrice)*(1-od.Discount) as Total
FROM Customers as c
INNER JOIN Orders as o ON c.CustomerID=o.CustomerID
INNER JOIN [Order Details] as od ON o.OrderID=od.OrderID
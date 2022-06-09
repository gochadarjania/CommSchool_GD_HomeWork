--TSQL 2012 
--Join
Use[TSQL2012]
--1 Task
SELECT c.contactname, c.city, o.orderdate FROM [Sales].[Customers] c
JOIN [Sales].[Orders] o ON o.custid = c.custid
WHERE c.city IN ('London', 'madrid')

--2. task
SELECT UPPER(p.productname), p.unitprice, c.categoryname from [Production].[Products] p
JOIN [Production].[Categories] c ON p.categoryid = c.categoryid
WHERE p.unitprice > 20 AND p.unitprice < 40

--3. Taks
Select (e.firstname +' ' + e.lastname) Employees, o.orderId from [HR].[Employees] e
Join [Sales].[Orders] o on o.empid = e.empid
Where o.freight > 50 and e.title = 'Sales Manager'

--4. Task
Select orderDate, c.contactname, c.city, c.address from [Sales].[Orders] o
JOIN [Sales].[Customers] c on o.custid = c.custid
Where o.orderdate in ('2007')

--5. Task
Select c.city from [Sales].[Orders] o
Join [HR].[Employees] e on e.empid = o.empid
JOIN [Sales].[Customers] c on o.custid = c.custid
Where e.lastname in ('Cameron')
group by c.city

--6. Task
Select c.country, c.city, o.orderid from [Sales].[Orders] o
JOIN [Sales].[Customers] c on o.custid = c.custid
Where c.country in ('Germany', 'Austria')

--7. Task
Select * from [Production].[Products] p
Join [Production].[Suppliers] s on p.supplierId = s.supplierid
Where s.city = 'Tokyo' and p.discontinued = 1

--8. Task
Select c.categoryname, p.productName from [Production].[Products] p
Join [Production].[Suppliers] s on p.supplierId = s.supplierId
Join [Production].[Categories] c on p.CategoryId = c.categoryId
Where s.country = 'Japan' and c.categoryName in ('Seafood', 'Beverages')


--9. Task
Select e.firstname, e.lastname, s.CompanyName from [Sales].[Orders] o
Join [HR].[Employees] e on o.empid = e.empId
Join [Sales].[Shippers] s on o.shipperid = s.shipperid
Where o.orderdate = '2007' and (FirstName +' '+ LastName) in ('Sara Davis', 'Maria Cameron')

--10. Task
Select p.productName, c.categoryName from [Production].[Products] p
Join [Production].[Suppliers] s on p.supplierId = s.supplierId
Join [Production].[Categories] c on p.CategoryId = c.categoryID
Where c.categoryName not in ('Seafood', 'Beverages')

--11. Task
Select orderId, e.firstname, e.lastname, e.City, c.city, c.contactname from [Sales].[Orders] o
Join [HR].[Employees] e on o.empId = e.empId
Join [Sales].[Customers] c on o.custId = c.custid
Where c.city = e.city

--12. Task
Select cust.ContactName from [Sales].[Orders] o
Join [Sales].[Customers] cust on o.custid = cust.custid
Join [Sales].[OrderDetails] orDet on o.orderId = orDet.OrderId
Join [Production].[Products] p on orDet.ProductId = p.ProductId
Join [Production].[Categories] cat on p.categoryid = cat.categoryid
Where cat.categoryName in ('Beverages', 'Dairy Products')
group by cust.ContactName 


--SUB Query
--Hardware
Use[Hardware]

--1. Task
Select p.Name, p.Price from [dbo].[Products] p
Where p.ManufacturerId in (
						select m.ManufacturerId from [dbo].[Manufacturers] m
						where m.Name = 'Hewlett-Packard'
						)

--2. Task
Select p.name, p.price from [dbo].[Products] p
Where p.ManufacturerId not in (
								select m.ManufacturerId from [dbo].[Manufacturers] m 
								where m.name = 'Fujitsu'
								)
--3. Task
Select p.name, p.price from [dbo].[Products] p
Where p.ManufacturerId not in (
								select m.ManufacturerId id from [dbo].[Manufacturers] m  
								where m.name in ('Sony', 'Fujitsu', 'IBM','Intel')
								)
--4. Task
select m.Name from [dbo].[Manufacturers] m 
Where m.ManufacturerId in (
								select p.ManufacturerId from [dbo].[Products] p 
								where p.price > 200)

--5.Task
Select p.name, p.price from [dbo].[Products] p
Where p.ManufacturerId not in (
								select m.ManufacturerId id from [dbo].[Manufacturers] m 
								where m.name in ('Genius', 'dell')
								)

--6. Task

select count(m.Name) Counted from [dbo].[Manufacturers] m 
where m.ManufacturerId in (
							select p.ManufacturerId from [dbo].[Products] p 
							where p.name like ('%drive%'))

--7. Task
DECLARE @avgPrice real;
Set @avgPrice = (select AVG(p.price) from [dbo].[Products] p) 

select count(p.Name) from [dbo].[Products] p 
where p.ManufacturerId in (
						select m.ManufacturerId from [dbo].[Manufacturers] m  
						where m.name in ('Intel') and  @avgPrice < p.Price)

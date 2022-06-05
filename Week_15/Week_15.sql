----------------Students-------------

--1. students which was born 1990
SELECT *  FROM Students s where DoB > '1990'

--2. print name lastname and age
SELECT s.Firstname, s.Lastname , DATEDIFF(YY, DoB, GETDATE()) 
FROM Students s 
where Country = 'Georgia' or Country = 'Libya'

--3. Insert student
INSERT INTO Students VALUES ('Sharp', 'Martina','1993-11-04','Integer.aliquam@acorciUt.edu', 9,	11,	30,	23,'British Indian Ocean Territory');

--4. Top 5 students
SELECT TOP (5) WITH TIES s.Firstname, s.MiddleTest 
FROM Students s 
ORDER BY s.MiddleTest DESC

--5. Delete studnets 19 score
DELETE Students
OUTPUT deleted.[Lastname], deleted.[Firstname]
WHERE FinalTest = 19

--6. Update students info
update Students 
set FinalTest = 0
where MiddleTest=1

----------------Persons-------------

--1. select persons id start 163
SELECT *  FROM Persons
where PrivateId LIKE '163%'

--2. Lastname = City
SELECT *  FROM Persons
where Lastname = City

--3. living in canada or Monaco
SELECT *  FROM Persons
where Country = 'Canada' OR Country = 'Monaco'

--4. not email persons name lastname privateid
SELECT Firstname,Lastname, PrivateId  FROM Persons
where Email IS NULL

--5. living in Spain or Turkey
SELECT *  FROM Persons
where Salary BETWEEN 1000 and 3000 and (Country = 'Spain' OR Country = 'Turkey')

--6. Company name contains - LLC. PC, LLP
SELECT WorkPlace  FROM Persons
where WorkPlace LIKE '%LLC%' OR
	  WorkPlace LIKE '%PC%' OR
	  WorkPlace LIKE '%LLP%'

--7. dot Counter
SELECT Email, IIF(len(Email)-len(REPLACE(Email,'.','')) > 2, 'more than 2 dots','less than 2 dots') 
FROM Persons

--8. return data Pink code end 51
SELECT *  FROM Persons
where PINcode LIKE '%51'

--9. GGroup by Country
select country, AVG(Salary) from Persons
group by country  
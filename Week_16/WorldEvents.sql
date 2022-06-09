--World Event
--1. Task
select count(e.EventName) numberOfEvents from [dbo].[Event] e
where e.CountryID in (
							select c.CountryID from [dbo].[Country] c
							where c.CountryName in ('Ukraine'))

--2. Task
select MIN(e.EventDate) from [dbo].[Event] e
where e.CountryID in(
						select c.CountryID from [dbo].[Country] c
						where c.CountryName in ('Antarctica'))

--3. Task
select count(c.CountryName) from [dbo].[Country] c
where c.ContinentID in (
							select c.ContinentID from [dbo].Continent c
							where c.ContinentName in ('South America','North America'))

--4. Task
DECLARE @lastEvent date;
Set @lastEvent = (select MAX(e.EventDate) from [dbo].[Event] e
				  where month(e.EventDate)=12 and DAY(e.EventDate)=31) 

select count(e.EventName) from [dbo].[Event] e
where e.EventDate = @lastEvent and e.CategoryID in (
						select c.CategoryID from [dbo].[Category] c
						where c.CategoryName in ('Economy'))

--5. Task
DECLARE @earlyEvent date;
Set @earlyEvent = (select min(e.EventDate) from [dbo].[Event] e) 

select min(e.EventDate) from [dbo].[Event] e
where e.CategoryID in (
						select c.CategoryID from [dbo].[Category] c
						where c.CategoryName in ('Sports'))

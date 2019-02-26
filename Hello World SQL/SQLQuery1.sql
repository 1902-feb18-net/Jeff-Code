SELECT 'Hello World';
SELECT *FROM SalesLT.Customer;

--This would switch databases (from Master to AdventureWorkdsLT)
--but Azure SQL DB (database) 
--Use AdventureWorkdsLT;

--SELECT 
--FROM

--SalesLT.Customer

--semicolons aren't necessary, but common convention
--SQL syntax is not case-sensitive
--This is also true for string comparision, but it also depends on the 
--settings for the datetime format,number font

--good idea to highlight certain query and then right click and execute that specific 
--query instead of running all the queries
select 1;
select CURRENT_TIMESTAMP;

--we get all colummns by using the "*" with select
select *
from SalesLT.Customer;

--to get a specific column by putting the name of the columnn after select
select Title, FirstName, MiddleName, LastName
from SalesLT.Customer;

--in order to change the way that the column names are displayed
--we can use alias "AS" to do this. In this case we want the column titles to be 
--spelled with the spaces in between the two words
select FirstName AS [First Name], LastName AS [Last Name]
from salesLt.Customer

--here we only get all the first names of the customers
select DISTINCT FirstName
from SalesLT.Customer

--we can filter rows as well 
--with the WHERE clause
select *
from SalesLT.Customer
where FirstName = 'Alice';

--showing off boolean operators 
select *
from SalesLT.Customer
where FirstName = 'Alice' and LastName != 'steiner';

--SQL has ordered comparison of number, dates, time, and strings
--strings are ordered in lexicographic order
--		i.e. a=1, b=2, c=3, etc.
--Operators: < <= > >=

--this gives us all customers whose first name starts with C
-- everything that starts with c and has more letters
select *
from SalesLT.Customer
where  FirstName >= 'c' and FirstName < 'd';

--we can also add a certain ordering 
--by using the "ORDER" function (?)
--the ordering is done by ascending order by default, but we can make
--it descending by adding the "DESC" modifier at the end 
select *
from SalesLT.Customer	
where  FirstName >= 'c' and FirstName < 'd'
ORDER BY FirstName, LastName;

--Regex-lite pattern matching can be accomplished on strings with the "LIKE" operator

--this gives us 
Select*
From SalesLT.Customer
where FirstName Like 'C[aeiou]%';
 

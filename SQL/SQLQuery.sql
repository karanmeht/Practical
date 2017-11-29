-- Create database
create database temp1

-- rename database name
alter database temp1 modify name=temp2

-- delete database
drop database temp2


--Create Table
create table Customers
(
Id int Not Null  Primary key,
[Name] varchar(20) Not Null,
Age int Not Null,
[Address] char(25) ,
Salary Decimal (18,2)
--Primary key (Id,[Name])
);

create table [Order]
(
Id int Not Null Primary Key,
[Date] date,
Customer_Id Int references Customers(Id),
Amount Decimal(18,2)
);

-- add reference key after created table
Alter Table [Order] Add Foreign key (Customer_Id) references customers (Id);

-- Delete table
--templary create table 
/*
create table Employee
(
Id int Not Null  Primary key,
[Name] varchar(20) Not Null
);
*/

drop table Employee

-- Insert record
INSERT INTO CUSTOMERS (Id,[NAME],AGE,ADDRESS,SALARY)
VALUES (2,'Ramesh', 32, 'Ahmedabad', 2000.00 );

Insert INTO Customers  VALUES (3,'PRANAV',24,'VADODARA',1500.00);

INSERT INTO CUSTOMERS (ID,NAME,AGE,ADDRESS,SALARY)
VALUES (4, 'Chaitali', 25, 'Mumbai', 6500.00 );

INSERT INTO CUSTOMERS (ID,NAME,AGE,ADDRESS,SALARY)
VALUES (5, 'Hardik', 27, 'Bhopal', 8500.00 );

INSERT INTO CUSTOMERS (ID,NAME,AGE,ADDRESS,SALARY)
VALUES (6, 'Komal', 22, 'MP', 4500.00 );

INSERT INTO CUSTOMERS 
VALUES (7, 'Muffy', 24, 'Indore', 10000.00 );

-- second way to insert record
/*
INSERT INTO CUSTOMERS (ID,NAME,AGE,ADDRESS,SALARY)
select ID,NAME,AGE,ADDRESS,SALARY from Customers1 where Id=10
*/

-- fetch the data
select * from Customers;

-- where (Condition)
select Id,[Name],Salary from Customers where Salary > 2000;
select Id,[Name],Salary,Age from Customers where Age >= 25;
SELECT ID, NAME, SALARY FROM CUSTOMERS WHERE NAME = 'Hardik';

-- AND and OR Operator
SELECT ID, NAME,Age, SALARY FROM CUSTOMERS WHERE SALARY > 2000 AND age < 25;
SELECT ID, NAME,Age, SALARY FROM CUSTOMERS WHERE SALARY > 2000 OR age < 25;
SELECT ID, NAME,Age, SALARY FROM CUSTOMERS WHERE SALARY > 2000 AND age < 25 OR Name='PRANAV';

-- Update Query
UPDATE CUSTOMERS SET ADDRESS = 'Pune' WHERE ID = 6;
UPDATE Customers SET NAME = 'Pranav' where Id=3;

--Delete Query
Delete from Customers where Id=10;

--LIKE 
--The SQL LIKE clause is used to compare a value to similar values using wildcard operators. There are two wildcards used in conjunction with the LIKE operator.
/*
Wildcard operators

 The percent sign (%) : The percent sign represents zero, one or multiple characters.
 The underscore (_) : The underscore represents a single number or character.
*/
select * from Customers where Salary LIKE '200%'; --Finds any values that start with 200.
select * from Customers where Salary LIKE '%200%'; --Finds any values that have 200 in any position.
select * from Customers where Salary LIKE '_00%'; --Finds any values that have 00 in the second and third positions.
select * from Customers where Salary LIKE '2_%_%'; --Finds any values that start with 2 and are at least 3 characters in length.
select * from Customers where Salary LIKE '2_%_%_%_%_%_%_%_%'; --Finds any values that start with 2 and are at least 8 characters in length.
select * from Customers where [Name] Like 'K%'; --Finds any values that start with 'k'.
select * from Customers where Salary Like '%2'; --Finds any values that end with 2.
select * from Customers where Salary Like '_2%3'; --Finds any values that have a 2 in the second position and end with a 3.
select * from Customers where Salary Like '2_____3';--Finds any values in a seven-digit number that start with 2 and end with 3.

--TOP
-- SELECT TOP number|percent column_name(s) FROM table_name WHERE [condition]
SELECT TOP 5 * FROM CUSTOMERS;
SELECT TOP 50 percent * FROM CUSTOMERS;

-- Order By
-- The SQL ORDER BY clause is used to sort the data in ascending or descending order, based on one or more columns.
-- SELECT column-list FROM table_name [WHERE condition] [ORDER BY column1, column2, .. columnN] [ASC | DESC];
SELECT * FROM CUSTOMERS ORDER BY Salary DESC;
select name,Salary from Customers Order By Salary;
SELECT * FROM CUSTOMERS  ORDER BY NAME, SALARY;
SELECT * FROM CUSTOMERS ORDER BY NAME DESC;
SELECT NAME, SUM(SALARY) FROM CUSTOMERS
   GROUP BY NAME;

-- Group by
-- The SQL GROUP BY clause is used in collaboration with the SELECT statement to arrange identical data into groups.
/*
SELECT column1, column2
FROM table_name
WHERE [ conditions ]
GROUP BY column1, column2
ORDER BY column1, column2
*/
SELECT NAME, SUM(SALARY) FROM CUSTOMERS GROUP BY NAME;
SELECT Id,[NAME],[Address],Salary FROM Customers GROUP BY Id,[NAME],[Address],Salary ORDER BY [Address] DESC;

-- Distinct
-- The SQL DISTINCT keyword is used in conjunction with the SELECT statement to eliminate all the duplicate records and fetching only unique records.
-- SELECT DISTINCT column1, column2,.....columnN FROM table_name WHERE [condition]
select distinct [Name] from Customers
select distinct [Name],Address from Customers group by name,Address order by Name
select distinct [Name] from Customers where name like '%h' order by [name] 
SELECT DISTINCT SALARY FROM CUSTOMERS ORDER BY SALARY;


--Own Order by
SELECT * FROM CUSTOMERS
   ORDER BY (CASE ADDRESS
   WHEN 'DELHI' 	 THEN 1
   WHEN 'BHOPAL' 	 THEN 2
   WHEN 'KOTA' 	 THEN 3
   WHEN 'AHMADABAD' THEN 4
   WHEN 'MP' 	THEN 5
   ELSE 100 END) ASC, ADDRESS DESC;

-- Constraints
-- Constraints are the rules enforced on the data columns of a table. These are used to limit the type of data that can go into a table. This ensures the accuracy and reliability of the data in the database.
-- NOT NULL , DEFAULT , PRIMARY KEY , FOREIGN KEY, CHECK , INDEX

ALTER TABLE EMPLOYEES DROP CONSTRAINT EMPLOYEES_PK; -- Drop Constraints

-- Join

-- The INNER JOIN creates a new result table by combining column values of two tables (table1 and table2) based upon the join-predicate. The query compares each row of table1 with each row of table2 to find all pairs of rows which satisfy the join-predicate. When the join-predicate is satisfied, column values for each matched pair of rows of A and B are combined into a result row.
--SELECT table1.column1, table2.column2... FROM table1 INNER JOIN table2 ON table1.common_field = table2.common_field;
Select customers.Id, Name,Amount,Date from Customers inner Join [Order] On customers.Id=[Order].Customer_Id;
select Customers.Id,name,Amount from Customers,[Order] where Customers.id=[Order].Customer_Id

-- The SQL LEFT JOIN returns all rows from the left table, even if there are no matches in the right table. This means that if the ON clause matches 0 (zero) records in the right table; the join will still return a row in the result, but with NULL in each column from the right table.
-- SELECT table1.column1, table2.column2... FROM table1 LEFT JOIN table2 ON table1.common_field = table2.common_field;
select Customers.Id,Name,Amount,[Date] from Customers left join [order] on Customers.Id=[Order].Customer_Id;


-- The SQL RIGHT JOIN returns all rows from the right table, even if there are no matches in the left table. This means that if the ON clause matches 0 (zero) records in the left table; the join will still return a row in the result, but with NULL in each column from the left table.
SELECT  Customers.Id, NAME, AMOUNT, DATE
   FROM CUSTOMERS
   RIGHT JOIN [ORDER]
   ON CUSTOMERS.ID = [ORDER].CUSTOMER_ID;

-- The SQL FULL JOIN combines the results of both left and right outer joins.
--The joined table will contain all records from both the tables and fill in NULLs for missing matches on either side.
-- SELECT table1.column1, table2.column2... FROM table1 FULL JOIN table2 ON table1.common_field = table2.common_field;
Select Customers.Id,name,Date,Amount from Customers full join [Order] on Customers.Id=[Order].Customer_Id;

select citynName,StateName from CityTable inner join StateTable on  StateTable.id=CityTable.StateId;

-- Union Operator
/*
The SQL UNION clause/operator is used to combine the results of two or more SELECT statements without returning any duplicate rows.

To use this UNION clause, each SELECT statement must have

    The same number of columns selected
    The same number of column expressions
    The same data type and
    Have them in the same order

But they need not have to be in the same length.
Syntax
SELECT column1 [, column2 ]
FROM table1 [, table2 ]
[WHERE condition]

UNION

SELECT column1 [, column2 ]
FROM table1 [, table2 ]
[WHERE condition]
*/
Select Customers.Id,name,Date,Amount from Customers left join [Order] on Customers.Id = [Order].Customer_Id
union 
select Customers.Id,name,Date,Amount from Customers right join [Order] on Customers.Id=[Order].Customer_Id;

/*
The UNION ALL operator is used to combine the results of two SELECT statements including duplicate rows.
The same rules that apply to the UNION clause will apply to the UNION ALL operator.
*/
Select Customers.Id,name,Date,Amount from Customers left join [Order] on Customers.Id = [Order].Customer_Id
union All 
select Customers.Id,name,Date,Amount from Customers right join [Order] on Customers.Id=[Order].Customer_Id;

--SQL INTERSECT Clause − This is used to combine two SELECT statements, but returns rows only from the first SELECT statement that are identical to a row in the second SELECT statement.
Select Customers.Id,name,Date,Amount from Customers left join [Order] on Customers.Id = [Order].Customer_Id
intersect
select Customers.Id,name,Date,Amount from Customers right join [Order] on Customers.Id=[Order].Customer_Id;

-- SQL EXCEPT Clause − This combines two SELECT statements and returns rows from the first SELECT statement that are not returned by the second SELECT statement.
Select Customers.Id,name,Date,Amount from Customers left join [Order] on Customers.Id = [Order].Customer_Id
Except
select Customers.Id,name,Date,Amount from Customers right join [Order] on Customers.Id=[Order].Customer_Id;

-- Null Value
select Id,name , Salary from Customers where Salary is Not null
select Id,name , Salary from Customers where Salary is null

-- Alias Syntax
-- You can rename a table or a column temporarily by giving another name known as Alias. The use of table aliases is to rename a table in a specific SQL statement. The renaming is a temporary change and the actual table name does not change in the database. The column aliases are used to rename a table's columns for the purpose of a particular SQL query.
/* SELECT column1, column2....
FROM table_name AS alias_name
WHERE [condition];
*/
select Id as Customer_Id,Name as Customer_Name from Customers where id<=5;
select c.Id, c.Name,o.Amount  from Customers as c , [Order] as o where c.id=o.Customer_Id;


-- index
-- CREATE INDEX index_name ON table_name ( column1, column2.....);
--CREATE UNIQUE INDEX index_name on table_name (column_name);
create index AgeIndex on customers (Age)
ALTER TABLE CUSTOMERS  DROP INDEX idx_age; --delete index

create table temp (
id int primary key,
name varchar(50),
Email nvarchar(50) unique );
ALTER TABLE temp
   DROP CONSTRAINT myUniqueConstraint;
-- Alter Command
-- The SQL ALTER TABLE command is used to add, delete or modify columns in an existing table. You should also use the ALTER TABLE command to add and drop various constraints on an existing table.

-- ALTER TABLE table_name ADD column_name datatype; -- new column
-- ALTER TABLE table_name DROP COLUMN column_name; -- Drop Column
--ALTER TABLE table_name MODIFY COLUMN column_name datatype; -- change the DATA TYPE
-- ALTER TABLE table_name MODIFY column_name datatype NOT NULL; --add a NOT NULL constraint
-- ALTER TABLE table_name ADD CONSTRAINT MyUniqueConstraint UNIQUE(column1, column2...);--ADD UNIQUE CONSTRAINT
-- ALTER TABLE table_name ADD CONSTRAINT MyUniqueConstraint CHECK (CONDITION);--ADD CHECK CONSTRAINT
-- ALTER TABLE table_name ADD CONSTRAINT MyPrimaryKey PRIMARY KEY (column1, column2...);--ADD PRIMARY KEY
-- ALTER TABLE table_name DROP CONSTRAINT MyUniqueConstraint;--DROP CONSTRAINT
ALTER TABLE CUSTOMERS ADD SEX char(1);
ALTER TABLE CUSTOMERS drop column SEX;

-- TRUNCATE TABLE 
-- The SQL TRUNCATE TABLE command is used to delete complete data from an existing table.
-- You can also use DROP TABLE command to delete complete table but it would remove complete table structure form the database and you would need to re-create this table once again if you wish you store some data.
 -- TRUNCATE TABLE  table_name;
 TRUNCATE TABLE temp;
 select * from temp;

 -- View
 --A view can contain all rows of a table or select rows from a table. A view can be created from one or many tables which depends on the written SQL query to create a view.
/* Views, which are a type of virtual tables allow users to do the following −
    Structure data in a way that users or classes of users find natural or intuitive.
    Restrict access to the data in such a way that a user can see and (sometimes) modify exactly what they need and no more.
    Summarize data from various tables which can be used to generate reports.

Syntax:: CREATE VIEW view_name AS SELECT column1, column2..... FROM table_name WHERE [condition];

with option check
The WITH CHECK OPTION is a CREATE VIEW statement option. The purpose of the WITH CHECK OPTION is to ensure that all UPDATE and INSERTs satisfy the condition(s) in the view definition.
If they do not satisfy the condition(s), the UPDATE or INSERT returns an error.	

Updating a View
A view can be updated under certain conditions which are given below −
    The SELECT clause may not contain the keyword DISTINCT.
    The SELECT clause may not contain summary functions.
    The SELECT clause may not contain set functions.
    The SELECT clause may not contain set operators.
    The SELECT clause may not contain an ORDER BY clause.
    The FROM clause may not contain multiple tables.
    The WHERE clause may not contain subqueries.
    The query may not contain GROUP BY or HAVING.
    Calculated columns may not be updated.
    All NOT NULL columns from the base table must be included in the view in order for the INSERT query to function.

	Insert record
	Rows of data can be inserted into a view. The same rules that apply to the UPDATE command also apply to the INSERT command.
    Here, we cannot insert rows in the CUSTOMERS_VIEW because we have not included all the NOT NULL columns in this view, otherwise you can insert rows in a view in a similar way as you insert them in a table.
*/

create view Temp_View as select id from temp ;
select * from Temp_View where id in (1,3);
update Temp_View set id=10 where id=4; -- update record in both table virtual and orinal 
Delete from temp_View where id =2; -- delete record in both table table orinal and virtual 
drop view Temp_View -- record not deleted from orinal table only deleted from virtual table

create view customer_view as select * from Customers where Salary is not null with check option;
insert into customer_view values (20,'karan mehta',25,null,Null);-- error salary should be Decimal value not a null value
insert into customers values (21,'karan mehta',25,null,18.55);-- save record in orinal table use can see data in view table 
insert into customer_view values (18,'karan mehta',25,null,182.00);
select * from customer_view
drop view customer_view

SELECT ID, NAME, AGE, ADDRESS, SALARY
FROM CUSTOMERS
GROUP BY ID, NAME, AGE, ADDRESS, SALARY
HAVING COUNT(age) >= 2;
DELETE FROM CUSTOMERS
   WHERE AGE =27;
 
 select total,count(total) as repeated from marks group by total 
 select distinct total, count(total) from student inner join marks on Student.Id=Student_Id group by total
 select total from Marks group by total having sum(total)>=70
 
 select Dept_Name,sum(salary) from Department inner join Employee on Department.id=Dept_Id group by Dept_Name

 select top 1 * from (select top 2  * from employee order by id desc) x order by id
SELECT * FROM (SELECT row_number() OVER (ORDER BY id desc) r, * FROM Employee) q
WHERE r = 2 

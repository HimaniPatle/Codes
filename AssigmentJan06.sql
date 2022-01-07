--Create Database ShopData
create database ShopData

--Create Table for Salesman
create Table Salesman
(
salesman_id NUMERIC(5) primary key,
Name varchar(30)not null,
City varchar(15) not null,
Commision DECIMAL(5,2),
)

--Create Table for Orders
create Table Orders
(
Ord_No numeric(5) primary key,
Purch_Amt decimal(8,2)not null,
Ord_Date DATE,
Customer_Id Numeric(5),
salesman_id NUMERIC(5) references Salesman(salesman_id)
)
Drop table Customer

--Create Table for Customer
create Table Customer
(
Customer_id numeric(5) primary key,
Cust_Name varchar(30),
City varchar(15),
Grade numeric(3),
salesman_id NUMERIC(5) references Salesman(salesman_id)
)

--Insert Data in Salesman Table
Insert into Salesman Values(5001,'James Hoog', 'New York', 0.15)
Insert into Salesman Values(5002,'Nail Knite', 'Paris', 0.13)
Insert into Salesman Values(5005,'Pit Alex', 'London', 0.11)
Insert into Salesman Values(5006,'Mc Lyon', 'Paris', 0.14)
Insert into Salesman Values(5007,'Paul Adam', 'Rome', 0.13)
Insert into Salesman Values(5003,'Lauson Hen', 'San Jose', 0.12)


--Inset Data in Order Table
Insert into Orders Values(70001,150.5,'2012-10-05',3005,5002)
Insert into Orders Values(70009,270.65,'2012-09-10',3001,5005)
Insert into Orders Values(70002,65.26,'2012-10-05',3002,5001)
Insert into Orders Values(70004,110.5,'2012-08-17',3009,5003)
Insert into Orders Values(70007,948.5,'2012-09-10',3005,5002)
Insert into Orders Values(70005,2400.6,'2012-07-27',3007,5001)
Insert into Orders Values(70008,5760,'2012-09-10',3002,5001)
Insert into Orders Values(70010,1983.43,'2012-10-10',3004,5006)
Insert into Orders Values(70003,2480.4,'2012-10-10',3009,5003)
Insert into Orders Values(70012,250.4,'2012-06-27',3008,5002)
Insert into Orders Values(70011,75.295,'2012-08-17',3003,5007)
Insert into Orders Values(70013,3045.6,'2012-04-25',3002,5001)


--Insert Data in Customer Table
Insert into Customer Values(3002,'Nick Rimando','New York',100,5001)
Insert into Customer Values(3007,'Brad Davis','New York',200,5001)
Insert into Customer Values(3005,'Graham Zusi','California',200,5002)
Insert into Customer Values(3008,'Julian Green','London',300,5002)
Insert into Customer Values(3004,'Fablian Johnson','Paris',300,5006)
Insert into Customer Values(3009,'Geoff Cameron','Berlin',100,5003)
Insert into Customer Values(3003,'Jozy Altidor','Moscow',200,5007)
Insert into Customer(Customer_id,Cust_Name,City,salesman_id) Values(3001,'Brad Guzan','London',5005)

--1)Write SQL statement to display all the information of all Salesman
Select * from Salesman

Select * from Orders

Select * from Customer

--2)Write SQL statement to display specific columns like name and commission for all salesman.
Select Name , Commision from Salesman 

--3)Write a query to display the columns in a specific order like order dste,salesman id, order number & purchase
--amount from all the orders.
Select Ord_Date ,salesman_id ,Ord_No , Purch_Amt from Orders

--4)Write Sql query to find the salespeople who lives in the City paris. Return Salesperson's name,city.
Select Name, City from Salesman where City='Paris'

--5)Write a SQL query to find those customers whose grade is 200.Return Cust_Id, Cust_Name,City,Grade,Salesman_id.
Select Customer_id ,Cust_Name , City, Grade,salesman_id from Customer where Grade = 200

--6)Write a SQL query to find the orders, which are delivered by a salesperson of ID 5001.Return ord_name,ord_date,purch_amt.
Select Ord_No, Ord_Date , Purch_Amt from Orders where salesman_id = 5001

--7)Calculate Avg purchase amt of all orders.Returns avg purchase amt
Select * from Orders
Select avg(Purch_Amt) as 'Avg_Purch_Amt' from Orders

--8)Cout the no of Unique salespeople.Return no. of salespeople
Select * from Salesman 
Select count(DISTINCT salesman_id) as 'Count_Salesman' from Salesman

--9)Count the num of Customers.Retun no. of customers
Select * from Customer
Select count(Customer_id) as 'Count_Customer' from Customer 

--10)Find max purchase amount
Select * from Orders 
Select max(Purch_Amt) as 'Max_PurchAmt' from Orders 

--11)Find the highest grade of each customers for each of the city.Return city,Maximum grade
Select * from Customer 
Select City,
max(Grade) as 'Max_Grade' from Customer group by City 

--12)Find the highest purchase amt ordered by each customer.Return customer id,Max purchase amt
Select * from Orders 
Select Customer_id,
max(Purch_Amt) as 'Max_PurchAmt' from Orders group by Customer_Id 




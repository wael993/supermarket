-- create and use Database
IF DB_ID('supermarket') IS NULL
create database supermarket
go


USE supermarket;
go

-- create tables
IF OBJECT_ID('Billing') IS NOT NULL
  DROP TABLE Billing;
GO

IF OBJECT_ID('Item') IS NOT NULL
  DROP TABLE Item;
GO

IF OBJECT_ID('Employees') IS NOT NULL
  DROP TABLE Employees;
GO
IF OBJECT_ID('Customer') IS NOT NULL
  DROP TABLE Customer;
GO


CREATE TABLE Employees (
	Employee_id int identity(1000,1) PRIMARY KEY,
	Username NVARCHAR (50),
	Password  NVARCHAR (50),
	FirstName NVARCHAR (50) NOT NULL,
	LastName NVARCHAR (50) NOT NULL,
	Birthday date  NOT NULL,
	Gender NVARCHAR (25),
	--1 is Male , 0 is Female
	Salary DECIMAL (10,2),
	Rolle NVARCHAR (25),
	Phone  NVARCHAR (25),
	Adress NVARCHAR (50) 
);


CREATE TABLE Item (
	Item_ID INT identity(2000,1) PRIMARY KEY ,
	Item_Name NVARCHAR (255) NOT NULL,
	Price DECIMAL(10,2), 
	Quantity int NOT NULL
	);
	
CREATE TABLE Customer (
	Customer_id int identity(1000,1) PRIMARY KEY,
	FirstName NVARCHAR (50) NOT NULL,
	LastName NVARCHAR (50) NOT NULL,
	Phone  NVARCHAR (25),
	Adress NVARCHAR (50) ,
	Email  NVARCHAR (150) 
);


CREATE TABLE Billing(
	Billing_id INT identity(3000,1) PRIMARY KEY,
	Billing_datum DATE NOT NULL,
	Customer_id INT ,
	Employee_id INT ,
	CONSTRAINT fk_Customer FOREIGN KEY (Customer_id)
					REFERENCES Customer(Customer_id),
	CONSTRAINT fk_Employees FOREIGN KEY (Employee_id)
					REFERENCES Employees(Employee_id)

);
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

IF OBJECT_ID('Orders') IS NOT NULL
  DROP TABLE Orders;
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
	Salary DECIMAL (10,2),
	Rolle NVARCHAR (25),
	Phone  NVARCHAR (25),
	Adress NVARCHAR (50) 
);


CREATE TABLE Item (
	Item_ID INT identity(7000,1) PRIMARY KEY ,
	Item_Name NVARCHAR (255) NOT NULL,
	Price DECIMAL(10,2), 
	Quantity int NOT NULL
	);
	
CREATE TABLE Customer (
	Customer_id int identity(2000,1) PRIMARY KEY,
	FirstName NVARCHAR (50) NOT NULL,
	LastName NVARCHAR (50) NOT NULL,
	Phone  NVARCHAR (25),
	Adress NVARCHAR (50) ,
	Email  NVARCHAR (150) 
);


CREATE TABLE Billing(
	Billing_id INT identity(50,1) PRIMARY KEY,
	Billing_date DATE NOT NULL,
	Customer_id INT ,
	Item_ID INT,
	Employee_id INT ,
	CONSTRAINT fk_Customer FOREIGN KEY (Customer_id)
					REFERENCES Customer(Customer_id),
	CONSTRAINT fk_Employees FOREIGN KEY (Employee_id)
					REFERENCES Employees(Employee_id),
	CONSTRAINT fk_Item_ID FOREIGN KEY (Item_ID)
					REFERENCES Item(Item_ID)

);

CREATE TABLE Orders(
	Order_Id INT identity(3000,1) PRIMARY KEY,
	Order_date DATE NOT NULL,
	Employee_id INT ,
	Item_ID INT,
	CONSTRAINT fk_Employee FOREIGN KEY (Employee_id)
					REFERENCES Employees(Employee_id),
	CONSTRAINT fk_Item FOREIGN KEY (Item_ID)
					REFERENCES Item(Item_ID)
);




INSERT INTO Employees(Username,Password,FirstName,LastName, Birthday,Gender,Salary,Rolle,Phone,Adress)
			  VALUES('Waelz','12','wael','Zobani','06-10-1993','Male',2712.25,'Admin','01766456565','66386 Sankt Ingbert , langstr.12'),
					('mozo','12','Mo','Zobani','10-08-2010','Male',2212.05,'Emp','01766456565','66386 Sankt Ingbert , langstr.12'),
					('lana','12','Land','Lang','05-02-2000','Female',1812.50,'Emp','01766456565','66386 Sankt Ingbert , langstr.12');
					



			 
INSERT INTO Item(Item_Name,Price,Quantity)
			  VALUES('tomato',1.99,170),('strawberry ',2.99,70),('raspberry',1.89,180),('pomegranate',3.99,150),('plum',2.99,70),('pineapple',2.99,10),
	  			    ('watermelon',3.99,60),('pear',1.89,20),('peach',1.95,50),('passion fruit',2.99,60),('orange',0.99,20),('mango ',3.99,80),
				    ('rambutan',1.92,120),('grapefruit',1.97,300),('grape',1.29,80),('kiwi',1.79,123),('coconut',1.49,50),('lemon',1.19,690);

			
INSERT INTO Customer(FirstName,LastName,Phone,Adress,Email)
			  VALUES('Amel','Mueller','0175585525','66386 Sankt Ingbert , langstr.12','Amelmueller@gemail.com'),
			  ('lila','Mueller','0175585525','66386 Sankt Ingbert , langstr.12','Laylamueller@gemail.com'),
			  ('Layla','Schmitt','0175585525','66386 Sankt Ingbert , langstr.12','Amelmueller@gemail.com'),
			  ('markus','Habeb','0175585525','66386 Sankt Ingbert , langstr.12','markus@gemail.com'),
			  ('Thomas','Braun','0175585525','66386 Sankt Ingbert , langstr.12','Thomas@gemail.com'),
			  ('Sam','Oha','0175585525','66386 Sankt Ingbert , langstr.12','Sam@gemail.com'),
			  ('Max','Mueller','0175585525','66386 Sankt Ingbert , langstr.12','Max@gemail.com'),
			  ('Frans','Muaster','0175585525','66386 Sankt Ingbert , langstr.12','Frans@gemail.com'),
			  ('lamis','Ohr','0175585525','66386 Sankt Ingbert , langstr.12','lamis@gemail.com'),
			  ('waled','Scmidt','0175585525','66386 Sankt Ingbert , langstr.12','waled@gemail.com'),
			  ('nina','walder','0175585525','66386 Sankt Ingbert , langstr.12','nina@gemail.com'),
			  ('alia','Mueller','0175585525','66386 Sankt Ingbert , langstr.12','alia@gemail.com'),
			  ('wesam','Schmitt','0175585525','66386 Sankt Ingbert , langstr.12','wesam@gemail.com'),
			  ('emily','Mueller','0175585525','66386 Sankt Ingbert , langstr.12','emily@gemail.com'),
			  ('Farhan','Mueller','0175585525','66386 Sankt Ingbert , langstr.12','Farhan@gemail.com'),
			  ('lia','Habeb','0175585525','66386 Sankt Ingbert , langstr.12','lia@gemail.com'),
			  ('smoil','Mueller','0175585525','66386 Sankt Ingbert , langstr.12','smoil@gemail.com'),
			  ('kinan','Braun','0175585525','66386 Sankt Ingbert , langstr.12','kinan@gemail.com'),
			  ('Hayya','Oha','0175585525','66386 Sankt Ingbert , langstr.12','Hayya@gemail.com'),
			  ('haydi','Muaster','0175585525','66386 Sankt Ingbert , langstr.12','haydi@gemail.com');






			  
			 
INSERT INTO Billing(Billing_date,Customer_id,Employee_id,Item_ID)
			  VALUES ('06-10-2021',2001,1000,7001),('07-10-2021',2002,1001,7002),('08-10-2021',2003,1001,7003),('09-10-2021',2004,1002,7003),('06-11-2021',2005,1001,7001),
					 ('06-11-2021',2006,1002,7001),('06-11-2021',2006,1002,7005),('08-11-2021',2007,1002,7006),('12-11-2021',2008,1001,7006),('12-11-2021',2009,1001,7005),
					 ('13-11-2021',2011,1000,7011),('14-12-2021',2011,1000,7012),('2-12-2021',2001,1002,7004),('02-12-2021',2002,1001,7007),('06-12-2021',2003,1001,7010),
					 ('08-12-2021',2009,1001,7011),('09-12-2021',2010,1002,7014),('09-12-2021',2010,1001,7009),('15-12-2021',2010,1002,7011),('16-12-2021',2010,1002,7008);


					 	  
			 
INSERT INTO Orders(Order_date,Employee_id,Item_ID)
			  VALUES ('06-10-2021',1001,7001),('07-10-2021',1001,7001),('08-10-2021',1001,7001),('09-10-2021',1001,7001),('06-11-2021',1001,7001),
					 ('06-11-2021',1001,7001),('06-11-2021',1001,7001),('08-11-2021',1001,7001),('12-11-2021',1001,7001),('12-11-2021',1001,7001),
					 ('13-11-2021',1001,7001),('14-12-2021',1001,7001),('2-12-2021',1001,7001),('02-12-2021',1001,7001),('06-12-2021',1001,7001),
					 ('08-12-2021',1001,7001),('09-12-2021',1001,7001),('09-12-2021',1001,7001),('15-12-2021',1001,7001),('16-12-2021',1001,7001);






			
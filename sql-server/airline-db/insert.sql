--  **************************************************************************************
--  Now that the database tables have been created, we can populate them with data
--  **************************************************************************************

--  **************************************************************************************


/*  Database Population Statements
    Add the INSERT statements you write to the end of the create.sql file as you work through the views and queries.  
    The final create.sql should be able to create your database and populate it with enough data to make sure that all
	views and queries return meaningful results.
*/

-- Write your insert statements here



--  Populate the region PlaneModel.

PRINT 'Populating PlaneModel table...';

INSERT INTO PlaneModel 
VALUES ('A380','Airbus','15700','900'), 
		('A300','Airbus','13450','871'), 
		('A340','Airbus','12400','881'), 
		('A390','Airbus','17400','1081'),
		('737','Boeing','5600','780'), 
		('777','Boeing','10000','892'),
		('779','Boeing','17000','922'),
		('787','Boeing','15000','903');


--  **************************************************************************************
--  Populate the Pilot table.
--  Since the primary key uses IDENTITY, we don't specify a value for that column.
PRINT 'Populating Pilot table...';

INSERT INTO Pilot 
VALUES ('Pramesh', 'Shrestha', '1989-04-25',5),
		('Maila', 'Battard', '2002-11-15',10),
		('Tom', 'Hardy', '1977-09-15',39),
		('Leonardo', 'DiCaprio', '1974-11-11',85),
		('Huge', 'Glass', '1980-08-22',9),
		('John', 'Fitzgerald', '1979-09-18',77),
		('Jennifer', 'Whalen','1987-09-17',10),
       ('Michael', 'Hartstein','1996-02-17',18),
		('Steven', 'King','1987-06-17', 60);


--  **************************************************************************************
--  Populate the PlaneDetail table.
--  Since the primary key uses IDENTITY, we don't specify a value for that column.

PRINT 'Populating PlaneDetail table...';

INSERT INTO PlaneDetail
VALUES ('A390','AU-1989',1989,50,50),
	   ('A380','AU-2000',2000,100,200), 
		('A300','AU-1970',1970,200,350), 
		('A340','AU-1880',1880,310,420), 
		('A390','AU-1990',1990,110,230),
		('737','BO-2001',2001,40,120), 
		('777','BO-1990',1990,155,450),
		('779','BO-2002',2002,121,244),
		('787','BO-2005',2005,195,340),
		('787','BO-2005-1',2005,95,140);


--  **************************************************************************************
--  Populate the PlanePilot table.

PRINT 'Populating PlanePilot table...';

INSERT INTO PlanePilot 
VALUES ('777',1),
	   ('A390',2),
	   ('A380',3),
	   ('777',3),
	   ('787',5),
	   ('787',6),
	   ('A340',1),
	   ('A340',3),
	   ('A340',4),
	   ('A340',2),
	   ('A340',8),
	   ('A340',9),
	   ('737',1),
	   ('779',4)
	   ; 




--  **************************************************************************************
--  Populate the Country table.

PRINT 'Populating Country table...';

INSERT INTO Country 
VALUES ('Australia','AUS'),
		('Austria','AUT'),
		('Brazil','BRA'),
		('Belgium','BEL'),
		('Canada','CAN'),
		('China','CHN'),
		('Nepal','NPl'),
		('Germany','GER'),
		('England','ENG'),
		('Spain','ESP'),
		('Portugal','POR'),
		('Sweden','SWE'),
		('New Zealand','NZL'),
		('United Arab Emirates', 'UAE'),
		('United States of America','USA');
       

--  **************************************************************************************
--  Populate the Airport table.

PRINT 'Populating Airport table...';

INSERT INTO Airport
VALUES ('PER','Perth Airport',0894788888,31.9385,115.9672,'AUS'),
		('AKL','Auckland Airport',06492750789,37.0082,174.7850,'NZL'),
		('DXB','Dubai International Airport',06494544432,56.54,33.33,'UAE'),
		('TIA','Tribhuwan International Airport',097714113033,27.6981,85.3592,'NPL'),
		('ABC','Abc Airport',985485893,43.221,44.54,'ENG'),
		('XYZ','Xyz Airport',542345433,34.43,23.32,'USA'),
		('IJK','Ijk Airport',844428322,67.54,54.32,'POR'),
		('PKR','Pokhara Airport',097761465979,28.2000,83.9817,'NPL'),
		('MEL','Melbourne Airport',0392971600,37.6690,144.8410,'AUS'),
		('SYD','Sydney Airport',0296679111,33.9399,151.1753,'AUS');


 

--  **************************************************************************************
--  Populate the Flight table.

PRINT 'Populating Flight table...';

INSERT INTO Flight
VALUES ('ABC123','TIA','SYD',5500),
       ('ABC987','PER', 'TIA',8800),
	   ('XYP023','XYZ', 'PKR',5800),
	   ('XCF123','ABC', 'AKL',7600),
	   ('PRA172','PER', 'DXB',7400),
	   ('JKL980','MEL', 'TIA',9800),
	   ('QR340','PKR', 'IJK',3500),
	   ('STH650','PER', 'MEL',5680);


--  **************************************************************************************
--  Populate the FlightAttendant table.
--  Since the primary key uses IDENTITY, we don't specify a value for that column.
PRINT 'Populating FlightAttendant table...';

INSERT INTO FlightAttendant 
VALUES ('Pramesh', 'Shrestha', '1989-04-25', '2004-04-25', 6),
		('John', 'Rai','1979-04-22', '2005-04-25', 3),
		('Mike', 'Magar','1990-04-22', '2010-04-25', 5),
		('Hari', 'Cobin', '1990-04-22', '2003-04-25', 3),
		('Greg', 'Nepal', '1991-04-22', '2002-04-25', 4),
		('Ram', 'Sharma', '1998-04-22', '2001-04-25', 1),
		('Amol', 'Pokharel', '1980-04-22', '2008-04-25', 1),
		('Nishesh', 'Gajurel', '1899-04-22', '2009-04-25', 2),
		('Pratik', 'Shrestha', '1999-04-22', '2003-04-25', 7);


--  **************************************************************************************
--  Populate the FlightInstance table.
--  Since the primary key uses IDENTITY, we don't specify a value for that column.
INSERT INTO FlightInstance
VALUES ('PRA172',3,1,2,5,'2015-12-11 10:30:00','2015-12-14 10:30:00'),
		('XCF123',3,2,3,1,'2015-12-11 10:30:00','2015-12-14 10:30:00'),
		('JKL980',4,3,1,2,'2015-12-11 10:30:00','2015-12-14 10:30:00'),
		('QR340',4,3,1,2,'2015-12-10 10:30:00','2015-12-11 10:30:00'),
		('QR340',4,3,1,2,'2015-12-11 10:30:00','2015-12-12 10:30:00'),
		('QR340',4,3,1,2,'2015-12-12 10:30:00','2015-12-13 10:30:00'),
		('PRA172',3,1,2,5,'2015-12-11 10:30:00','2015-12-14 10:30:00'),
		('ABC987',2,5,3,3,'2015-12-11 10:30:00','2015-12-14 10:30:00'),
		('ABC123',3,1,2,4,'2015-12-11 10:30:00','2015-12-14 10:30:00'),
		('JKL980',4,3,1,2,'2015-12-11 10:30:00','2015-12-14 10:30:00'),
		('STH650',1,3,4,5,'2015-12-11 10:30:00','2015-12-14 10:30:00'),
		('XCF123',3,2,3,1,'2015-12-11 10:30:00','2015-12-14 10:30:00'),
		('ABC123',5,4,2,4,'2017-11-11 10:30:00','2017-11-14 10:30:00'),
		('ABC123',5,4,2,4,'2017-11-11 10:30:00','2017-11-14 10:30:00'),
		('JKL980',4,3,1,2,'2017-12-11 10:30:00','2017-12-14 10:30:00'),
		('STH650',1,3,4,5,'2017-12-11 10:30:00','2017-12-14 10:30:00');


--  **************************************************************************************
--  Populate the InstanceAttendant table.

INSERT INTO InstanceAttendant
VALUES (1,2),
		(2,3),
		(3,4),
		(4,1),
		(5,5),
		(7,6),
		(1,7),
		(2,8),
		(3,5),
		(7,3),
		(8,3),
		(2,1),
		(8,1),
		(9,5),
		(6,1),
		(10,7),
		(10,8),
		(10,9),
		(11,1),
		(11,2),
		(11,3),
		(13,4),
		(15,6),
		(15,1),
		(16,5),
		(16,4),
		(12,7),
		(14,9),
		(15,7);


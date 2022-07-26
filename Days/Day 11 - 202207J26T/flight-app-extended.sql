CREATE TABLE flight(
	flight_id int, 
	flight_no varchar(50),

	airline_name varchar(256),
	source_point varchar(128),
	destination_point varchar(128),
	travel_date datetime,
	number_of_seats int,
	ticket_fare float);
	
INSERT INTO flight( flight_id, flight_no, airline_name, source_point, destination_point,travel_date,number_of_seats,ticket_fare)
VALUES (1, 'AI 101', 'AIR INDIA', 'BHUBANESWAR', 'BANGALORE', '2022-07-25', 250, 8000);

INSERT INTO flight( flight_id, flight_no, airline_name, source_point, destination_point,travel_date,number_of_seats,ticket_fare)
VALUES (2, 'AI 102', 'AIR INDIA', 'BHUBANESWAR', 'MUMBAI', '2022-07-25', 250, 7000);

INSERT INTO flight( flight_id, flight_no, airline_name, source_point, destination_point,travel_date,number_of_seats,ticket_fare)
VALUES (3, 'AI 103', 'AIR INDIA', 'BHUBANESWAR', 'TRIVENDRUM', '2022-07-25', 250, 10000);

INSERT INTO flight( flight_id, flight_no, airline_name, source_point, destination_point,travel_date,number_of_seats,ticket_fare)
VALUES (4, 'AI 104', 'AIR INDIA', 'BHUBANESWAR', 'NEW DELHI', '2022-07-26', 250, 9000);
	
INSERT INTO flight( flight_id, flight_no, airline_name, source_point, destination_point,travel_date,number_of_seats,ticket_fare)
VALUES (4, 'AI 104', 'AIR INDIA', 'BHUBANESWAR', 'NEW DELHI', '2022-07-26', 250, 9000);

Case Study:	
The flight of flight_id=4 has recorded twice.
How can I fix it?

Answer 1:
	You have to run only once.
	
Answer 2:
	We have to make the column to enable with "PRIMARY KEY" or "UNIQUE KEY"
		
What is primary key?
	Primary key is the unique key and not null 
	
What is unique key?
	If the column does not allow duplicate value,
	Then we say the column is enabled with "UNIQUE" key
				
What is not null column?
	If the column is not allowed to have NULL value, 
	Then we say the column is enabled with "NOT NULL" constraint
	
What is primary key?
	If the column does not allow duplicate value 
	  and does not allow the NULL value 
	Then we say the column is enabled with "PRIMARY KEY"
	
How many number of primary keys we can have?
	In a table we can have only one "PRIMARY KEY".
	
How many number of unique keys we can have?
	In a table we can have one or more "PRIMARY KEY".
	
I made flight_id to have PRIMARY KEY. 
Is there any possibility to make flight_no to have "PRIMARY KEY" as well.
	Not possible.
	As flight_id had PRIMARY KEY.
	So we cannot have two PRIMARY KEYs in a table.
	Then we can apply UNIQUE KEY to flight_no.
	So, flight_id is PRIMARY KEY.
	flight_no is UNIQUE key. 
	
See the following entity/tuple/relation/table 
Student{roll_number,school_id,board_register_number, first_name, last_name, etc}
	roll_number is unique wrt to the particular school 
	It may be repeated in another school 
	But board_register_number is allocated by the educational board 
	So, it is unique even across all schools. 
	
	roll_number and school_id together can be UNIQUE 
	board_register_number is UNIQUE 
	
	One of the above can be PRIMAY KEY 
	Another one can be UNIQUE KEY 
	
	
******************Introducing PRIMARY KEY*****************

CREATE TABLE flight(
	flight_id int PRIMARY KEY, 
	flight_no varchar(50),
	airline_name varchar(256),
	source_point varchar(128),
	destination_point varchar(128),
	travel_date datetime,
	number_of_seats int,
	ticket_fare float);

CREATE TABLE flight(
	flight_id int, 
	flight_no varchar(50),
	airline_name varchar(256),
	source_point varchar(128),
	destination_point varchar(128),
	travel_date datetime,
	number_of_seats int,
	ticket_fare float,
	PRIMARY KEY(flight_id));

************************OR****************************
CREATE TABLE flight(
	flight_id int, 
	flight_no varchar(50),
	airline_name varchar(256),
	source_point varchar(128),
	destination_point varchar(128),
	travel_date datetime,
	number_of_seats int,
	ticket_fare float);
	
ALTER TABLE flight ADD PRIMARY KEY(flight_id);	

	
******************Introducing UNIQUE key*****************
CREATE TABLE flight(
	flight_id int PRIMARY KEY, 
	flight_no varchar(50) UNIQUE,
	airline_name varchar(256),
	source_point varchar(128),
	destination_point varchar(128),
	travel_date datetime,
	number_of_seats int,
	ticket_fare float);	
	
	
******************Introducing NOT NULL, NULL, DEFAULT, CHECK*****************
CREATE TABLE flight(
	flight_id int PRIMARY KEY, 
	flight_no varchar(50) UNIQUE NOT NULL,
	airline_name varchar(256) NOT NULL,
	source_point varchar(128) NOT NULL,
	destination_point varchar(128) NOT NULL,
	travel_date datetime NULL,
	number_of_seats int NOT NULL DEFAULT 250 CHECK(number_of_seats<=1000),
	ticket_fare float NOT NULL);	
	
******************customer*****************
CREATE TABLE customer(
	customer_id int PRIMARY KEY, 
	username varchar(50) UNIQUE NOT NULL,
	password varchar(50) NOT NULL,
	full_name varchar(128) NOT NULL,
	email_id varchar(128) NOT NULL UNIQUE,
	phone_number varchar(50) NOT NULL UNIQUE ,
	address varchar(1000) NOT NULL DEFAULT(''),
	date_of_birth datetime NOT NULL);	

******************booking w/o KEYS*****************

CREATE TABLE booking(
	booking_id int,
	booking_date datetime,
	booking_number varchar(50),
	customer_id int,
	flight_id int,
	travel_date datetime,
	number_of_passengers int,
	total_fare float);
	
	
WHAT IS FOREIGN KEY?
	The column which is primary key of another table 
	so this column refers the column of another table 
	For example, booking flight_id is the foreign key of booking table 
	which is primary key  of the flight table 
	
****INTRODUCE PRIMARY KEY, UNIQUE, FOREIGN KEY, NOT NULL*****	
CREATE TABLE booking(
	booking_id int PRIMARY KEY,
	booking_date datetime NOT NULL,
	booking_number varchar(50) UNIQUE NOT NULL,
	customer_id int FOREIGN KEY REFERENCES customer(customer_id),
	flight_id int FOREIGN KEY REFERENCES flight(flight_id),
	travel_date datetime,
	number_of_passengers int,
	total_fare float NOT NULL DEFAULT 0 CHECK(total_fare>=0));
	
CREATE TABLE booking(
	booking_id int PRIMARY KEY,
	booking_date datetime NOT NULL,
	booking_number varchar(50) UNIQUE NOT NULL,
	customer_id int FOREIGN KEY REFERENCES customer(customer_id) ON CASCADE DELETE,
	flight_id int FOREIGN KEY REFERENCES flight(flight_id),
	travel_date datetime,
	number_of_passengers int,
	total_fare float NOT NULL DEFAULT 0 CHECK(total_fare>=0));	
	
	
**************************STUDENT**********************
CREATE TABLE Student(roll_number int ,
	school_id int,
	board_register_number varchar(50) NOT NULL, 
	first_name varchar(50) , 
	last_name varchar(50),
	PRIMARY KEY(roll_number,school_id)
);
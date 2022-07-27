CREATE TABLE flight(
	flight_id int PRIMARY KEY, 
	flight_no varchar(50)UNIQUE NOT NULL,
	airline_name varchar(256) NOT NULL,
	source_point varchar(128)NOT NULL,
	destination_point varchar(128)NOT NULL,
	travel_date datetime NULL,
	number_of_seats int NOT NULL DEFAULT(250) CHECK(number_of_seats>=0),
	ticket_fare float not null);



ALTER TABLE flight
	ADD departure_time time, 
	arrival_time time;
/*
ALTER TABLE flight 
	DROP CONSTRAINT PK__flight__E3705765190A1C70;---?????

ALTER TABLE flight
	ADD PRIMARY KEY(flight_id);
	
ALTER TABLE flight
	ALTER COLUMN airline_name varchar(512) NOT NULL;
	
ALTER TABLE flight	
	ADD status int;
	
ALTER TABLE flight	
	DROP COLUMN status;	
*/	
	
	

CREATE TABLE customer(
    customer_id int PRIMARY KEY, 
    username varchar(50) UNIQUE NOT NULL,
    password varchar(50) NOT NULL,
    full_name varchar(128) NOT NULL,
    email_id varchar(128) NOT NULL UNIQUE,
    phone_number varchar(50) NOT NULL UNIQUE ,
    address varchar(1000) NOT NULL DEFAULT(''),
    date_of_birth datetime NOT NULL);   

CREATE TABLE booking(
    booking_id int primary key,
    booking_date datetime not null,
    booking_number varchar(50) unique not null,
    customer_id int not null foreign key references customer(customer_id),
    flight_id int not null foreign key references flight(flight_id),
    travel_date datetime not null,
    number_of_passengers int not null default(1),
    total_fare float not null default(0));
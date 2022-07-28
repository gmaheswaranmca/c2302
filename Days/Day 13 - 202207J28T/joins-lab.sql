drop table booking;
drop table flight;
drop table customer;


CREATE TABLE flight(
	flight_id int PRIMARY KEY, 
	flight_no varchar(50)UNIQUE NOT NULL,
	airline_name varchar(256) NOT NULL,
	source_point varchar(128)NOT NULL,
	destination_point varchar(128)NOT NULL,
	travel_date datetime NULL,
	number_of_seats int NOT NULL DEFAULT(250) CHECK(number_of_seats>=0),
	ticket_fare float not null);
	

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

-- master data
INSERT INTO flight( flight_id, flight_no, airline_name, 
	source_point, destination_point,
	travel_date,
	number_of_seats,ticket_fare)
VALUES 
(1, 'AI 101', 'AIR INDIA', 'BHUBANESWAR', 'BANGALORE', '2022-08-01', 250, 8000),
(2, 'AI 102', 'AIR INDIA', 'BHUBANESWAR', 'MUMBAI', '2022-08-02', 150, 7000),
(3, 'AI 103', 'AIR INDIA', 'BHUBANESWAR', 'TRIVENDRUM', '2022-08-01', 175, 10000),
(4, 'AI 104', 'AIR INDIA', 'BHUBANESWAR', 'NEW DELHI', '2022-08-02', 250, 9000),
(11, 'AI 201', 'AIR INDIA EXPRESS', 'MUMBAI', 'BANGALORE', '2022-08-01', 250, 8000),
(12, 'AI 202', 'AIR INDIA EXPRESS', 'MUMBAI', 'BHUBANESWAR', '2022-08-02', 150, 7000),
(13, 'AI 203', 'AIR INDIA EXPRESS', 'MUMBAI', 'TRIVENDRUM', '2022-08-01', 175, 10000),
(14, 'AI 204', 'AIR INDIA EXPRESS', 'MUMBAI', 'NEW DELHI', '2022-08-02', 250, 9000),
(21, 'AI 301', 'AIR INDIA', 'BANGALORE', 'BHUBANESWAR', '2022-08-01', 250, 8000),
(22, 'AI 302', 'AIR INDIA', 'BANGALORE', 'MUMBAI', '2022-08-02', 150, 7000),
(23, 'AI 303', 'AIR INDIA', 'BANGALORE', 'TRIVENDRUM', '2022-08-01', 175, 10000),
(24, 'AI 304', 'AIR INDIA', 'BANGALORE', 'NEW DELHI', '2022-08-02', 250, 9000),
(31, 'AI 401', 'AIR INDIA', 'TRIVENDRUM', 'BANGALORE', '2022-08-01', 250, 8000),
(32, 'AI 402', 'AIR INDIA', 'TRIVENDRUM', 'MUMBAI', '2022-08-02', 150, 7000),
(33, 'AI 403', 'AIR INDIA', 'TRIVENDRUM', 'BHUBANESWAR', '2022-08-01', 175, 10000),
(34, 'AI 404', 'AIR INDIA', 'TRIVENDRUM', 'NEW DELHI', '2022-08-02', 250, 9000),
(41, 'AI 501', 'AIR INDIA', 'NEW DELHI', 'BANGALORE', '2022-08-01', 250, 8000),
(42, 'AI 502', 'AIR INDIA', 'NEW DELHI', 'MUMBAI', '2022-08-02', 150, 7000),
(43, 'AI 503', 'AIR INDIA', 'NEW DELHI', 'BHUBANESWAR', '2022-08-01', 175, 10000),
(44, 'AI 504', 'AIR INDIA', 'NEW DELHI', 'TRIVENDRUM', '2022-08-02', 250, 9000);

INSERT INTO customer(customer_id,username,password,
	full_name,email_id,phone_number,
	date_of_birth)
VALUES
(10,'stutee','1234','stutee rath','stuteerath1234@gmail.com','1234567','2000-10-06'),
(20,'rahul','4321','rahul bejoy','rahul.bejoy10@gmail.com','7356156426','1998-01-21'),
(30,'palak','4567','palak saraf','palaksaraf1700@gmail.com','8296106775','2000-06-17'),
(40,'ashish','0000','ashish ranjan','ashishranjan07@gmail.com','7992439751','1999-12-02'),
(50,'logesh','4141','logesh rajan','logesh@gmail.com','123456789','2001-10-05');



INSERT INTO booking(booking_id,booking_date,booking_number,
	customer_id,flight_id,
	number_of_passengers,travel_date)
VALUES(10010,getdate(),'001',
	10,1,
	1,'2022-08-01');

INSERT INTO booking(booking_id,booking_date,booking_number,
	customer_id,flight_id,
	number_of_passengers,travel_date)
VALUES(10011,getdate(),'002',
	20,4,
	1,'2022-08-02');

INSERT INTO booking(booking_id,booking_date,booking_number,
	customer_id,flight_id,
	number_of_passengers,travel_date)
VALUES(10012,getdate(),'003',
	20,200,
	1,'2022-08-02');



select 
	b.booking_id, b.booking_number, 
	b.booking_date, b.flight_id as booking_flight_id,
	f.flight_no, f.source_point, 
	f.destination_point, f.flight_id as flight_flight_id
from booking as b
	CROSS JOIN flight as f 
;		-- 2 rows

select 
	b.booking_id, b.booking_number, 
	b.booking_date, b.flight_id as booking_flight_id,
	f.flight_no, f.source_point, 
	f.destination_point, f.flight_id as flight_flight_id
from booking as b
	INNER JOIN flight as f ON b.flight_id=f.flight_id
;		-- 2 rows


select 
	b.booking_id, b.booking_number, 
	b.booking_date, b.flight_id as booking_flight_id,
	f.flight_no, f.source_point, 
	f.destination_point, f.flight_id as flight_flight_id
from booking as b
	LEFT OUTER JOIN flight as f ON b.flight_id=f.flight_id
;		-- 2 rows + 1 extra row from left table 


select 
	b.booking_id, b.booking_number, 
	b.booking_date, b.flight_id as booking_flight_id,
	f.flight_no, f.source_point, 
	f.destination_point, f.flight_id as flight_flight_id
from booking as b
	RIGHT OUTER JOIN flight as f ON b.flight_id=f.flight_id
;	-- 2 rows + 18 extra row from right table 

select 
	b.booking_id, b.booking_number, 
	b.booking_date, b.flight_id as booking_flight_id,
	f.flight_no, f.source_point, 
	f.destination_point, f.flight_id as flight_flight_id
from booking as b
	FULL OUTER JOIN flight as f ON b.flight_id=f.flight_id
;	-- 2 rows + 1 extra row from left table + 18 extra rows from right table 
	

	
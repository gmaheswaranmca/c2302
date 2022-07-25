CREATE TABLE flight(
					flight_id int, 
					flight_no varchar(50),
					airline_name varchar(256),
					source_point varchar(128),
					destination_point varchar(128),
					travel_date datetime,
					number_of_seats int,
					ticket_fare float);

DROP TABLE flight;

SP_HELP flight;

SP_HELP booking;

SELECT * FROM flight;


INSERT INTO flight( flight_id, flight_no, airline_name, source_point, destination_point,travel_date,number_of_seats,ticket_fare)
VALUES (1, 'AI 101', 'AIR INDIA', 'BHUBANESWAR', 'BANGALORE', '2022-07-25', 250, 8000);

INSERT INTO flight( flight_id, flight_no, airline_name, source_point, destination_point,travel_date,number_of_seats,ticket_fare)
VALUES (2, 'AI 102', 'AIR INDIA', 'BHUBANESWAR', 'MUMBAI', '2022-07-25', 250, 7000);

INSERT INTO flight( flight_id, flight_no, airline_name, source_point, destination_point,travel_date,number_of_seats,ticket_fare)
VALUES (3, 'AI 103', 'AIR INDIA', 'BHUBANESWAR', 'TRIVENDRUM', '2022-07-25', 250, 10000);

INSERT INTO flight( flight_id, flight_no, airline_name, source_point, destination_point,travel_date,number_of_seats,ticket_fare)
VALUES (4, 'AI 104', 'AIR INDIA', 'BHUBANESWAR', 'NEW DELHI', '2022-07-26', 250, 9000);

DELETE FROM flight WHERE flight_id=4;

UPDATE flight 
SET number_of_seats=275
WHERE flight_no= 'AI 102';

UPDATE flight 
SET number_of_seats=150
WHERE source_point= 'BHUBANESWAR' AND destination_point= 'BANGALORE';

ALTER TABLE flight
ADD departure_time time, arrival_time time;

UPDATE flight 
SET departure_time ='19:30', arrival_time= '21:30'
WHERE flight_id= 1;

UPDATE flight 
SET departure_time ='20:30', arrival_time= '22:30'
WHERE flight_id= 2;

UPDATE flight 
SET departure_time ='17:30', arrival_time= '19:30'
WHERE flight_id= 3;

UPDATE flight 
SET departure_time ='00:30', arrival_time= '14:30'
WHERE flight_id= 4;

SELECT flight_id, flight_no, airline_name, source_point, destination_point,travel_date,departure_time,arrival_time,number_of_seats,ticket_fare
FROM flight;

SELECT flight_id, flight_no, airline_name,
source_point, destination_point,
travel_date,departure_time,arrival_time,
number_of_seats,ticket_fare
FROM flight;

SELECT flight_id, flight_no, airline_name,
source_point, destination_point,
FORMAT (travel_date, 'dd-MM-yyyy') ,departure_time,arrival_time,
number_of_seats,ticket_fare
FROM flight;

SELECT flight_id, flight_no, airline_name,
source_point, destination_point,
FORMAT (travel_date, 'dd-MM-yyyy') travel_date,departure_time,arrival_time,
number_of_seats,ticket_fare
FROM flight;

SELECT flight_id, flight_no, airline_name,
source_point, destination_point,
FORMAT (travel_date, 'ddd,dd-MMM-yyyy') travel_date,departure_time,arrival_time,
number_of_seats,ticket_fare
FROM flight;

SELECT flight_id, flight_no, airline_name,
source_point, destination_point,
FORMAT (travel_date, 'dddd,dd-MMMM-yyyy') travel_date,departure_time,arrival_time,
number_of_seats,ticket_fare
FROM flight;

SELECT flight_id, flight_no, airline_name,
source_point, destination_point,
FORMAT (travel_date, 'dddd,dd-MMMM-yyyy') travel_date,
FORMAT (CONVERT (datetime, departure_time), 'hh:mm tt') departure_time,
FORMAT (CONVERT (datetime, arrival_time), 'hh:mm tt') arrival_time,
number_of_seats,ticket_fare
FROM flight;

SELECT flight_id, flight_no, airline_name,
source_point, destination_point,
FORMAT (travel_date, 'dddd,dd-MMMM-yyyy') travel_date,
CONVERT (datetime, departure_time) departure_time,
CONVERT (datetime, arrival_time) arrival_time,
number_of_seats,ticket_fare
FROM flight;



SELECT GETDATE();
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





INSERT INTO flight( flight_id, flight_no, airline_name, source_point, destination_point,travel_date,number_of_seats,ticket_fare)
VALUES (11, 'AI 201', 'AIR INDIA', 'BANGALORE', 'BHUBANESHWAR', '2022-07-25', 250, 8000),
 (12, 'AI 202', 'AIR INDIA', 'BANGALORE', 'MUMBAI', '2022-07-25', 250, 7000),
 (13, 'AI 203', 'AIR INDIA', 'BANGALORE', 'TRIVENDRUM', '2022-07-25', 250, 10000),
 (14, 'AI 204', 'AIR INDIA', 'BANGALORE', 'NEW DELHI', '2022-07-26', 250, 9000);
 UPDATE flight 
SET departure_time ='19:30', arrival_time= '21:30'
WHERE flight_id= 11;
UPDATE flight 
SET departure_time ='20:30', arrival_time= '22:30'
WHERE flight_id= 12;
UPDATE flight 
SET departure_time ='17:30', arrival_time= '19:30'
WHERE flight_id= 13;
UPDATE flight 
SET departure_time ='00:30', arrival_time= '14:30'
WHERE flight_id= 14;


INSERT INTO flight( flight_id, flight_no, airline_name, source_point, destination_point,travel_date,number_of_seats,ticket_fare)
VALUES (15, 'AI 301', 'AIR INDIA EXPRESS', 'MUMBAI', 'BHUBANESHWAR', '2022-07-25', 250, 8000),
 (16, 'AI 302', 'AIR INDIA EXPRESS', 'MUMBAI', 'BANGALORE', '2022-07-25', 250, 7000),
 (17, 'AI 303', 'AIR INDIA EXPRESS', 'MUMBAI', 'TRIVENDRUM', '2022-07-25', 250, 10000),
 (18, 'AI 304', 'AIR INDIA EXPRESS', 'MUMBAI', 'NEW DELHI', '2022-07-26', 250, 9000);
UPDATE flight 
SET departure_time ='19:30', arrival_time= '21:30'
WHERE flight_id= 15;
UPDATE flight 
SET departure_time ='20:30', arrival_time= '22:30'
WHERE flight_id= 16;
UPDATE flight 
SET departure_time ='17:30', arrival_time= '19:30'
WHERE flight_id= 17;
UPDATE flight 
SET departure_time ='00:30', arrival_time= '14:30'
WHERE flight_id= 18;

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
CONVERT (datetime, departure_time) departure_time,
CONVERT (datetime, arrival_time) arrival_time,
number_of_seats,ticket_fare
FROM flight;


SELECT flight_id, flight_no, airline_name,
source_point, destination_point,
FORMAT (travel_date, 'dddd,dd-MMMM-yyyy') travel_date,
FORMAT (CONVERT (datetime, departure_time), 'hh:mm tt') departure_time,
FORMAT (CONVERT (datetime, arrival_time), 'hh:mm tt') arrival_time,
number_of_seats,ticket_fare
FROM flight;




SELECT GETDATE();
--
SELECT * 
FROM flight;

--list flights where source starts at letter 'B'
SELECT * 
FROM flight 
WHERE source_point LIKE 'M%';

--list flights where source is 'BANGALORE'
SELECT * 
FROM flight 
WHERE source_point='BANGALORE';

--list flights where source ends at letter 'E'
SELECT * 
FROM flight 
WHERE source_point LIKE '%E';

--list flights where source's second letter is 'A'
select* from flight
 where source_point like '_A%';
 
--list flights where flight_fare is 7000 
select* from flight
where  ticket_fare=7000;

--list flights where flight_fare is NOT (7000 OR 10000)
select* from flight
where  ticket_fare=7000 OR ticket_fare=10000;

--list flights where flight_fare is 7000 OR ????
SELECT * 
FROM flight 
WHERE ticket_fare=7000 OR ticket_fare=10000;

SELECT * 
FROM flight 
WHERE( ticket_fare IN (7000,10000));

--list flights where flight_fare is NOT (7000 OR ????)
SELECT * 
FROM flight 
WHERE NOT( ticket_fare IN (7000,10000));

SELECT * 
FROM flight 
WHERE ( ticket_fare NOT IN (7000,10000));

--list flights where flight_fare in between  7000 AND 9000
 SELECT * 
FROM flight 
WHERE  ticket_fare>=7000 And ticket_fare<=9000;

SELECT * 
FROM flight 
WHERE  ticket_fare BETWEEN 7000 AND 9000;

--list flights where flight_fare is NOT between ???? AND 7000
SELECT * 
FROM flight 
WHERE  NOT(ticket_fare>=7000 And ticket_fare<=9000);

SELECT * 
FROM flight 
WHERE  NOT(ticket_fare BETWEEN 7000 AND 9000);

SELECT * 
FROM flight 
WHERE  ticket_fare  NOT BETWEEN 7000 AND 9000;

--sort the flights based on flight_fare ascending order
SELECT * 
FROM flight 
ORDER BY ticket_fare asc;

SELECT * 
FROM flight 
ORDER BY ticket_fare;

--sort the flights based on flight_fare descending order
SELECT * 
FROM flight 
ORDER BY ticket_fare desc;

--sort the flights based on flight_fare descending order then by source name ascending order 
SELECT * 
FROM flight 
ORDER BY ticket_fare desc,source_point;

SELECT * 
FROM flight 
ORDER BY ticket_fare desc,source_point asc;

--sort the flights based on flight_fare descending order then by source name ascending order use the ordinal
SELECT * 
FROM flight 
ORDER BY 8 desc,4;

SELECT * 
FROM flight 
ORDER BY 8 desc,4 asc;

--list distinct source_point names	
--list distinct fares
--find number of flights
--find number of fares
--find number of distinct fares
--find max fare 
--find min fare 
--find total seats
--find average seats per flight 
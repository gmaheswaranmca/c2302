/*
CREATE DATABASE ars_db;

USE ars_db;
*/

CREATE TABLE flight(
	flight_id int primary key identity(101,2),
	flight_number varchar(50) NOT NULL,
	airline_name varchar(256) NOT NULL,
	source varchar(128) NOT NULL,
	destination varchar(128) NOT NULL,
	travel_date datetime,
	number_of_seats int NOT NULL DEFAULT 275,
	ticket_fare float NOT NULL DEFAULT 5500
);	

sp_help flight;
	
INSERT INTO flight(flight_number,airline_name,source,destination,travel_date)
VALUES('AI 1242','Air India','Mumbai','New Delhi','2022-07-23'); -- 101

INSERT INTO flight(flight_number,airline_name,source,destination,travel_date)
VALUES('AI 130','Air India','Mumbai' ,'Chennai','2022-07-24'); -- 103

INSERT INTO flight(flight_number,airline_name,source,destination,travel_date)
VALUES('AI 988','Air India','Trivandrum','Bhubaneswar','2022-07-23'); -- 105

INSERT INTO flight(flight_number,airline_name,source,destination,travel_date)
VALUES('IX 0396','Air India Express','Kochi','Mumbai','2022-07-24'); -- 107

INSERT INTO flight(flight_number,airline_name,source,destination,travel_date)
VALUES('IX 0184','Air India Express','Kochi','New Delhi','2022-07-23'); -- 105

SELECT * FROM flight; -- * is NOT standard | go for COLUMN NAMES in the 'SELECT clause'

UPDATE flight
SET ticket_fare = 6000
WHERE flight_number='AI 988';

UPDATE flight
SET ticket_fare = 7000
WHERE source='Kochi' and destination='New Delhi';

INSERT INTO flight(flight_number,airline_name,source,destination,travel_date)
VALUES('IX 0185','Air India Express','Vijawada','Guntur','2022-07-25');

UPDATE flight
SET ticket_fare = 4500
WHERE flight_number='IX 0185';

DELETE FROM flight WHERE flight_id=113;


SELECT * FROM flight;

SELECT flight_id, flight_number,airline_name,
	source,destination,
	travel_date,
	number_of_seats, ticket_fare 
FROM flight;	

SELECT flight_id, flight_number,airline_name,
	source,destination,
	travel_date,
	number_of_seats, ticket_fare 
FROM flight 
WHERE source='Mumbai';	

SELECT flight_id, flight_number,airline_name,
	source,destination,
	travel_date,
	number_of_seats, ticket_fare 
FROM flight 
WHERE destination='New Delhi';	

SELECT flight_id, flight_number,airline_name,
	source,destination,
	travel_date,
	number_of_seats, ticket_fare 
FROM flight 
WHERE travel_date='2022-07-24';	

SELECT flight_id, flight_number,airline_name,
	source,destination,
	travel_date,
	number_of_seats, ticket_fare 
FROM flight 
WHERE     (airline_name = 'Air India');

SELECT COUNT(*) FROM flight;
SELECT MAX(ticket_fare) FROM flight;
SELECT MIN(ticket_fare) FROM flight;
SELECT SUM(number_of_seats*ticket_fare) FROM flight; --Total booking amount of all the tickets 
SELECT SUM(number_of_seats*ticket_fare)/SUM(number_of_seats) FROM flight; -- Average ticket fare
SELECT AVG(number_of_seats) FROM flight;
SELECT AVG(number_of_seats*ticket_fare) FROM flight; -- Per flight all seats total ticket fare
SELECT COUNT(SOURCE) FROM flight;
SELECT COUNT(DISTINCT SOURCE) FROM flight; -- number of distinct source column values
SELECT COUNT(DISTINCT destination) FROM flight; -- number of distinct destination values
SELECT COUNT(travel_date) FROM flight;
SELECT COUNT(DISTINCT travel_date) FROM flight; --number of distinct travel dates
SELECT COUNT(DISTINCT ticket_fare) FROM flight; -- number of distinct fares
SELECT DISTINCT ticket_fare FROM flight; -- displays distinct ticket_fares
SELECT DISTINCT travel_date FROM flight; -- displays distinct travel_dates
SELECT DISTINCT airline_name FROM flight;-- displays distinct airline_names

SELECT flight_id, flight_number,airline_name,
	source,destination,
	travel_date,
	number_of_seats, ticket_fare 
FROM flight 
WHERE     (ticket_fare = 4500) OR (ticket_fare = 6000); -- ticket fare is either 4500 or 6000

SELECT flight_id, flight_number,airline_name,
	source,destination,
	travel_date,
	number_of_seats, ticket_fare 
FROM flight 
WHERE     (ticket_fare IN (4500,6000)); -- ticket fare is either 4500 or 6000

SELECT flight_id, flight_number,airline_name,
	source,destination,
	travel_date,
	number_of_seats, ticket_fare 
FROM flight 
WHERE   NOT ( (ticket_fare = 4500) OR (ticket_fare = 6000)); -- ticket fare is other than 4500 or 6000

SELECT flight_id, flight_number,airline_name,
	source,destination,
	travel_date,
	number_of_seats, ticket_fare 
FROM flight 
WHERE     (ticket_fare NOT IN (4500,6000));-- ticket fare is other than 4500 or 6000


SELECT flight_id, flight_number,airline_name,
	source,destination,
	travel_date,
	number_of_seats, ticket_fare 
FROM flight 
WHERE     (4500<=ticket_fare) AND (ticket_fare<=6000); -- ticket fare bt 4500 and 6000 (included)
-- WHERE     (ticket_fare>=4500) AND (ticket_fare<=6000); 

SELECT flight_id, flight_number,airline_name,
	source,destination,
	travel_date,
	number_of_seats, ticket_fare 
FROM flight 
WHERE (ticket_fare BETWEEN 4500 AND 6000); -- ticket fare bt 4500 and 6000 (included)

SELECT flight_id, flight_number,airline_name,
	source,destination,
	travel_date,
	number_of_seats, ticket_fare 
FROM flight 
WHERE (ticket_fare NOT BETWEEN 4500 AND 6000); -- ticket fare not bt 4500 and 6000

SELECT flight_id, flight_number,airline_name,
	source,destination,
	travel_date,
	number_of_seats, ticket_fare 
FROM flight 
WHERE     (ticket_fare != 4500)

SELECT flight_id, flight_number,airline_name,
	source,destination,
	travel_date,
	number_of_seats, ticket_fare 
FROM flight 
WHERE (travel_date BETWEEN '2022-07-23' AND '2022-07-24') -- flights run bt 23 and 24 of month Jul/2022

SELECT  flight_number,airline_name,
	source,destination,
	travel_date 
FROM flight 
WHERE (travel_date BETWEEN '2022-07-23' AND '2022-07-24') -- for selective columns and flights run bt 23 and 24 of month Jul/2022

SELECT flight_id, flight_number,airline_name,
	source,destination,
	travel_date,
	number_of_seats, ticket_fare 
FROM flight 
WHERE destination LIKE '%i' -- All the flights whose destination ends at alphabet 'i'

SELECT flight_id, flight_number,airline_name,
	source,destination,
	travel_date,
	number_of_seats, ticket_fare 
FROM flight 
WHERE destination LIKE 'C%'  -- All the flights whose destination ends at alphabet 'C'


SELECT flight_id, flight_number,airline_name,
	source,destination,
	travel_date,
	number_of_seats, ticket_fare 
FROM flight 
WHERE destination LIKE '%a%'  -- All the flights whose destination contains alphabet 'C'

SELECT flight_id, flight_number,airline_name,
	source,destination,
	travel_date,
	number_of_seats, ticket_fare 
FROM flight 
WHERE destination LIKE '%a_'  -- All the flights whose destination 2nd to last alphabet 'a'

SELECT flight_id, flight_number,airline_name,
	source,destination,
	travel_date,
	number_of_seats, ticket_fare 
FROM flight 
WHERE source LIKE '_____' -- here 5 underscores are there, so five characters source will be selected


-- Sorting the flights
SELECT flight_id, flight_number,airline_name,
	source,destination,
	travel_date,
	number_of_seats, ticket_fare 
FROM flight ORDER BY travel_date ASC -- sort based on trave_date ascending order 

SELECT flight_id, flight_number,airline_name,
	source,destination,
	travel_date,
	number_of_seats, ticket_fare 
FROM flight ORDER BY 6 ASC -- sort based on 6th column (travel_date) ascending order 
						-- 6th column of the result table ie not from the original table
						-- 6 is the ordinal number and ordinal numbers starts at 1 (not zero)


SELECT flight_id, flight_number,airline_name,
	source,destination,
	travel_date,
	number_of_seats, ticket_fare 
FROM flight ORDER BY travel_date DESC -- sort based on trave_date ascending order 

SELECT flight_id, flight_number,airline_name,
	source,destination,
	travel_date,
	number_of_seats, ticket_fare 
FROM flight ORDER BY travel_date ASC, source ASC -- sort based on trave_date ascending order then by source ascending order

DROP TABLE flight;

/*

DROP DATABASE ars_db;

*/
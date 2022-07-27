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


-- -- Transactions
--book stutee from BHUBANESWAR to BANGALORE and travel date on 2022-08-01
SELECT * FROM customer WHERE username='stutee';
SELECT * FROM flight WHERE source_point='BHUBANESWAR' AND destination_point='BANGALORE';

INSERT INTO booking(booking_id,booking_date,booking_number,
	customer_id,flight_id,
	number_of_passengers,travel_date)
VALUES(10010,getdate(),'001',
	10,1,
	1,'2022-08-01');

--book rahul from BHUBANESWAR to NEW DELHI and travel date on 2022-08-02
SELECT * FROM customer WHERE username='rahul';
SELECT * FROM flight WHERE source_point='BHUBANESWAR' AND destination_point='NEW DELHI';
INSERT INTO booking(booking_id,booking_date,booking_number,
	customer_id,flight_id,
	number_of_passengers,travel_date)
VALUES(10011,getdate(),'002',
	20,4,
	1,'2022-08-02');



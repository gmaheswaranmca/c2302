In the query, 
we can have  
more than one table relationship 
for getting the data

-- JOIN 

Our example,
booking table has flight_id

flight_no, source_point, destination_point are at flight table 

Now we need to write a query to get these data 

*****Querying booking table, add a relationship in the query with flight table***
JOIN 

In the query, table information is given at "FROM" clause 

************FROM booking, flight************				ORACLE STD 
		------ CROSS JOIN 
************FROM booking CROSS JOIN flight************		ANSI STANDARD 



INNER JOIN 		---> Joined Records 
OUTER JOIN 		--->
		Other than Joined Records(Rows) 					--- inner 
		Left Side table some rows may not be in joining 
		Right Side table some rows may not be in joining 
		These extra rows are called							--- outer 
		
	





		CROSS JOIN will do what 
		each row of the left side table is joined with 
		every row of the right side table 
		
		===>
		
		let us assume: 
		booking has 3 rows 
		flight has 20 rows 
		
		CROSS JOIN result table will have 3 x 20 = 60 rows 
************FROM booking INNER JOIN flight ON <condition>************
************FROM booking INNER JOIN flight ON booking.flight_id=flight.flight_id************
	if we use equal operator in the INNER JOIN condition,
	then it is called EQUI JOIN 
************FROM booking INNER JOIN flight ON booking.flight_id!=flight.flight_id************	
	if we dont use equal operator in the INNER JOIN condition,
	then it is called NON EQUI JOIN 
	
	
	
select 
	booking.booking_id, booking.booking_number, 
	booking.booking_date, booking.flight_id as booking_flight_id,
	flight.flight_no, flight.source_point, 
	flight.destination_point, flight.flight_id as flight_flight_id
from booking
	INNER JOIN flight ON booking.flight_id=flight.flight_id
;



select 
	f.flight_no, f.source_point, 
	f.destination_point, f.flight_id as flight_flight_id,
	b.booking_id, b.booking_number, 
	b.booking_date, b.flight_id as booking_flight_id
from flight as f
	LEFT OUTER JOIN booking as b ON b.flight_id=f.flight_id
;
LEFT JOIN -> LEFT OUTER JOIN -> 

	Joined Rows (2)
	Plus 
	Extra recrods(18) in the Left Table (flight) 
	will be into left side details 
	the right side details are NULL 

	No of records in Left Join = 2 + 18 = 20 

select 
	b.booking_id, b.booking_number, 
	b.booking_date, b.flight_id as booking_flight_id,
	f.flight_no, f.source_point, 
	f.destination_point, f.flight_id as flight_flight_id
from booking as b
	RIGHT OUTER JOIN flight as f ON b.flight_id=f.flight_id
;

No of joined rows(2)
Extra records in the right table (flight) = 18

--------------------------------------------------------------------------

ALTER TABLE booking
	DROP CONSTRAINT FK__booking__flight___45F365D3;

INSERT INTO booking(booking_id,booking_date,booking_number,
	customer_id,flight_id,
	number_of_passengers,travel_date)
VALUES(10012,getdate(),'003',
	20,200,
	1,'2022-08-02');
--------------------------------------------------------------------------

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
	

		







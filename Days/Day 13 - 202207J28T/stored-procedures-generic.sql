--drop procedure sp_find_sum

create procedure sp_find_sum
--alter procedure sp_find_sum
	@first_number int,
	@second_number int
as
begin
	declare @sum int;
	set @sum = @first_number + @second_number;
	print 'The sum is ' + str(@sum);
end
go

-- execute sp_find_sum 10,20
-- execute sp_find_sum @first_number=2,@second_number=3
-- execute sp_find_sum @second_number=3,@first_number=2

--drop procedure sp_find_max_of_two

create procedure sp_find_max_of_two
--alter procedure sp_find_max_of_two
	@first_number int,
	@second_number int
as
begin
	declare @max int;
	
	if @first_number > @second_number
	begin
		set @max = @first_number;
	end
	else
	begin
		set @max = @second_number;
	end

	print 'The max is ' + str(@max);
end
go

-- execute sp_find_max_of_two 10,20
-- execute sp_find_max_of_two 20,10

--drop procedure sp_print_natrual
create procedure sp_print_natrual
--alter procedure sp_print_natrual
	@N int
as
begin
	declare @I int;
	
	set @I = 1;
	while @I <= @N
	begin
		print str(@I);	
		set @I = @I + 1;
	end
end
go

-- execute sp_print_natrual 15


--drop procedure sp_print_natrual_skip_5
create procedure sp_print_natrual_skip_5
--alter procedure sp_print_natrual_skip_5
	@N int
as
begin
	declare @I int;
	
	set @I = 1;
	while @I <= @N
	begin
		if @I % 5 = 0
		begin 
			set @I = @I + 1;
			continue;
		end 

		print str(@I);	
		set @I = @I + 1;
	end
end
go

-- execute sp_print_natrual_skip_5 15



--drop procedure sp_print_natrual_stop_inside
create procedure sp_print_natrual_stop_inside
--alter procedure sp_print_natrual_stop_inside
	@N int
as
begin
	declare @I int;
	
	set @I = 1;
	while 1=1
	begin
		print str(@I);	
		set @I = @I + 1;
		if @I > @N
		begin 
			break;
		end 
	end
end
go

-- execute sp_print_natrual_stop_inside 15



--DROP PROCEDURE sp_create_booking

CREATE PROCEDURE sp_create_booking
--ALTER PROCEDURE sp_create_booking
	@username VARCHAR(50),
	@flight_no VARCHAR(50),
	@booking_id INT,
	@booking_number VARCHAR(50),
	@number_of_passengers INT
AS
BEGIN
	DECLARE @vcustomer_id INT;
	DECLARE @vflight_id INT;
	DECLARE @vtravel_date DATETIME;
	DECLARE @vfare FLOAT;
	DECLARE @vbooking_amount FLOAT;

	SELECT @vcustomer_id=customer_id 
	FROM customer
	WHERE username=@username;
	
	SELECT @vflight_id=flight_id,
		@vtravel_date=travel_date,
		@vfare = ticket_fare
	FROM flight
	WHERE flight_no=@flight_no;

	SET @vbooking_amount = @vfare * @number_of_passengers;


	/*Print STR(@vcustomer_id) + ',' + STR(@vflight_id) 
		+ ',' + FORMAT(@vtravel_date,'dd-MM-yyyy');
	*/
	BEGIN TRANSACTION;
		INSERT INTO booking(booking_id,booking_date,booking_number,
			customer_id,flight_id,
			number_of_passengers,travel_date)
		VALUES(@booking_id,getdate(),@booking_number,
			@vcustomer_id,@vflight_id,
			@number_of_passengers,@vtravel_date);

		UPDATE booking 
		SET total_fare=@vbooking_amount
		WHERE booking_id=@booking_id;
	COMMIT TRANSACTION;
END
GO

--EXECUTE sp_create_booking 'ashish','AI 302',10014,'005',2;


--DROP PROCEDURE sp_change_fare 

CREATE PROCEDURE sp_change_fare 
--ALTER PROCEDURE sp_change_fare 
	@flight_id INT,
	@fare FLOAT
AS
BEGIN
	BEGIN TRANSACTION;
	UPDATE flight 
	SET ticket_fare=@fare
	WHERE flight_id=@flight_id;
	COMMIT TRANSACTION;
END
GO

--EXEC sp_change_fare 3,11000;
--select * from flight;
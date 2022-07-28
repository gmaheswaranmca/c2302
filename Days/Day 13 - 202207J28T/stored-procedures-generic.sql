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
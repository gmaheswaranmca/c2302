CREATE TABLE employee
(employee_id INT, 
employee_name VARCHAR(256) NOT NULL DEFAULT '', 
job_title VARCHAR(50) NOT NULL DEFAULT '', 
salary float NOT NULL DEFAULT 0,
PRIMARY KEY(employee_id)
);
GO 

INSERT INTO [dbo].[employee] ([employee_id], [employee_name], [job_title], [salary]) 
VALUES (1001, N'Maheswaran', N'Trainer', 1001)
INSERT INTO [dbo].[employee] ([employee_id], [employee_name], [job_title], [salary]) 
VALUES (1002, N'Ashish Ranjan', N'Programmer Analyst', 7500)
INSERT INTO [dbo].[employee] ([employee_id], [employee_name], [job_title], [salary]) 
VALUES (1003, N'Logesh Rajan', N'Software Engineer', 8000)
INSERT INTO [dbo].[employee] ([employee_id], [employee_name], [job_title], [salary]) 
VALUES (1004, N'Gokul', N'Software Engineer', 5500)
INSERT INTO [dbo].[employee] ([employee_id], [employee_name], [job_title], [salary]) 
VALUES (1005, N'Stutee [SP]', N'Programmer', 7800)
GO

CREATE PROCEDURE employee_add
	@employee_id int,
	@employee_name varchar(256),
	@job_title  varchar(256),
	@salary float
AS
BEGIN
	INSERT INTO employee
	(employee_id,employee_name,job_title,salary) 
	VALUES(@employee_id,@employee_name,@job_title,@salary);
END
GO 

CREATE PROCEDURE employee_update
	@employee_id int,
	@employee_name varchar(256),
	@job_title  varchar(256),
	@salary float
AS
BEGIN
	UPDATE employee 
	SET 
		employee_name=@employee_name,
		job_title=@job_title,
		salary=@salary 
	WHERE employee_id=@employee_id;
END
GO 

CREATE PROCEDURE employee_delete
	@employee_id int
AS
BEGIN
	DELETE FROM employee 
	WHERE employee_id=@employee_id;
END
GO 

CREATE PROCEDURE employee_select	
AS
BEGIN
	SELECT employee_id,
		employee_name,job_title,salary 
	FROM employee;
END
GO 
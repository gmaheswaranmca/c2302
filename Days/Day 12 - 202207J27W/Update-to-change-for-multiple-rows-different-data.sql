CREATE TABLE emp(
	emp_id int, 
	full_name varchar(100),
	salary float, 	
	dept_id int);
INSERT INTO emp	
VALUES(10,'rahul',NULL,	10),
(20,'stutee',NULL,	20),
(30,'jain',NULL,	30);
		
CREATE TABLE emp_sal(
	emp_id int, 
	salary float);
INSERT INTO emp_sal
VALUES(10,7000),
		(20,8000),
		(30,6000);

SELECT * FROM emp;
SELECT * FROM emp_sal;

UPDATE emp 
SET emp.salary = sal.salary 
FROM emp_sal sal 
WHERE (emp.emp_id=sal.emp_id);


DROP TABLE emp;


	Update emp 
	SET salary = CASE 
		WHEN emp_id=10 THEN 5000 
		WHEN emp_id=20 THEN 7000 
		WHEN emp_id=30 THEN 8000
		ELSE salary 
		END;
	
	Update emp 
	SET salary = CASE emp_id
		WHEN 10 THEN 5000 
		WHEN 20 THEN 7000 
		WHEN 30 THEN 8000
		ELSE salary 
		END;
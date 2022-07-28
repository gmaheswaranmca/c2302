CREATE TABLE departments (
	department_id INT  PRIMARY KEY,
	department_name VARCHAR (30) NOT NULL
);

CREATE TABLE employees (
	employee_id INT  PRIMARY KEY,
	first_name VARCHAR (20) DEFAULT NULL,
	last_name VARCHAR (25) NOT NULL,
	email VARCHAR (100) NOT NULL,
	phone_number VARCHAR (20) DEFAULT NULL,
	hire_date DATETIME NOT NULL,
	salary FLOAT NOT NULL,
	manager_id INT  DEFAULT NULL,
	department_id INT DEFAULT NULL,
	FOREIGN KEY (department_id) REFERENCES departments (department_id),
	FOREIGN KEY (manager_id) REFERENCES employees (employee_id)
);

/*Data for the table departments */

INSERT INTO departments(department_id,department_name) 
VALUES (1,'Administration');
INSERT INTO departments(department_id,department_name) 
VALUES (2,'Marketing');
INSERT INTO departments(department_id,department_name) 
VALUES (3,'Purchasing');
INSERT INTO departments(department_id,department_name) 
VALUES (4,'Human Resources');
INSERT INTO departments(department_id,department_name) 
VALUES (5,'Shipping');
INSERT INTO departments(department_id,department_name) 
VALUES (6,'IT');
INSERT INTO departments(department_id,department_name) 
VALUES (7,'Public Relations');
INSERT INTO departments(department_id,department_name) 
VALUES (8,'Sales');
INSERT INTO departments(department_id,department_name) 
VALUES (9,'Executive');
INSERT INTO departments(department_id,department_name) 
VALUES (10,'Finance');
INSERT INTO departments(department_id,department_name) 
VALUES (11,'Accounting');



/*Data for the table employees */

INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (100,'Steven','King','steven.king@sqltutorial.org','515.123.4567','1987-06-17',24000.00,NULL,9);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (101,'Neena','Kochhar','neena.kochhar@sqltutorial.org','515.123.4568','1989-09-21',17000.00,100,9);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (102,'Lex','De Haan','lex.de haan@sqltutorial.org','515.123.4569','1993-01-13',17000.00,100,9);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (103,'Alexander','Hunold','alexander.hunold@sqltutorial.org','590.423.4567','1990-01-03',9000.00,102,6);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (104,'Bruce','Ernst','bruce.ernst@sqltutorial.org','590.423.4568','1991-05-21',6000.00,103,6);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (105,'David','Austin','david.austin@sqltutorial.org','590.423.4569','1997-06-25',4800.00,103,6);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (106,'Valli','Pataballa','valli.pataballa@sqltutorial.org','590.423.4560','1998-02-05',4800.00,103,6);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (107,'Diana','Lorentz','diana.lorentz@sqltutorial.org','590.423.5567','1999-02-07',4200.00,103,6);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (108,'Nancy','Greenberg','nancy.greenberg@sqltutorial.org','515.124.4569','1994-08-17',12000.00,101,10);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (109,'Daniel','Faviet','daniel.faviet@sqltutorial.org','515.124.4169','1994-08-16',9000.00,108,10);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (110,'John','Chen','john.chen@sqltutorial.org','515.124.4269','1997-09-28',8200.00,108,10);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (111,'Ismael','Sciarra','ismael.sciarra@sqltutorial.org','515.124.4369','1997-09-30',7700.00,108,10);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (112,'Jose Manuel','Urman','jose manuel.urman@sqltutorial.org','515.124.4469','1998-03-07',7800.00,108,10);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (113,'Luis','Popp','luis.popp@sqltutorial.org','515.124.4567','1999-12-07',6900.00,108,10);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (114,'Den','Raphaely','den.raphaely@sqltutorial.org','515.127.4561','1994-12-07',11000.00,100,3);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (115,'Alexander','Khoo','alexander.khoo@sqltutorial.org','515.127.4562','1995-05-18',3100.00,114,3);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (116,'Shelli','Baida','shelli.baida@sqltutorial.org','515.127.4563','1997-12-24',2900.00,114,3);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (117,'Sigal','Tobias','sigal.tobias@sqltutorial.org','515.127.4564','1997-07-24',2800.00,114,3);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (118,'Guy','Himuro','guy.himuro@sqltutorial.org','515.127.4565','1998-11-15',2600.00,114,3);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (119,'Karen','Colmenares','karen.colmenares@sqltutorial.org','515.127.4566','1999-08-10',2500.00,114,3);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (120,'Matthew','Weiss','matthew.weiss@sqltutorial.org','650.123.1234','1996-07-18',8000.00,100,5);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (121,'Adam','Fripp','adam.fripp@sqltutorial.org','650.123.2234','1997-04-10',8200.00,100,5);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (122,'Payam','Kaufling','payam.kaufling@sqltutorial.org','650.123.3234','1995-05-01',7900.00,100,5);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (123,'Shanta','Vollman','shanta.vollman@sqltutorial.org','650.123.4234','1997-10-10',6500.00,100,5);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (126,'Irene','Mikkilineni','irene.mikkilineni@sqltutorial.org','650.124.1224','1998-09-28',2700.00,120,5);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (145,'John','Russell','john.russell@sqltutorial.org',NULL,'1996-10-01',14000.00,100,8);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (146,'Karen','Partners','karen.partners@sqltutorial.org',NULL,'1997-01-05',13500.00,100,8);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (176,'Jonathon','Taylor','jonathon.taylor@sqltutorial.org',NULL,'1998-03-24',8600.00,100,8);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (177,'Jack','Livingston','jack.livingston@sqltutorial.org',NULL,'1998-04-23',8400.00,100,8);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (178,'Kimberely','Grant','kimberely.grant@sqltutorial.org',NULL,'1999-05-24',7000.00,100,8);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (179,'Charles','Johnson','charles.johnson@sqltutorial.org',NULL,'2000-01-04',6200.00,100,8);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (192,'Sarah','Bell','sarah.bell@sqltutorial.org','650.501.1876','1996-02-04',4000.00,123,5);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (193,'Britney','Everett','britney.everett@sqltutorial.org','650.501.2876','1997-03-03',3900.00,123,5);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (200,'Jennifer','Whalen','jennifer.whalen@sqltutorial.org','515.123.4444','1987-09-17',4400.00,101,1);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (201,'Michael','Hartstein','michael.hartstein@sqltutorial.org','515.123.5555','1996-02-17',13000.00,100,2);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (202,'Pat','Fay','pat.fay@sqltutorial.org','603.123.6666','1997-08-17',6000.00,201,2);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (203,'Susan','Mavris','susan.mavris@sqltutorial.org','515.123.7777','1994-06-07',6500.00,101,4);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (204,'Hermann','Baer','hermann.baer@sqltutorial.org','515.123.8888','1994-06-07',10000.00,101,7);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (205,'Shelley','Higgins','shelley.higgins@sqltutorial.org','515.123.8080','1994-06-07',12000.00,101,11);
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,salary,manager_id,department_id) 
VALUES (206,'William','Gietz','william.gietz@sqltutorial.org','515.123.8181','1994-06-07',8300.00,205,11);

/*
Queries:
o INSERT YOUR NAME INTO EMPLOYEES
o UPDATE William Gietz's salary to 50% extra
o Display Employee Full Name, email, phone number
o Display Employee Full Name, email, phone number, department id
o Display Employee Full Name, email, phone number, department name
o Display Employee Full Name, email, phone number, manager id
o Display Employee Full Name, email, phone number, manager name
o Display maximum salary 
o Display minimum salary 
o Display total salary 
o Display number of employees
o Display distinct salaries
o Display number of managers (NO DISTINCT)
o Display number of managers (DISTINCT)
o Display department name, number of employees for each department 
o Display Employee Full Name, email, phone number 	--- I
	where salary is greater than or equal to 8000
o Display Employee Full Name, email, phone number 	--- II
	where salary Department is either 3 or 5 
o Display Employee Full Name, email, phone number 	--- I
	where employee name starts with  	
*/

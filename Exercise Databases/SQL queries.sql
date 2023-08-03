SELECT id, first_name, last_name, job_title 
FROM hotel.employees
ORDER BY id;

SELECT id, first_name, last_name, job_title 
FROM hotel.employees
ORDER BY first_name ASC;

SELECT id AS 'No.', 
first_name AS 'First name',
last_name AS 'Last name',
job_title AS 'Job title'
FROM hotel.employees AS e
ORDER BY id;

SELECT concat(first_name,' ',last_name) AS 'Full Name', 
job_title as  'Job Title',
id AS 'No.'
FROM hotel.employees;

SELECT concat(first_name,' ',last_name) AS 'Full Name', 
job_title as  'Job Title',
salary AS 'Salary'
FROM hotel.employees
WHERE SALARY > 1000;

SELECT DISTINCT department_id
FROM hotel.employees;

SELECT last_name, department_id
FROM hotel.employees
WHERE department_id = 1;

SELECT last_name, salary
FROM hotel.employees
WHERE salary <= 2000;

SELECT first_name, last_name FROM hotel.employees
WHERE NOT (department_id = 3 OR department_id = 4);

SELECT last_name, salary FROM hotel.employees
WHERE salary BETWEEN 1200 AND 2200;

SELECT * FROM hotel.employees AS e
WHERE e.department_id = 4 AND e.salary >= 1000;

SELECT last_name, department_id
FROM hotel.employees
WHERE department_id IS NULL;

SELECT last_name, department_id 
FROM hotel.employees
WHERE department_id IS NOT NULL;

SELECT last_name, hire_date
FROM hotel.employees
ORDER BY hire_date;

INSERT INTO hotel.departments (name) VALUES ('Human Resources');

SELECT * FROM hotel.departments;

CREATE TABLE hotel.employee_contacts
AS
SELECT id, first_name, CONCAT(first_name, '.', last_name,'@hotel.com') 
AS email, 
'N/A' AS phone
FROM hotel.employees;

SELECT * FROM hotel.employee_contacts;

create table hotel.restaurant(
	menu varchar(50)
);

UPDATE hotel.employees
SET last_name = 'Brown'
WHERE id = 1;

UPDATE hotel.employees
SET salary = salary * 1.10,
	job_title = CONCAT('Senior',' ', `job_title`)
WHERE department_id = 3;

UPDATE hotel.employees
SET salary = salary + 100
WHERE job_title = 'Housekeeper';
SELECT salary
FROM hotel.employees;

DELETE FROM hotel.employees 
WHERE id = 1;

TRUNCATE TABLE employee_contacts;

select * from hotel.employee_contacts;

DELETE FROM employees
WHERE department_id = 1
OR department_id = 2;
SELECT * FROM employees;

SELECT d.name AS department_name,
       COUNT(e.id) AS total_employees,
       AVG(e.salary) AS average_salary,
       MIN(e.salary) AS min_salary,
       MAX(e.salary) AS max_salary
FROM departments d
LEFT JOIN employees e ON d.id = e.department_id
GROUP BY d.name
HAVING total_employees >= 2
ORDER BY average_salary DESC;

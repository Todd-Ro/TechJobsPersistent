--Part 1

-- My query was 
SELECT *
FROM jobs;

-- followed by
SELECT DATA_TYPE
FROM INFORMATION_SCHEMA.COLUMNS
WHERE table_schema = 'techjobs' and table_name='jobs';

/*My answer is
Id - int
Name - longtext
EmployerId - int*/



--Part 2

--Part 3


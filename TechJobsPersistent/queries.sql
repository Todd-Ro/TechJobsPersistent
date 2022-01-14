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

SELECT Name 
FROM employers
WHERE Location="St. Louis City";

--Part 3

-- Without the restriction that it must be attached to a job, the query would be
SELECT Name 
FROM skills
WHERE Id is not null
ORDER BY Name;

--With this restriction, the query is
SELECT skills.Name
FROM skills
INNER JOIN jobskills ON jobskills.SkillId = skills.Id
ORDER BY skills.Name;
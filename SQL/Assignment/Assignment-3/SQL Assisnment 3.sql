use AssignmentDB

-- Q1_Managers
SELECT DISTINCT ename FROM EMP WHERE job = 'MANAGER';


-- Q2_EarnMoreThan1000
SELECT ename, sal FROM EMP WHERE sal > 1000;


-- Q3_ExceptJames
SELECT ename, sal FROM EMP WHERE ename != 'JAMES';


-- Q4_NamesBeginWithS
SELECT * FROM EMP WHERE ename LIKE 'S%';


-- Q5_NamesContainA
SELECT ename FROM EMP WHERE ename LIKE '%A%';

-- Q6_ThirdCharL
SELECT ename FROM EMP WHERE ename LIKE '__L%';


-- Q7_DailySalaryJones
SELECT ename, sal / 30 AS daily_salary FROM EMP WHERE ename = 'JONES';


-- Q8_TotalMonthlySalary
SELECT SUM(sal) AS total_monthly_salary FROM EMP;


-- Q9_AvgAnnualSalary
SELECT AVG(sal * 12) AS average_annual_salary FROM EMP;



-- Q10_ExceptSalesmanDept30
SELECT ename, job, sal, deptno FROM EMP 
WHERE deptno = 30 AND job != 'SALESMAN';



-- Q11_UniqueDepartments
SELECT DISTINCT deptno FROM EMP;


-- Q12_SalaryAbove1500Dept10Or30
SELECT ename AS Employee, sal AS Monthly_Salary FROM EMP 
WHERE sal > 1500 AND (deptno = 10 OR deptno = 30);



-- Q13_ManagerOrAnalyst
SELECT ename, job, sal 
FROM EMP 
WHERE (job = 'MANAGER' OR job = 'ANALYST') AND sal NOT IN (1000, 3000, 5000);



-- Q14_CommGreaterThanSal
SELECT ename, sal, comm 
FROM EMP 
WHERE comm > sal * 1.10;


-- Q15_TwoLsInName
SELECT ename 
FROM EMP 
WHERE ename LIKE '%L%L%' AND (deptno = 30 OR mgr_id = 7782);



--16
SELECT ename 
FROM EMP 
WHERE DATEDIFF(yy, hiredate, GETDATE()) BETWEEN 31 AND 39;
-- employees with experience between 31 and 39 years
SELECT COUNT(*) AS Total_No_Of_Employees 
FROM EMP 
WHERE DATEDIFF(yy, hiredate, GETDATE()) BETWEEN 31 AND 39;



-- Q17_DeptsAndEmployeesOrder
SELECT d.dname, e.ename FROM DEPT d 
JOIN EMP e ON d.deptno = e.deptno 
ORDER BY d.dname ASC, e.ename DESC;



-- Q18_ExperienceMiller
SELECT 
ENAME,
DATEDIFF(YEAR, HIREDATE, GETDATE()) AS EXPERIENCE
FROM EMP
WHERE ENAME = 'MILLER';





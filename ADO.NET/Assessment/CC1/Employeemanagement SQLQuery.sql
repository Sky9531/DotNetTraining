CREATE DATABASE Employeemanagement

USE Employeemanagement

---1. Create a stored procedure
CREATE TABLE Employee_Details (
    EmpNo INT PRIMARY KEY,  
    EmpName VARCHAR(50) NOT NULL, 
    EmpSal NUMERIC(10, 2) CHECK (EmpSal >= 25000), 
    EmpType CHAR(1) CHECK (EmpType IN ('F', 'P'))  
);



CREATE PROCEDURE AddEmployee
    @EmpName VARCHAR(50),
    @EmpSal NUMERIC(10, 2),
    @EmpType CHAR(1)
AS
BEGIN
   
    DECLARE @NewEmpNo INT;
    SELECT @NewEmpNo = COALESCE(MAX(EmpNo), 0) + 1 FROM Employee_Details;
    INSERT INTO Employee_Details (EmpNo, EmpName, EmpSal, EmpType)
    VALUES (@NewEmpNo, @EmpName, @EmpSal, @EmpType);
    SELECT @NewEmpNo AS NewEmpNo;
END;

--2.test the stored procedure
EXEC AddEmployee @EmpName = 'Sonu', @EmpSal = 30000, @EmpType = 'F';
EXEC AddEmployee @EmpName = 'Satish', @EmpSal = 28000, @EmpType = 'P';

SELECT * FROM Employee_Details;
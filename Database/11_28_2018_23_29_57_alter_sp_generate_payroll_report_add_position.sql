-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[spReportGeneratedPayrollPerUser] 
	-- Add the parameters for the stored procedure here
	@payrollDetailsId INT
AS
BEGIN
	SELECT * FROM PayrollDetails
	INNER JOIN Additionals on Additionals.ID = PayrollDetails.AdditionalID
	INNER JOIN Deductions on Deductions.ID = PayrollDetails.DeductionID
	INNER JOIN Employee on Employee.ID = PayrollDetails.EmployeeID
	INNER JOIN Users on Users.EmployeeID = PayrollDetails.EmployeeID
	INNER JOIN Remarks on Remarks.ID = PayrollDetails.ID
	INNER JOIN Employee_Position on Employee_Position.ID = Employee.Position
	WHERE PayrollDetails.ID= @payrollDetailsId
END

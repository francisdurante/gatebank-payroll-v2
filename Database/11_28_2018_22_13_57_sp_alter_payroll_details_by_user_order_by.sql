
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[spGetAPayrollDetailPerUser] 
		@employeeId INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT * FROM PayrollDetails
	INNER JOIN Additionals on Additionals.ID = PayrollDetails.AdditionalID
	INNER JOIN Deductions on Deductions.ID = PayrollDetails.DeductionID
	INNER JOIN Employee on Employee.ID = PayrollDetails.EmployeeID
	INNER JOIN Users on Users.EmployeeID = PayrollDetails.EmployeeID
	WHERE PayrollDetails.EmployeeID = @employeeId
	ORDER BY PayrollDetails.ID DESC
END

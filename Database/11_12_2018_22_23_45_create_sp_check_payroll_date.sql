-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE spCheckPayrollDate 
	@employeeName varchar(max),
	@dateFrom Date,
	@dateTo Date
AS
BEGIN
	Declare @employeeID INT,
			@count Int
	SET NOCOUNT ON;
	
	SELECT @employeeID = (SELECT ID FROM Employee WHERE EmployeeName = @employeeName);

	SELECT @count = (SELECT COUNT(*) FROM PayrollDetails WHERE DateFrom = @dateFrom AND DateTo = @dateTo AND EmployeeID = @employeeID);
   
	SELECT 'Response' = @count
END


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[spGetEmployeeName] 
	@status INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	if(@status = 0)
	BEGIN
		SELECT * FROM Employee 
		INNER JOIN Employee_Position on Employee.Position = Employee_Position.ID
		INNER JOIN Branch on Employee.Branch =  Branch.ID
		WHERE EmployeeStatus = 0 
		ORDER BY Branch ASC;
	END
	if(@status = 1)
	BEGIN
		SELECT * FROM Employee 
		INNER JOIN Employee_Position on Employee.Position = Employee_Position.ID
		INNER JOIN Branch on Employee.Branch =  Branch.ID
		WHERE EmployeeStatus = 1 
		ORDER BY Branch ASC;
	END
	ELSE
	BEGIN
		SELECT * FROM Employee 
		INNER JOIN Employee_Position on Employee.Position = Employee_Position.ID 
		INNER JOIN Branch on Employee.Branch =  Branch.ID
		ORDER BY Branch ASC;
	END
END
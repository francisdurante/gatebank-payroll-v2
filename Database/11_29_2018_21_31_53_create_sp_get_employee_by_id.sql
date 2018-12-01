-- =====================
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE spGetEmployeeDetailsByID 
	@userId INT
AS
BEGIN
	DECLARE @employeeId INT
	SET NOCOUNT ON;
	SET @employeeId = (SELECT EmployeeID FROM Users WHERE ID = @userId)
	SELECT * FROM Employee 
		INNER JOIN Employee_Position on Employee.Position = Employee_Position.ID
		INNER JOIN Branch on Employee.Branch =  Branch.ID
		WHERE Employee.ID = @employeeId
		ORDER BY Branch ASC;
END

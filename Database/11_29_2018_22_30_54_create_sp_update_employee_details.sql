
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE spUpdateEmployeeDetails
	@fullName VARCHAR(50),
	@basicSalary float,
	@position VARCHAR(50),
	@branch VARCHAR(50),
	@dateHired DATETIME,
	@status INT
	
AS
BEGIN
	DECLARE @positionID INT,
			@branchID INT
	SET NOCOUNT ON;
	SET @positionID = (SELECT ID FROM Employee_Position WHERE Name = @position);
	SET @branchID = (SELECT ID FROM Branch WHERE BranchName = @branch);
    -- Insert statements for procedure here
	UPDATE Employee 
	SET EmployeeName = @fullName, 
	BasicSalary = @basicSalary,
	Position = @positionID,
	Branch = @branchID,
	DateHired = @dateHired,
	EmployeeStatus = @status
END

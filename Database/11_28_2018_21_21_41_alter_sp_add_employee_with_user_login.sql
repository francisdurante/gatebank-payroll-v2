
-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[spInsertEmployee] 
	-- Add the parameters for the stored procedure here
	@fullName VARCHAR(100),
	@basicSalary float,
	@position VARCHAR(50),
	@dateHire DATE,
	@branch VARCHAR(100),
	@userLogIn DECIMAL(4,0),
	@password VARCHAR(MAX)
AS
BEGIN
	DECLARE @positionId INT,
			@branchId INT,
			@checkExisting INT,
			@employeeId INT
	SET NOCOUNT ON;
	SELECT @checkExisting = (SELECT COUNT(*) FROM Employee WHERE EmployeeName = @fullName);
	if(@checkExisting = 0)
	BEGIN
		SELECT @positionId = (SELECT ID FROM Employee_Position WHERE Name = @position);
		SELECT @branchId = (SELECT ID FROM Branch WHERE BranchName = @branch);

		INSERT INTO Employee(EmployeeName,BasicSalary,Position,DateHired,Branch)
		VALUES (@fullName,@basicSalary,@positionId,@dateHire,@branchId);
		SET @employeeId = SCOPE_IDENTITY();

		INSERT INTO Users(full_name,login_id,login_password,access_level,user_status,EmployeeID) 
		VALUES
		(@fullName,@userLogIn,@password,2,1,@employeeId)

		SELECT 'Response' = 1;
	END
	ELSE
		BEGIN
		SELECT 'Response' = 0;
		END
END

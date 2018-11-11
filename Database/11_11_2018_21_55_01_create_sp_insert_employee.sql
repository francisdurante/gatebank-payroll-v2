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
CREATE PROCEDURE spInsertEmployee 
	-- Add the parameters for the stored procedure here
	@fullName VARCHAR(100),
	@basicSalary float,
	@position VARCHAR(50),
	@dateHire DATE,
	@branch VARCHAR(100)
AS
BEGIN
	DECLARE @positionId INT,
			@branchId INT
	SET NOCOUNT ON;
	SELECT @positionId = (SELECT ID FROM Employee_Position WHERE Name = @position);
	SELECT @branchId = (SELECT ID FROM Branch WHERE BranchName = @branch);

	INSERT INTO Employee(EmployeeName,BasicSalary,Position,DateHired,Branch)
	VALUES (@fullName,@basicSalary,@positionId,@dateHire,@branchId);
END

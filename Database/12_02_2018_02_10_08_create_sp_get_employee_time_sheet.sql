
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE spGetEmployeetimeSheet
	-- Add the parameters for the stored procedure here
	@employeeID INT,
	@date date
AS
BEGIN
	
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM TimeSheet 
	WHERE EmployeeID = @employeeID
	AND TimeSheetDay LIKE @date
END

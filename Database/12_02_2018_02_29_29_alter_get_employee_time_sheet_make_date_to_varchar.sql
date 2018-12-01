
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[spGetEmployeetimeSheet]
	-- Add the parameters for the stored procedure here
	@employeeID INT,
	@date VARCHAR(50)
AS
BEGIN
	
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM TimeSheet 
	WHERE EmployeeID = @employeeID
	AND TimeSheetDay LIKE @date
END

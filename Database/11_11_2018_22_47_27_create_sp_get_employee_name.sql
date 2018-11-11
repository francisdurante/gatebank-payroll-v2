
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE spGetEmployeeName 
	@status INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	if(@status = 0)
	BEGIN
		SELECT * FROM Employee WHERE EmployeeStatus = 0 ORDER BY Branch ASC;
	END
	if(@status = 1)
	BEGIN
		SELECT * FROM Employee WHERE EmployeeStatus = 1 ORDER BY Branch ASC;
	END
	ELSE
	BEGIN
		SELECT * FROM Employee ORDER BY Branch ASC;
	END
END
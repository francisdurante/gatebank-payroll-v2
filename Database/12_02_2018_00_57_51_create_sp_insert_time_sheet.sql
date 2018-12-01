-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE spInsertTimeSheet
	@employeeID INT,
	@date date,
	@timeIn VARCHAR(50),
	@timeOut VARCHAR(50),
	@remarks VARCHAR(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    INSERT INTO TimeSheet(EmployeeID, TimeSheetDay, TimeSheetTimeIn, TimeSheetTimeOut, TimeSheetRemarks)
	VALUES(@employeeID, @date,@timeIn,@timeOut,@remarks);
END

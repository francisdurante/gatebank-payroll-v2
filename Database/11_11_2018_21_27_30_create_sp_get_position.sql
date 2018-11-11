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
CREATE PROCEDURE spGetPosition 
	@status int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	if(@status = 0)
	BEGIN
		SELECT * FROM Employee_Position WHERE EP_Status = 0;
	END
	if(@status = 1)
	BEGIN
		SELECT * FROM Employee_Position WHERE EP_Status = 1;
	END
	if(@status = 2)
	BEGIN
		SELECT * FROM Employee_Position;
	END
END

-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE spSaveParameters
	-- Add the parameters for the stored procedure here
	@pagibig float,
	@philhealth float,
	@provi float
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	UPDATE ParameterDeductions SET Parameter_value = @pagibig WHERE ID = 1;
	UPDATE ParameterDeductions SET Parameter_value = @philhealth WHERE ID = 2;
	UPDATE ParameterDeductions SET Parameter_value = @provi WHERE ID = 3;
END

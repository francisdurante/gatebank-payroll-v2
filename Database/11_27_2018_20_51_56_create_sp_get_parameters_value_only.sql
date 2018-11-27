
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE spGetValueParameters 
	-- Add the parameters for the stored procedure here
	@for varchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT ParameterDeductions.Parameter_value FROM ParameterDeductions WHERE Parameter_name = @for;
END

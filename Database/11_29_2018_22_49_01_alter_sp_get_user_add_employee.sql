
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[spGetUsers] 
	-- Add the parameters for the stored procedure here
	@user_full_name VARCHAR(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT * FROM Users 
	INNER JOIN AccessLevel on Users.access_level = AccessLevel.ID
	INNER JOIN Employee on Employee.ID = Users.ID
	WHERE full_name LIKE @user_full_name
	
END

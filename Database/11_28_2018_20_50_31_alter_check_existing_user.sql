
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[spCheckIfExistingUser] 
	@userlogID DECIMAL(4,0)
AS
BEGIN
	SET NOCOUNT ON;
	
    -- Insert statements for procedure here
	SELECT * FROM Users WHERE login_id = @userlogID;
	
END

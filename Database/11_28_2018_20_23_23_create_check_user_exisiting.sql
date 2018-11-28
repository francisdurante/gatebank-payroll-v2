-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE spCheckIfExistingUser 
	@userlogID DECIMAL(4,0)
AS
BEGIN
	SET NOCOUNT ON;
	
    -- Insert statements for procedure here
	SELECT * FROM Users WHERE @userlogID = @userlogID;
	
END

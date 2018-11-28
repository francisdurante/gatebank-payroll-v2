
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[spSaveUser] 
	@fullName VARCHAR(50),
	@userLogId DECIMAL(4,0),
	@password VARCHAR(MAX),
	@accessLevel VARCHAR(100)

AS
BEGIN
	SET NOCOUNT ON;
	
    -- Insert statements for procedure here
	
	INSERT INTO Users(full_name,login_id,login_password,access_level,user_status) 
	VALUES
	(@fullName,@userLogId,@password,1,1)
END

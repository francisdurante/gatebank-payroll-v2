-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE spSaveUser 
	@fullName VARCHAR(50),
	@userLogId DECIMAL(4,0),
	@password VARCHAR(MAX),
	@accessLevel VARCHAR(100)

AS
BEGIN
	DECLARE @accessLevelID INT
	SET NOCOUNT ON;
	SET @accessLevelID = (SELECT ID FROM AccessLevel WHERE name = @accessLevel);
    -- Insert statements for procedure here
	
	INSERT INTO Users(full_name,login_id,login_password,access_level) 
	VALUES
	(@fullName,@userLogId,@password,@accessLevelID)
END


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE spUpdateUsers 
	@fullName Varchar(50),
	@AccessLevel VARCHAR(50),
	@status INT,
	@ID INT
	
AS
BEGIN
	DECLARE @AccessLevelID INT
	SET NOCOUNT ON;

    SET @AccessLevelID = (SELECT ID FROM AccessLevel WHERE AccessLevel.name = @AccessLevel);

	UPDATE Users 
	SET full_name = @fullName, 
	access_level = @AccessLevelID, 
	user_status = @status 
	WHERE ID = @ID
	
END

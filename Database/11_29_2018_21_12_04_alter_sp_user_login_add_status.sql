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
-- Author:		Francis Durante
-- Create date: 11102018
-- Description:	LoggedIn
-- =============================================
ALTER PROCEDURE [dbo].[spUserLoggedIn] 
	-- Add the parameters for the stored procedure here
	@username varchar(50),
	@password varchar(max)
AS
BEGIN
	DECLARE @user_logged_count INT,
			@return INT
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT @user_logged_count = (SELECT COUNT(*) FROM Users 
	WHERE Users.login_id = @username 
	AND Users.login_password = @password
	AND Users.user_status = 1);

	IF(@user_logged_count = 0)
		BEGIN
			SELECT @return = 0;
		END
	ELSE IF(@user_logged_count = 1)
		BEGIN
			SELECT @return = 1;
		END
	ELSE
		BEGIN
			SELECT @return = 2;
		END
	if(@return = 1)
		BEGIN
			SELECT * FROM Users 
			INNER JOIN AccessLevel ON Users.access_level = AccessLevel.ID
			WHERE Users.login_id = @username 
			AND Users.login_password = @password
		END
	else
	BEGIN
		SELECT 'Response' = @return;
	END
END

CREATE TABLE Users(
	ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	login_id decimal(4) NOT NULL,
	login_password VARCHAR(MAX) NOT NULL,
	access_level INT NOT NULL,
	full_name VARCHAR(100) NOT NULL,
	user_status INT DEFAULT 1

	FOREIGN KEY (access_level) REFERENCES AccessLevel(ID)
);
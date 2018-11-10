Create TABLE AccessLevel(
	ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	name VARCHAR(100),
	access_level_status INT DEFAULT 1
);
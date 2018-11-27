CREATE TABLE ParameterDeductions(
	ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Parameter_name varchar(25) NOT NULL,
	Parameter_value float NOT NULL,
	Parameter_status INT DEFAULT 1  NOT NULL
	)

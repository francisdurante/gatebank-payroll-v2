CREATE TABLE Employee(
	ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Name VARCHAR(MAX) NOT NULL,
	Position INT NOT NULL,
	Basic_Salary float,
	E_Status INT
	FOREIGN KEY (Position) REFERENCES Employee_Position(ID)
);
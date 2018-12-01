CREATE TABLE TimeSheet(
	ID INT IDENTITY(1,1) NOT NULL,
	EmployeeID INT NOT NULL,
	TimeSheetDay Date NOT NULL,
	TimeSheetTimeIn VARCHAR(50) NULL,
	TimeSheetTimeOut VARCHAR(50) NULL,
	TimeSheetRemarks VARCHAR(50) NULL,

	FOREIGN KEY (EmployeeID) REFERENCES Employee(ID)
)

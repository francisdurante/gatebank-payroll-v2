CREATE TABLE PayrollDetails(
	ID int primary key identity(1,1) not null,
	EmployeeID int not null,
	AdditionalID int not null,
	DeductionID int not null,
	DateFrom date not null,
	DateTo date not null

	Foreign key (EmployeeID) references Employee(ID),
	Foreign key (AdditionalID) references Additionals(ID),
	Foreign key (DeductionID) references Deductions(ID)
)
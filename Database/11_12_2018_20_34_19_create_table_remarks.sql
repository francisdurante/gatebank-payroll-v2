Create table Remarks(
	ID int primary key identity(1,1) not null,
	PayrollDetailsID int not null,
	Remarks Varchar(MAX)

	Foreign key (PayrollDetailsID) references PayrollDetails(ID)
)
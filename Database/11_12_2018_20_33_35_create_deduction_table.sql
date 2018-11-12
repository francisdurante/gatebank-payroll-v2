CREATE TABLE Deductions(
	ID int primary key not null identity(1,1),
	SSS float not null,
	PagIbig float not null,
	PhilHealth float not null,
	Tax float not null,
	SSSLoan float not null,
	PagIbigLoan float not null,
	ProviLoan float not null,
	Absents float not null,
	Lates float not null,
	SMCard float not null,
	ArHealthCard float not null,
	Other float not null
)
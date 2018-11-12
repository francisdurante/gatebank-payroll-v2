CREATE TABLE Additionals(
	ID int primary key not null identity(1,1),
	OT float not null,
	Allowance float not null,
	Incentives float not null,
	Bonus float not null,
	Other1 varchar(50),
	Other1V float not null,
	Other2 varchar(50),
	Other2V float not null,
	Other3 varchar(50),
	Other3V float not null
)
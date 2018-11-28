ALTER TABLE Users 
	ADD EmployeeID integer constraint fk foreign key references Employee(ID)
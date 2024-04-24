if not exists (SELECT 1 From dbo.Customer)
begin
	insert into dbo.Customer(FirstName,LastName)
	values ('Daniel','Jesus'),
	('Renato','Groofe'),
	('Thiago','Adriano'),
	('Ray','Carneiro')



end
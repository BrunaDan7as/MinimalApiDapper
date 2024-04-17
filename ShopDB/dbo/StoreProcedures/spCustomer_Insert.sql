CREATE PROCEDURE [dbo].[spCustomer_Insert]
	@FirstName nvarchar(50),
	@LastName nvarchar(50)
AS
	INSERT INTO dbo.Customer (FirstName, LastName)
	VALUES (@FirstName, @LastName)
RETURN 0

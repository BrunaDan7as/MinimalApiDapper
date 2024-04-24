CREATE PROCEDURE [dbo].[spCustomer_Delete]
	@Id int
AS
BEGIN
	DELETE FROM dbo.Customer
	WHERE Id = @Id;
END

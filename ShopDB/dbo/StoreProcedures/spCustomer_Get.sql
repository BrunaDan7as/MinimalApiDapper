CREATE PROCEDURE [dbo].[spCustomer_Get]
	@Id int
AS
Begin
	SELECT *
	From dbo.Customer
	Where Id = @Id;
End

USE AdventureWorks2014
GO

Create Procedure SP_HumanResources_Department_Delete (
	@name nvarchar(50)
	)
AS
BEGIN
	Delete From HumanResources.Department
	Where Name = @name
	return 1
END
GO
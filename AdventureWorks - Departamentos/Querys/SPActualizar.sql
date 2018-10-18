use AdventureWorks2014
go

create procedure SP_HumanResources_Department_Update (
	@name nvarchar(50),
	@newName nvarchar(50),
	@GroupName nvarchar(50),
	@date datetime
	)
AS
BEGIN
	BEGIN
	Select Name From HumanResources.Department Where Name=@name
	END
	BEGIN
	Update HumanResources.Department
	SET Name=@newName, GroupName=@GroupName, ModifiedDate=@date
	Where Name=@name
	END
END
go
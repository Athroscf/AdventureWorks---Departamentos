use AdventureWorks2014
go

Create Procedure SP_HumanResources_Department_Insert
(@name nvarchar(50), 
 @groupName nvarchar(50), 
 @date datetime)
AS
BEGIN
	INSERT INTO HumanResources.Department (Name, GroupName, ModifiedDate)
    VALUES (@name, @groupName, @date)
	return 1
END
go
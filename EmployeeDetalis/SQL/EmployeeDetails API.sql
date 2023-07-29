create table EmployeeDetails
(
  ID int primary key identity(1,1),
  Name nvarchar(500) not null,
  Address nvarchar(500) not null,
  Age int not null,
  Phonenumber bigint not null,
  DOB datetime2 not null
  )
  drop table EmployeeDetails

  create or alter procedure listEmployeeDetails (@id int)
  as
  begin
   select * from EmployeeDetails
   where ID=@id
   end

   exec listEmployeeDetails 2
 
  select * from EmployeeDetails

create or alter procedure EmployeeDetailsinsert (@Name nvarchar(500),@Address nvarchar(500), @Age int,@phonenumber bigint, @DOB datetime2)
   as 
   begin

   insert into EmployeeDetails (Name,Address,Age,Phonenumber,DOB) values (@Name,@Address,@Age,@phonenumber,@DOB)
   end

   exec EmployeeDetailsinsert 'hari','palani',21,8925520077,'08-08-2002'

   create or alter procedure EmployeeDetailsUpdate (@Name nvarchar(500),@Address nvarchar(500), @Age int,@phonenumber bigint, @DOB datetime2 ,@ID int)
   as
   begin
    update EmployeeDetails set Name=@Name,Address=@Address,Age=@Age,Phonenumber=@phonenumber,DOB=@DOB
	where ID=@ID
	end
	exec EmployeeDetailsUpdate 'ajay','akp',24,0987654321,'08-08-2002',1

	create or alter procedure EmployeeDetailsDelete (@id int)
	as
	begin
	 delete from EmployeeDetails where ID =@id

 end

 exec EmployeeDetailsDelete  1

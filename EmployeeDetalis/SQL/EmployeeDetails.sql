create table EmployeeDetails
(
  Name nvarchar(500) not null,
  Address nvarchar(500) not null,
  Age int not null,
  Phonenumber bigint not null,
  DOB datetime2 not null
  )
  drop table EmployeeDetails

  create procedure listEmployeeDetails
  as
  begin
   select * from EmployeeDetails
   end

   exec listEmployeeDetails
 

create or alter procedure EmployeeDetailsinsert (@Name nvarchar(500),@Address nvarchar(500), @Age int,@phonenumber bigint, @DOB datetime2)
   as 
   begin

   insert into EmployeeDetails (Name,Address,Age,Phonenumber,DOB) values (@Name,@Address,@Age,@phonenumber,@DOB)
   end

   exec EmployeeDetailsinsert 'hari','palani',21,8925520077,'08-08-2002'

   
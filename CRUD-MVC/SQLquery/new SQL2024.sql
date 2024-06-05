Create Table HospitalDetails(
Id  bigint identity(1,1) Primary key ,
Name nvarchar(100) Not null,
Email nvarchar(100) unique,
Address nvarchar(300) Not null,
Phonenumber bigint Not null,
Pincode bigint Not null)


create or alter procedure  HospitalLogin
 
 (@Name nvarchar(50), 
 @Email nvarchar(100),
 @Address nvarchar(100),
 @Phonenumber bigint,
 @Pincode bigint) 
 
 AS
 Begin
 Insert into[dbo] .[HospitalDetails]
 ([Name],[Email],[Address],[Phonenumber],[Pincode])
 values(
 @Name,
 @Email,
 @Address,
 @Phonenumber,
 @Pincode)
end

exec HospitalLogin  'santhosh','santhosh11@gmail.com','wvfwfwqfwqff',909099090,624613
select *from [HospitalDetails]

 create or alter procedure HospitalEdit
(
 @Name nvarchar(100),
 @Address nvarchar(100),
 @Phonenumber bigint) 
 As
 Begin
 update HospitalDetails set Address=@Address,Phonenumber=@Phonenumber
 where Name=@Name
 end
-- exec  HospitalEdit 'santhosh','sancon@gmail.com',34573698698

-- exec HospitalEdit 2, 'santoshkumar','madesh123@gmail.com','2/23,porulur,dindugul',9090909090,624616
 select *from HospitalDetails

 create or alter procedure HospitalDelete
 (@Id Bigint)
 As
 begin Delete  HospitalDetails where Id=@Id end


 exec HospitalDelete 7
 select *from HospitalDetails

 create or alter procedure HospitalSearch
 (@Name nvarchar (100))
 As
 Begin select * from HospitalDetails 
 where
  Name like'%'+@Name+'%'
  end
  exec HospitalSearch 'ABC'
  Create or alter procedure HospitalShowall
  As
  Begin select *from HospitalDetails end 

-- Id like '%'+@Name+'%' or
-- Email like'%'+@Name+'%'or
-- Address like '%'+@Name+'%' or
 --Phonenumber like'%'+@Name+'%' or
 --Pincode like'%'+@Name+'%'
 

 -- exec HospitalSearch 909099090
 --  create or alter procedure HospitalSelect
 --(@Id Bigint,
 --@Name nvarchar(100),
 --@Email nvarchar(100),
 --@Address nvarchar(100),
 --@Phonenumber bigint,
 --@Pincode bigint)
   
 --As
 --Begin select *from HospitalDetails where Name=@Name,Email=@Email,Address=@Address,
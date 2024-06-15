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
 @Id Bigint ,
 @Name nvarchar (100),
 @Email nvarchar(100),
 @Address nvarchar(100),
 @Phonenumber bigint,
 @Pincode Bigint) 
 As
 Begin
 update HospitalDetails set Name=@Name, Email=@Email, Address=@Address,Phonenumber=@Phonenumber,Pincode=@Pincode
 where Id=@Id
 end
-- exec HospitalEdit 1,'santhosh',5656565656
-- exec  HospitalEdit 'santhosh','sancon@gmail.com',34573698698

exec HospitalEdit 1, 'santoshkumar','madesh123@gmail.com','2/23,porulur,dindugul',9090909090,624616
 select *from HospitalDetails

 create or alter procedure HospitalDelete
 (@Id Bigint)
 As
 begin Delete  HospitalDetails where Id=@Id end


 exec HospitalDelete 7
 select *from HospitalDetails

 create or alter procedure HospitalSearch
 (@Id Bigint)
 As
 Begin select * from HospitalDetails 
 where Id=@Id  end
  
 --exec HospitalSearch 1
  ----exec HospitalSearch 'ABC'
  Create or alter procedure HospitalShowall
  As
  Begin select *from HospitalDetails end 

---------LOCATIONPOINT--------
Create  table Locationdetils
(LocationId Bigint Identity(1,1),
Locationname nvarchar(100) not null)
 select *from Locationdetils



create or alter procedure Locationpoint
As
Begin
select * from Locationdetils end
exec Locationpoint 
 
 create or Alter procedure Locationinsert
 (@Locationname nvarchar(100))
 As
 Begin
 insert into dbo.Locationdetils(Locationname)
 values(@Locationname)
 end
 --exec Locationinsert 'Madurai'

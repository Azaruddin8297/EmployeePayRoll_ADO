-- UC-1-Create Database
create database AddressBookService
use AddressBookService

--UC2-Create Table
create table AddressBook
(	FirstName varchar(100),
	LastName varchar(100),
	Address varchar(100),
	City varchar(50),
	State varchar(50),
	Zip int,
	PhoneNumber varchar(20),
	Email varchar(50)
)

--UC3-Insert Contacts
insert into AddressBook(FirstName,LastName,Address,City,State,Zip,PhoneNumber,Email) values
('Azar','Uddin','RG-Road','Hyderabad','Telangana',500039,'8297214219','Azaruddin@gamil.com'),
('Uddin','Azar','MG-Road','Hyderabad','Telangana',501039,'9999999999','Azar@gamil.com'),
('Iron','Man','GM-Road','Bangalore','Karnataka',500009,'8888888888','Iron@gamil.com'),
('Hulk','Jhon','RR-Road','Kolkata','WestBengal',500000,'7777777777','Hulk@gamil.com'),
('Zombie','Annie','GR-Road','Chennai','TamilNadu',500001,'6666666666','Zombie@gamil.com'),
('Captain','America','GG-Road','Thirur','Kerala',500002,'5555555555','Captain@gamil.com')

select * from AddressBook 

--UC4-Edit Contact
update AddressBook 
set PhoneNumber='4545454545'
where FirstName='Captain'

--UC5-Delete Contact
delete AddressBook 
where FirstName='Hulk'

--UC6-Retrieve Person By City Or State
select * from AddressBook 
where City='Hyderabad' or State='Kerala' 

--UC7-Count Of AddressBook By State And City
select count(*),State,City from AddressBook 
group by State,City

--UC8-Sorting Names
select * from AddressBook 
where City='Hyderabad'
order by(FirstName)
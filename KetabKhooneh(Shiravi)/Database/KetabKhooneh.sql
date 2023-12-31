-- 
-- به نام خــــدا
------------------------------------------------------------------------
-- Mohsen Shiravi
-- dbKetabKhaneh(Shiravi)
/*---------------------------------------------------------------------*/
/*********************************************************************************************/
--Tables
--                                  ********************
--                                  ********************
--                                           ***
--                                           ***
--                                           ***
--                                           ***
--                                           ***
--                                           ***
--                                           ***
--                                           ***
--                                           ***

/**********************************************************************************************/
if exists(select * from sys.objects where type='U' and Name='tTrust')
drop table tTrust
Go
if exists(select * from sys.objects where type='U' and Name='tUsers')
drop table tUsers
Go
if exists(select * from sys.objects where type='U' and Name='tKetab')
drop table tKetab
Go
if exists(select * from sys.objects where type='U' and Name='tModir')
drop table tModir
Go
if exists(select * from sys.objects where type='U' and Name='tGroups')
drop table tGroups
Go
/*4&&&&&&&&&&&&&&&&&&&&&&&&&&&&&  &&&&&&&&&&&&&&&&&&&&&&&&&&*/
Create table tModir
(
ModirID tinyint identity Primary key,
ModirUserName nvarchar(55) not null,
ModirPass nvarchar(55) not null,
ModirNoAccess bit default 0
)
Go
insert tModir values ('Yahya','1',1)
insert tModir values ('taher','2',0)
insert tModir values ('mahdi','3',0)
insert tModir values ('نادر احمدی','1',0)
Go
/*4&&&&&&&&&&&&&&&&&&&&&&&&&&&&&  &&&&&&&&&&&&&&&&&&&&&&&&&&*/
Create table tUsers
(
UsID int identity(10001,1) primary key,
UsName Nvarchar(33) not null,
UsFamily Nvarchar(33) not null,
UsFatherName Nvarchar(33) not null,
UsNumber char(10) null , -- 09363320376 Mobile
UsBirthDate char(4) null ,-- 1366
UsStartDate bigint null ,
UsRevivalDate char(8) null
)
Go
Insert tUsers values ('محسن','شیروی','نادر','0944755781','1368',13900305,13900305)
Insert tUsers values ('مهدی','قرخلو','غلامرضا','0944755781','1366',13900305,13910311)
Insert tUsers values ('حسین','شیروی','علی','0944755781','1366',13900305,13910311)
Insert tUsers values ('جواد','سیدی','محمدعلی','0944755781','1366',13900305,13900305)
Insert tUsers values ('نادر','احمدی','حسن','0944755781','1366',13900305,13910311)
go
/*4&&&&&&&&&&&&&&&&&&&&&&&&&&&&& گروه &&&&&&&&&&&&&&&&&&&&&&&&&&*/
create table tGroups
(
GroupID Tinyint identity primary key,
GroupName Nvarchar(55) not null,
Unique(GroupName)
)
Go
insert tGroups values('ادبی')
insert tGroups values('علمی')
insert tGroups values('ورزشی')
insert tGroups values('کامپیوتر')
insert tGroups values('غیره')
insert tGroups values('تخیلی')

-- select * from tGroups
Go
/*5&&&&&&&&&&&&&&&&&&&&&&&&&& کتاب &&&&&&&&&&&&&&&&&&&&&&&&&&&*/
create table tKetab
(
KetabID int identity primary key,
KetabOnvan nvarchar(99) Not Null,
KetabFee int not null,
KetabDate char(4) not null,
ketabMojood bit null Default 1, -- mojood dar ketabkhooneh = 1
KetabNumChap tinyInt null Default 1,
GroupID tinyint not null references tGroups(GroupID),
KetabNevisande Nvarchar(110) null,
KetabNasher Nvarchar(55) null
)
Go
Insert tKetab values ('Asp.Net',3000,'1384',1,20,4,'استفان والتر،بابک احترامی','خراسان')
Insert tKetab values ('Ado.Net',3000,'1384',1,2,1,'عین الله جعفر نژاد قمی','البرز')
Insert tKetab values ('Sql Server 2008',5000,'1388',1,2,1,'عین الله جعفر نژاد قمی','آستان قدس')
Insert tKetab values ('Visual Basic 2005',12000,'1388',1,5,1,'مهدی قرخلو','جهاد دانشگاهی')
Insert tKetab values ('Visual Basic 2008',11000,'1387',1,3,1,'عین الله جعفر نژاد قمی','رازی')
Insert tKetab values ('C#.net 2005',15000,'1386',1,2,4,'محمد هاشمیان','خراسان')
-- select * from tKetab
Go
/*7&&&&&&&&&&&&&&&&&&&&&&&&&&& ثبت &&&&&&&&&&&&&&&&&&&&&&&&*/
Create table tTrust
(
TrID int identity Primary key,
TrDate bigint null,
TrReturnDate bigint null,
UsID int null references tUsers(UsID),
KetabID int null references tKetab(KetabID)
)
Go
-- Select * from tTrust 
Go
/*-----------------------------------------------------------------*/
/*********************************************************************************************/

/****************************************************************************************************/
-- Procedures
--                                *******************   **********************
--                                *******************   **********************
--                                ***                   ***                ***
--                                ***                   ***                *** 
--                                ***                   ***                ***
--                                *******************   **********************
--                                *******************   **********************
--                                                ***   ***
--                                                ***   ***
--                                                ***   ***
--                                *******************   ***
--                                *******************   ***

/*****************************************************************************************************/
/******************************************************************/
--select * from tKetab
/********************************************************************************/
if exists(select * from sys.objects where type='P' and Name='spInsertTrust')
drop procedure spInsertTrust
Go
Create procedure spInsertTrust
@TrDate bigint=null,
@TrReturnDate bigint=null,
@UsID int=null,
@KetabID int=null
as
Insert tTrust values (@TrDate,@TrReturnDate,@UsID,@KetabID)
return (select @@identity)
go
/*&&&&&&&&&&&&&&&&&&&&& چک کردن اجازه دسترسی مدیر &&&&&&&&&&&&&&&&&&*/
if exists(select * from sys.objects where type='P' and Name='sp_checkModir')
drop Procedure sp_checkModir
Go
Create procedure sp_checkModir
@ModirID tinyint,
@modirPass nvarchar(55)
as
if exists(select * from tModir where ModirID=@ModirID and ModirPass=@modirPass and ModirNoAccess=0)
-- Okay
return @ModirID
else if exists(select * from tModir where ModirID=@ModirID and ModirNoAccess=0)
--pass irad dare
return 0
else if exists(select * from tModir where ModirID=@ModirID and ModirNoAccess=1)
--gheyre faal shodeid
return -1
Go
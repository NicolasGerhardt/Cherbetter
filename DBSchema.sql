--create database CherBetter
--use cherbetter

--create table Tickets (
--	TID int Identity(1,1) NOT NULL Primary Key,
--	Title nvarchar(50) NOT NULL,
--	TDescription nvarchar(300),
--	TStatus nvarchar(1) NOT NULL,
--	Resolution nvarchar(300)
--);

--create table Favorites (
--	FID int Identity(1,1) NOT NULL Primary Key,
--	Email nvarchar(20) NOT NULL,
--	TicketID int foreign Key References Tickets(TID) NOT NULL
--);

insert into Tickets (Title, TDescription, TStatus, Resolution) values
('My computer not powering on', 'Computer is not powering on, it is plugged in', 0, null),
('Monitor not working', 'Monitor is black and not showing anything, please help', 0, null)
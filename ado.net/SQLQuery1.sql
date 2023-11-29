CREATE DATABASE UserBlogDB

use UserBlogDB

CREATE TABLE Users(
Id int identity primary key,
Name nvarchar(60),
Surname nvarchar(60),
Password nvarchar(256) not null
)

CREATE TABLE Blogs(
Id int identity primary key,
Title nvarchar(100),
Description nvarchar(300),
UserId int references Users(Id)
)

select * from users

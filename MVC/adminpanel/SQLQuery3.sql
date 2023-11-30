CREATE DATABASE AzMB101_Nihad
USE AzMB101_Nihad

CREATE TABLE Users (
  Name VARCHAR(255),
  Position VARCHAR(255),
  Office VARCHAR(255),
  Age INT,
  Start_date DATE,
  Salary INT
);

INSERT INTO Users (Name, Position, Office, Age, Start_date, Salary)
VALUES ('John Doe', 'Manager', 'Seattle', 35, '2022-01-01', 100000),
       ('Jane Smith', 'Engineer', 'New York', 28, '2021-05-01', 80000),
       ('Bob Johnson', 'Sales', 'Los Angeles', 42, '2020-03-01', 120000);


select * from Users
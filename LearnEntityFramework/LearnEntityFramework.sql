use LearnEntityFramework

create table Category(
Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
Name varchar(50) NULL
)

INSERT Category (Name) VALUES ('Mobile')
INSERT Category (Name) VALUES ('Laptop')
INSERT Category (Name) VALUES ('Tivi')

create table Product(
Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
Name varchar(50) NULL,
Price money NULL,
Quantity int NULL,
CreationDate date NULL,
Status bit NULL,
CategoryId int NULL,
FOREIGN KEY(CategoryId) REFERENCES Category(Id)
)

INSERT Product (Name, Price, Quantity, CreationDate, Status, CategoryId) VALUES ('Mobile 1', 10.0000, 2, '2017-12-20', 1, 1)
INSERT Product (Name, Price, Quantity, CreationDate, Status, CategoryId) VALUES ('Mobile 2', 24.0000, 4, '2017-12-21', 0, 1)
INSERT Product (Name, Price, Quantity, CreationDate, Status, CategoryId) VALUES ('Mobile 3', 26.0000, 9, '2017-11-14', 1, 1)
INSERT Product (Name, Price, Quantity, CreationDate, Status, CategoryId) VALUES ('Laptop 1', 15.0000, 7, '2017-06-10', 1, 2)
INSERT Product (Name, Price, Quantity, CreationDate, Status, CategoryId) VALUES ('Laptop 2', 21.0000, 16, '2017-09-19', 0, 2)
INSERT Product (Name, Price, Quantity, CreationDate, Status, CategoryId) VALUES ('Tivi 1', 18.0000, 11, '2016-11-20', 1, 3)
INSERT Product (Name, Price, Quantity, CreationDate, Status, CategoryId) VALUES ('Tivi 2', 25.0000, 17, '2016-12-05', 0, 3) 

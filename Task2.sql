CREATE TABLE Product (
	Id INT PRIMARY KEY,
	"Name" TEXT
);

INSERT INTO Product
VALUES
	(1, 'Viola'),
	(2, 'Lays'),
	(3, 'Twix');
	(4, 'Pepsi');

CREATE TABLE Category (
	Id INT PRIMARY KEY,
	"Name" TEXT
);

INSERT INTO Category
VALUES
	(1, 'Cheese'),
	(2, 'Сrisps'),
	(3, 'Chocolate');

CREATE TABLE ProductCategory (
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductCategories
VALUES
	(1, 1),
	(2, 2),
	(3, 3);

SELECT P."Name", C."Name"
FROM Product P
LEFT JOIN ProductCategory PC
	ON P.Id = PC.ProductId
LEFT JOIN Categoriy C
	ON PC.CategoryId = C.Id;
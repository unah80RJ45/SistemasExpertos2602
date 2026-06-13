drop table Articulo

create table Articulo
(
	Codigo		varchar(20),
	Existencia	int,
	Promedio	int,
	Minimo		int,
	Tiempo		int
)

INSERT INTO Articulo
VALUES ('Producto A', 20, 5, 30, 4),
       ('Producto B', 100, 10, 30, 5),
       ('Producto C', 12, 8, 10, 2);

select * from Articulo

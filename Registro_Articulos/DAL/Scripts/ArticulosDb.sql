CREATE DATABASE ArticulosDb
GO
USE ArticulosDb
GO
CREATE TABLE Articulos
(
	Id int primary key identity,
	Fecha DateTime,
	Descripcion Varchar(max),
	Precio Varchar(15),
	Cantidad Varchar(15),
	CantidadCotizada Varchar(15)
);
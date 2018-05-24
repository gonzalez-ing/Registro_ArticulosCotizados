
CREATE TABLE Articulos
(
	ArticuloId int primary key identity,
	Fecha Date,
	Descripcion varchar(max),
	Precio money,
	Cantidad int,
	CantidadCotizada int
)
GO
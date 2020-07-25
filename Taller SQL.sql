USE [master]
GO
CREATE DATABASE [Taller]
GO
USE [Taller]
GO

---- CREACIÓN DE TABLAS

CREATE TABLE [dbo].[clientes](
       [IDCliente] [int] IDENTITY(1,1) NOT NULL,
       [Nombre] [varchar](50) NULL,
       [Apellido] [varchar](50) NULL,
       [Fecha_Nacimiento] [varchar](50) NULL,
       [Nro_Documento] [varchar](50) NULL,
       [Direccion] [varchar](50) NULL,
PRIMARY KEY ([IDCliente]) )

CREATE TABLE [dbo].[productos](
       [IDProducto] [int] IDENTITY(1,1) NOT NULL,
       [Nombre] [varchar](50) NULL,
       [Descripcion] [varchar](50) NULL,
       [Precio] [money] NULL,
       [Stock] [int] NULL,
PRIMARY KEY ([IDProducto]) )

---- INSERTS DE REGISTROS

INSERT INTO clientes values('Malena','Gonzales','',456,'-')
INSERT INTO clientes values('Nicolás','Agnessi Vuelta','',789,'-')
INSERT INTO clientes values('Milton','Sesarego','',258,'-')

INSERT INTO productos values('Arena','Bolsa de 25kg',85,20)
INSERT INTO productos values('Cemento','Bolsa de 50kg',450,15)
INSERT INTO productos values('Piedra','Bolsa de 25kg',150,10)

---- CREACIÓN DE STORED PROCEDURES

-- CLIENTES

USE [Taller]
GO

CREATE PROCEDURE GetClientes
AS
BEGIN
-- SET NOCOUNT ON added to prevent extra result sets from
-- interfering with SELECT statements.
SET NOCOUNT ON;

SELECT IDCliente, Nombre, Apellido, Fecha_Nacimiento, Nro_Documento, Direccion FROM clientes
END
GO

CREATE PROCEDURE UpdateClientes
	@Nombre varchar(50),
	@Apellido varchar(50),
	@Fecha_Nacimiento varchar (50),
	@Nro_Documento varchar (50),
	@Direccion varchar (50),
	@IDCliente int out
AS
BEGIN
UPDATE clientes
SET Nombre=@Nombre,
	Apellido=@Apellido,
	Fecha_Nacimiento=@Fecha_Nacimiento,
	Nro_Documento=@Nro_Documento,
	Direccion=@Direccion
WHERE IDCliente=@IDCliente
END
GO

CREATE PROCEDURE InsertClientes
	@Nombre varchar(50),
	@Apellido varchar(50),
	@Fecha_Nacimiento varchar (50),
	@Nro_Documento varchar (50),
	@Direccion varchar (50)
AS
BEGIN
INSERT INTO clientes
(Nombre, Apellido, Fecha_Nacimiento, Nro_Documento, Direccion) 
VALUES (@Nombre, @Apellido, @Fecha_Nacimiento, @Nro_Documento, @Direccion)
END
GO

CREATE PROCEDURE GetClientesPorNombreApellido
	@Nombre varchar(50),
	@Apellido varchar(50)
AS
BEGIN
-- SET NOCOUNT ON added to prevent extra result sets from
-- interfering with SELECT statements.
SET NOCOUNT ON;

SELECT IDCliente, Nombre, Apellido, Fecha_Nacimiento, Nro_Documento, Direccion 
FROM clientes
WHERE Nombre = @Nombre OR Apellido = @Apellido
END
GO

CREATE PROCEDURE GetClientesPorID
	@IDCliente int
AS
BEGIN
-- SET NOCOUNT ON added to prevent extra result sets from
-- interfering with SELECT statements.
SET NOCOUNT ON;

SELECT IDCliente, Nombre, Apellido, Fecha_Nacimiento, Nro_Documento, Direccion 
FROM clientes
WHERE IDCliente = @IDCliente
END
GO

CREATE PROCEDURE GetClientesPorNroDocumento
	@Nro_Documento varchar(50)
AS
BEGIN
-- SET NOCOUNT ON added to prevent extra result sets from
-- interfering with SELECT statements.
SET NOCOUNT ON;

SELECT IDCliente, Nombre, Apellido, Fecha_Nacimiento, Nro_Documento, Direccion 
FROM clientes
WHERE Nro_Documento = @Nro_Documento
END
GO

CREATE PROCEDURE DeleteClientes
	@IDCliente int
AS
BEGIN
DELETE FROM clientes WHERE IDCliente=@IDCliente
END
GO

-- PRODUCTOS

CREATE PROCEDURE GetProductos
AS
BEGIN
-- SET NOCOUNT ON added to prevent extra result sets from
-- interfering with SELECT statements.
SET NOCOUNT ON;

SELECT IDProducto, Nombre, Descripcion, Precio, Stock FROM productos
END
GO

CREATE PROCEDURE UpdateProductos
	@Nombre varchar(50),
	@Descripcion varchar(50),
	@Precio money,
	@Stock int,
	@IDProducto int out
AS
BEGIN
UPDATE productos
SET Nombre=@Nombre,
	Descripcion=@Descripcion,
	Precio=@Precio,
	Stock=@Stock
WHERE IDProducto=@IDProducto
END
GO

CREATE PROCEDURE InsertProductos
	@Nombre varchar(50),
	@Descripcion varchar(50),
	@Precio money,
	@Stock int
AS
BEGIN
INSERT INTO productos
(Nombre, Descripcion, Precio, Stock) 
VALUES (@Nombre, @Descripcion, @Precio, @Stock)
END
GO

CREATE PROCEDURE GetProductosPorNombre
	@Nombre varchar(50)
AS
BEGIN
-- SET NOCOUNT ON added to prevent extra result sets from
-- interfering with SELECT statements.
SET NOCOUNT ON;

SELECT IDProducto, Nombre, Descripcion, Precio, Stock 
FROM productos 
WHERE Nombre = @Nombre
END
GO

CREATE PROCEDURE GetProductosPorID
	@IDProducto int
AS
BEGIN
-- SET NOCOUNT ON added to prevent extra result sets from
-- interfering with SELECT statements.
SET NOCOUNT ON;

SELECT IDProducto, Nombre, Descripcion, Precio, Stock 
FROM productos 
WHERE IDProducto = @IDProducto
END
GO

CREATE PROCEDURE DeleteProductos
	@IDProducto int
AS
BEGIN
DELETE FROM productos WHERE IDProducto=@IDProducto
END
GO



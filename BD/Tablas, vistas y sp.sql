--CREATE DATABASE Facturacion_Farmacia

--USE Facturacion_Farmacia

CREATE TABLE USUARIOS
(
NOMBRE VARCHAR(50) NOT NULL,
CONTRASENA VARCHAR(50) NOT NULL
)

CREATE TABLE CATEGORIAS
(
ID_CATEGORIA INT PRIMARY KEY,
DES_CATEGORIA NVARCHAR(50)
)

CREATE TABLE LABORATORIOS
(
ID_LABORATORIO INT PRIMARY KEY,
NOMBRE NVARCHAR(50),
DIRECCION NVARCHAR(100),
TELEFONO NVARCHAR(8),
FAX NVARCHAR(8),
CONTACTO NVARCHAR(50)
)

CREATE TABLE PROVEEDORES
(
ID_PROVEEDOR INT PRIMARY KEY,
NOMBRE_PROVEEDOR NVARCHAR(50),
DIRECCION NVARCHAR(50),
TELEFONO NVARCHAR(8),
FAX NVARCHAR(8),
WEB NVARCHAR(50),
CONTACTO NVARCHAR(50)
)

CREATE TABLE CLIENTES
(
ID_CLIENTE INT PRIMARY KEY,
NOMBRES_APELLIDOS NVARCHAR(150),
CEDULA NVARCHAR(14),
TELEFONO NVARCHAR(8)
)

CREATE TABLE PRODUCTOS
(
ID_PRODUCTO INT PRIMARY KEY,
DES_PRODUCTO NVARCHAR(50),
ID_CATEGORIA INT CONSTRAINT FK_CATEGORIAS_PRODUCTOS FOREIGN KEY REFERENCES dbo.CATEGORIAS(ID_CATEGORIA) ON UPDATE CASCADE ON DELETE CASCADE,
ID_PROVEEDOR INT CONSTRAINT FK_PROVEEDORES_PRODUCTOS FOREIGN KEY REFERENCES dbo.PROVEEDORES(ID_PROVEEDOR) ON UPDATE CASCADE ON DELETE CASCADE,
CANT_X_PRESENTACION NVARCHAR(50),
PRECIO_UNIT MONEY,
UNIDADES_INV INT,
DESCONTINUADO BIT
)

 CREATE TABLE TEMPORALDGV
 (
 ID_PRODUCTO INT ,
 DES_PRODUCTO NVARCHAR(50),
 PRECIO_UNIT FLOAT,
 CANTIDAD INT
 )

 CREATE TABLE CAT_TIPO_VENTA
 (
 ID_TIPO_VENTA INT PRIMARY KEY,
 DESCRIPCION NVARCHAR(MAX) NOT NULL
 )

 CREATE TABLE FACTURAS
 (
 ID_FACTURA INT PRIMARY KEY,
 NO_FACTURA NVARCHAR(MAX),
 FECHA_FACTURA NVARCHAR(MAX),
 HORA_FACTURA NVARCHAR(MAX),
 ID_TIPO_VENTA INT CONSTRAINT FK_CAT_TIPO_VENTA_FACTURAS FOREIGN KEY REFERENCES dbo.CAT_TIPO_VENTA(ID_TIPO_VENTA) ON UPDATE CASCADE ON DELETE CASCADE,
 ID_CLIENTE INT CONSTRAINT FK_CLIENTES_FACTURAS FOREIGN KEY REFERENCES dbo.CLIENTES(ID_CLIENTE) ON UPDATE CASCADE ON DELETE CASCADE,
 ID_EMPLEADO INT NOT NULL,
 SUB_TOTAL FLOAT NOT NULL,
 IVA FLOAT NOT NULL,
 TOTAL FLOAT NOT NULL
 )


 CREATE TABLE DETALLEFACTURA
 (
 ID_DETALLE INT PRIMARY KEY,
 ID_FACTURA INT CONSTRAINT FK_FACTURA_DETALLEFACTURA FOREIGN KEY REFERENCES dbo.FACTURAS(ID_FACTURA) ON UPDATE CASCADE ON DELETE CASCADE,
 ID_PRODUCTO INT CONSTRAINT FK_PRODUCTOS_DETALLEFACTURA FOREIGN KEY REFERENCES dbo.PRODUCTOS(ID_PRODUCTO) ON UPDATE CASCADE ON DELETE CASCADE,
 PRECIO_UNIT FLOAT NOT NULL,
 CANTIDAD INT NOT NULL,
 )
 
 CREATE TABLE COMPRAPRODUCTOS
 (
 ID_COMPRA INT PRIMARY KEY,
 FECHA_COMPRA DATETIME,
 ID_PROVEEDOR INT CONSTRAINT FK_PROVEEDORES_COMPRAPRODUCTOS FOREIGN KEY REFERENCES dbo.PROVEEDORES(ID_PROVEEDOR),
 ID_PRODUCTO INT CONSTRAINT FK_PRODUCTOS_COMPRAPRODUCTOS FOREIGN KEY REFERENCES dbo.PRODUCTOS(ID_PRODUCTO),
 UNIDAD_MED NVARCHAR(50),
 PRECIO_UNIT MONEY,
 CANTIDAD INT
 )

 CREATE VIEW VISTA_DETALLEFACTURA AS

SELECT DF.ID_DETALLE, DF.ID_FACTURA, P.DES_PRODUCTO,DF.PRECIO_UNIT, DF.CANTIDAD 
FROM dbo.DETALLEFACTURA DF 
INNER JOIN dbo.PRODUCTOS  P
ON DF.ID_PRODUCTO = P.ID_PRODUCTO

CREATE VIEW VISTA_FACTURAS AS

SELECT F.ID_FACTURA, F.NO_FACTURA, F.FECHA_FACTURA,F.HORA_FACTURA, F.ID_TIPO_VENTA, CTP.DESCRIPCION,F.ID_CLIENTE, C.NOMBRES_APELLIDOS, C.CEDULA,C.TELEFONO, F.ID_EMPLEADO, F.SUB_TOTAL, F.IVA,F.TOTAL
FROM dbo.FACTURAS F
INNER JOIN dbo.CLIENTES C
ON F.ID_CLIENTE = C.ID_CLIENTE 
INNER JOIN dbo.CAT_TIPO_VENTA CTP
ON F.ID_TIPO_VENTA = CTP.ID_TIPO_VENTA


GO
CREATE PROCEDURE SP_ACTUALIZAR_CLIENTE
@V_IDCLIENTE AS INT,
@V_NOMBRES_APELLIDOS AS NVARCHAR(150),
@V_CEDULA AS NVARCHAR(14),
@V_TELEFONO AS NVARCHAR(8)
AS
BEGIN
UPDATE dbo.CLIENTES
SET ID_CLIENTE = @V_IDCLIENTE,
NOMBRES_APELLIDOS = @V_NOMBRES_APELLIDOS,
CEDULA=@V_CEDULA,
TELEFONO = @V_TELEFONO
WHERE ID_CLIENTE = @V_IDCLIENTE
END

GO
CREATE PROCEDURE SP_ACTUALIZAR_CLIENTES
@V_IDCLIENTE AS INT,
@V_NOMBRES_APELLIDOS AS NVARCHAR(150),
@V_TELEFONO AS NVARCHAR(8)
AS
BEGIN
UPDATE dbo.CLIENTES
SET ID_CLIENTE = @V_IDCLIENTE,
NOMBRES_APELLIDOS = @V_NOMBRES_APELLIDOS,
TELEFONO = @V_TELEFONO
WHERE ID_CLIENTE = @V_IDCLIENTE
END

GO
CREATE PROCEDURE SP_ACTUALIZAR_CLIENTES1
@V_IDCLIENTE AS INT,
@V_NOMBRES_APELLIDOS AS NVARCHAR(150),
@V_CEDULA AS NVARCHAR(14),
@V_TELEFONO AS NVARCHAR(8)
AS
BEGIN
UPDATE dbo.CLIENTES
SET ID_CLIENTE = @V_IDCLIENTE,
NOMBRES_APELLIDOS = @V_NOMBRES_APELLIDOS,
CEDULA=@V_CEDULA,
TELEFONO = @V_TELEFONO
WHERE ID_CLIENTE = @V_IDCLIENTE
END
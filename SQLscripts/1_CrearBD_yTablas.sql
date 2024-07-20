CREATE DATABASE BDVentas
go
-- Definición de tipos
USE BDVentas
GO

-- Definir tipos personalizados para mejorar la consistencia
CREATE TYPE dbo.ID FROM VARCHAR(10);
CREATE TYPE dbo.Descripcion FROM VARCHAR(255);
CREATE TYPE dbo.Estado FROM BIT;
CREATE TYPE dbo.Documento FROM VARCHAR(20);
CREATE TYPE dbo.Telefono FROM VARCHAR(20);
CREATE TYPE dbo.Dinero FROM DECIMAL(10, 2);
CREATE TYPE dbo.FechaHora FROM DATETIME2(0);

GO

-- Create ROL table
CREATE TABLE ROL (
    IdRol dbo.ID PRIMARY KEY,
    Descripcion dbo.Descripcion NOT NULL,
    FechaRegistro dbo.FechaHora NOT NULL DEFAULT GETDATE()
)
GO

-- Create PERMISO table
CREATE TABLE PERMISO (
    IdPermiso dbo.ID PRIMARY KEY,
    IdRol dbo.ID NOT NULL,
    NombreMenu dbo.Descripcion NOT NULL,
    FechaRegistro dbo.FechaHora NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (IdRol) REFERENCES ROL(IdRol)
)
GO

-- Create EMPLEADO table
CREATE TABLE EMPLEADO (
    IdEmpleado dbo.ID PRIMARY KEY,
    Documento dbo.Documento NOT NULL UNIQUE,
    NombreCompleto dbo.Descripcion NOT NULL,
    Correo VARCHAR(100) NOT NULL UNIQUE,
    Clave VARCHAR(100) NOT NULL,
    IdRol dbo.ID NOT NULL,
    Estado dbo.Estado NOT NULL DEFAULT 1,
    FechaRegistro dbo.FechaHora NOT NULL DEFAULT GETDATE(),
    Imagen VARBINARY(MAX),
    FOREIGN KEY (IdRol) REFERENCES ROL(IdRol)
)
GO

-- Create CATEGORIA table
CREATE TABLE CATEGORIA (
    IdCategoria dbo.ID PRIMARY KEY,
    Descripcion dbo.Descripcion NOT NULL,
    Estado dbo.Estado NOT NULL DEFAULT 1,
    FechaRegistro dbo.FechaHora NOT NULL DEFAULT GETDATE()
)
GO

-- Create PRODUCTO table
CREATE TABLE PRODUCTO (
    IdProducto dbo.ID PRIMARY KEY,
    Codigo VARCHAR(50) NOT NULL UNIQUE,
    Nombre dbo.Descripcion NOT NULL,
    Descripcion dbo.Descripcion,
    IdCategoria dbo.ID NOT NULL,
    Stock INT NOT NULL DEFAULT 0,
    PrecioCompra dbo.Dinero NOT NULL,
    PrecioVenta dbo.Dinero NOT NULL,
    Estado dbo.Estado NOT NULL DEFAULT 1,
    FechaRegistro dbo.FechaHora NOT NULL DEFAULT GETDATE(),
    Imagen VARBINARY(MAX),
    FOREIGN KEY (IdCategoria) REFERENCES CATEGORIA(IdCategoria)
)
GO

-- Create CLIENTE table
CREATE TABLE CLIENTE (
    IdCliente dbo.ID PRIMARY KEY,
    Documento dbo.Documento NOT NULL UNIQUE,
    NombreCompleto dbo.Descripcion NOT NULL,
    Correo VARCHAR(100),
    Telefono dbo.Telefono,
    Estado dbo.Estado NOT NULL DEFAULT 1,
    FechaRegistro dbo.FechaHora NOT NULL DEFAULT GETDATE()
)
GO

-- Create PROVEEDOR table
CREATE TABLE PROVEEDOR (
    IdProveedor dbo.ID PRIMARY KEY,
    Documento dbo.Documento NOT NULL UNIQUE,
    RazonSocial dbo.Descripcion NOT NULL,
    Correo VARCHAR(100),
    Telefono dbo.Telefono,
    Estado dbo.Estado NOT NULL DEFAULT 1,
    FechaRegistro dbo.FechaHora NOT NULL DEFAULT GETDATE()
)
GO

-- Create COMPRA table
CREATE TABLE COMPRA (
    IdCompra dbo.ID PRIMARY KEY,
    IdEmpleado dbo.ID NOT NULL,
    IdProveedor dbo.ID NOT NULL,
    TipoDocumento VARCHAR(50) NOT NULL,
    NumeroDocumento VARCHAR(50) NOT NULL,
    MontoTotal dbo.Dinero NOT NULL,
    FechaRegistro dbo.FechaHora NOT NULL DEFAULT GETDATE(),
	Estado dbo.Estado NOT NULL DEFAULT 1,
    FOREIGN KEY (IdEmpleado) REFERENCES EMPLEADO(IdEmpleado),
    FOREIGN KEY (IdProveedor) REFERENCES PROVEEDOR(IdProveedor)
)
GO

-- Create DETALLE_COMPRA table
CREATE TABLE DETALLE_COMPRA (
    IdDetalleCompra dbo.ID PRIMARY KEY,
    IdCompra dbo.ID NOT NULL,
    IdProducto dbo.ID NOT NULL,
    PrecioCompra dbo.Dinero NOT NULL,
    PrecioVenta dbo.Dinero NOT NULL,
    Cantidad INT NOT NULL,
    MontoTotal dbo.Dinero NOT NULL,
    FechaRegistro dbo.FechaHora NOT NULL DEFAULT GETDATE(),
	Estado dbo.Estado NOT NULL DEFAULT 1,
    FOREIGN KEY (IdCompra) REFERENCES COMPRA(IdCompra),
    FOREIGN KEY (IdProducto) REFERENCES PRODUCTO(IdProducto)
)
GO

-- Create VENTA table
CREATE TABLE VENTA (
    IdVenta dbo.ID PRIMARY KEY,
    IdEmpleado dbo.ID NOT NULL,
    TipoDocumento VARCHAR(50) NOT NULL,
    NumeroDocumento VARCHAR(50) NOT NULL,
    DocumentoCliente dbo.Documento NOT NULL,
    NombreCliente dbo.Descripcion NOT NULL,
    MontoPago dbo.Dinero NOT NULL,
    MontoCambio dbo.Dinero NOT NULL,
    MontoTotal dbo.Dinero NOT NULL,
    FechaRegistro dbo.FechaHora NOT NULL DEFAULT GETDATE(),
	Estado dbo.Estado NOT NULL DEFAULT 1,
    FOREIGN KEY (IdEmpleado) REFERENCES EMPLEADO(IdEmpleado)
)
GO

-- Create DETALLE_VENTA table
CREATE TABLE DETALLE_VENTA (
    IdDetalleVenta dbo.ID PRIMARY KEY,
    IdVenta dbo.ID NOT NULL,
    IdProducto dbo.ID NOT NULL,
    PrecioUnitario dbo.Dinero NOT NULL,
    Cantidad INT NOT NULL,
    SubTotal dbo.Dinero NOT NULL,
    FechaRegistro dbo.FechaHora NOT NULL DEFAULT GETDATE(),
	Estado dbo.Estado NOT NULL DEFAULT 1,
    FOREIGN KEY (IdVenta) REFERENCES VENTA(IdVenta),
    FOREIGN KEY (IdProducto) REFERENCES PRODUCTO(IdProducto)
)
GO
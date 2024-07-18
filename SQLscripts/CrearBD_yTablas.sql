create database BDVentas
go
use BDVentas
go
-- Create ROL table
CREATE TABLE ROL (
    IdRol INT PRIMARY KEY NOT NULL,
    Descripcion VARCHAR(255),
    FechaRegistro DATE
)
go
-- Create PERMISO table
CREATE TABLE PERMISO (
    IdPermiso INT PRIMARY KEY NOT NULL,
    IdRol INT NOT NULL,
    NombreMenu VARCHAR(255),
    FechaRegistro DATE,
    FOREIGN KEY (IdRol) REFERENCES ROL(IdRol)
)
go
-- Create Empleado table
CREATE TABLE EMPLEADO (
    IdEmpleado INT PRIMARY KEY NOT NULL,
    Documento VARCHAR(20),
    NombreCompleto VARCHAR(255),
    Correo VARCHAR(255),
    Clave VARCHAR(255),
    IdRol INT NOT NULL,
    Estado VARCHAR(20),
    FechaRegistro DATE,
	Imagen IMAGE,
    FOREIGN KEY (IdRol) REFERENCES ROL(IdRol)
)
go
-- Create CATEGORIA table
CREATE TABLE CATEGORIA (
    IdCategoria INT PRIMARY KEY NOT NULL,
    Descripcion VARCHAR(255),
    Estado VARCHAR(20),
    FechaRegistro DATE
)
go
-- Create PRODUCTO table
CREATE TABLE PRODUCTO (
    IdProducto INT PRIMARY KEY NOT NULL,
    Codigo VARCHAR(50),
    Nombre VARCHAR(255),
    Descripcion VARCHAR(255),
    IdCategoria INT NOT NULL,
    Stock INT,
    PrecioCompra DECIMAL(10, 2),
    PrecioVenta DECIMAL(10, 2),
    Estado VARCHAR(20),
    FechaRegistro DATE,
	Imagen IMAGE,
    FOREIGN KEY (IdCategoria) REFERENCES CATEGORIA(IdCategoria)
)
go
-- Create CLIENTE table
CREATE TABLE CLIENTE (
    IdCliente INT PRIMARY KEY NOT NULL,
    Documento VARCHAR(20),
    NombreCompleto VARCHAR(255),
    Correo VARCHAR(255),
    Telefono VARCHAR(20),
    Estado VARCHAR(20),
    FechaRegistro DATE
)
go
-- Create PROVEEDOR table
CREATE TABLE PROVEEDOR (
    IdProveedor INT PRIMARY KEY NOT NULL,
    Documento VARCHAR(20),
    RazonSocial VARCHAR(255),
    Correo VARCHAR(255),
    Telefono VARCHAR(20),
    Estado VARCHAR(20),
    FechaRegistro DATE
)
go
-- Create COMPRA table
CREATE TABLE COMPRA (
    IdCompra INT PRIMARY KEY NOT NULL,
    IdEmpleado INT NOT NULL,
    IdProveedor INT NOT NULL,
    TipoDocumento VARCHAR(50),
    NumeroDocumento VARCHAR(50),
    MontoTotal DECIMAL(10, 2),
    FechaRegistro DATE,
    FOREIGN KEY (IdEmpleado) REFERENCES Empleado(IdEmpleado),
    FOREIGN KEY (IdProveedor) REFERENCES PROVEEDOR(IdProveedor)
)
go
-- Create DETALLE_COMPRA table
CREATE TABLE DETALLE_COMPRA (
    IdDetalleCompra INT PRIMARY KEY NOT NULL,
    IdCompra INT NOT NULL,
    IdProducto INT NOT NULL,
    PrecioCompra DECIMAL(10, 2),
    PrecioVenta DECIMAL(10, 2),
    Cantidad INT,
    MontoTotal DECIMAL(10, 2),
    FechaRegistro DATE,
    FOREIGN KEY (IdCompra) REFERENCES COMPRA(IdCompra),
    FOREIGN KEY (IdProducto) REFERENCES PRODUCTO(IdProducto)
)
go
-- Create VENTA table
CREATE TABLE VENTA (
    IdVenta INT PRIMARY KEY NOT NULL,
	IdEmpleado INT NOT NULL,
    TipoDocumento VARCHAR(50),
    NumeroDocumento VARCHAR(50),
    DocumentoCliente VARCHAR(20),
    NombreCliente VARCHAR(255),
    MontoPago DECIMAL(10, 2),
    MontoCambio DECIMAL(10, 2),
    MontoTotal DECIMAL(10, 2),
    FechaRegistro DATE
	FOREIGN KEY (IdEmpleado) REFERENCES EMPLEADO(IdEmpleado)
)
go
-- Create DETALLE_VENTA table
CREATE TABLE DETALLE_VENTA (
    IdDetalleVenta INT PRIMARY KEY NOT NULL,
    IdVenta INT NOT NULL,
    IdProducto INT NOT NULL,
    PrecioUnitario DECIMAL(10, 2),
    Cantidad INT,
    SubTotal DECIMAL(10, 2),
    FechaRegistro DATE,
    FOREIGN KEY (IdVenta) REFERENCES VENTA(IdVenta),
    FOREIGN KEY (IdProducto) REFERENCES PRODUCTO(IdProducto)
)
go
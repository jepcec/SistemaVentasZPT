USE BDVentas
GO

-- *****************************************************
-- DATOS ROL
-- *****************************************************
EXEC uspInsertarRol @Descripcion = 'Administrador'
EXEC uspInsertarRol @Descripcion = 'Vendedor'
EXEC uspInsertarRol @Descripcion = 'Almacenero'

-- *****************************************************
-- DATOS PERMISO
-- *****************************************************
EXEC uspInsertarPermiso @IdRol = 'R0001', @NombreMenu = 'Todos'
EXEC uspInsertarPermiso @IdRol = 'R0002', @NombreMenu = 'Ventas'

-- *****************************************************
-- DATOS EMPLEADO
-- *****************************************************
EXEC uspInsertarEmpleado 
    @Documento = '12345678', 
    @NombreCompleto = 'Juan Pérez', 
    @Correo = 'juan@example.com', 
    @Clave = 'password123', 
    @IdRol = 'R0001'

EXEC uspInsertarEmpleado 
    @Documento = '87654321', 
    @NombreCompleto = 'María García', 
    @Correo = 'maria@example.com', 
    @Clave = 'password456', 
    @IdRol = 'R0002'

EXEC uspInsertarEmpleado 
    @Documento = '11223344', 
    @NombreCompleto = 'Carlos López', 
    @Correo = 'carlos@example.com', 
    @Clave = 'password789', 
    @IdRol = 'R0002'

-- *****************************************************
-- DATOS CATEGORIA
-- *****************************************************
EXEC uspInsertarCategoria @Descripcion = 'Electrónicos'
EXEC uspInsertarCategoria @Descripcion = 'Muebles'
EXEC uspInsertarCategoria @Descripcion = 'Ropa'
EXEC uspInsertarCategoria @Descripcion = 'Alimentos'

-- *****************************************************
-- DATOS PRODUCTO
-- *****************************************************
EXEC uspInsertarProducto 
    @Codigo = 'XY-1JKFDSAKJ', -- DIFERENTE AL IdProducto
    @Nombre = 'Smartphone X', 
    @Descripcion = 'Teléfono inteligente de última generación', 
    @IdCategoria = 'CT0001', 
    @Stock = 50, 
    @PrecioCompra = 300.00, 
    @PrecioVenta = 450.00

EXEC uspInsertarProducto 
    @Codigo = 'hjhkjhkj', 
    @Nombre = 'Silla Ergonómica', 
    @Descripcion = 'Silla de oficina ergonómica', 
    @IdCategoria = 'CT0002', 
    @Stock = 30, 
    @PrecioCompra = 80.00, 
    @PrecioVenta = 150.00

EXEC uspInsertarProducto 
    @Codigo = 'kjjlkjkljlkj', 
    @Nombre = 'Camiseta Algodón', 
    @Descripcion = 'Camiseta 100% algodón', 
    @IdCategoria = 'CT0003', 
    @Stock = 100, 
    @PrecioCompra = 5.00, 
    @PrecioVenta = 15.00

EXEC uspInsertarProducto 
    @Codigo = 'kjlkjkljlkj', 
    @Nombre = 'Arroz Integral', 
    @Descripcion = 'Arroz integral de 1kg', 
    @IdCategoria = 'CT0004', 
    @Stock = 200, 
    @PrecioCompra = 2.00, 
    @PrecioVenta = 4.00

-- *****************************************************
-- DATOS CLIENTE
-- *****************************************************
EXEC uspInsertarCliente 
    @Documento = '11111111', 
    @NombreCompleto = 'Ana Martínez', 
    @Correo = 'ana@email.com', 
    @Telefono = '999888777'

EXEC uspInsertarCliente 
    @Documento = '22222222', 
    @NombreCompleto = 'Pedro Rodríguez', 
    @Correo = 'pedro@email.com', 
    @Telefono = '888777666'

EXEC uspInsertarCliente 
    @Documento = '33333333', 
    @NombreCompleto = 'Lucía Sánchez', 
    @Correo = 'lucia@email.com', 
    @Telefono = '777666555'

-- *****************************************************
-- DATOS PROVEEDOR
-- *****************************************************
EXEC uspInsertarProveedor 
    @Documento = '20123456789',
    @RazonSocial = 'Distribuidora TecnoPartes S.A.',
    @Correo = 'ventas@tecnopartes.com',
    @Telefono = '(01) 555-1234'
-- Insertar Proveedor 2
EXEC uspInsertarProveedor 
    @Documento = '20987654321',
    @RazonSocial = 'Suministros Oficina Pro E.I.R.L.',
    @Correo = 'contacto@oficinapro.com',
    @Telefono = '(01) 555-5678'
-- Insertar Proveedor 3
EXEC uspInsertarProveedor 
    @Documento = '20456789012',
    @RazonSocial = 'Insumos Químicos del Perú S.A.C.',
    @Correo = 'ventas@insumosquimicos.pe',
    @Telefono = '(01) 555-9012'
-- Insertar Proveedor 4
EXEC uspInsertarProveedor 
    @Documento = '20345678901',
    @RazonSocial = 'Maquinarias Industriales del Sur S.R.L.',
    @Correo = 'info@maquinariassur.com',
    @Telefono = '(01) 555-3456'

-- *****************************************************
-- DATOS COMPRA
-- *****************************************************
EXEC uspInsertarCompra 
    @IdEmpleado = 'E0002', 
    @IdProveedor = 'PRV0001', 
    @TipoDocumento = 'Factura', 
    @NumeroDocumento = 'F001-001', 
    @MontoTotal = 20000.00

EXEC uspInsertarCompra 
    @IdEmpleado = 'E0003', 
    @IdProveedor = 'PRV0002', 
    @TipoDocumento = 'Factura', 
    @NumeroDocumento = 'F001-002', 
    @MontoTotal = 5000.00

-- *****************************************************
-- DATOS DETALLE_COMPRA
-- *****************************************************
EXEC uspInsertarDetalleCompra 
    @IdCompra = 'CM0001', 
    @IdProducto = 'PRD0001', 
    @PrecioCompra = 300.00, 
    @PrecioVenta = 450.00, 
    @Cantidad = 50, 
    @MontoTotal = 15000.00

EXEC uspInsertarDetalleCompra 
    @IdCompra = 'CM0001', 
    @IdProducto = 'PRD0002', 
    @PrecioCompra = 80.00, 
    @PrecioVenta = 150.00, 
    @Cantidad = 30, 
    @MontoTotal = 2400.00

EXEC uspInsertarDetalleCompra 
    @IdCompra = 'CM0002', 
    @IdProducto = 'PRD0003', 
    @PrecioCompra = 5.00, 
    @PrecioVenta = 15.00, 
    @Cantidad = 100, 
    @MontoTotal = 500.00

-- *****************************************************
-- DATOS VENTA
-- *****************************************************
EXEC uspInsertarVenta 
    @IdEmpleado = 'E0002', 
    @TipoDocumento = 'Boleta', 
    @NumeroDocumento = 'B001-001', 
    @DocumentoCliente = '11111111', 
    @NombreCliente = 'Ana Martínez', 
    @MontoPago = 500.00, 
    @MontoCambio = 50.00, 
    @MontoTotal = 450.00

EXEC uspInsertarVenta 
    @IdEmpleado = 'E0002', 
    @TipoDocumento = 'Factura', 
    @NumeroDocumento = 'F001-001', 
    @DocumentoCliente = '22222222', 
    @NombreCliente = 'Pedro Rodríguez', 
    @MontoPago = 200.00, 
    @MontoCambio = 20.00, 
    @MontoTotal = 180.00

-- *****************************************************
-- DATOS DETALLE_VENTA
-- *****************************************************
EXEC uspInsertarDetalleVenta 
    @IdVenta = 'V0001', 
    @IdProducto = 'PRD0001', 
    @PrecioUnitario = 450.00, 
    @Cantidad = 1, 
    @SubTotal = 450.00

EXEC uspInsertarDetalleVenta 
    @IdVenta = 'V0002', 
    @IdProducto = 'PRD0003', 
    @PrecioUnitario = 15.00, 
    @Cantidad = 12, 
    @SubTotal = 180.00
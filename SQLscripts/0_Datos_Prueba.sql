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
EXEC uspInsertarPermiso @IdRol = 'R0003', @NombreMenu = 'Almacén'

-- *****************************************************
-- DATOS EMPLEADO
-- *****************************************************
EXEC uspInsertarEmpleado 
    @Documento = '45678912', 
    @NombreCompleto = 'Carlos Rodríguez', 
    @Correo = 'carlos.rodriguez@tecnostore.com', 
    @Clave = 'Admin2024!', 
    @IdRol = 'R0001'

EXEC uspInsertarEmpleado 
    @Documento = '78912345', 
    @NombreCompleto = 'Ana Silva', 
    @Correo = 'ana.silva@tecnostore.com', 
    @Clave = 'Ventas2024!', 
    @IdRol = 'R0002'

EXEC uspInsertarEmpleado 
    @Documento = '56789123', 
    @NombreCompleto = 'Luis Gómez', 
    @Correo = 'luis.gomez@tecnostore.com', 
    @Clave = 'Almacen2024!', 
    @IdRol = 'R0003'

-- *****************************************************
-- DATOS CATEGORIA
-- *****************************************************
EXEC uspInsertarCategoria @Descripcion = 'Laptops'
EXEC uspInsertarCategoria @Descripcion = 'Desktops'
EXEC uspInsertarCategoria @Descripcion = 'Periféricos'
EXEC uspInsertarCategoria @Descripcion = 'Componentes'
EXEC uspInsertarCategoria @Descripcion = 'Almacenamiento'

-- *****************************************************
-- DATOS PRODUCTO (15 productos con stock inicial 0)
-- *****************************************************
EXEC uspInsertarProducto 
    @Codigo = 'LAP-001', 
    @Nombre = 'Laptop Lenovo ThinkPad X1', 
    @Descripcion = 'Laptop empresarial de 14"', 
    @IdCategoria = 'CT0001', 
    @Stock = 0, 
    @PrecioCompra = 1200.00, 
    @PrecioVenta = 1500.00

EXEC uspInsertarProducto 
    @Codigo = 'LAP-002', 
    @Nombre = 'Laptop HP Spectre x360', 
    @Descripcion = 'Laptop convertible de 13"', 
    @IdCategoria = 'CT0001', 
    @Stock = 0, 
    @PrecioCompra = 1000.00, 
    @PrecioVenta = 1300.00

EXEC uspInsertarProducto 
    @Codigo = 'DSK-001', 
    @Nombre = 'Desktop Dell XPS', 
    @Descripcion = 'Desktop de alto rendimiento', 
    @IdCategoria = 'CT0002', 
    @Stock = 0, 
    @PrecioCompra = 800.00, 
    @PrecioVenta = 1100.00

EXEC uspInsertarProducto 
    @Codigo = 'DSK-002', 
    @Nombre = 'iMac 27"', 
    @Descripcion = 'All-in-One de Apple', 
    @IdCategoria = 'CT0002', 
    @Stock = 0, 
    @PrecioCompra = 1500.00, 
    @PrecioVenta = 1800.00

EXEC uspInsertarProducto 
    @Codigo = 'PER-001', 
    @Nombre = 'Teclado Mecánico Logitech G915', 
    @Descripcion = 'Teclado gaming inalámbrico', 
    @IdCategoria = 'CT0003', 
    @Stock = 0, 
    @PrecioCompra = 180.00, 
    @PrecioVenta = 230.00

EXEC uspInsertarProducto 
    @Codigo = 'PER-002', 
    @Nombre = 'Mouse Razer DeathAdder V2', 
    @Descripcion = 'Mouse gaming ergonómico', 
    @IdCategoria = 'CT0003', 
    @Stock = 0, 
    @PrecioCompra = 50.00, 
    @PrecioVenta = 70.00

EXEC uspInsertarProducto 
    @Codigo = 'PER-003', 
    @Nombre = 'Monitor ASUS ProArt PA32UCX-PK', 
    @Descripcion = 'Monitor 4K HDR de 32"', 
    @IdCategoria = 'CT0003', 
    @Stock = 0, 
    @PrecioCompra = 4000.00, 
    @PrecioVenta = 5000.00

EXEC uspInsertarProducto 
    @Codigo = 'COM-001', 
    @Nombre = 'Procesador Intel Core i9-11900K', 
    @Descripcion = 'CPU de 11ª generación', 
    @IdCategoria = 'CT0004', 
    @Stock = 0, 
    @PrecioCompra = 450.00, 
    @PrecioVenta = 550.00

EXEC uspInsertarProducto 
    @Codigo = 'COM-002', 
    @Nombre = 'Tarjeta Gráfica NVIDIA RTX 3080', 
    @Descripcion = 'GPU de alta gama', 
    @IdCategoria = 'CT0004', 
    @Stock = 0, 
    @PrecioCompra = 700.00, 
    @PrecioVenta = 900.00

EXEC uspInsertarProducto 
    @Codigo = 'COM-003', 
    @Nombre = 'Placa Base ASUS ROG Maximus XIII', 
    @Descripcion = 'Placa base Z590 ATX', 
    @IdCategoria = 'CT0004', 
    @Stock = 0, 
    @PrecioCompra = 400.00, 
    @PrecioVenta = 500.00

EXEC uspInsertarProducto 
    @Codigo = 'ALM-001', 
    @Nombre = 'SSD Samsung 970 EVO Plus 1TB', 
    @Descripcion = 'SSD NVMe M.2', 
    @IdCategoria = 'CT0005', 
    @Stock = 0, 
    @PrecioCompra = 150.00, 
    @PrecioVenta = 200.00

EXEC uspInsertarProducto 
    @Codigo = 'ALM-002', 
    @Nombre = 'HDD Seagate Barracuda 4TB', 
    @Descripcion = 'Disco duro interno de 3.5"', 
    @IdCategoria = 'CT0005', 
    @Stock = 0, 
    @PrecioCompra = 80.00, 
    @PrecioVenta = 120.00

EXEC uspInsertarProducto 
    @Codigo = 'PER-004', 
    @Nombre = 'Auriculares Sony WH-1000XM4', 
    @Descripcion = 'Auriculares inalámbricos con cancelación de ruido', 
    @IdCategoria = 'CT0003', 
    @Stock = 0, 
    @PrecioCompra = 250.00, 
    @PrecioVenta = 350.00

EXEC uspInsertarProducto 
    @Codigo = 'PER-005', 
    @Nombre = 'Webcam Logitech C920', 
    @Descripcion = 'Cámara web Full HD', 
    @IdCategoria = 'CT0003', 
    @Stock = 0, 
    @PrecioCompra = 60.00, 
    @PrecioVenta = 80.00

EXEC uspInsertarProducto 
    @Codigo = 'COM-004', 
    @Nombre = 'Memoria RAM Corsair Vengeance 32GB', 
    @Descripcion = 'Kit de RAM DDR4 3200MHz', 
    @IdCategoria = 'CT0004', 
    @Stock = 0, 
    @PrecioCompra = 120.00, 
    @PrecioVenta = 160.00

-- *****************************************************
-- DATOS CLIENTE
-- *****************************************************
EXEC uspInsertarCliente 
    @Documento = '09876543', 
    @NombreCompleto = 'María López', 
    @Correo = 'maria.lopez@email.com', 
    @Telefono = '987654321'

EXEC uspInsertarCliente 
    @Documento = '12345678', 
    @NombreCompleto = 'Juan Pérez', 
    @Correo = 'juan.perez@email.com', 
    @Telefono = '912345678'

EXEC uspInsertarCliente 
    @Documento = '87654321', 
    @NombreCompleto = 'Laura García', 
    @Correo = 'laura.garcia@email.com', 
    @Telefono = '923456789'

-- *****************************************************
-- DATOS PROVEEDOR
-- *****************************************************
EXEC uspInsertarProveedor 
    @Documento = '20123456789',
    @RazonSocial = 'TechImport S.A.C.',
    @Correo = 'ventas@techimport.com',
    @Telefono = '(01) 619-1234'

EXEC uspInsertarProveedor 
    @Documento = '20987654321',
    @RazonSocial = 'Componentes del Futuro E.I.R.L.',
    @Correo = 'ventas@componentesdelfuturo.com',
    @Telefono = '(01) 711-5678'

EXEC uspInsertarProveedor 
    @Documento = '20456789012',
    @RazonSocial = 'Global PC Parts S.A.',
    @Correo = 'ventas@globalpcparts.com',
    @Telefono = '(01) 523-9012'

-- *****************************************************
-- DATOS COMPRA
-- *****************************************************
EXEC uspInsertarCompra 
    @IdEmpleado = 'E0003', 
    @IdProveedor = 'PRV0001', 
    @TipoDocumento = 'FACTURA', 
    @NumeroDocumento = 'F001-00001', 
    @MontoTotal = 15000.00

EXEC uspInsertarCompra 
    @IdEmpleado = 'E0003', 
    @IdProveedor = 'PRV0002', 
    @TipoDocumento = 'FACTURA', 
    @NumeroDocumento = 'F001-00002', 
    @MontoTotal = 8000.00

-- *****************************************************
-- DATOS DETALLE_COMPRA
-- *****************************************************
EXEC uspInsertarDetalleCompra 
    @IdCompra = 'CM0001', 
    @IdProducto = 'PRD0001', 
    @PrecioCompra = 1200.00, 
    @PrecioVenta = 1500.00, 
    @Cantidad = 10, 
    @MontoTotal = 12000.00

EXEC uspInsertarDetalleCompra 
    @IdCompra = 'CM0001', 
    @IdProducto = 'PRD0005', 
    @PrecioCompra = 180.00, 
    @PrecioVenta = 230.00, 
    @Cantidad = 20, 
    @MontoTotal = 3600.00

EXEC uspInsertarDetalleCompra 
    @IdCompra = 'CM0002', 
    @IdProducto = 'PRD0008', 
    @PrecioCompra = 450.00, 
    @PrecioVenta = 550.00, 
    @Cantidad = 15, 
    @MontoTotal = 6750.00

EXEC uspInsertarDetalleCompra 
    @IdCompra = 'CM0002', 
    @IdProducto = 'PRD0011', 
    @PrecioCompra = 150.00, 
    @PrecioVenta = 200.00, 
    @Cantidad = 10, 
    @MontoTotal = 1500.00

-- *****************************************************
-- DATOS VENTA
-- *****************************************************
EXEC uspInsertarVenta 
    @IdEmpleado = 'E0002', 
    @TipoDocumento = 'BOLETA',
    @DocumentoCliente = '09876543', 
    @NombreCliente = 'María López', 
    @MontoPago = 1600.00, 
    @MontoCambio = 100.00, 
    @MontoTotal = 1500.00

EXEC uspInsertarVenta 
    @IdEmpleado = 'E0002', 
    @TipoDocumento = 'FACTURA', 
    @DocumentoCliente = '12345678', 
    @NombreCliente = 'Juan Pérez', 
    @MontoPago = 510.00, 
    @MontoCambio = 50.00, 
    @MontoTotal = 460.00

-- *****************************************************
-- DATOS DETALLE_VENTA
-- *****************************************************
EXEC uspInsertarDetalleVenta 
    @IdVenta = 'V0001', 
    @IdProducto = 'PRD0001', 
    @PrecioUnitario = 1500.00, 
    @Cantidad = 1, 
    @SubTotal = 1500.00

EXEC uspInsertarDetalleVenta 
    @IdVenta = 'V0002', 
    @IdProducto = 'PRD0005', 
    @PrecioUnitario = 230.00, 
    @Cantidad = 2, 
    @SubTotal = 460.00

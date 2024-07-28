USE BDVentas
GO

-- *******************************************************************************************
-- PROCEDIMIENTOS PARA CRAAR COMPROBANTES DE VENTA --
-- *******************************************************************************************

-- Listar COMPROBANTES VENTA
CREATE PROCEDURE uspListarComprobanteVenta
AS
BEGIN
    SET NOCOUNT ON;
    SELECT V.IdVenta, V.NumeroDocumento, V.NombreCliente, V.MontoPago, V.MontoCambio, V.MontoTotal, 
			V.FechaRegistro, E.NombreCompleto AS NombreEmpleado
    FROM VENTA V
    INNER JOIN EMPLEADO E ON V.IdEmpleado = E.IdEmpleado AND V.TipoDocumento = 'Boleta' AND V.Estado = 1
    ORDER BY V.IdVenta;
END;
GO

-- Buscar COMPROBANTES VENTA
CREATE PROCEDURE uspBuscarComprobanteVenta
	@documento NVARCHAR(20),
    @campo NVARCHAR(50),
    @contenido NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @SQL NVARCHAR(MAX);
    
    IF @contenido IS NULL OR @contenido = ''
    BEGIN
        SET @SQL = N'SELECT V.IdVenta, V.NumeroDocumento, V.NombreCliente, V.MontoPago, V.MontoCambio, V.MontoTotal, 
                        V.FechaRegistro, E.NombreCompleto AS NombreEmpleado
                     FROM VENTA V
                     INNER JOIN EMPLEADO E ON V.IdEmpleado = E.IdEmpleado
                     WHERE V.TipoDocumento = @documento AND V.Estado = 1';
        EXEC sp_executesql @SQL, N'@documento NVARCHAR(10)', @documento;
    END

    ELSE
    BEGIN
        SET @SQL = N'SELECT V.IdVenta, V.NumeroDocumento, V.NombreCliente, V.MontoPago, V.MontoCambio, V.MontoTotal, 
                        V.FechaRegistro, E.NombreCompleto AS NombreEmpleado
                     FROM VENTA V
                     INNER JOIN EMPLEADO E ON V.IdEmpleado = E.IdEmpleado
                     WHERE V.TipoDocumento = @documento AND V.Estado = 1
                     AND ' + QUOTENAME(@campo) + ' LIKE @contenido + ''%''';
        EXEC sp_executesql @SQL, N'@documento NVARCHAR(10), @contenido NVARCHAR(50)', @documento, @contenido;
    END
END;
GO

-- Listar DETALLES PRODUCTOS VENDIDOS
CREATE PROCEDURE uspListarProductosVendidos
    @IdVenta dbo.ID
AS
BEGIN
    SET NOCOUNT ON;
    SELECT P.Nombre AS NombreProducto, DV.Cantidad, DV.PrecioUnitario, DV.SubTotal AS Importe
    FROM DETALLE_VENTA DV
    INNER JOIN PRODUCTO P ON DV.IdProducto = P.IdProducto
    WHERE DV.IdVenta = @IdVenta
    ORDER BY DV.IdDetalleVenta;
END;
GO

-- Buscar DETALLES PRODUCTOS VENDIDOS
CREATE PROCEDURE uspBuscarProductosVendidos
    @IdVenta dbo.ID,
    @campo NVARCHAR(50),
    @contenido NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @SQL NVARCHAR(MAX);

    IF @contenido IS NULL OR @contenido = ''
    BEGIN
        SET @SQL = N'SELECT P.Nombre AS NombreProducto, DV.Cantidad, DV.PrecioUnitario, DV.SubTotal AS Importe
                     FROM DETALLE_VENTA DV
                     INNER JOIN PRODUCTO P ON DV.IdProducto = P.IdProducto
                     WHERE DV.IdVenta = @IdVenta';
    END

    ELSE
    BEGIN
        -- Determinar el tipo de dato del campo para construir la consulta adecuada
        IF @campo IN ('Cantidad', 'PrecioUnitario', 'SubTotal')
        BEGIN
            SET @SQL = N'SELECT P.Nombre AS NombreProducto, DV.Cantidad, DV.PrecioUnitario, DV.SubTotal AS Importe
                         FROM DETALLE_VENTA DV
                         INNER JOIN PRODUCTO P ON DV.IdProducto = P.IdProducto
                         WHERE DV.IdVenta = @IdVenta AND ' + @campo + ' LIKE CAST(@contenido AS DECIMAL(10, 2)) + ''%''';
        END

        ELSE
        BEGIN
            SET @SQL = N'SELECT P.Nombre AS NombreProducto, DV.Cantidad, DV.PrecioUnitario, DV.SubTotal AS Importe
                         FROM DETALLE_VENTA DV
                         INNER JOIN PRODUCTO P ON DV.IdProducto = P.IdProducto
                         WHERE DV.IdVenta = @IdVenta AND ' + @campo + ' LIKE @contenido + ''%''';
        END
    END

    EXEC sp_executesql @SQL, N'@IdVenta NVARCHAR(10), @contenido NVARCHAR(50)', @IdVenta, @contenido;
END;
GO





-- *******************************************************************************************
-- PROCEDIMIENTOS PARA CRAAR COMPROBANTES DE COMPRA --
-- *******************************************************************************************

-- Listar COMPRA
CREATE PROCEDURE uspListarComprobantesCompras
AS
BEGIN
    SET NOCOUNT ON;
    SELECT C.IdCompra, C.NumeroDocumento, C.MontoTotal, C.FechaRegistro, E.NombreCompleto AS NombreEmpleado, P.RazonSocial AS NombreProveedor
    FROM COMPRA C
    INNER JOIN EMPLEADO E ON C.IdEmpleado = E.IdEmpleado
    INNER JOIN PROVEEDOR P ON C.IdProveedor = P.IdProveedor
	WHERE C.Estado = 1 AND C.TipoDocumento = 'FACTURA'
    ORDER BY C.IdCompra;
END;
GO

-- Buscar COMPROBANTES COMPRA
CREATE PROCEDURE uspBuscarComprobanteCompra
	@documento NVARCHAR(20),
    @campo NVARCHAR(50),
    @contenido NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @SQL NVARCHAR(MAX);
    
    IF @contenido IS NULL OR @contenido = ''
    BEGIN
		SET @SQL = N'SELECT C.IdCompra, C.NumeroDocumento, C.MontoTotal, C.FechaRegistro, E.NombreCompleto AS NombreEmpleado, P.RazonSocial AS NombreProveedor
					 FROM COMPRA C
					 INNER JOIN EMPLEADO E ON C.IdEmpleado = E.IdEmpleado
					 INNER JOIN PROVEEDOR P ON C.IdProveedor = P.IdProveedor
					 WHERE C.Estado = 1 AND C.TipoDocumento = @documento';
        EXEC sp_executesql @SQL, N'@documento NVARCHAR(10)', @documento;
    END

    ELSE
    BEGIN
		SET @SQL = N'SELECT C.IdCompra, C.NumeroDocumento, C.MontoTotal, C.FechaRegistro, E.NombreCompleto AS NombreEmpleado, P.RazonSocial AS NombreProveedor
					 FROM COMPRA C
					 INNER JOIN EMPLEADO E ON C.IdEmpleado = E.IdEmpleado
					 INNER JOIN PROVEEDOR P ON C.IdProveedor = P.IdProveedor
					 WHERE C.Estado = 1 AND C.TipoDocumento = @documento
					 AND ' + QUOTENAME(@campo) + 'LIKE @contenido + ''%''';
        EXEC sp_executesql @SQL, N'@documento NVARCHAR(10), @contenido NVARCHAR(50)', @documento, @contenido;
    END
END;
GO

-- Listar Productos Comprados
CREATE PROCEDURE uspListarProductosComprados
    @IdCompra dbo.ID
AS
BEGIN
    SET NOCOUNT ON;
    SELECT P.Nombre AS NombreProducto, DC.Cantidad, DC.PrecioCompra AS PrecioUnitario, DC.MontoTotal AS Importe
    FROM DETALLE_COMPRA DC
    INNER JOIN PRODUCTO P ON DC.IdProducto = P.IdProducto
    WHERE DC.IdCompra = @IdCompra
    ORDER BY DC.IdDetalleCompra;
END;
GO

-- Buscar DETALLES PRODUCTOS COMPRADOS
CREATE PROCEDURE uspBuscarProductosComprados
    @IdCompra dbo.ID,
    @campo NVARCHAR(50),
    @contenido NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @SQL NVARCHAR(MAX);

    IF @contenido IS NULL OR @contenido = ''
    BEGIN
        SET @SQL = N'SELECT P.Nombre AS NombreProducto, DC.Cantidad, DC.PrecioCompra AS PrecioUnitario, DC.MontoTotal AS Importe
					 FROM DETALLE_COMPRA DC
					 INNER JOIN PRODUCTO P ON DC.IdProducto = P.IdProducto
					 WHERE DC.IdCompra = @IdCompra';
    END

    ELSE
    BEGIN
        -- Determinar el tipo de dato del campo para construir la consulta adecuada
        IF @campo IN ('Cantidad', 'PrecioCompra', 'SubTotal')
        BEGIN
            SET @SQL = N'SELECT P.Nombre AS NombreProducto, DC.Cantidad, DC.PrecioCompra AS PrecioUnitario, DC.MontoTotal AS Importe
						 FROM DETALLE_COMPRA DC
						 INNER JOIN PRODUCTO P ON DC.IdProducto = P.IdProducto
                         WHERE DC.IdCompra = @IdCompra AND ' + @campo + ' LIKE CAST(@contenido AS DECIMAL(10, 2)) + ''%''';
        END

        ELSE
        BEGIN
            SET @SQL = N'SELECT P.Nombre AS NombreProducto, DC.Cantidad, DC.PrecioCompra AS PrecioUnitario, DC.MontoTotal AS Importe
						 FROM DETALLE_COMPRA DC
						 INNER JOIN PRODUCTO P ON DC.IdProducto = P.IdProducto
                         WHERE DC.IdCompra = @IdCompra AND ' + @campo + ' LIKE @contenido + ''%''';
        END
    END

    EXEC sp_executesql @SQL, N'@IdCompra NVARCHAR(10), @contenido NVARCHAR(50)', @IdCompra, @contenido;
END;
GO
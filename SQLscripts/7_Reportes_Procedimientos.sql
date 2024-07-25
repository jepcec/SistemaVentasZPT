USE BDVentas
GO

-- *******************************
-- PROCEDIMIENTOS PARA CRAAR COMPROBANTES DE VENTA --
-- *******************************

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
    SELECT P.Nombre AS NombreProducto, DV.Cantidad, DV.PrecioUnitario, DV.SubTotal
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
        SET @SQL = N'SELECT P.Nombre AS NombreProducto, DV.Cantidad, DV.PrecioUnitario, DV.SubTotal
					 FROM DETALLE_VENTA DV
					 INNER JOIN PRODUCTO P ON DV.IdProducto = P.IdProducto
					 WHERE DV.IdVenta = @IdVenta';
    ELSE
        SET @SQL = N'SELECT P.Nombre AS NombreProducto, DV.Cantidad, DV.PrecioUnitario, DV.SubTotal
					 FROM DETALLE_VENTA DV
					 INNER JOIN PRODUCTO P ON DV.IdProducto = P.IdProducto
                     WHERE DV.IdVenta = @IdVenta AND ' + @campo + ' LIKE @contenido + ''%''';
    EXEC sp_executesql @SQL, N'@IdVenta INT, @contenido NVARCHAR(50)', @IdVenta, @contenido;
END;
GO

--select * from DETALLE_VENTA

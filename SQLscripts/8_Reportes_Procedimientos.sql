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
    BEGIN
        SET @SQL = N'SELECT P.Nombre AS NombreProducto, DV.Cantidad, DV.PrecioUnitario, DV.SubTotal
                     FROM DETALLE_VENTA DV
                     INNER JOIN PRODUCTO P ON DV.IdProducto = P.IdProducto
                     WHERE DV.IdVenta = @IdVenta';
    END

    ELSE
    BEGIN
        -- Determinar el tipo de dato del campo para construir la consulta adecuada
        IF @campo IN ('Cantidad', 'PrecioUnitario', 'SubTotal')
        BEGIN
            SET @SQL = N'SELECT P.Nombre AS NombreProducto, DV.Cantidad, DV.PrecioUnitario, DV.SubTotal
                         FROM DETALLE_VENTA DV
                         INNER JOIN PRODUCTO P ON DV.IdProducto = P.IdProducto
                         WHERE DV.IdVenta = @IdVenta AND ' + @campo + ' LIKE CAST(@contenido AS DECIMAL(10, 2)) + ''%''';
        END

        ELSE
        BEGIN
            SET @SQL = N'SELECT P.Nombre AS NombreProducto, DV.Cantidad, DV.PrecioUnitario, DV.SubTotal
                         FROM DETALLE_VENTA DV
                         INNER JOIN PRODUCTO P ON DV.IdProducto = P.IdProducto
                         WHERE DV.IdVenta = @IdVenta AND ' + @campo + ' LIKE @contenido + ''%''';
        END
    END

    EXEC sp_executesql @SQL, N'@IdVenta NVARCHAR(10), @contenido NVARCHAR(50)', @IdVenta, @contenido;
END;
GO


-- Procedimiento para Actualizar la claveEmpleado
CREATE PROCEDURE uspActualizarClaveEmpleado
    @Correo VARCHAR(100),
    @NuevaClave VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Result TABLE (ResultCode INT, ResultMessage NVARCHAR(200));

    BEGIN TRY
        -- Verifica si el correo existe
        IF EXISTS (SELECT 1 FROM EMPLEADO WHERE Correo = @Correo)
        BEGIN
            -- Actualiza la clave
            UPDATE EMPLEADO
            SET Clave = @NuevaClave
            WHERE Correo = @Correo;

            INSERT INTO @Result VALUES (0, 'Clave actualizada exitosamente.');
        END
        ELSE
        BEGIN
            INSERT INTO @Result VALUES (1, 'Correo no encontrado.');
        END
    END TRY
    BEGIN CATCH
        INSERT INTO @Result VALUES (1, ERROR_MESSAGE());
    END CATCH;

    SELECT * FROM @Result;
END
GO

-- Procedimiento Almacenado para actualizar el estado del empleado
CREATE PROCEDURE uspActualizarEstadoEmpleado
    @IdEmpleado NVARCHAR(20),
    @NuevoEstado BIT
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Result TABLE (ResultCode INT, ResultMessage NVARCHAR(200));

    BEGIN TRY
        -- Verifica si el empleado existe
        IF EXISTS (SELECT 1 FROM EMPLEADO WHERE IdEmpleado = @IdEmpleado)
        BEGIN
            -- Actualiza el estado del empleado
            UPDATE EMPLEADO
            SET Estado = @NuevoEstado
            WHERE IdEmpleado = @IdEmpleado;

            INSERT INTO @Result VALUES (0, 'Estado actualizado exitosamente.');
        END
        ELSE
        BEGIN
            INSERT INTO @Result VALUES (1, 'Empleado no encontrado.');
        END
    END TRY
    BEGIN CATCH
        INSERT INTO @Result VALUES (1, ERROR_MESSAGE());
    END CATCH;

    SELECT * FROM @Result;
END
GO
use BDVentas
go
-- Procedimiento para anular una venta
CREATE PROCEDURE uspAnularVenta
    @IdVenta dbo.ID
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRANSACTION;
    
    BEGIN TRY
        -- Cambiar el estado de la venta a 0 (anulado)
        UPDATE VENTA
        SET Estado = 0
        WHERE IdVenta = @IdVenta;
        
        -- Cambiar el estado de los detalles de la venta a 0 (anulado)
        UPDATE DETALLE_VENTA
        SET Estado = 0
        WHERE IdVenta = @IdVenta;
        
        COMMIT TRANSACTION;
        
        -- El trigger se encargará de actualizar el stock
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO

-- Procedimiento para anular una compra
CREATE PROCEDURE uspAnularCompra
    @IdCompra dbo.ID
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRANSACTION;
    
    BEGIN TRY
        -- Cambiar el estado de la compra a 0 (anulado)
        UPDATE COMPRA
        SET Estado = 0
        WHERE IdCompra = @IdCompra;
        
        -- Cambiar el estado de los detalles de la compra a 0 (anulado)
        UPDATE DETALLE_COMPRA
        SET Estado = 0
        WHERE IdCompra = @IdCompra;
        
        COMMIT TRANSACTION;
        
        -- El trigger se encargará de actualizar el stock
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO

-- Trigger para actualizar el stock después de anular una venta
CREATE TRIGGER trg_AnularVenta_ActualizarStock
ON DETALLE_VENTA
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    
    IF UPDATE(Estado)
    BEGIN
        UPDATE p
        SET p.Stock = p.Stock + dv.Cantidad
        FROM PRODUCTO p
        INNER JOIN inserted i ON p.IdProducto = i.IdProducto
        INNER JOIN DETALLE_VENTA dv ON i.IdDetalleVenta = dv.IdDetalleVenta
        WHERE i.Estado = 0 AND dv.Estado = 0;
    END
END
GO

-- Trigger para actualizar el stock después de anular una compra
CREATE TRIGGER trg_AnularCompra_ActualizarStock
ON DETALLE_COMPRA
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    
    IF UPDATE(Estado)
    BEGIN
        UPDATE p
        SET p.Stock = p.Stock - dc.Cantidad
        FROM PRODUCTO p
        INNER JOIN inserted i ON p.IdProducto = i.IdProducto
        INNER JOIN DETALLE_COMPRA dc ON i.IdDetalleCompra = dc.IdDetalleCompra
        WHERE i.Estado = 0 AND dc.Estado = 0;
    END
END
GO
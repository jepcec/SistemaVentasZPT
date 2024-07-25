use BDVentas
go
-- Trigger para actualizar el stock después de insertar un detalle de venta
CREATE TRIGGER trg_InsertarDetalleVenta_ActualizarStock
ON DETALLE_VENTA
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE p
    SET p.Stock = p.Stock - i.Cantidad
    FROM PRODUCTO p
    INNER JOIN inserted i ON p.IdProducto = i.IdProducto;
END
GO

-- Trigger para actualizar el stock después de insertar un detalle de compra
CREATE TRIGGER trg_InsertarDetalleCompra_ActualizarStock
ON DETALLE_COMPRA
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE p
    SET p.Stock = p.Stock + i.Cantidad
    FROM PRODUCTO p
    INNER JOIN inserted i ON p.IdProducto = i.IdProducto;
END
GO


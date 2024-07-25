USE BDVentas
GO

-- CREAR LOS CONTADORES 
CREATE TABLE CONTADORES (
    Tabla VARCHAR(50) PRIMARY KEY,
	Prefijo VARCHAR(4),
    UltimoNumero INT NOT NULL DEFAULT 0
)
GO
INSERT INTO CONTADORES (Tabla, Prefijo, UltimoNumero) VALUES 
('ROL','R', 0), ('PERMISO','PRS', 0), ('EMPLEADO','E', 0), ('CATEGORIA','CT', 0),
('PRODUCTO','PRD', 0), ('CLIENTE','CL', 0), ('PROVEEDOR','PRV', 0), ('COMPRA','CM', 0),
('DETALLE_COMPRA','DC', 0), ('VENTA','V', 0), ('DETALLE_VENTA','DV', 0)
GO

-- *******************************************************************************************
-- PROCEDIMIENTOS GENERAR C�DIGO --
-- *******************************************************************************************

-- FUNCION PARA OBTENER EL SIGUIENTE ID
CREATE FUNCTION dbo.ObtenerSiguienteID
(
    @Tabla VARCHAR(50)
)
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @UltimoNumero INT
    DECLARE @SiguienteID VARCHAR(10)
	DECLARE @Prefijo VARCHAR(4)
    
    SELECT @UltimoNumero = UltimoNumero, @Prefijo = Prefijo
    FROM CONTADORES
    WHERE Tabla = @Tabla

    SET @UltimoNumero = @UltimoNumero + 1
    SET @SiguienteID = @Prefijo + RIGHT('0000' + CAST(@UltimoNumero AS VARCHAR(4)), 4)
    
    RETURN @SiguienteID
END
GO

-- PROCEDIMIENTO PARA OBTENER EL SIGUIENTE ID
CREATE OR ALTER PROCEDURE uspGenerarCodigo
    @Tabla VARCHAR(50)
AS
BEGIN
	DECLARE @NuevoCodigo VARCHAR(10)
    SET NOCOUNT ON;

    -- Obtener el siguiente ID usando la funci�n
    SET @NuevoCodigo = dbo.ObtenerSiguienteID(@Tabla)

    -- Devolver el c�digo generado
    SELECT @NuevoCodigo AS Codigo
END
GO

-- PROCEDIMIENTO PARA INCREMENTAR CONTADOR
CREATE PROCEDURE IncrementarContador
    @Tabla VARCHAR(50)
AS
BEGIN
    UPDATE CONTADORES
    SET UltimoNumero = UltimoNumero + 1
    WHERE Tabla = @Tabla
END
GO

-- *******************************************************************************************
-- TRIGGERS PARA INCREMENTAR LOS CONTADORES --
-- *******************************************************************************************

-- Trigger para ROL
CREATE TRIGGER TR_ROL_Insert
ON ROL
AFTER INSERT
AS
BEGIN
    EXEC IncrementarContador 'ROL'
END
GO

-- Trigger para PERMISO
CREATE TRIGGER TR_PERMISO_Insert
ON PERMISO
AFTER INSERT
AS
BEGIN
    EXEC IncrementarContador 'PERMISO'
END
GO

-- Trigger para EMPLEADO
CREATE TRIGGER TR_EMPLEADO_Insert
ON EMPLEADO
AFTER INSERT
AS
BEGIN
    EXEC IncrementarContador 'EMPLEADO'
END
GO

-- Trigger para CATEGORIA
CREATE TRIGGER TR_CATEGORIA_Insert
ON CATEGORIA
AFTER INSERT
AS
BEGIN
    EXEC IncrementarContador 'CATEGORIA'
END
GO

-- Trigger para PRODUCTO
CREATE TRIGGER TR_PRODUCTO_Insert
ON PRODUCTO
AFTER INSERT
AS
BEGIN
    EXEC IncrementarContador 'PRODUCTO'
END
GO

-- Trigger para CLIENTE
CREATE TRIGGER TR_CLIENTE_Insert
ON CLIENTE
AFTER INSERT
AS
BEGIN
    EXEC IncrementarContador 'CLIENTE'
END
GO

-- Trigger para PROVEEDOR
CREATE TRIGGER TR_PROVEEDOR_Insert
ON PROVEEDOR
AFTER INSERT
AS
BEGIN
    EXEC IncrementarContador 'PROVEEDOR'
END
GO

-- Trigger para COMPRA
CREATE TRIGGER TR_COMPRA_Insert
ON COMPRA
AFTER INSERT
AS
BEGIN
    EXEC IncrementarContador 'COMPRA';
END
GO

-- Trigger para DETALLE_COMPRA
CREATE TRIGGER TR_DETALLE_COMPRA_Insert
ON DETALLE_COMPRA
AFTER INSERT
AS
BEGIN
    EXEC IncrementarContador 'DETALLE_COMPRA'
END
GO

-- Trigger para VENTA
CREATE TRIGGER TR_VENTA_Insert
ON VENTA
AFTER INSERT
AS
BEGIN
    DECLARE @TipoDocumento VARCHAR(50);
	EXEC IncrementarContador 'VENTA';
    -- Obtener el tipo de documento del registro insertado
    SELECT @TipoDocumento = TipoDocumento
    FROM INSERTED;

    -- Incrementar el contador seg�n el tipo de documento
    IF @TipoDocumento = 'FACTURA'
    BEGIN
        EXEC IncrementarContador 'FACTURA';
    END
    ELSE IF @TipoDocumento = 'BOLETA'
    BEGIN
        EXEC IncrementarContador 'BOLETA';
    END
END
GO

-- Trigger para DETALLE_VENTA
CREATE TRIGGER TR_DETALLE_VENTA_Insert
ON DETALLE_VENTA
AFTER INSERT
AS
BEGIN
    EXEC IncrementarContador 'DETALLE_VENTA'
END
GO

-- *******************************************************************************************
-- PROCEDIMIENTOS GENERAR N�MERO DE COMPROBANTE--
-- *******************************************************************************************

INSERT INTO CONTADORES (Tabla, Prefijo, UltimoNumero) VALUES 
('FACTURA','121', 0), ('BOLETA','001', 0)
GO
-- FUNCION PARA OBTENER EL SIGUIENTE ID
CREATE FUNCTION dbo.ObtenerSiguienteNumeroComprobante
(
    @TipoDocumento VARCHAR(50)
)
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @UltimoNumero INT
    DECLARE @SiguienteID VARCHAR(10)
	DECLARE @Prefijo VARCHAR(4)
    
    SELECT @UltimoNumero = UltimoNumero, @Prefijo = Prefijo
    FROM CONTADORES
    WHERE Tabla = @TipoDocumento

    SET @UltimoNumero = @UltimoNumero + 1
    SET @SiguienteID = @Prefijo + '-' + RIGHT('0000' + CAST(@UltimoNumero AS VARCHAR(4)), 4) + '-' + LEFT(@TipoDocumento, 1)
    
    RETURN @SiguienteID
END
GO

-- PROCEDIMIENTO PARA OBTENER EL SIGUIENTE ID
CREATE OR ALTER PROCEDURE uspGenerarNumeroComprobante
    @TipoDocumento VARCHAR(50)
AS
BEGIN
	DECLARE @NuevoCodigo VARCHAR(10)
    SET NOCOUNT ON;

    -- Obtener el siguiente ID usando la funci�n
    SET @NuevoCodigo = dbo.ObtenerSiguienteID(@TipoDocumento)

    -- Devolver el c�digo generado
    SELECT @NuevoCodigo AS Codigo
END
GO
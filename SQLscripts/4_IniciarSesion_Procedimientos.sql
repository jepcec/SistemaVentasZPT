use BDVentas
go
-- *******************************************************************************************
-- PROCEDIMIENTOS PARA INICIO DE SESIÓN --
-- *******************************************************************************************

-- Procedimiento para verificar usuario
CREATE OR ALTER PROCEDURE uspVerificarUsuario
    @correo VARCHAR(100),  -- Ajustar el tamaño del correo si es necesario
    @contraseña VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @encriptado VARBINARY(128);  -- Ajustar tipo de dato a VARBINARY para HASHBYTES
    SET @encriptado = HASHBYTES('MD5', @contraseña);

    IF EXISTS (
        SELECT * 
        FROM EMPLEADO 
        WHERE Correo = @correo
          AND Clave = @encriptado
          AND Estado = 1  -- Verificar que el estado del empleado sea 1 (habilitado)
    )
    BEGIN
        SELECT codError = 0, mensaje = 'El usuario sí existe y está habilitado';
    END
    ELSE IF EXISTS (
        SELECT * 
        FROM EMPLEADO 
        WHERE Correo = @correo
          AND Clave = @encriptado
    )
    BEGIN
        SELECT codError = 2, mensaje = 'El usuario existe pero está deshabilitado';
    END
    ELSE
    BEGIN
        SELECT codError = 1, mensaje = 'Usuario y/o contraseña incorrectos';
    END
END;
GO

-- Procedimiento para devolver cargo de usuario
CREATE PROCEDURE uspDevolverCargo
	@correo varchar(100)
AS
BEGIN
	SELECT Descripcion 
	FROM ROL
	INNER JOIN EMPLEADO E ON E.Correo = @correo
END
GO

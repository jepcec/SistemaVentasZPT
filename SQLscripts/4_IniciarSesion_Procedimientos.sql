use BDVentas
go
-- *******************************************************************************************
-- PROCEDIMIENTOS PARA INICIO DE SESIÓN --
-- *******************************************************************************************

-- Procedimiento para  verificar usuario
CREATE PROCEDURE uspVerificarUsuario
	@idEmpleado varchar(10),
	@contraseña varchar(100)
AS
BEGIN
	DECLARE @encriptado VARCHAR(50)
	SET @encriptado = HASHBYTES('MD5', @contraseña)
	IF EXISTS (SELECT * FROM EMPLEADO 
				WHERE IdEmpleado = @idEmpleado
				AND Clave = @encriptado)

		SELECT codError = 0, mensaje = 'El usuario si existe'
	ELSE
		SELECT  codError = 1, mensaje = 'Usuario y/o contraseña incorrectos'
END
go

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

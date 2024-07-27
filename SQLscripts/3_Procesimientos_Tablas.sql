USE BDVentas
GO

-- *******************************************************************************************
-- TABLA 1  - ROL --
-- *******************************************************************************************

-- Insertar ROL
CREATE PROCEDURE uspInsertarRol
    @Descripcion VARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Result TABLE (ResultCode INT, ResultMessage NVARCHAR(200));
	DECLARE @NuevoID dbo.ID
    BEGIN TRY
		-- Obtener el siguiente ID
		SET @NuevoID = dbo.ObtenerSiguienteID('ROL')
        INSERT INTO ROL (IdRol, Descripcion, FechaRegistro)
        VALUES (@NuevoID, @Descripcion, GETDATE())
        INSERT INTO @Result VALUES (0, 'Rol insertado exitosamente.');
    END TRY
    BEGIN CATCH
        INSERT INTO @Result VALUES (1, ERROR_MESSAGE());
    END CATCH;
    SELECT * FROM @Result;
END;
GO

-- Modificar ROL
CREATE PROCEDURE uspModificarRol
    @IdRol dbo.ID,
    @Descripcion VARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Result TABLE (ResultCode INT, ResultMessage NVARCHAR(200));
    BEGIN TRY
        UPDATE ROL SET Descripcion = @Descripcion WHERE IdRol = @IdRol;
        IF @@ROWCOUNT > 0
            INSERT INTO @Result VALUES (0, 'Rol modificado exitosamente.');
        ELSE
            INSERT INTO @Result VALUES (1, 'No se encontró el rol especificado.');
    END TRY
    BEGIN CATCH
        INSERT INTO @Result VALUES (1, ERROR_MESSAGE());
    END CATCH;
    SELECT * FROM @Result;
END;
GO

-- Eliminar ROL
CREATE PROCEDURE uspEliminarRol
    @IdRol dbo.ID
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Result TABLE (ResultCode INT, ResultMessage NVARCHAR(200));
    BEGIN TRY
        DELETE FROM ROL WHERE IdRol = @IdRol;
        IF @@ROWCOUNT > 0
            INSERT INTO @Result VALUES (0, 'Rol eliminado exitosamente.');
        ELSE
            INSERT INTO @Result VALUES (1, 'No se encontró el rol especificado.');
    END TRY
    BEGIN CATCH
        INSERT INTO @Result VALUES (1, ERROR_MESSAGE());
    END CATCH;
    SELECT * FROM @Result;
END;
GO

-- Listar ROL
CREATE PROCEDURE uspListarRol
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM ROL ORDER BY IdRol;
END;
GO

-- Buscar ROL
CREATE PROCEDURE uspBuscarRol
    @campo NVARCHAR(50),
    @contenido NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @SQL NVARCHAR(MAX);
    IF @contenido IS NULL OR @contenido = ''
        SET @SQL = N'SELECT * FROM ROL';
    ELSE
        SET @SQL = N'SELECT * FROM ROL WHERE ' + @campo + ' LIKE @contenido + ''%''';
    EXEC sp_executesql @SQL, N'@contenido NVARCHAR(50)', @contenido;
END;
GO



-- *******************************************************************************************
-- TABLA 2 - PERMISO --
-- *******************************************************************************************

-- Insertar PERMISO
CREATE PROCEDURE uspInsertarPermiso
    @IdRol dbo.ID,
    @NombreMenu VARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Result TABLE (ResultCode INT, ResultMessage NVARCHAR(200));
	DECLARE @NuevoID dbo.ID
    BEGIN TRY
		SET @NuevoID = dbo.ObtenerSiguienteID('PERMISO')
        INSERT INTO PERMISO (IdPermiso,IdRol, NombreMenu, FechaRegistro)
        VALUES (@NuevoID, @IdRol, @NombreMenu, GETDATE())
        INSERT INTO @Result VALUES (0, 'Permiso insertado exitosamente.');
    END TRY
    BEGIN CATCH
        INSERT INTO @Result VALUES (1, ERROR_MESSAGE());
    END CATCH;
    SELECT * FROM @Result;
END;
GO

-- Modificar PERMISO
CREATE PROCEDURE uspModificarPermiso
    @IdPermiso dbo.ID,
    @IdRol dbo.ID,
    @NombreMenu VARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Result TABLE (ResultCode INT, ResultMessage NVARCHAR(200));
    BEGIN TRY
        UPDATE PERMISO 
        SET IdRol = @IdRol, NombreMenu = @NombreMenu
        WHERE IdPermiso = @IdPermiso;
        IF @@ROWCOUNT > 0
            INSERT INTO @Result VALUES (0, 'Permiso modificado exitosamente.');
        ELSE
            INSERT INTO @Result VALUES (1, 'No se encontró el permiso especificado.');
    END TRY
    BEGIN CATCH
        INSERT INTO @Result VALUES (1, ERROR_MESSAGE());
    END CATCH;
    SELECT * FROM @Result;
END;
GO

-- Eliminar PERMISO
CREATE PROCEDURE uspEliminarPermiso
    @IdPermiso dbo.ID
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Result TABLE (ResultCode INT, ResultMessage NVARCHAR(200));
    BEGIN TRY
        DELETE FROM PERMISO WHERE IdPermiso = @IdPermiso;
        IF @@ROWCOUNT > 0
            INSERT INTO @Result VALUES (0, 'Permiso eliminado exitosamente.');
        ELSE
            INSERT INTO @Result VALUES (1, 'No se encontró el permiso especificado.');
    END TRY
    BEGIN CATCH
        INSERT INTO @Result VALUES (1, ERROR_MESSAGE());
    END CATCH;
    SELECT * FROM @Result;
END;
GO

-- Listar PERMISO
CREATE PROCEDURE uspListarPermiso
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM PERMISO ORDER BY IdPermiso;
END;
GO

-- Buscar PERMISO
CREATE PROCEDURE uspBuscarPermiso
    @campo NVARCHAR(50),
    @contenido NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @SQL NVARCHAR(MAX);
    IF @contenido IS NULL OR @contenido = ''
        SET @SQL = N'SELECT * FROM PERMISO';
    ELSE
        SET @SQL = N'SELECT * FROM PERMISO WHERE ' + @campo + ' LIKE @contenido + ''%''';
    EXEC sp_executesql @SQL, N'@contenido NVARCHAR(50)', @contenido;
END;
GO


-- *******************************************************************************************
-- TABLA 3 - EMPLEADO --
-- *******************************************************************************************

-- Insertar EMPLEADO
CREATE PROCEDURE uspInsertarEmpleado
    @Documento VARCHAR(20),
    @NombreCompleto VARCHAR(255),
    @Correo VARCHAR(255),
    @Clave VARCHAR(255),
    @IdRol dbo.ID,
    @Imagen IMAGE = NULL
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Result TABLE (ResultCode INT, ResultMessage NVARCHAR(200));
	DECLARE @NuevoID dbo.ID
    BEGIN TRY
		SET @NuevoID = dbo.ObtenerSiguienteID('EMPLEADO')
        INSERT INTO EMPLEADO (IdEmpleado,Documento, NombreCompleto, Correo, Clave, IdRol, FechaRegistro, Imagen)
        VALUES (@NuevoID, @Documento, @NombreCompleto, @Correo, HASHBYTES('MD5', @Clave), @IdRol, GETDATE(), @Imagen);
        INSERT INTO @Result VALUES (0, 'Empleado insertado exitosamente.');
    END TRY
    BEGIN CATCH
        INSERT INTO @Result VALUES (1, ERROR_MESSAGE());
    END CATCH;
    SELECT * FROM @Result;
END;
GO

-- Modificar EMPLEADO
CREATE PROCEDURE uspModificarEmpleado
    @IdEmpleado dbo.ID,
    @Documento VARCHAR(20),
    @NombreCompleto VARCHAR(255),
    @Correo VARCHAR(255),
    @Clave VARCHAR(255),
    @IdRol dbo.ID,
    @Imagen IMAGE = NULL
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Result TABLE (ResultCode INT, ResultMessage NVARCHAR(200));
    BEGIN TRY
        UPDATE EMPLEADO 
        SET Documento = @Documento, 
            NombreCompleto = @NombreCompleto, 
            Correo = @Correo, 
            Clave = CASE WHEN @Clave = '' THEN Clave ELSE HASHBYTES('MD5', @Clave) END,
            IdRol = @IdRol,
            Imagen = ISNULL(@Imagen, Imagen)
        WHERE IdEmpleado = @IdEmpleado;
        IF @@ROWCOUNT > 0
            INSERT INTO @Result VALUES (0, 'Empleado modificado exitosamente.');
        ELSE
            INSERT INTO @Result VALUES (1, 'No se encontró el empleado especificado.');
    END TRY
    BEGIN CATCH
        INSERT INTO @Result VALUES (1, ERROR_MESSAGE());
    END CATCH;
    SELECT * FROM @Result;
END;
GO

-- Eliminar EMPLEADO
CREATE PROCEDURE uspEliminarEmpleado
    @IdEmpleado dbo.ID
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Result TABLE (ResultCode INT, ResultMessage NVARCHAR(200));
    BEGIN TRY
        DELETE FROM EMPLEADO WHERE IdEmpleado = @IdEmpleado;
        IF @@ROWCOUNT > 0
            INSERT INTO @Result VALUES (0, 'Empleado eliminado exitosamente.');
        ELSE
            INSERT INTO @Result VALUES (1, 'No se encontró el empleado especificado.');
    END TRY
    BEGIN CATCH
        INSERT INTO @Result VALUES (1, ERROR_MESSAGE());
    END CATCH;
    SELECT * FROM @Result;
END;
GO

-- Listar EMPLEADO
CREATE PROCEDURE uspListarEmpleado
AS
BEGIN
    SET NOCOUNT ON;
    SELECT E.*, R.Descripcion AS NombreRol
    FROM EMPLEADO E
    INNER JOIN ROL R ON E.IdRol = R.IdRol
    ORDER BY E.IdEmpleado;
END;
GO

-- Buscar EMPLEADO
CREATE PROCEDURE uspBuscarEmpleado
    @campo NVARCHAR(50),
    @contenido NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @SQL NVARCHAR(MAX);
    IF @contenido IS NULL OR @contenido = ''
        SET @SQL = N'SELECT E.*, R.Descripcion AS NombreRol
                     FROM EMPLEADO E
                     INNER JOIN ROL R ON E.IdRol = R.IdRol';
    ELSE
        SET @SQL = N'SELECT E.*, R.Descripcion AS NombreRol
                     FROM EMPLEADO E
                     INNER JOIN ROL R ON E.IdRol = R.IdRol
                     WHERE ' + @campo + ' LIKE @contenido + ''%''';
    EXEC sp_executesql @SQL, N'@contenido NVARCHAR(50)', @contenido;
END;
GO


-- *******************************************************************************************
-- TABLA 4 - CATEGORIA --
-- *******************************************************************************************

-- Insertar CATEGORIA
CREATE PROCEDURE uspInsertarCategoria
    @Descripcion VARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Result TABLE (ResultCode INT, ResultMessage NVARCHAR(200));
	DECLARE @NuevoID dbo.ID
    BEGIN TRY
		SET @NuevoID = dbo.ObtenerSiguienteID('CATEGORIA')
        INSERT INTO CATEGORIA (IdCategoria,Descripcion, FechaRegistro)
        VALUES (@NuevoID, @Descripcion, GETDATE());
        INSERT INTO @Result VALUES (0, 'Categoría insertada exitosamente.');
    END TRY
    BEGIN CATCH
        INSERT INTO @Result VALUES (1, ERROR_MESSAGE());
    END CATCH;
    SELECT * FROM @Result;
END;
GO

-- Modificar CATEGORIA
CREATE PROCEDURE uspModificarCategoria
    @IdCategoria dbo.ID,
    @Descripcion VARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Result TABLE (ResultCode INT, ResultMessage NVARCHAR(200));
    BEGIN TRY
        UPDATE CATEGORIA 
        SET Descripcion = @Descripcion
        WHERE IdCategoria = @IdCategoria;
        IF @@ROWCOUNT > 0
            INSERT INTO @Result VALUES (0, 'Categoría modificada exitosamente.');
        ELSE
            INSERT INTO @Result VALUES (1, 'No se encontró la categoría especificada.');
    END TRY
    BEGIN CATCH
        INSERT INTO @Result VALUES (1, ERROR_MESSAGE());
    END CATCH;
    SELECT * FROM @Result;
END;
GO

-- Eliminar CATEGORIA
CREATE PROCEDURE uspEliminarCategoria
    @IdCategoria dbo.ID
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Result TABLE (ResultCode INT, ResultMessage NVARCHAR(200));
    BEGIN TRY
        DELETE FROM CATEGORIA WHERE IdCategoria = @IdCategoria;
        IF @@ROWCOUNT > 0
            INSERT INTO @Result VALUES (0, 'Categoría eliminada exitosamente.');
        ELSE
            INSERT INTO @Result VALUES (1, 'No se encontró la categoría especificada.');
    END TRY
    BEGIN CATCH
        INSERT INTO @Result VALUES (1, ERROR_MESSAGE());
    END CATCH;
    SELECT * FROM @Result;
END;
GO

-- Listar CATEGORIA
CREATE PROCEDURE uspListarCategoria
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM CATEGORIA ORDER BY IdCategoria;
END;
GO

-- Buscar CATEGORIA
CREATE PROCEDURE uspBuscarCategoria
    @campo NVARCHAR(50),
    @contenido NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @SQL NVARCHAR(MAX);
    IF @contenido IS NULL OR @contenido = ''
        SET @SQL = N'SELECT * FROM CATEGORIA';
    ELSE
        SET @SQL = N'SELECT * FROM CATEGORIA WHERE ' + @campo + ' LIKE @contenido + ''%''';
    EXEC sp_executesql @SQL, N'@contenido NVARCHAR(50)', @contenido;
END;
GO


-- *******************************************************************************************
-- TABLA 5 - PRODUCTO --
-- *******************************************************************************************

-- Insertar PRODUCTO
CREATE PROCEDURE uspInsertarProducto
    @Codigo VARCHAR(50),
    @Nombre VARCHAR(255),
    @Descripcion VARCHAR(255),
    @IdCategoria dbo.ID,
    @Stock INT,
    @PrecioCompra DECIMAL(10, 2),
    @PrecioVenta DECIMAL(10, 2),
    @Imagen IMAGE = NULL
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Result TABLE (ResultCode INT, ResultMessage NVARCHAR(200));
	DECLARE @NuevoID dbo.ID
    BEGIN TRY
		SET @NuevoID = dbo.ObtenerSiguienteID('PRODUCTO')
        INSERT INTO PRODUCTO (IdProducto, Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, FechaRegistro, Imagen)
        VALUES (@NuevoID, @Codigo, @Nombre, @Descripcion, @IdCategoria, @Stock, @PrecioCompra, @PrecioVenta, GETDATE(), @Imagen);
        
        INSERT INTO @Result VALUES (0, 'Producto insertado exitosamente.');
    END TRY
    BEGIN CATCH
        INSERT INTO @Result VALUES (1, ERROR_MESSAGE());
    END CATCH;
    SELECT * FROM @Result;
END;
GO

-- Modificar PRODUCTO
CREATE PROCEDURE uspModificarProducto
    @IdProducto dbo.ID,
    @Codigo VARCHAR(50),
    @Nombre VARCHAR(255),
    @Descripcion VARCHAR(255),
    @IdCategoria dbo.ID,
    @Stock INT,
    @PrecioCompra DECIMAL(10, 2),
    @PrecioVenta DECIMAL(10, 2),
    @Imagen IMAGE = NULL
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Result TABLE (ResultCode INT, ResultMessage NVARCHAR(200));
    BEGIN TRY
        UPDATE PRODUCTO
        SET Codigo = @Codigo,
            Nombre = @Nombre,
            Descripcion = @Descripcion,
            IdCategoria = @IdCategoria,
            Stock = @Stock,
            PrecioCompra = @PrecioCompra,
            PrecioVenta = @PrecioVenta,
            Imagen = ISNULL(@Imagen, Imagen)
        WHERE IdProducto = @IdProducto;
        
        IF @@ROWCOUNT > 0
            INSERT INTO @Result VALUES (0, 'Producto modificado exitosamente.');
        ELSE
            INSERT INTO @Result VALUES (1, 'No se encontró el producto especificado.');
    END TRY
    BEGIN CATCH
        INSERT INTO @Result VALUES (1, ERROR_MESSAGE());
    END CATCH;
    SELECT * FROM @Result;
END;
GO

-- Eliminar PRODUCTO
CREATE PROCEDURE uspEliminarProducto
    @IdProducto dbo.ID
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Result TABLE (ResultCode INT, ResultMessage NVARCHAR(200));
    BEGIN TRY
        DELETE FROM PRODUCTO WHERE IdProducto = @IdProducto;
        IF @@ROWCOUNT > 0
            INSERT INTO @Result VALUES (0, 'Producto eliminado exitosamente.');
        ELSE
            INSERT INTO @Result VALUES (1, 'No se encontró el producto especificado.');
    END TRY
    BEGIN CATCH
        INSERT INTO @Result VALUES (1, ERROR_MESSAGE());
    END CATCH;
    SELECT * FROM @Result;
END;
GO

-- Listar PRODUCTO
CREATE PROCEDURE uspListarProducto
AS
BEGIN
    SET NOCOUNT ON;
    SELECT P.*, C.Descripcion AS NombreCategoria
    FROM PRODUCTO P
    INNER JOIN CATEGORIA C ON P.IdCategoria = C.IdCategoria
    ORDER BY P.IdProducto;
END;
GO

-- Buscar PRODUCTO
CREATE PROCEDURE uspBuscarProducto
    @campo NVARCHAR(50),
    @contenido NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @SQL NVARCHAR(MAX);
    IF @contenido IS NULL OR @contenido = ''
        SET @SQL = N'SELECT P.*, C.Descripcion AS NombreCategoria
                     FROM PRODUCTO P
                     INNER JOIN CATEGORIA C ON P.IdCategoria = C.IdCategoria';
    ELSE
        SET @SQL = N'SELECT P.*, C.Descripcion AS NombreCategoria
                     FROM PRODUCTO P
                     INNER JOIN CATEGORIA C ON P.IdCategoria = C.IdCategoria
                     WHERE ' + @campo + ' LIKE @contenido + ''%''';
    EXEC sp_executesql @SQL, N'@contenido NVARCHAR(50)', @contenido;
END;
GO


-- *******************************************************************************************
-- TABLA 6 - CLIENTE --
-- *******************************************************************************************

-- Insertar CLIENTE
CREATE PROCEDURE uspInsertarCliente
    @Documento VARCHAR(20),
    @NombreCompleto VARCHAR(255),
    @Correo VARCHAR(255),
    @Telefono VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Result TABLE (ResultCode INT, ResultMessage NVARCHAR(200));
	DECLARE @NuevoID dbo.ID
    BEGIN TRY
		SET @NuevoID = dbo.ObtenerSiguienteID('CLIENTE')
        INSERT INTO CLIENTE (IdCliente, Documento, NombreCompleto, Correo, Telefono, FechaRegistro)
        VALUES (@NuevoID, @Documento, @NombreCompleto, @Correo, @Telefono, GETDATE());
        INSERT INTO @Result VALUES (0, 'Cliente insertado exitosamente.');
    END TRY
    BEGIN CATCH
        INSERT INTO @Result VALUES (1, ERROR_MESSAGE());
    END CATCH;
    SELECT * FROM @Result;
END;
GO

-- Modificar CLIENTE
CREATE PROCEDURE uspModificarCliente
    @IdCliente dbo.ID,
    @Documento VARCHAR(20),
    @NombreCompleto VARCHAR(255),
    @Correo VARCHAR(255),
    @Telefono VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Result TABLE (ResultCode INT, ResultMessage NVARCHAR(200));
    BEGIN TRY
        UPDATE CLIENTE 
        SET Documento = @Documento, NombreCompleto = @NombreCompleto, 
            Correo = @Correo, Telefono = @Telefono
        WHERE IdCliente = @IdCliente;
        IF @@ROWCOUNT > 0
            INSERT INTO @Result VALUES (0, 'Cliente modificado exitosamente.');
        ELSE
            INSERT INTO @Result VALUES (1, 'No se encontró el cliente especificado.');
    END TRY
    BEGIN CATCH
        INSERT INTO @Result VALUES (1, ERROR_MESSAGE());
    END CATCH;
    SELECT * FROM @Result;
END;
GO

-- Eliminar CLIENTE
CREATE PROCEDURE uspEliminarCliente
    @IdCliente dbo.ID
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Result TABLE (ResultCode INT, ResultMessage NVARCHAR(200));
    BEGIN TRY
        DELETE FROM CLIENTE WHERE IdCliente = @IdCliente;
        IF @@ROWCOUNT > 0
            INSERT INTO @Result VALUES (0, 'Cliente eliminado exitosamente.');
        ELSE
            INSERT INTO @Result VALUES (1, 'No se encontró el cliente especificado.');
    END TRY
    BEGIN CATCH
        INSERT INTO @Result VALUES (1, ERROR_MESSAGE());
    END CATCH;
    SELECT * FROM @Result;
END;
GO

-- Listar CLIENTE
CREATE PROCEDURE uspListarCliente
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM CLIENTE ORDER BY IdCliente;
END;
GO

-- Buscar CLIENTE
CREATE PROCEDURE uspBuscarCliente
    @campo NVARCHAR(50),
    @contenido NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @SQL NVARCHAR(MAX);
    IF @contenido IS NULL OR @contenido = ''
        SET @SQL = N'SELECT * FROM CLIENTE';
    ELSE
        SET @SQL = N'SELECT * FROM CLIENTE WHERE ' + @campo + ' LIKE @contenido + ''%''';
    EXEC sp_executesql @SQL, N'@contenido NVARCHAR(50)', @contenido;
END;
GO



-- *******************************************************************************************
-- TABLA 7 - PROVEEDOR --
-- *******************************************************************************************

-- Insertar PROVEEDOR
CREATE PROCEDURE uspInsertarProveedor
    @Documento VARCHAR(20),
    @RazonSocial VARCHAR(255),
    @Correo VARCHAR(255),
    @Telefono VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Result TABLE (ResultCode INT, ResultMessage NVARCHAR(200));
	DECLARE @NuevoID dbo.ID
    BEGIN TRY
		SET @NuevoID = dbo.ObtenerSiguienteID('PROVEEDOR')
        INSERT INTO PROVEEDOR (IdProveedor, Documento, RazonSocial, Correo, Telefono, FechaRegistro)
        VALUES (@NuevoID, @Documento, @RazonSocial, @Correo, @Telefono, GETDATE());
        INSERT INTO @Result VALUES (0, 'Proveedor insertado exitosamente.');
    END TRY
    BEGIN CATCH
        INSERT INTO @Result VALUES (1, ERROR_MESSAGE());
    END CATCH;
    SELECT * FROM @Result;
END;
GO

-- Modificar PROVEEDOR
CREATE PROCEDURE uspModificarProveedor
    @IdProveedor dbo.ID,
    @Documento VARCHAR(20),
    @RazonSocial VARCHAR(255),
    @Correo VARCHAR(255),
    @Telefono VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Result TABLE (ResultCode INT, ResultMessage NVARCHAR(200));
    BEGIN TRY
        UPDATE PROVEEDOR 
        SET Documento = @Documento, RazonSocial = @RazonSocial, 
            Correo = @Correo, Telefono = @Telefono
        WHERE IdProveedor = @IdProveedor;
        IF @@ROWCOUNT > 0
            INSERT INTO @Result VALUES (0, 'Proveedor modificado exitosamente.');
        ELSE
            INSERT INTO @Result VALUES (1, 'No se encontró el proveedor especificado.');
    END TRY
    BEGIN CATCH
        INSERT INTO @Result VALUES (1, ERROR_MESSAGE());
    END CATCH;
    SELECT * FROM @Result;
END;
GO

-- Eliminar PROVEEDOR
CREATE PROCEDURE uspEliminarProveedor
    @IdProveedor dbo.ID
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Result TABLE (ResultCode INT, ResultMessage NVARCHAR(200));
    BEGIN TRY
        DELETE FROM PROVEEDOR WHERE IdProveedor = @IdProveedor;
        IF @@ROWCOUNT > 0
            INSERT INTO @Result VALUES (0, 'Proveedor eliminado exitosamente.');
        ELSE
            INSERT INTO @Result VALUES (1, 'No se encontró el proveedor especificado.');
    END TRY
    BEGIN CATCH
        INSERT INTO @Result VALUES (1, ERROR_MESSAGE());
    END CATCH;
    SELECT * FROM @Result;
END;
GO

-- Listar PROVEEDOR
CREATE PROCEDURE uspListarProveedor
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM PROVEEDOR ORDER BY IdProveedor;
END;
GO

-- Buscar PROVEEDOR
CREATE PROCEDURE uspBuscarProveedor
    @campo NVARCHAR(50),
    @contenido NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @SQL NVARCHAR(MAX);
    IF @contenido IS NULL OR @contenido = ''
        SET @SQL = N'SELECT * FROM PROVEEDOR';
    ELSE
        SET @SQL = N'SELECT * FROM PROVEEDOR WHERE ' + @campo + ' LIKE @contenido + ''%''';
    EXEC sp_executesql @SQL, N'@contenido NVARCHAR(50)', @contenido;
END;
GO



-- *******************************************************************************************
-- TABLA 8 - COMPRA --
-- *******************************************************************************************

-- Insertar COMPRA
CREATE PROCEDURE uspInsertarCompra
    @IdEmpleado dbo.ID,
    @IdProveedor dbo.ID,
    @TipoDocumento VARCHAR(50),
	@NumeroDocumento VARCHAR(20),
    @MontoTotal DECIMAL(10, 2)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Result TABLE (ResultCode INT, ResultMessage NVARCHAR(200));
	DECLARE @NuevoID dbo.ID
    BEGIN TRY
		SET @NuevoID = dbo.ObtenerSiguienteID('COMPRA')
        INSERT INTO COMPRA (IdCompra, IdEmpleado, IdProveedor, TipoDocumento, NumeroDocumento, MontoTotal, FechaRegistro)
        VALUES (@NuevoID, @IdEmpleado, @IdProveedor, @TipoDocumento, @NumeroDocumento, @MontoTotal, GETDATE());
        INSERT INTO @Result VALUES (0, 'Compra insertada exitosamente.');
    END TRY
    BEGIN CATCH
        INSERT INTO @Result VALUES (1, ERROR_MESSAGE());
    END CATCH;
    SELECT * FROM @Result;
END;
GO

-- Modificar COMPRA
CREATE PROCEDURE uspModificarCompra
    @IdCompra dbo.ID,
    @IdEmpleado dbo.ID,
    @IdProveedor dbo.ID,
    @MontoTotal DECIMAL(10, 2)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Result TABLE (ResultCode INT, ResultMessage NVARCHAR(200));
    BEGIN TRY
        UPDATE COMPRA 
        SET IdEmpleado = @IdEmpleado, IdProveedor = @IdProveedor,
            MontoTotal = @MontoTotal
        WHERE IdCompra = @IdCompra;
        IF @@ROWCOUNT > 0
            INSERT INTO @Result VALUES (0, 'Compra modificada exitosamente.');
        ELSE
            INSERT INTO @Result VALUES (1, 'No se encontró la compra especificada.');
    END TRY
    BEGIN CATCH
        INSERT INTO @Result VALUES (1, ERROR_MESSAGE());
    END CATCH;
    SELECT * FROM @Result;
END;
GO

-- Eliminar COMPRA
CREATE PROCEDURE uspEliminarCompra
    @IdCompra dbo.ID
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Result TABLE (ResultCode INT, ResultMessage NVARCHAR(200));
    BEGIN TRY
        DELETE FROM DETALLE_COMPRA WHERE IdCompra = @IdCompra;
        DELETE FROM COMPRA WHERE IdCompra = @IdCompra;
        IF @@ROWCOUNT > 0
            INSERT INTO @Result VALUES (0, 'Compra eliminada exitosamente.');
        ELSE
            INSERT INTO @Result VALUES (1, 'No se encontró la compra especificada.');
    END TRY
    BEGIN CATCH
        INSERT INTO @Result VALUES (1, ERROR_MESSAGE());
    END CATCH;
    SELECT * FROM @Result;
END;
GO

-- Listar COMPRA
CREATE PROCEDURE uspListarCompra
AS
BEGIN
    SET NOCOUNT ON;
    SELECT C.*, E.NombreCompleto AS NombreEmpleado, P.RazonSocial AS NombreProveedor
    FROM COMPRA C
    INNER JOIN EMPLEADO E ON C.IdEmpleado = E.IdEmpleado
    INNER JOIN PROVEEDOR P ON C.IdProveedor = P.IdProveedor
    ORDER BY C.IdCompra;
END;
GO

-- Buscar COMPRA
CREATE PROCEDURE uspBuscarCompra
    @campo NVARCHAR(50),
    @contenido NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @SQL NVARCHAR(MAX);
    IF @contenido IS NULL OR @contenido = ''
        SET @SQL = N'SELECT C.*, E.NombreCompleto AS NombreEmpleado, P.RazonSocial AS NombreProveedor
                     FROM COMPRA C
                     INNER JOIN EMPLEADO E ON C.IdEmpleado = E.IdEmpleado
                     INNER JOIN PROVEEDOR P ON C.IdProveedor = P.IdProveedor';
    ELSE
        SET @SQL = N'SELECT C.*, E.NombreCompleto AS NombreEmpleado, P.RazonSocial AS NombreProveedor
                     FROM COMPRA C
                     INNER JOIN EMPLEADO E ON C.IdEmpleado = E.IdEmpleado
                     INNER JOIN PROVEEDOR P ON C.IdProveedor = P.IdProveedor
                     WHERE ' + @campo + ' LIKE @contenido + ''%''';
    EXEC sp_executesql @SQL, N'@contenido NVARCHAR(50)', @contenido;
END;
GO



-- *******************************************************************************************
-- TABLA 9 - DETALLE_COMPRA --
-- *******************************************************************************************

-- Insertar DETALLE_COMPRA
CREATE PROCEDURE uspInsertarDetalleCompra
    @IdCompra dbo.ID,
    @IdProducto dbo.ID,
    @PrecioCompra DECIMAL(10, 2),
    @PrecioVenta DECIMAL(10, 2),
    @Cantidad INT,
    @MontoTotal DECIMAL(10, 2)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Result TABLE (ResultCode INT, ResultMessage NVARCHAR(200));
	DECLARE @NuevoID dbo.ID
    BEGIN TRY
		SET @NuevoID = dbo.ObtenerSiguienteID('DETALLE_COMPRA')
        INSERT INTO DETALLE_COMPRA (IdDetalleCompra, IdCompra, IdProducto, PrecioCompra, PrecioVenta, Cantidad, MontoTotal, FechaRegistro)
        VALUES (@NuevoID, @IdCompra, @IdProducto, @PrecioCompra, @PrecioVenta, @Cantidad, @MontoTotal, GETDATE());
        INSERT INTO @Result VALUES (0, 'Detalle de compra insertado exitosamente.');
    END TRY
    BEGIN CATCH
        INSERT INTO @Result VALUES (1, ERROR_MESSAGE());
    END CATCH;
    SELECT * FROM @Result;
END;
GO

-- Modificar DETALLE_COMPRA
CREATE PROCEDURE uspModificarDetalleCompra
    @IdDetalleCompra dbo.ID,
    @IdCompra dbo.ID,
    @IdProducto dbo.ID,
    @PrecioCompra DECIMAL(10, 2),
    @PrecioVenta DECIMAL(10, 2),
    @Cantidad INT,
    @MontoTotal DECIMAL(10, 2)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Result TABLE (ResultCode INT, ResultMessage NVARCHAR(200));
    BEGIN TRY
        UPDATE DETALLE_COMPRA 
        SET IdCompra = @IdCompra, IdProducto = @IdProducto, 
            PrecioCompra = @PrecioCompra, PrecioVenta = @PrecioVenta, 
            Cantidad = @Cantidad, MontoTotal = @MontoTotal
        WHERE IdDetalleCompra = @IdDetalleCompra;
        IF @@ROWCOUNT > 0
            INSERT INTO @Result VALUES (0, 'Detalle de compra modificado exitosamente.');
        ELSE
            INSERT INTO @Result VALUES (1, 'No se encontró el detalle de compra especificado.');
    END TRY
    BEGIN CATCH
        INSERT INTO @Result VALUES (1, ERROR_MESSAGE());
    END CATCH;
    SELECT * FROM @Result;
END;
GO

-- Eliminar DETALLE_COMPRA
CREATE PROCEDURE uspEliminarDetalleCompra
    @IdDetalleCompra dbo.ID
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Result TABLE (ResultCode INT, ResultMessage NVARCHAR(200));
    BEGIN TRY
        DELETE FROM DETALLE_COMPRA WHERE IdDetalleCompra = @IdDetalleCompra;
        IF @@ROWCOUNT > 0
            INSERT INTO @Result VALUES (0, 'Detalle de compra eliminado exitosamente.');
        ELSE
            INSERT INTO @Result VALUES (1, 'No se encontró el detalle de compra especificado.');
    END TRY
    BEGIN CATCH
        INSERT INTO @Result VALUES (1, ERROR_MESSAGE());
    END CATCH;
    SELECT * FROM @Result;
END;
GO

-- Listar DETALLE_COMPRA
CREATE PROCEDURE uspListarDetalleCompra
    @IdCompra dbo.ID
AS
BEGIN
    SET NOCOUNT ON;
    SELECT DC.*, P.Nombre AS NombreProducto
    FROM DETALLE_COMPRA DC
    INNER JOIN PRODUCTO P ON DC.IdProducto = P.IdProducto
    WHERE DC.IdCompra = @IdCompra
    ORDER BY DC.IdDetalleCompra;
END;
GO

-- Buscar DETALLE_COMPRA
CREATE PROCEDURE uspBuscarDetalleCompra
    @IdCompra dbo.ID,
    @campo NVARCHAR(50),
    @contenido NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @SQL NVARCHAR(MAX);
    IF @contenido IS NULL OR @contenido = ''
        SET @SQL = N'SELECT DC.*, P.Nombre AS NombreProducto
                     FROM DETALLE_COMPRA DC
                     INNER JOIN PRODUCTO P ON DC.IdProducto = P.IdProducto
                     WHERE DC.IdCompra = @IdCompra';
    ELSE
        SET @SQL = N'SELECT DC.*, P.Nombre AS NombreProducto
                     FROM DETALLE_COMPRA DC
                     INNER JOIN PRODUCTO P ON DC.IdProducto = P.IdProducto
                     WHERE DC.IdCompra = @IdCompra AND ' + @campo + ' LIKE @contenido + ''%''';
    EXEC sp_executesql @SQL, N'@IdCompra INT, @contenido NVARCHAR(50)', @IdCompra, @contenido;
END;
GO




-- *******************************************************************************************
-- TABLA 10 - VENTA --
-- *******************************************************************************************

-- Insertar VENTA
CREATE PROCEDURE uspInsertarVenta
    @IdEmpleado dbo.ID,
    @TipoDocumento VARCHAR(50),
    @DocumentoCliente VARCHAR(20),
    @NombreCliente VARCHAR(255),
    @MontoPago DECIMAL(10, 2),
    @MontoCambio DECIMAL(10, 2),
    @MontoTotal DECIMAL(10, 2)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Result TABLE (ResultCode INT, ResultMessage NVARCHAR(200));
	DECLARE @NuevoID dbo.ID
	DECLARE @NumeroDocumento VARCHAR(20)
    BEGIN TRY
		SET @NuevoID = dbo.ObtenerSiguienteID('VENTA')
		SET @NumeroDocumento = dbo.ObtenerSiguienteNumeroComprobante(@TipoDocumento)
        INSERT INTO VENTA (IdVenta, IdEmpleado, TipoDocumento, NumeroDocumento , DocumentoCliente, NombreCliente, MontoPago, MontoCambio, MontoTotal, FechaRegistro)
        VALUES (@NuevoID, @IdEmpleado, @TipoDocumento, @NumeroDocumento, @DocumentoCliente, @NombreCliente, @MontoPago, @MontoCambio, @MontoTotal, GETDATE());

        INSERT INTO @Result VALUES (0, 'Venta insertada exitosamente.');
    END TRY
    BEGIN CATCH
        INSERT INTO @Result VALUES (1, ERROR_MESSAGE());
    END CATCH;
    SELECT * FROM @Result;
END;
GO

-- Modificar VENTA
CREATE PROCEDURE uspModificarVenta
    @IdVenta dbo.ID,
    @IdEmpleado dbo.ID,
    @DocumentoCliente VARCHAR(20),
    @NombreCliente VARCHAR(255),
    @MontoPago DECIMAL(10, 2),
    @MontoCambio DECIMAL(10, 2),
    @MontoTotal DECIMAL(10, 2)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Result TABLE (ResultCode INT, ResultMessage NVARCHAR(200));
    BEGIN TRY
        UPDATE VENTA 
        SET IdEmpleado = @IdEmpleado,
            DocumentoCliente = @DocumentoCliente, 
            NombreCliente = @NombreCliente, MontoPago = @MontoPago, 
            MontoCambio = @MontoCambio, MontoTotal = @MontoTotal
        WHERE IdVenta = @IdVenta;
        IF @@ROWCOUNT > 0
            INSERT INTO @Result VALUES (0, 'Venta modificada exitosamente.');
        ELSE
            INSERT INTO @Result VALUES (1, 'No se encontró la venta especificada.');
    END TRY
    BEGIN CATCH
        INSERT INTO @Result VALUES (1, ERROR_MESSAGE());
    END CATCH;
    SELECT * FROM @Result;
END;
GO

-- Eliminar VENTA
CREATE PROCEDURE uspEliminarVenta
    @IdVenta dbo.ID
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Result TABLE (ResultCode INT, ResultMessage NVARCHAR(200));
    BEGIN TRY
        DELETE FROM DETALLE_VENTA WHERE IdVenta = @IdVenta;
        DELETE FROM VENTA WHERE IdVenta = @IdVenta;
        IF @@ROWCOUNT > 0
            INSERT INTO @Result VALUES (0, 'Venta eliminada exitosamente.');
        ELSE
            INSERT INTO @Result VALUES (1, 'No se encontró la venta especificada.');
    END TRY
    BEGIN CATCH
        INSERT INTO @Result VALUES (1, ERROR_MESSAGE());
    END CATCH;
    SELECT * FROM @Result;
END;
GO

-- Listar VENTA
CREATE PROCEDURE uspListarVenta
AS
BEGIN
    SET NOCOUNT ON;
    SELECT V.*, E.NombreCompleto AS NombreEmpleado
    FROM VENTA V
    INNER JOIN EMPLEADO E ON V.IdEmpleado = E.IdEmpleado
    ORDER BY V.IdVenta;
END;
GO

-- Buscar VENTA
CREATE PROCEDURE uspBuscarVenta
    @campo NVARCHAR(50),
    @contenido NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @SQL NVARCHAR(MAX);
    IF @contenido IS NULL OR @contenido = ''
        SET @SQL = N'SELECT V.*, E.NombreCompleto AS NombreEmpleado
                     FROM VENTA V
                     INNER JOIN EMPLEADO E ON V.IdEmpleado = E.IdEmpleado';
    ELSE
        SET @SQL = N'SELECT V.*, E.NombreCompleto AS NombreEmpleado
                     FROM VENTA V
                     INNER JOIN EMPLEADO E ON V.IdEmpleado = E.IdEmpleado
                     WHERE ' + @campo + ' LIKE @contenido + ''%''';
    EXEC sp_executesql @SQL, N'@contenido NVARCHAR(50)', @contenido;
END;
GO



-- *******************************************************************************************
-- TABLA 11 - DETALLE_VENTA --
-- *******************************************************************************************

-- Insertar DETALLE_VENTA
CREATE PROCEDURE uspInsertarDetalleVenta
    @IdVenta dbo.ID,
    @IdProducto dbo.ID,
    @PrecioUnitario DECIMAL(10, 2),
    @Cantidad INT,
    @SubTotal DECIMAL(10, 2)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Result TABLE (ResultCode INT, ResultMessage NVARCHAR(200));
	DECLARE @NuevoID dbo.ID
    BEGIN TRY
		SET @NuevoID = dbo.ObtenerSiguienteID('DETALLE_VENTA')
        INSERT INTO DETALLE_VENTA (IdDetalleVenta, IdVenta, IdProducto, PrecioUnitario, Cantidad, SubTotal, FechaRegistro)
        VALUES (@NuevoID, @IdVenta, @IdProducto, @PrecioUnitario, @Cantidad, @SubTotal, GETDATE());
        INSERT INTO @Result VALUES (0, 'Detalle de venta insertado exitosamente.');
    END TRY
    BEGIN CATCH
        INSERT INTO @Result VALUES (1, ERROR_MESSAGE());
    END CATCH;
    SELECT * FROM @Result;
END;
GO

-- Modificar DETALLE_VENTA
CREATE PROCEDURE uspModificarDetalleVenta
    @IdDetalleVenta dbo.ID,
    @IdVenta dbo.ID,
    @IdProducto dbo.ID,
    @PrecioUnitario DECIMAL(10, 2),
    @Cantidad INT,
    @SubTotal DECIMAL(10, 2)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Result TABLE (ResultCode INT, ResultMessage NVARCHAR(200));
    BEGIN TRY
        UPDATE DETALLE_VENTA 
        SET IdVenta = @IdVenta, IdProducto = @IdProducto, 
            PrecioUnitario = @PrecioUnitario, Cantidad = @Cantidad, 
            SubTotal = @SubTotal
        WHERE IdDetalleVenta = @IdDetalleVenta;
        IF @@ROWCOUNT > 0
            INSERT INTO @Result VALUES (0, 'Detalle de venta modificado exitosamente.');
        ELSE
            INSERT INTO @Result VALUES (1, 'No se encontró el detalle de venta especificado.');
    END TRY
    BEGIN CATCH
        INSERT INTO @Result VALUES (1, ERROR_MESSAGE());
    END CATCH;
    SELECT * FROM @Result;
END;
GO

-- Eliminar DETALLE_VENTA
CREATE PROCEDURE uspEliminarDetalleVenta
    @IdDetalleVenta dbo.ID
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Result TABLE (ResultCode INT, ResultMessage NVARCHAR(200));
    BEGIN TRY
        DELETE FROM DETALLE_VENTA WHERE IdDetalleVenta = @IdDetalleVenta;
        IF @@ROWCOUNT > 0
            INSERT INTO @Result VALUES (0, 'Detalle de venta eliminado exitosamente.');
        ELSE
            INSERT INTO @Result VALUES (1, 'No se encontró el detalle de venta especificado.');
    END TRY
    BEGIN CATCH
        INSERT INTO @Result VALUES (1, ERROR_MESSAGE());
    END CATCH;
    SELECT * FROM @Result;
END;
GO

-- Listar DETALLE_VENTA
CREATE PROCEDURE uspListarDetalleVenta
    @IdVenta dbo.ID
AS
BEGIN
    SET NOCOUNT ON;
    SELECT DV.*, P.Nombre AS NombreProducto
    FROM DETALLE_VENTA DV
    INNER JOIN PRODUCTO P ON DV.IdProducto = P.IdProducto
    WHERE DV.IdVenta = @IdVenta
    ORDER BY DV.IdDetalleVenta;
END;
GO

-- Buscar DETALLE_VENTA
CREATE PROCEDURE uspBuscarDetalleVenta
    @IdVenta dbo.ID,
    @campo NVARCHAR(50),
    @contenido NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @SQL NVARCHAR(MAX);
    IF @contenido IS NULL OR @contenido = ''
        SET @SQL = N'SELECT DV.*, P.Nombre AS NombreProducto
                     FROM DETALLE_VENTA DV
                     INNER JOIN PRODUCTO P ON DV.IdProducto = P.IdProducto
                     WHERE DV.IdVenta = @IdVenta';
    ELSE
        SET @SQL = N'SELECT DV.*, P.Nombre AS NombreProducto
                     FROM DETALLE_VENTA DV
                     INNER JOIN PRODUCTO P ON DV.IdProducto = P.IdProducto
                     WHERE DV.IdVenta = @IdVenta AND ' + @campo + ' LIKE @contenido + ''%''';
    EXEC sp_executesql @SQL, N'@IdVenta INT, @contenido NVARCHAR(50)', @IdVenta, @contenido;
END;
GO

-- *******************************************************************************************
-- PROCEDIMIENTOS PARA INICIO DE SESIÓN --
-- *******************************************************************************************
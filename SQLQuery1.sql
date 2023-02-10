SELECT * FROM USUARIO

CREATE PROC SP_USUARIO_REGISTRAR(
@IdRol INT,
@Documento VARCHAR(50),
@NombreCompleto VARCHAR(100),
@Correo VARCHAR(100),
@Clave VARCHAR(100),
@Estado bit,
@IdUsarioResultado int OUTPUT,
@Mensaje VARCHAR(500) OUTPUT
)
as
BEGIN

	SET @IdUsarioResultado = 0
	SET @Mensaje = ''
	
	
	if NOT EXISTS(SELECT * FROM USUARIO WHERE Documento = @Documento)
		BEGIN
			INSERT INTO USUARIO(IdRol, Documento,NombreCompleto,Correo,Clave,Estado) VALUES
			(@IdRol,@Documento,@NombreCompleto,@Correo,@Clave,@Estado)
			
			SET @IdUsarioResultado = SCOPE_IDENTITY()
		END
	ELSE
		SET @Mensaje = 'No se puede repetir la clave del empleado a más de un usuario'
	
END


DECLARE @idusuariogenerado int
DECLARE @mensaje VARCHAR(500)
EXEC SP_REGISTRARUSUARIO 2,'0123', 'pruebas', 'prueba@', '123', 1, @idusuariogenerado OUTPUT, @mensaje OUTPUT

SELECT @idusuariogenerado
SELECT @Mensaje




create PROC SP_USUARIO_EDITAR(
@IdUsuario INT,
@IdRol INT,
@Documento VARCHAR(50),
@NombreCompleto VARCHAR(100),
@Correo VARCHAR(100),
@Clave VARCHAR(100),
@Estado bit,
@Respuesta bit OUTPUT,
@Mensaje VARCHAR(500) OUTPUT
)
as
BEGIN

	SET @Respuesta = 0
	SET @Mensaje = ''
	
	
	if NOT EXISTS(SELECT * FROM USUARIO WHERE Documento = @Documento and idusuario != @IdUsuario)
		BEGIN
			UPDATE USUARIO SET
			IdRol = @IdRol, 
			Documento = @Documento,
			NombreCompleto = @NombreCompleto,
			Correo = @Correo,
			Clave = @Clave,
			Estado = @Estado
			WHERE IdUsuario = @IdUsuario
			
			SET @Respuesta = 1
		END
	ELSE
		SET @Mensaje = 'No se puede repetir la clave del empleado a más de un usuario'
	
END

DECLARE @respuesta bit
DECLARE @mensaje VARCHAR(500)
EXEC SP_EDITARUSUARIO 4, 2,'0123', 'pruebas 2', 'prueba@', '123', 1, @respuesta OUTPUT, @mensaje OUTPUT

SELECT @respuesta
SELECT @mensaje

select * from USUARIO


alter PROC SP_USUARIO_ELIMINAR(
@IdUsuario INT,
@Respuesta bit OUTPUT,
@Mensaje VARCHAR(500) OUTPUT
)
as
BEGIN

	SET @Respuesta = 0
	SET @Mensaje = ''
	DECLARE @pasoreglas bit = 1

	IF EXISTS(SELECT * FROM COMPRA C
	INNER JOIN USUARIO U ON U.IdUsuario = C.IdUsuario
	WHERE U.IdUsuario = @IdUsuario
	)
	
	BEGIN 
		SET @pasoreglas = 0;
		SET @Respuesta = 0
		SET @Mensaje = @Mensaje + 'El usuario no se puede eliminar porque se encuentra relacionado a una COMPRA\n'
	END
	
	IF EXISTS(SELECT * FROM VENTA V
	INNER JOIN USUARIO U ON U.IdUsuario = V.IdUsuario
	WHERE U.IdUsuario = @IdUsuario
	)
	
	BEGIN 
		SET @pasoreglas = 0;
		SET @Respuesta = 0
		SET @Mensaje = @Mensaje + 'El usuario no se puede eliminar porque se encuentra relacionado a una VENTA\n'
	END

	if(@pasoreglas = 1)
	BEGIN
		UPDATE USUARIO SET
		FechaBorrado = GETDATE()
		WHERE IdUsuario = @IdUsuario
			
		SET @Respuesta = 1
	END
	
END


DECLARE @respuesta bit
DECLARE @mensaje VARCHAR(500)
EXEC SP_USUARIO_ELIMINAR 4, @respuesta OUTPUT, @mensaje OUTPUT

SELECT @respuesta
SELECT @mensaje

select GETDATE();
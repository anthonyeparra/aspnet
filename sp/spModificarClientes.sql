CREATE PROCEDURE spModificarClientes(
@nIdentificacion BIGINT,
@cNombres varchar(50),
@cApellidos varchar(50),
@cMensaje varchar(100) OUTPUT)
 AS
 IF NOT EXISTS(SELECT 1 FROM tbClientes WHERE clieIdentificacion = @nIdentificacion)
 BEGIN
 SET @cMensaje='El cliente con esta identificacion ya existe';
 END
 ELSE
 BEGIN
 UPDATE tbClientes SET 
clieNombres=@cNombres,
clieApellidos= @cApellidos
WHERE
clieIdentificacion=@nIdentificacion;
 SET @cMensaje='Cliente Actualizado Correctamente';
 END
 IF @@ERROR !=0
 BEGIN
 SET @cMensaje='Se ha producido un error durante el procedimiento';
 END
CREATE PROCEDURE spEliminarClientes(
@nIdentificacion BIGINT,
@cMensaje varchar(100) OUTPUT)
 AS
 IF NOT EXISTS(SELECT 1 FROM tbClientes WHERE clieIdentificacion = @nIdentificacion)
 BEGIN
 SET @cMensaje='El cliente con esta identificacion no existe';
 END
 ELSE
 BEGIN
 DELETE FROM tbClientes 
WHERE
clieIdentificacion=@nIdentificacion;
 SET @cMensaje='Cliente Actualizado Correctamente';
 END
 IF @@ERROR !=0
 BEGIN
 SET @cMensaje='Se ha producido un error durante el procedimiento';
 END
CREATE PROCEDURE spInsertarClientes(
@nIdentificacion BIGINT,
@cNombres varchar(50),
@cApellidos varchar(50),
@cMensaje varchar(100) OUTPUT)
 AS
 IF EXISTS(SELECT 1 FROM tbClientes WHERE clieIdentificacion = @nIdentificacion)
 BEGIN
 SET @cMensaje='El cliente con esta identificacion ya existe';
 END
 ELSE
 BEGIN
 INSERT INTO tbClientes(clieIdentificacion,clieNombres,clieApellidos)
 VALUES(
 @nIdentificacion,
 @cNombres,
 @cApellidos)
 END


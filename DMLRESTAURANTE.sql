-- =============================================
-- Author:		Hollman Rojas
-- Create date: 04/09/2020
-- Description:	Procedimiento almacenado consulta Clientes.
-- =============================================


CREATE PROCEDURE sp_consulta_clientes
AS
BEGIN
Select * from Clientes
END
GO

-- =============================================
-- Author:		Hollman Rojas
-- Create date: 04/09/2020
-- Description:	Procedieminto almacenado Insertar Clientes.
-- =============================================

CREATE PROCEDURE sp_insertar_cliente
@Documento_cliente numeric (10,0),
@Nom_cliente nvarchar (50),
@Apellido_cliente nvarchar (50),
@Direccion_cliente nvarchar (80),
@Telefono_cliente decimal (10,0),
@fecha_registro date,
@fecha_nacimeinto date
as
begin
insert into  Clientes (Documento_cliente, Nom_cliente, Apellido_cliente, Direccion_cliente, Telefono_cliente, fecha_registro, fecha_nacimeinto)
values (@Documento_cliente, @Nom_cliente, @Apellido_cliente,@Direccion_cliente,@Telefono_cliente,@fecha_registro,@fecha_nacimeinto)
select * from Clientes
end
go

exec sp_insertar_cliente 10256666, 'Homero', 'Simpson','Av Siempre Viva 456', 15555555, '04/09/2000', '04/09/1973'

-- =============================================
-- Author:		Hollman Rojas
-- Create date: 04/09/2020
-- Description:	Procedieminto almacenado Modifica Cliente.
-- =============================================

CREATE PROCEDURE sp_modificar_cliente
@Documento_cliente numeric (10,0),
@Nom_cliente nvarchar (50),
@Apellido_cliente nvarchar (50),
@Direccion_cliente nvarchar (80),
@Telefono_cliente decimal (10,0),
@fecha_registro date,
@fecha_nacimeinto date
AS
UPDATE Clientes SET [Nom_cliente]= @Nom_cliente , [Apellido_cliente]= @Apellido_cliente, [Direccion_cliente]= @Direccion_cliente, [Telefono_cliente]=@Telefono_cliente, [fecha_registro]= @fecha_registro, [fecha_nacimeinto]=@fecha_nacimeinto
WHERE Documento_cliente = @Documento_cliente
select * from Clientes
 GO


 -- =============================================
-- Author:		Hollman Rojas
-- Create date: 04/09/2020
-- Description:	Procedimiento almacenado consulta Empleados.
-- =============================================
CREATE PROCEDURE sp_consultar_empleado
AS
BEGIN
Select * from Empleado

END
GO
 -- =============================================
-- Author:		Hollman Rojas
-- Create date: 04/09/2020
-- Description:	Procedimiento almacenado insertar Empleados.
-- =============================================
CREATE PROCEDURE sp_insertar_Empleado
@Documento_empleado numeric (10,0),
@Nom_empleado nvarchar (50),
@Apellido_empleado nvarchar (50),
@Direccion_empleado nvarchar (80),
@Telefono_empleado decimal (10,0),
@Cargo nvarchar (50),
@fecha_contratacion date
as
begin
insert into  Empleado (Documento_empleado, Nom_empleado, Apellido_empleado, Direccion_empleado, Telefono_empleado, Cargo, fecha_contratacion)
values (@Documento_empleado, @Nom_empleado, @Apellido_empleado,@Direccion_empleado,@Telefono_empleado,@Cargo,@fecha_contratacion)
select * from Empleado;
End
Go

-- =============================================
-- Author:		Hollman Rojas
-- Create date: 04/09/2020
-- Description:	Procedimiento almacenado Modifica Empleado.
-- =============================================
CREATE PROCEDURE sp_modificar_empleado
@Documento_empleado numeric (10,0),
@Nom_empleado nvarchar (50),
@Apellido_empleado nvarchar (50),
@Direccion_empleado nvarchar (80),
@Telefono_empleado decimal (10,0),
@Cargo nvarchar (50),
@fecha_contratacion date
AS
UPDATE Empleado SET [Nom_empleado]= @Nom_empleado , [Apellido_empleado]= @Apellido_empleado, [Direccion_empleado]= @Direccion_empleado, [Telefono_empleado]=@Telefono_empleado, [Cargo]= @Cargo, [fecha_contratacion]=@fecha_contratacion
WHERE Documento_empleado = @Documento_empleado
select * from Empleado;
 GO

  -- =============================================
-- Author:		Hollman Rojas
-- Create date: 04/09/2020
-- Description:	Procedimiento almacenado consulta mesas.
-- =============================================
CREATE PROCEDURE sp_consultar_mesa
AS
BEGIN
Select * from Mesas

END
GO

  -- =============================================
-- Author:		Hollman Rojas
-- Create date: 04/09/2020
-- Description:	Procedimiento almacenado insertar mesas.
-- =============================================

CREATE PROCEDURE sp_insertar_mesa
@id_mesa int ,
@num_mesa numeric (2,0)
as
begin
insert into  Mesas (id_mesa, num_mesa)
values (@id_mesa, @num_mesa)
select * from Mesas;
End
Go

  -- =============================================
-- Author:		Hollman Rojas
-- Create date: 04/09/2020
-- Description:	Procedimiento almacenado modificar mesas.
-- =============================================

CREATE PROCEDURE sp_modificar_mesa
@id_mesa int ,
@num_mesa numeric (2,0)
AS
UPDATE Mesas SET [num_mesa]= @num_mesa 
WHERE id_mesa = @id_mesa
select * from Mesas;
 GO

   -- =============================================
-- Author:		Hollman Rojas
-- Create date: 04/09/2020
-- Description:	Procedimiento almacenado eliminar mesas.
-- =============================================

CREATE PROCEDURE sp_eliminar_mesa
@num_mesa numeric (2,0)
as
begin
Delete FROM Mesas WHERE num_mesa = @num_mesa
end
select * from Mesas;
go

 -- =============================================
-- Author:		Hollman Rojas
-- Create date: 04/09/2020
-- Description:	Procedimiento almacenado agregar reserva.
-- =============================================

CREATE PROCEDURE sp_insertar_reserva
@id_reserva numeric (10,0), 
@Documento_cliente numeric (10,0),
@id_mesa int,
@Fecha_reserva datetime
as
begin
insert into  Reservas (id_reserva, Documento_cliente,id_mesa,Fecha_reserva)
values (@id_reserva, @Documento_cliente, @id_mesa,@Fecha_reserva)
select * from Reservas;
End
Go

-- =============================================
-- Author:		Hollman Rojas
-- Create date: 04/09/2020
-- Description:	Procedimiento almacenado consultar reservas.
-- =============================================

CREATE PROCEDURE sp_consultar_reserva
AS
BEGIN
Select * from Reservas

END
GO

   -- =============================================
-- Author:		Hollman Rojas
-- Create date: 04/09/2020
-- Description:	Procedimiento almacenado modificar reservas.
-- =============================================

CREATE PROCEDURE sp_modificar_reserva
@id_reserva numeric (10,0), 
@Documento_cliente numeric (10,0),
@id_mesa int,
@Fecha_reserva datetime
AS
UPDATE Reservas SET [Documento_cliente]= @Documento_cliente, [id_mesa]= @id_mesa, [Fecha_reserva]= @Fecha_reserva
WHERE id_reserva = @id_reserva
select * from Reservas;
 GO

  -- =============================================
-- Author:		Hollman Rojas
-- Create date: 04/09/2020
-- Description:	Procedimiento almacenado eliminar reservas.
-- =============================================

CREATE PROCEDURE sp_eliminar_reservas
@id_reserva  numeric (2,0)
as
begin
Delete FROM Reservas WHERE id_reserva  = @id_reserva 
end
select * from Reservas;
go

 -- =============================================
-- Author:		Hollman Rojas
-- Create date: 04/09/2020
-- Description:	Procedimiento almacenado consultar detalle factura.
-- =============================================

CREATE PROCEDURE sp_consultar_Detalle_Factura
AS
BEGIN
Select * from Detalle_Factura

END
GO

 -- =============================================
-- Author:		Hollman Rojas
-- Create date: 04/09/2020
-- Description:	Procedimiento almacenado modificar detalle factura.
-- =============================================

CREATE PROCEDURE sp_modificar_detalle_factura
@id_detalle_factura int, 
@id_factura numeric (10,0),
@Documento_empleado numeric (10,0),
@id_plato int,
@id_mesa int
AS
UPDATE Detalle_Factura SET [id_factura]= @id_factura, [Documento_empleado]= @Documento_empleado, [id_plato]= @id_plato, [id_mesa]= @id_mesa
WHERE id_detalle_factura = @id_detalle_factura
select * from Detalle_Factura;
 GO

 -- =============================================
-- Author:		Hollman Rojas
-- Create date: 04/09/2020
-- Description:	Procedimiento almacenado ingresar detalle factura.
-- ============================================
CREATE PROCEDURE sp_insertar_detalle_factura
@id_factura numeric (10,0),
@Documento_empleado numeric (10,0),
@id_plato int,
@id_mesa int
as
begin
insert into  Detalle_Factura( id_factura, Documento_empleado, id_plato, id_mesa)
values ( @id_factura, @Documento_empleado,@id_plato, @id_mesa)
select * from Detalle_Factura;
End
Go

exec sp_insertar_detalle_factura  1, 80121042, 1, 1

 -- =============================================
-- Author:		Hollman Rojas
-- Create date: 04/09/2020
-- Description:	Procedimiento almacenado consultar plato.
-- =============================================

CREATE PROCEDURE sp_consultar_consultar_plato
AS
BEGIN
Select * from Platos

END
GO

-- =============================================
-- Author:		Hollman Rojas
-- Create date: 04/09/2020
-- Description:	Procedimiento almacenado insertar plato.
-- =============================================
CREATE PROCEDURE sp_insertar_plato2
@Nombre_plato nvarchar (50),
@Precio_plato decimal (10,0)
as
begin
insert into  Platos (Nombre_plato, Precio_plato)
values (@Nombre_plato, @Precio_plato)
select * from Platos;
End
Go

Exec sp_insertar_plato2 "Bandeja Paisa", 2500 

-- =============================================
-- Author:		Hollman Rojas
-- Create date: 04/09/2020
-- Description:	Procedimiento almacenado eliminar plato.
-- =============================================

CREATE PROCEDURE sp_eliminar_plato
@id_plato int
as
begin
Delete FROM Platos WHERE id_plato = @id_plato 
select * from Platos;
end
go

  -- =============================================
-- Author:		Hollman Rojas
-- Create date: 04/09/2020
-- Description:	Procedimiento almacenado insertar factura.
-- =============================================

CREATE PROCEDURE sp_insertar_factura
@id_factura numeric (10,0),
@Documento_cliente numeric (10,0),
@Fecha_factura date
as
begin
insert into  Facturas (id_factura, Documento_cliente, Fecha_factura)
values (@id_factura, @Documento_cliente, @Fecha_factura )
select * from Facturas;
End
Go

exec sp_insertar_factura 1, 80121042, "07/09/2020"


-- =============================================
-- Author:		Hollman Rojas
-- Create date: 04/09/2020
-- Description:	Consultas
-- =============================================
CREATE PROCEDURE Fecha_reserva_cliente
as
begin
SELECT Clientes.Documento_cliente, Clientes.Nom_cliente, Reservas.Fecha_reserva, Reservas.id_mesa
FROM Clientes
FULL OUTER JOIN Reservas ON Clientes.Documento_cliente=Reservas.Documento_cliente
ORDER BY Clientes.Nom_cliente ;
end
go




CREATE PROCEDURE Facturacion
as
begin

SELECT def.id_detalle_factura, concat(c.Nom_cliente, ' ' , c.Apellido_cliente) as "Nombre Cliente" , p.Nombre_plato, p.Precio_plato , m.num_mesa, 
concat(e.Nom_empleado, ' ' , e.Apellido_empleado)as "Atendido por" from Detalle_Factura def
INNER JOIN Facturas f on f.id_factura = def.id_factura
INNER JOIN Clientes c on c.Documento_cliente = f.Documento_cliente
INNER JOIN Platos P on p.id_plato = def.id_plato
INNER JOIN Mesas m on m.id_mesa = def.id_mesa
INNER JOIN Empleado e on e.Documento_empleado = def.Documento_empleado
end
go
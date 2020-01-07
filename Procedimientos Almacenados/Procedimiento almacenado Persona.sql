--Procedimiento listar
create proc listar_persona
as
select IdPersona as ID, tipo_persona as Tipo_Persona, nombre as Nombre, tipo_documento as Tipo_Documento,
num_documento as Num_Documento, direccion as Direccion, telefono as Telefono, email as Email
from persona
order by idpersona desc
go

--Procedimiento listar proveedor
create proc listar_personaProveedor
as
select IdPersona as ID, tipo_persona as Tipo_Persona, nombre as Nombre, tipo_documento as Tipo_Documento,
num_documento as Num_Documento, direccion as Direccion, telefono as Telefono, email as Email
from persona where tipo_persona='Proveedor'
order by idpersona desc
go

--Procedimiento listar clientes
create proc listar_personaCliente
as
select IdPersona as ID, tipo_persona as Tipo_Persona, nombre as Nombre, tipo_documento as Tipo_Documento,
num_documento as Num_Documento, direccion as Direccion, telefono as Telefono, email as Email
from persona where tipo_persona='Cliente'
order by idpersona desc
go

--Procedimiento Buscar
create proc buscar
@valor varchar (100)
as
select IdPersona as ID, tipo_persona as Tipo_Persona, nombre as Nombre, tipo_documento as Tipo_Documento,
num_documento as Num_Documento, direccion as Direccion, telefono as Telefono, email as Email
from persona 
where nombre like '%' + @valor + '%' or email like '%' + @valor + '%'
order by nombre asc
go

--Procedimiento Buscar Proveedor
create proc buscarProveedor
@valor varchar (100)
as
select IdPersona as ID, tipo_persona as Tipo_Persona, nombre as Nombre, tipo_documento as Tipo_Documento,
num_documento as Num_Documento, direccion as Direccion, telefono as Telefono, email as Email
from persona 
where (nombre like '%' + @valor + '%' or email like '%' + @valor + '%')
and tipo_persona = 'Proveedor'
order by nombre asc
go

--Procedimiento Buscar Cliente
create proc buscarClientes
@valor varchar (100)
as
select IdPersona as ID, tipo_persona as Tipo_Persona, nombre as Nombre, tipo_documento as Tipo_Documento,
num_documento as Num_Documento, direccion as Direccion, telefono as Telefono, email as Email
from persona 
where (nombre like '%' + @valor + '%' or email like '%' + @valor + '%')
and tipo_persona = 'Clientes'
order by nombre asc
go

--Procedimiento Insertar
create proc insertar_persona
@tipo_persona varchar (20),
@nombre varchar (100),
@tipo_documento varchar (20),
@num_documento varchar (20),
@direccion varchar (70),
@telefono varchar (20),
@email varchar (50)
as
insert into persona (tipo_persona,nombre, tipo_documento, num_documento, direccion, telefono, email)
values (@tipo_persona, @nombre, @tipo_documento, @num_documento, @direccion, @telefono, @email)
go
--Procedimiento Actualizar
create proc actualizar_persona
@idpersona integer,
@tipo_persona varchar (20),
@nombre varchar (100),
@tipo_documento varchar (20),
@num_documento varchar (20),
@direccion varchar (70),
@telefono varchar (20),
@email varchar (50)
as
update persona set tipo_persona=@tipo_persona,nombre=@nombre, tipo_documento=@tipo_documento, num_documento=@num_documento,
direccion=@direccion, telefono=@telefono, email=@email
where idpersona=@idpersona
go
--Procedimiento Eliminar
create proc eliminar_persona
@idpersona integer
as
delete from persona
where idpersona=@idpersona
go

--Procedimiento existe
create proc exite_persona
@valor varchar (100),
@existe bit output
as
if exists (select nombre from persona where nombre = LTRIM(RTRIM(@valor)))
	begin
		set @existe=1
	end
else
	begin
		set @existe=0
	end
go


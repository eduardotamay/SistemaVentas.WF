--Procedimiento Listar
create proc usuario_listar
as
select u.idusuario as ID, u.idrol, r.nombre as Rol, u.nombre as Nombre,
u.tipo_documento as Tipo_Documento, u.num_documento as Num_Documento,
u.direccion as Direccion, u.telefono as Telefono, u.email as Email,
u.estado as Estado 
from usuario u inner join rol r on u.idrol=r.idrol
order by u.idusuario desc
go

--Procedimiento Buscar
create proc usuario_buscar
@valor varchar (50)
as
select u.idusuario as ID, u.idrol, r.nombre as Rol, u.nombre as Nombre,
u.tipo_documento as Tipo_Documento, u.num_documento as Num_Documento,
u.direccion as Direccion, u.telefono as Telefono, u.email as Email,
u.estado as Estado 
from usuario u inner join rol r on u.idrol=r.idrol
where u.nombre like '%' + @valor + '%' OR u.email like '%' + @valor + '%'
go
--Procedimiento Insertar
create proc usuario_insertar
@idrol integer,
@nombre varchar(100),
@tipo_documento varchar (20),
@num_documento varchar (20),
@direccion varchar (70),
@telefono varchar(20),
@email varchar (20),
@clave varchar (50)
as
insert into usuario (idrol,nombre,tipo_documento, num_documento, direccion, telefono, email, clave)
values (@idrol, @nombre, @tipo_documento, @num_documento, @direccion, @telefono, @email, HASHBYTES('SHA2_256',@clave))
go

--Procedimiento Actualizar
CREATE PROC usuario_actualizar
@idusuario integer,
@idrol integer,
@nombre varchar(100),
@tipo_documento varchar (20),
@num_documento varchar (20),
@direccion varchar (70),
@telefono varchar(20),
@email varchar (20),
@clave varchar (50)
as
if @clave <>''
	UPDATE usuario set idrol=@idrol, nombre=@nombre, tipo_documento=@tipo_documento, num_documento=@num_documento, direccion=@direccion,
						telefono=@telefono, email=@email, clave=HASHBYTES('SHA2_256',@clave)
	where idusuario=@idusuario
else
	UPDATE usuario set idrol=@idrol, nombre=@nombre, tipo_documento=@tipo_documento, num_documento=@num_documento, direccion=@direccion,
						telefono=@telefono, email=@email
	where idusuario=@idusuario
go
--Procedimiento Eliminar
create proc usuario_eliminar
@idusuario integer
as
DELETE FROM usuario
WHERE idusuario=@idusuario
go
--Procedimiento Activar
create proc usuario_activar
@idusuario integer
as
UPDATE usuario set estado=1
where idusuario=@idusuario
go
--Procedimiento Desactivar
create proc usuario_desactivar
@idusuario integer
as
UPDATE usuario set estado=0
where idusuario=@idusuario
go
--Procedimiento Existe
create proc usuario_existe
@valor varchar (100),
@existe bit output
as
	if exists (select email from usuario where email = LTRIM(RTRIM( @valor)))
		begin
			set @existe = 1
		 end
	else
		begin
			set @existe=0
		end
go


select * from usuario
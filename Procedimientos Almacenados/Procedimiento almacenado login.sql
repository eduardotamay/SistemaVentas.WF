create proc usuario_login
@email varchar (50),
@clave varchar (50)
as
select u.idusuario, u.idrol, r.nombre as rol, u.nombre, u.estado
from usuario u inner join rol r on u.idrol=r.idrol
where u.email=@email and u.clave=HASHBYTES('SHA2_256',@clave)
GO

execute usuario_listar
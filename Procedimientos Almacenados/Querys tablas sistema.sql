--Tabla categoria
create table categoria (
	idcategoria integer primary key identity,
	nombre varchar (50) not null unique,
	descripcion varchar (255) null,
	estado bit default(1)
);
go
insert into categoria (nombre,descripcion) 
values ('Ipads', 'Todos los ipads están bien');

select * from categoria;


--Tabla articulo
create table articulo (
	idarticulo integer primary key identity,
	idcategoria integer not null,
	codigo varchar (50) null,
	nombre varchar (100) not null unique,
	precio_venta decimal (11,2) not null,
	stock integer not null,
	descripcion varchar (255) null,
	imagen varchar (20) null,
	estado bit default(1),
	FOREIGN KEY (idcategoria) REFERENCES categoria (idcategoria) 
);
go

--Tabla personas
create table persona (
	idpersona integer primary key identity,
	tipo_persona varchar (20) not null,
	nombre varchar (100) not null,
	tipo_documento varchar (20) null,
	num_documento varchar (20) null,
	direccion varchar (70) null,
	telefono varchar (20) null,
	email varchar (50) null
);
go

--Tabla rol
create table rol (
	idrol integer primary key identity,
	nombre varchar (30) not null,
	descripcion varchar (255) null,
	estado bit default (1)
);

--tabla usuario 
create table usuario (
	idusuario integer primary key identity,
	idrol integer not null,
	nombre varchar (100) not null,
	tipo_documento varchar (20) null,
	num_documento varchar (20) null,
	direccion varchar (70) null,
	telefono varchar (20) null,
	email varchar (20) null,
	clave varbinary (MAX) not null,
	estado bit default (1),
	FOREIGN KEY (idrol) REFERENCES rol (idrol) 
);
go

create table ingreso (
	idingreso integer primary key identity,
	idproveedor integer not null,
	idusuario integer not null,
	tipo_comprobante varchar (20) not null,
	serie_comprobante varchar (7) not null,
	fecha datetime not null,
	impuesto decimal (4,2) not null,
	total decimal (11,2) not null,
	estado varchar (20) not null,
	FOREIGN KEY (idproveedor) REFERENCES persona (idpersona),
	FOREIGN KEY (idusuario) REFERENCES usuario (idusuario)

);
go

--Tabla detalle_ingreso
create table detalle_ingreso (
	iddetalle_ingreso integer primary key identity,
	idingreso integer not null,
	idarticulo integer not null,
	cantidad integer not null,
	precio decimal (11,2) not null
	FOREIGN KEY (idingreso) REFERENCES ingreso (idingreso) ON DELETE CASCADE,
	FOREIGN KEY (idarticulo) REFERENCES articulo (idarticulo)
);
go


--Table ventas
create table venta (
	idventa integer primary key identity,
	idcliente integer not null,
	idusuario integer not null,
	tipo_comprobante varchar (20) not null,
	serie_comprobante varchar (7) not null,
	num_comprobante varchar (10) not null,
	fecha datetime not null,
	impuesto decimal (4,2) not null,
	total decimal (11,2) not null,
	estado varchar (20) not null,
	FOREIGN KEY (idcliente) REFERENCES persona (idpersona),
	FOREIGN KEY (idusuario) REFERENCES usuario (idusuario)
);


--Table detalle_venta
create table detalle_venta (
	iddetalle_venta integer primary key identity,
	idventa integer not null,
	idarticulo integer not null,
	cantidad integer not null,
	precio decimal (11,2) not null,
	descuento decimal (11,2) not null,
	FOREIGN KEY (idventa) REFERENCES venta (idventa) ON DELETE CASCADE,
	FOREIGN KEY (idarticulo) REFERENCES articulo (idarticulo)
);











Create database Restaurante
Use Restaurante;

Create table Mesas(
id_mesa int not null,
num_mesa numeric (2,0) not null

CONSTRAINT  pk_mesa PRIMARY KEY (id_mesa)

)


Create table Clientes(
Documento_cliente numeric (10,0) ,
Nom_cliente nvarchar (50) not null,
Apellido_cliente nvarchar (50) not null,
Direccion_cliente nvarchar (80) not null,
Telefono_cliente decimal (10,0) not null,
fecha_registro date not null,
fecha_nacimeinto date not null,

CONSTRAINT  pk_Cliente PRIMARY KEY (Documento_cliente)
)

Create table Facturas(
id_factura numeric (10,0),
Documento_cliente numeric (10,0),
Fecha_factura date not null

CONSTRAINT  pk_facturas PRIMARY KEY (id_factura)
CONSTRAINT fk_factura_cliente FOREIGN KEY (Documento_cliente) references Clientes (Documento_cliente)

)
Create table Reservas(
id_reserva numeric (10,0),
Documento_cliente numeric (10,0) not null,
id_mesa int not null,
Fecha_reserva datetime not null,

CONSTRAINT  pk_reservas PRIMARY KEY (id_reserva),
CONSTRAINT fk_reserva FOREIGN KEY (Documento_cliente) references Clientes (Documento_cliente),
CONSTRAINT fk_reserva_mesa FOREIGN KEY (id_mesa) references Mesas (id_mesa)
)


Create table Empleado(
Documento_empleado numeric (10,0),
Nom_empleado nvarchar (50) not null,
Apellido_empleado nvarchar (50) not null,
Direccion_empleado nvarchar (80) not null,
Telefono_empleado decimal (10,0) not null,
Cargo nvarchar (50) not null,
fecha_contratacion date not null

CONSTRAINT  pk_empleado PRIMARY KEY (Documento_empleado),
)

create table Platos(
id_plato int identity,
Nombre_plato nvarchar (50) not null,
Precio_plato decimal (10,0) not null,

CONSTRAINT  pk_plato PRIMARY KEY (id_plato),
)


Create table Detalle_Factura(
id_detalle_factura int identity,
id_factura numeric (10,0) not null,
Documento_empleado numeric (10,0) not null,
id_plato int not null,
id_mesa int not null,

CONSTRAINT  pk_Detalle_Factura PRIMARY KEY (id_detalle_factura),
CONSTRAINT fk_detalle_factura_factura FOREIGN KEY (id_factura) references Facturas (id_factura),
CONSTRAINT fk_detalle_factura_empleado FOREIGN KEY (Documento_empleado) references Empleado (Documento_empleado),
CONSTRAINT fk_detalle_factura_plato FOREIGN KEY (id_plato) references Platos (id_plato),
CONSTRAINT fk_detalle_factura_mesa FOREIGN KEY (id_mesa) references Mesas (id_mesa),

)
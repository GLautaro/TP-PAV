CREATE DATABASE db_don_cayetano
GO
USE db_don_cayetano;

CREATE TABLE estado_pedido (
	id_estado INT IDENTITY(1,1) PRIMARY KEY,
	nombre_estado VARCHAR(20)
);

CREATE TABLE tipo_producto (
	id_tipo_producto INT IDENTITY(1,1) PRIMARY KEY,
	nombre_tipo_producto VARCHAR(100) NOT NULL,
	descripcion VARCHAR(100) NOT NULL
);

CREATE TABLE unidad_medida (
	id_u_medida INT IDENTITY(1,1) PRIMARY KEY,
	nombre_u_medida VARCHAR(100)
);

CREATE TABLE tipo_franquicia (
	id_tipo_franquicia INT IDENTITY(1,1) PRIMARY KEY,
	monto_minimo_compra FLOAT NOT NULL,
	porcentaje_descuento FLOAT NOT NULL,
	nombre_tipo_franquicia VARCHAR(100) NOT NULL,
	CONSTRAINT CHK_PORCENTAJE_FRANQUICIA CHECK (porcentaje_descuento >= 0 AND porcentaje_descuento <= 100)
);

CREATE TABLE barrio (
	id_barrio INT IDENTITY(1,1) PRIMARY KEY,
	nombre_barrio VARCHAR(100) NOT NULL
);

CREATE TABLE vendedor (
	legajo_vendedor INT IDENTITY(1,1) PRIMARY KEY,
	nombre_vendedor VARCHAR(100) NOT NULL,
	apellido_vendedor VARCHAR(100) NOT NULL,
	porcentaje_comision FLOAT NOT NULL,
	CONSTRAINT CHK_PORCENTAJE_VENDEDOR CHECK (porcentaje_comision >= 0 AND porcentaje_comision <= 100)
);

CREATE TABLE franquicia (
	id_franquicia INT IDENTITY(1,1) PRIMARY KEY,
	nombre_responsable VARCHAR(100) NOT NULL,
	apellido_responsable VARCHAR(100),
	calle VARCHAR(100) NOT NULL,
	nro_calle INT NOT NULL,
	id_barrio INT FOREIGN KEY REFERENCES barrio(id_barrio),
	monto_minimo_compra FLOAT NOT NULL,
	id_tipo_franquicia INT FOREIGN KEY REFERENCES tipo_franquicia(id_tipo_franquicia),
	legajo_vendedor INT FOREIGN KEY REFERENCES vendedor(legajo_vendedor)
);

CREATE TABLE producto (
	id_producto INT IDENTITY(1,1) PRIMARY KEY,
	nombre_producto VARCHAR(100) NOT NULL,
	cantidad_u_medida FLOAT,
	id_u_medida INT FOREIGN KEY REFERENCES unidad_medida(id_u_medida),
	descripcion VARCHAR(100),
	id_tipo_producto INT FOREIGN KEY REFERENCES tipo_producto(id_tipo_producto),
	precio_unitario FLOAT NOT NULL,
	estado_producto BIT,
	CONSTRAINT CHK_PRECIO_PRODUCTO CHECK (precio_unitario > 0),
	CONSTRAINT CHK_CANTIDAD_U_MEDIDA CHECK (cantidad_u_medida > 0)
);

CREATE TABLE pedido (
	id_pedido INT IDENTITY(1,1) PRIMARY KEY,
	fecha_solicitud DATE NOT NULL,
	fecha_entrega DATE,
	id_estado INT FOREIGN KEY REFERENCES estado_pedido(id_estado),
	id_franquicia INT FOREIGN KEY REFERENCES franquicia(id_franquicia),
	id_vendedor INT FOREIGN KEY REFERENCES vendedor(legajo_vendedor),
	monto_final FLOAT,
	CONSTRAINT CHK_MONTO CHECK (monto_final > 0)
);

CREATE TABLE pedido_x_producto (
	id_pedido INT FOREIGN KEY REFERENCES pedido(id_pedido) NOT NULL,
	id_producto INT FOREIGN KEY REFERENCES producto(id_producto) NOT NULL,
	cantidad INT NOT NULL,
	precio_unitario FLOAT NOT NULL,
	PRIMARY KEY (id_pedido, id_producto),
	CONSTRAINT CHK_PRECIO_VENTA CHECK (precio_unitario > 0)
);

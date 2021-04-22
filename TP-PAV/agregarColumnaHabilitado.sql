USE db_don_cayetano;
GO

ALTER TABLE barrio ADD habilitado BIT NOT NULL DEFAULT(1);
ALTER TABLE franquicia ADD habilitado BIT NOT NULL DEFAULT(1);
ALTER TABLE tipo_franquicia ADD habilitado BIT NOT NULL DEFAULT(1);
ALTER TABLE tipo_producto ADD habilitado BIT NOT NULL DEFAULT(1);
ALTER TABLE vendedor ADD habilitado BIT NOT NULL DEFAULT(1);
ALTER TABLE unidad_medida ADD habilitado BIT NOT NULL DEFAULT(1);

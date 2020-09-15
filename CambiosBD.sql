UPDATE STATUS SET Nombre = 'DEVUELTA A PROVEDOR' WHERE cod_status = 4
UPDATE STATUS SET Nombre = 'VENTA DEVUELTA' WHERE cod_status = 2

alter table prendas add fec_devolucion smalldatetime null 


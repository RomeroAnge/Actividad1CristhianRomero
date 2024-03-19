CREATE DATABASE ACTIVIDAD1_CRISTHIANROMERO

GO

CREATE TABLE COMPUTADORA (
IDCOMPUTADORA INT IDENTITY (1,1) NOT NULL,
NOMBRE NVARCHAR (50) NOT NULL,
DESCRIPCION NVARCHAR (100) NOT NULL,
PRECIO MONEY NOT NULL,
FECHADEFABRICACION DATETIME NOT NULL,
PRIMARY KEY (IDCOMPUTADORA),
);


insert into computadora values('Victus' ,'Computadora Gamer',5550,'2022-01-09 12:47:29');
insert into computadora values('Dell' ,'Computadora de Oficina',5780,'2022-01-12 11:34:09');
insert into computadora values('Ideapad' ,'Computadora Gamer',7550,'2022-01-09 12:47:29');
insert into computadora values('Inspiron' ,'Computadora de Oficina',10550,'2022-01-12 11:34:09');
insert into computadora values('Rog Strix' ,'Computadora Gamer',15550,'2022-01-09 12:47:29');

select * from computadora
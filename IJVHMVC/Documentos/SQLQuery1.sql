Create database IJVHDB

use IJVHDB
CREATE TABLE Veterinaria(
id int identity (1,1) primary key,
Nombre varchar(50),
Edad int,
NombreDue�o varchar(60),
MotivoConsulta varchar (150)

)

select * from Veterinaria
CREATE DATABASE tarea1

Use tarea1


CREATE TABLE Ingreso(
Usuario varchar(150), 
contraseña varchar(150),
rol varchar(150)
)

INSERT INTO Ingreso VALUES('Jose','1234J','Secretario')
INSERT INTO Ingreso VALUES('Canelin','1234B','Administrador')
INSERT INTO Ingreso VALUES('Gabo','1234G','cliente')

SELECT *FROM Ingreso

DROP TABLE Ingreso


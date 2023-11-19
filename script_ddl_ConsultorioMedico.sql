﻿-- Creación de la base de datos:
CREATE DATABASE ConsultorioMedico


-- Cración del Login y contraseña para el usuario de la base de datos:
CREATE LOGIN usrConsultorio WITH PASSWORD='consult0rio123',
  DEFAULT_DATABASE = ConsultorioMedico,
  CHECK_EXPIRATION = OFF,
  CHECK_POLICY = ON
GO

USE ConsultorioMedico;
CREATE USER usrConsultorio FOR LOGIN usrConsultorio
GO
ALTER ROLE db_owner ADD MEMBER usrConsultorio
GO

-- Creación de las tablas:
CREATE TABLE Paciente (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  cedulaIdentidad VARCHAR(15) NOT NULL,
  nombres VARCHAR(40) NOT NULL,
  apellidos VARCHAR(40) NOT NULL,
  direccion VARCHAR(100) NOT NULL,
  telefono INT NOT NULL,
  sexo VARCHAR(2) NOT NULL,
  fechaNacimiento DATE NOT NULL,
  usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME(),
  fechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
  estado SMALLINT NOT NULL DEFAULT 1,
);
CREATE TABLE Medico (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  cedulaIdentidad VARCHAR(15) NOT NULL,
  nombres VARCHAR(50) NOT NULL,
  apellidos VARCHAR(50) NOT NULL,
  direccion VARCHAR(200) NOT NULL,
  telefono INT NOT NULL,
  sexo VARCHAR(2) NOT NULL,
  matriculaProfesional VARCHAR(10) NOT NULL,
  fechaNacimiento DATE NOT NULL,
  usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME(),
  fechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
  estado SMALLINT NOT NULL DEFAULT 1
);
CREATE TABLE Cita (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idPaciente INT NOT NULL,
  idMedico INT NOT NULL,
  fechaCita DATE NOT NULL,
  observaciones VARCHAR(200),
  usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME(),
  fechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
  estado SMALLINT NOT NULL DEFAULT 1,
  CONSTRAINT fk_Cita_Paciente FOREIGN KEY(idPaciente) REFERENCES Paciente(id),
  CONSTRAINT fk_Cita_Medico FOREIGN KEY(idMedico) REFERENCES Medico(id)
);
-- Procedimientos almacenados para listar:
CREATE PROC paPacienteListar @parametro VARCHAR(50)
AS
  SELECT id,cedulaIdentidad,nombres,apellidos,direccion,telefono,sexo,fechaNacimiento,usuarioRegistro,fechaRegistro,estado
  FROM Paciente
  WHERE estado<>-1 AND nombres LIKE '%'+REPLACE(@parametro,' ','%')+'%';

CREATE PROC paMedicoListar @parametro VARCHAR(50)
AS
  SELECT id,cedulaIdentidad,nombres,apellidos,direccion,telefono,sexo,matriculaProfesional,fechaNacimiento,usuarioRegistro,fechaRegistro,estado
  FROM Medico
  WHERE estado<>-1 AND nombres LIKE '%'+REPLACE(@parametro,' ','%')+'%';
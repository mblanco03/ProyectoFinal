CREATE DATABASE ClientesDB;
USE ClientesDB;

CREATE TABLE Clientes (
    Id INT PRIMARY KEY,
    Nombres NVARCHAR(100) NOT NULL,
    Apellidos NVARCHAR(100) NOT NULL,
    Genero NVARCHAR(10),
    FechaNacimiento DATE,
    Estado NVARCHAR(50)
);

CREATE TABLE InformacionGeneral (
    Id INT PRIMARY KEY,
    ClienteId INT,
    TipoInformacion NVARCHAR(50),
    FechaCreacion DATETIME DEFAULT GETDATE(),
    FechaActualizacion DATETIME,
    UsuarioCreador NVARCHAR(50),
    Estado NVARCHAR(50),
    FOREIGN KEY (ClienteId) REFERENCES Clientes(Id)
);

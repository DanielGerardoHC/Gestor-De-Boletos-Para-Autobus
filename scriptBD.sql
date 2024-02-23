CREATE DATABASE GestorVentaBoletos;

USE GestorVentaBoletos;

-- Crear una tabla para almacenar información de rutas de transporte
CREATE TABLE Rutas (
    RutaID INT PRIMARY KEY IDENTITY(1,1),
    NombreRuta NVARCHAR(255) NOT NULL,
    Origen NVARCHAR(255) NOT NULL,
    Destino NVARCHAR(255) NOT NULL,
    Precio DECIMAL(10, 2) NOT NULL,
    AsientosDisponibles INT
);

-- Crear una tabla para almacenar información de usuarios
CREATE TABLE Usuarios (
    UsuarioID INT PRIMARY KEY IDENTITY(1,1),
    NombreUsuario NVARCHAR(50) NOT NULL,
    Contraseña NVARCHAR(100) NOT NULL,
    NivelUsuario INT NOT NULL, -- 1 para usuario y 2 para administrador
	NombreCompleto NVARCHAR (200),
	Edad INT, 
	Correo NVARCHAR (200),
);


-- Crear una tabla para almacenar información de compras de boletos
CREATE TABLE Compras (
    CompraID INT PRIMARY KEY IDENTITY(1,1),
    UsuarioID INT NOT NULL,
    RutaID INT NOT NULL,
    FechaCompra DATETIME NOT NULL,
    CantidadAsientos INT NOT NULL,
    TotalCompra DECIMAL(10, 2) NOT NULL,
    AsientosComprados NVARCHAR(MAX), -- Almacenar los nombres de los asientos comprados
    FOREIGN KEY (UsuarioID) REFERENCES Usuarios(UsuarioID),
    FOREIGN KEY (RutaID) REFERENCES Rutas(RutaID)
);

SELECT * FROM Usuarios;

INSERT INTO Usuarios (NombreUsuario, Contraseña, NivelUsuario, NombreCompleto, Edad, Correo) VALUES
('admin', 'admin', 2, 'Daniel Gerardo Hernandez Calderon', 19, 'Admin.NetDeveloper@gmail.com')


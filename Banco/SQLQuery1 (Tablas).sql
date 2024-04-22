CREATE TABLE [dbo].[cliente] (
    [id_cliente] INT IDENTITY(1,1) NOT NULL,
    [a_paterno] NVARCHAR (50) NOT NULL,
    [a_materno] NVARCHAR (50) NULL,
    [nombre] NVARCHAR (50) NOT NULL,
    [edad] INT NOT NULL,
    [correo] NVARCHAR (50) NOT NULL,
    [telefono] NVARCHAR (10) NULL,
    [curp] NVARCHAR (18) NOT NULL,
    [rfc] NVARCHAR (10) NULL,
    [contrasenia] NVARCHAR (8) NOT NULL,
    PRIMARY KEY CLUSTERED ([id_cliente])
);

CREATE TABLE [dbo].[ejecutivo] (
    [id_ejecutivo] INT IDENTITY(1,1) NOT NULL,
    [a_paterno] NVARCHAR (50) NOT NULL,
    [a_materno] NVARCHAR (50) NULL,
    [nombre] NVARCHAR (50) NOT NULL,
    [edad] INT NOT NULL,
    [rfc] NVARCHAR (10) NOT NULL,
    [contrasenia] NVARCHAR (8) NOT NULL,
    PRIMARY KEY CLUSTERED ([id_ejecutivo])
);

CREATE TABLE [dbo].[cuenta] (
    [id_cuenta] INT IDENTITY(1,1) NOT NULL,
    [saldo] DECIMAL(18,2) NOT NULL,
    PRIMARY KEY CLUSTERED ([id_cuenta])
);
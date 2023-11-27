CREATE TABLE [dbo].[usuario] (
    [Id]       INT IDENTITY (1, 1) NOT NULL,
    [RA] CHAR(10) NOT NULL,
    [nome]     VARCHAR (100) NULL,
    [curso] VARCHAR (100) NULL,
    [semestre] INT NULL,
    [senha] CHAR(6) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[sala] (
    [Id]       INT IDENTITY (1, 1) NOT NULL,
    [numero] INT NOT NULL,
    [modalidade] VARCHAR (100) NULL,
    [qtde_pessoas] INT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[reserva] (
    [Id] INT IDENTITY (1, 1) NOT NULL,
    [id_usuario] INT NOT NULL,
    [id_sala] INT NOT NULL,
    [data] DATETIME2  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Usuario_toReserva] FOREIGN KEY ([id_usuario]) REFERENCES [usuario]([Id]),
    CONSTRAINT [FK_Sala_toReserva] FOREIGN KEY ([id_sala]) REFERENCES [sala]([Id])
);



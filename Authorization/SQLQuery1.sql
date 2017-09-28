CREATE TABLE [dbo].[Users] (
    [Id]       BIGINT  IDENTITY (1, 1)   NOT NULL,
    [Name]     NCHAR (20) NOT NULL,
    [Password] NCHAR (15) NOT NULL,
    [Email]    NCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[UsersInfo] (
    [Id]        BIGINT  IDENTITY (1, 1)       NOT NULL,
    [LastName]  NCHAR (20)  NOT NULL,
    [FirstName] NCHAR (50)  NOT NULL,
    [Adres]     NCHAR (150) NULL,
    [Phone]     NCHAR (40)  NULL,
    [Code]      INT         NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

INSERT INTO [Users] ([Name], [Password],  [Email]) VALUES ('Fox','111111',' Fox @mail.by');
INSERT INTO [Users] ([Name], [Password],  [Email]) VALUES ('SunKot','852632','Sun@mail.by');
INSERT INTO [Users] ([Name], [Password],  [Email]) VALUES ('Rulon','Run456','rulon@mail.by');
INSERT INTO [Users] ([Name], [Password],  [Email]) VALUES ('Loput7','qwerty','Loput@mail.by');
INSERT INTO [Users] ([Name], [Password],  [Email]) VALUES ('Rewa','asd444',' Rewa @mail.by');

INSERT INTO [UsersInfo] (LastName, FirstName, Adres,Phone, Code) VALUES ('Liza','Ivanova','Grodno','+37529741235',123565);
INSERT INTO [UsersInfo] (LastName, FirstName, Adres,Phone, Code) VALUES ('Alex','Smirnov','Brest','',34532423);
INSERT INTO [UsersInfo] (LastName, FirstName, Adres,Phone, Code) VALUES ('Vova','Sidorov','','+37529865421',356321);
INSERT INTO [UsersInfo] (LastName, FirstName, Adres,Phone, Code) VALUES ('Inna','Krot','Minsk','',56312365);
INSERT INTO [UsersInfo] (LastName, FirstName, Adres,Phone, Code) VALUES ('Nikolaj','Guk','Minsk','',7865333);
INSERT INTO [UsersInfo] (LastName, FirstName, Adres,Phone, Code) VALUES ('Ivan','Gromov','Minsk','',457445);

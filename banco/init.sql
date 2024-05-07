create table if not exists Usuarios
(
    Id    int auto_increment primary key,
    Nome  varchar(255) not null,
    Email varchar(255) not null
);

create table if not exists Permissaos
(
    Id        int auto_increment primary key,
    Descricao varchar(255) not null,
    UsuarioId int          null,
    constraint FK_Permissaos_Usuarios_UsuarioId
        foreign key (UsuarioId) references Usuarios (Id)
);

create index IX_Permissaos_UsuarioId
    on Permissaos (UsuarioId);

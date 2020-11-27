USE RoleWebApp;
GO

CREATE SCHEMA RWA;
GO



CREATE TABLE RWA.TipoPermiso
(
	Id INT IDENTITY PRIMARY KEY,
	Descripcion VARCHAR(150) NOT NULL
);

CREATE TABLE RWA.Permiso
(
	Id INT IDENTITY PRIMARY KEY,
	NombreEmpleado VARCHAR(50) NOT NULL,
	ApellidosEmpleado VARCHAR(60) NOT NULL,
	TipoPermiso INT NOT NULL FOREIGN KEY REFERENCES RWA.TipoPermiso(Id),
	FechaPermiso Date NOT NULL,
);

insert into RWA.TipoPermiso (Descripcion) values ('Permiso General');
insert into RWA.TipoPermiso (Descripcion) values ('Maternidad');
insert into RWA.TipoPermiso (Descripcion) values ('Enfermedad');
insert into RWA.TipoPermiso (Descripcion) values ('Viaje importante');
insert into RWA.TipoPermiso (Descripcion) values ('Luto');

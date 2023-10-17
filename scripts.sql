Create TABLE tbl_Usuario(
	Id int identity primary key,
	Usuario varchar(100) not null,
	Senha varchar(100) not null,
	Nome varchar(100) not null,
	Email varchar(100) not null,
	Ativo BIT not null,
	Administrador BIT
)

select * from tbl_Usuario

ALTER PROCEDURE usp_ValidarUsuario
(
	@Usuario varchar(100),
	@Senha varchar(100)
)
AS
BEGIN
	SELECT 
		Id,
		Usuario,
		Nome,
		Email,
		Ativo,
		Administrador
	FROM tbl_Usuario WHERE Usuario = @Usuario AND Senha = @Senha
END

insert into tbl_usuario select 'kelvin','3244185981728979115075721453575112','Kelvin Santos da Rocha','kelvinsantosdarocha@gmail.com',1,1
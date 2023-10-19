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

--insert into tbl_usuario select 'kelvin','3244185981728979115075721453575112','Kelvin Santos da Rocha','kelvinsantosdarocha@gmail.com',1,1

create table tbl_Cliente
(
	Id int identity primary key,
	Nome varchar(100) not null,
	Email varchar(100) not null,
	Telefone varchar(20) not null,
	Celular varchar(20) not null,
	RG varchar(30) UNIQUE not null,
	CPF varchar(30) UNIQUE not null,
	CEP varchar(20),
	Endereco varchar(100),
	Complemento varchar(100),
	Bairro varchar(100),
	Numero int,
	Cidade varchar(100),
	Estado varchar(40)
)

CREATE PROCEDURE usp_InserirCliente
(
	@ID INT = NULL,
	@Nome varchar(100),
	@RG varchar(30),
	@CPF varchar(30),
	@Email varchar(100),
	@Telefone varchar(20),
	@Celular varchar(20),
	@CEP varchar(20) = NULL,
	@Endereco varchar(100) = NULL,
	@Numero INT = NULL,
	@Complemento varchar(100) = NULL,
	@Bairro varchar(100) = NULL,
	@Cidade varchar(100) = NULL,
	@Estado varchar(40) = NULL
)
AS
BEGIN
	
	IF EXISTS (SELECT 1 FROM tbl_Cliente where Id = @ID)
		BEGIN
			UPDATE
				tbl_Cliente
			SET
				Nome = @Nome,
				Email = @Email,
				Telefone = @Telefone,
				Celular = @Celular,
				RG = @RG,
				CPF = @CPF,
				CEP = @CEP,
				Endereco = @Endereco,
				Complemento = @Complemento,
				Bairro = @Bairro,
				Numero = @Numero,
				Cidade = @Cidade,
				Estado = @Estado
			WHERE
				Id = @ID
		END

	ELSE
		BEGIN
			INSERT INTO
				tbl_Cliente
			(
				Nome,
				Email,
				Telefone,
				Celular,
				RG,
				CPF,
				CEP,
				Endereco,
				Complemento,
				Bairro,
				Numero,
				Cidade,
				Estado
			)
			VALUES
			(
				@Nome,
				@Email,
				@Telefone,
				@Celular,
				@RG,
				@CPF,
				@CEP,
				@Endereco,
				@Complemento,
				@Bairro,
				@Numero,
				@Cidade,
				@Estado
			)
		END
END

CREATE PROCEDURE usp_ListarClientes
(
	@Nome varchar(100) = NULL
)
AS
BEGIN
	
	IF (@Nome IS NOT NULL)
		BEGIN
			SELECT 
				*
			FROM 
				tbl_Cliente 
			WHERE 
				Nome like @Nome
		END
	ELSE
		BEGIN
			SELECT
				*
			FROM
				tbl_Cliente
		END
END

CREATE PROCEDURE usp_SelecionarCliente
(
	@CPF varchar(100) = NULL
)
AS
BEGIN

	SELECT
		*
	FROM
		tbl_Cliente
	WHERE
		CPF = ISNULL(@CPF,cpf)

END

CREATE PROCEDURE usp_ExcluirCliente
(
	@ID INT
)
AS
BEGIN

	DELETE FROM
		tbl_Cliente
	WHERE
		Id = @ID

END

select * from tbl_Cliente
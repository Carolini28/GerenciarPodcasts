
CREATE TABLE dbo.Episodios(
	Id int IDENTITY(1,1) NOT NULL,
	Nome nvarchar(100) NOT NULL,
	CodigoAutor int NOT NULL,
	CodigoCategoria int NOT NULL,
	NomeDoAudio nvarchar(250) NOT NULL
)

CREATE TABLE dbo.Categorias(
	CodigoCategoria int IDENTITY(1,1) NOT NULL,
	NomeCategoria nvarchar(100) NOT NULL
)

CREATE TABLE dbo.Autores(
	CodigoAutor int IDENTITY(1,1) NOT NULL,
	NomeAutor nvarchar(100) NOT NULL,
	ProfissaoDoAutor nvarchar(100) NOT NULL,
	Imagem nvarchar(250) NULL
)

select * from dbo.Categorias;

select * from dbo.Autores;

select * from dbo.Episodios;
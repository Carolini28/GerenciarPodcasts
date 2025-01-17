USE [GerenciarPodcast]
GO
/****** Object:  Table [dbo].[Autores]    Script Date: 16/11/2020 22:53:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Autores](
	[CodigoAutor] [int] IDENTITY(1,1) NOT NULL,
	[NomeAutor] [nvarchar](100) NOT NULL,
	[ProfissaoDoAutor] [nvarchar](100) NOT NULL,
	[Imagem] [nvarchar](250) NULL,
 CONSTRAINT [PK_Autores] PRIMARY KEY CLUSTERED 
(
	[CodigoAutor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 16/11/2020 22:53:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[CodigoCategoria] [int] IDENTITY(1,1) NOT NULL,
	[NomeCategoria] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Categorias] PRIMARY KEY CLUSTERED 
(
	[CodigoCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Episodios]    Script Date: 16/11/2020 22:53:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Episodios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](100) NOT NULL,
	[CodigoAutor] [int] NOT NULL,
	[CodigoCategoria] [int] NOT NULL,
	[NomeDoAudio] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Episodios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Episodios]  WITH CHECK ADD  CONSTRAINT [FK_Episodios_Autores] FOREIGN KEY([CodigoAutor])
REFERENCES [dbo].[Autores] ([CodigoAutor])
GO
ALTER TABLE [dbo].[Episodios] CHECK CONSTRAINT [FK_Episodios_Autores]
GO
ALTER TABLE [dbo].[Episodios]  WITH CHECK ADD  CONSTRAINT [FK_Episodios_Categorias] FOREIGN KEY([CodigoCategoria])
REFERENCES [dbo].[Categorias] ([CodigoCategoria])
GO
ALTER TABLE [dbo].[Episodios] CHECK CONSTRAINT [FK_Episodios_Categorias]
GO

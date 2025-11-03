CREATE TABLE [dbo].[Aluno](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Matricula] [varchar](50) NOT NULL,
	[DataNascimento] [date] NOT NULL,
	[Cpf] [varchar](14) NOT NULL,
	[Cep] [varchar](10) NOT NULL,
	[Endereco] [varchar](50) NOT NULL,
	[Bairro] [varchar](50) NOT NULL,
	[Cidade] [varchar](50) NOT NULL,
	[Numero] [varchar](10) NOT NULL,
	[IdTurma] [int] NULL
) ON [PRIMARY]

CREATE TABLE [dbo].[Turma](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[DataIni] [date] NULL,
	[DataFim] [date] NULL
) ON [PRIMARY]

CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Senha] [varchar](50) NOT NULL,
	[Perfil] [varchar](40) NULL
) ON [PRIMARY]

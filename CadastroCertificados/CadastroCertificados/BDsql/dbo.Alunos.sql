CREATE TABLE [dbo].[Alunos] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [NomeAluno] NVARCHAR (MAX) NOT NULL,
    [Curso]     NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Alunos] PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[Certificados] (
    [Id]                INT            IDENTITY (1, 1) NOT NULL,
    [NomeCertificado]   NVARCHAR (MAX) NOT NULL,
    [AlunoId]           INT            NOT NULL,
    [TipoCertificado]   NVARCHAR (MAX) NOT NULL,
    [TempoCertificado]  INT           NOT NULL,
    [LinkCertificado]   NVARCHAR (MAX) NOT NULL,
    [StatusCertificado] NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Certificados] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Certificados_Alunos_AlunoId] FOREIGN KEY ([AlunoId]) REFERENCES [dbo].[Alunos] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Certificados_AlunoId]
    ON [dbo].[Certificados]([AlunoId] ASC);


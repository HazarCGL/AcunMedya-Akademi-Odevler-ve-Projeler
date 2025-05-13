CREATE TABLE [dbo].[Doktorlar] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [DoktorAdi]    NVARCHAR (100) NOT NULL,
    [DoktorSoyadi] NVARCHAR (100) NOT NULL,
    [BransID]      INT            NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([BransID]) REFERENCES [dbo].[Branslar] ([Id])
);


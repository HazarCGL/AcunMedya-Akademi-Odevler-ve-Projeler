CREATE TABLE [dbo].[Randevular] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [HastaAdi]    NVARCHAR (100) NOT NULL,
    [HastaSoyadi] NVARCHAR (100) NOT NULL,
    [BransID]     INT            NULL,
    [DoktorID]    INT            NULL,
    [Tarih]       DATETIME       NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([BransID]) REFERENCES [dbo].[Branslar] ([Id]),
    FOREIGN KEY ([DoktorID]) REFERENCES [dbo].[Doktorlar] ([Id])
);


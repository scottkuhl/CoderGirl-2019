CREATE TABLE [dbo].[Cheeses] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [Description] NVARCHAR (MAX) NULL,
    [Name]        NVARCHAR (MAX) NULL,
    [CategoryID]  INT            NOT NULL,
    [Taste] NVARCHAR(MAX) NULL, 
    CONSTRAINT [PK_Cheeses] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Cheeses_Categories_CategoryID] FOREIGN KEY ([CategoryID]) REFERENCES [dbo].[Categories] ([ID]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Cheeses_CategoryID]
    ON [dbo].[Cheeses]([CategoryID] ASC);


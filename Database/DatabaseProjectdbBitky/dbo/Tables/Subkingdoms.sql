CREATE TABLE [dbo].[Subkingdoms] (
    [SubkingdomID]      INT            IDENTITY (1, 1) NOT NULL,
    [SubkingdomNameLat] NVARCHAR (100) NULL,
    [SubkingdomNameTr]  NVARCHAR (100) NULL,
    [SubkingdomNameEn]  NVARCHAR (100) NULL
);
GO

ALTER TABLE [dbo].[Subkingdoms]
    ADD CONSTRAINT [PK_Subkingdoms] PRIMARY KEY CLUSTERED ([SubkingdomID] ASC);
GO


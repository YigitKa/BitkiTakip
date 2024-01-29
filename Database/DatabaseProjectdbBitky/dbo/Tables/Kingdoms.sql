CREATE TABLE [dbo].[Kingdoms] (
    [KingdomID]      INT            IDENTITY (1, 1) NOT NULL,
    [KingdomNameLat] NVARCHAR (100) NULL,
    [KingdomNameTr]  NVARCHAR (100) NULL,
    [KingdomNameEn]  NVARCHAR (100) NULL,
    CONSTRAINT [PK_Kingdoms] PRIMARY KEY CLUSTERED ([KingdomID] ASC)
);


GO


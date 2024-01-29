CREATE TABLE [dbo].[Divisions] (
    [DivisionID]      INT            IDENTITY (1, 1) NOT NULL,
    [DivisionNameLat] NVARCHAR (100) NULL,
    [DivisionNameTr]  NVARCHAR (100) NULL,
    [DivisionNameEn]  NVARCHAR (100) NULL,
    CONSTRAINT [PK_Divisions] PRIMARY KEY CLUSTERED ([DivisionID] ASC)
);


GO


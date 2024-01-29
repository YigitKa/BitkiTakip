CREATE TABLE [dbo].[Species] (
    [SpeciyID]      INT            IDENTITY (1, 1) NOT NULL,
    [SpeciyNameLat] NVARCHAR (100) NULL,
    [SpeciyNameTr]  NVARCHAR (100) NULL,
    [SpeciyNameEn]  NVARCHAR (100) NULL,
    CONSTRAINT [PK_Species] PRIMARY KEY CLUSTERED ([SpeciyID] ASC)
);


GO


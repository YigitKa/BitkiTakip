CREATE TABLE [dbo].[Classes] (
    [ClassID]      INT            IDENTITY (1, 1) NOT NULL,
    [ClassNameLat] NVARCHAR (100) NULL,
    [ClassNameTr]  NVARCHAR (100) NULL,
    [ClassNameEn]  NVARCHAR (100) NULL,
    CONSTRAINT [PK_Classes] PRIMARY KEY CLUSTERED ([ClassID] ASC)
);


GO


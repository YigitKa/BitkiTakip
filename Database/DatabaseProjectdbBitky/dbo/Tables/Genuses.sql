CREATE TABLE [dbo].[Genuses] (
    [GenusID]      INT            IDENTITY (1, 1) NOT NULL,
    [GenusNameLat] NVARCHAR (100) NULL,
    [GenusNameTr]  NVARCHAR (100) NULL,
    [GenusNameEn]  NVARCHAR (100) NULL,
    CONSTRAINT [PK_Genuses] PRIMARY KEY CLUSTERED ([GenusID] ASC)
);


GO


CREATE TABLE [dbo].[Names] (
    [NameID]     INT            IDENTITY (1, 1) NOT NULL,
    [NameLat]    NVARCHAR (100) NULL,
    [NameTr]     NVARCHAR (100) NULL,
    [NameEn]     NVARCHAR (100) NULL,
    [NameCommon] NVARCHAR (100) NULL,
    CONSTRAINT [PK_Names] PRIMARY KEY CLUSTERED ([NameID] ASC)
);


GO


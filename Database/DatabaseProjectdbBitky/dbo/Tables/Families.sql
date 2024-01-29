CREATE TABLE [dbo].[Families] (
    [FamilyID]      INT            IDENTITY (1, 1) NOT NULL,
    [FamilyNameLat] NVARCHAR (100) NULL,
    [FamilyNameTr]  NVARCHAR (100) NULL,
    [FamilyNameEn]  NVARCHAR (100) NULL,
    CONSTRAINT [PK_Families] PRIMARY KEY CLUSTERED ([FamilyID] ASC)
);


GO


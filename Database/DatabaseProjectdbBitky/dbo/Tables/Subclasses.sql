CREATE TABLE [dbo].[Subclasses] (
    [SubclassID]      INT            IDENTITY (1, 1) NOT NULL,
    [SubclassNameLat] NVARCHAR (100) NULL,
    [SubclassNameTr]  NVARCHAR (100) NULL,
    [SubclassNameEn]  NVARCHAR (100) NULL,
    CONSTRAINT [PK_Subclasses] PRIMARY KEY CLUSTERED ([SubclassID] ASC)
);


GO


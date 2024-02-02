CREATE TABLE [dbo].[PlantPhotos] (
    [PhotoID]   INT            IDENTITY (1, 1) NOT NULL,
    [PlantID]   INT            NOT NULL,
    [PhotoPath] NVARCHAR (250) NOT NULL
);
GO

ALTER TABLE [dbo].[PlantPhotos]
    ADD CONSTRAINT [PK_PlantPhotos] PRIMARY KEY CLUSTERED ([PhotoID] ASC);
GO


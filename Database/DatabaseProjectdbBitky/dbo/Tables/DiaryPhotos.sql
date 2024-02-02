CREATE TABLE [dbo].[DiaryPhotos] (
    [DiaryPhotoID]  INT            IDENTITY (1, 1) NOT NULL,
    [UserDiaryID]   INT            NOT NULL,
    [PhotoPath]     NVARCHAR (250) NOT NULL,
    [InsertionDate] DATETIME       NOT NULL
);
GO

ALTER TABLE [dbo].[DiaryPhotos]
    ADD CONSTRAINT [PK_DiaryPhotos] PRIMARY KEY CLUSTERED ([DiaryPhotoID] ASC);
GO

ALTER TABLE [dbo].[DiaryPhotos]
    ADD CONSTRAINT [DEFAULT_DiaryPhotos_InsertionDate] DEFAULT (getdate()) FOR [InsertionDate];
GO


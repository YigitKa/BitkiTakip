CREATE TABLE [dbo].[UserDiary] (
    [DiaryID] INT IDENTITY (1, 1) NOT NULL,
    [UserID]  INT NOT NULL,
    [PlantID] INT NOT NULL
);
GO

ALTER TABLE [dbo].[UserDiary]
    ADD CONSTRAINT [PK_UserDiary] PRIMARY KEY CLUSTERED ([DiaryID] ASC);
GO


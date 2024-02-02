CREATE TABLE [dbo].[Users] (
    [UserID]       INT            IDENTITY (1, 1) NOT NULL,
    [Username]     NVARCHAR (100) NOT NULL,
    [RegisterType] INT            NOT NULL,
    [RegisterDate] DATETIME       NOT NULL,
    [UpdateDate]   DATETIME       NOT NULL
);
GO

ALTER TABLE [dbo].[Users]
    ADD CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([UserID] ASC);
GO

ALTER TABLE [dbo].[Users]
    ADD CONSTRAINT [DEFAULT_Users_RegisterDate] DEFAULT (getdate()) FOR [RegisterDate];
GO

ALTER TABLE [dbo].[Users]
    ADD CONSTRAINT [DEFAULT_Users_UpdateDate] DEFAULT (getdate()) FOR [UpdateDate];
GO


CREATE TABLE [dbo].[Plants] (
    [PlantID]      INT IDENTITY (1, 1) NOT NULL,
    [NameID]       INT NOT NULL,
    [KingdomID]    INT NOT NULL,
    [SubkingdomID] INT NOT NULL,
    [DivisionID]   INT NOT NULL,
    [ClassID]      INT NOT NULL,
    [SubclassID]   INT NOT NULL,
    [OrderID]      INT NOT NULL,
    [FamilyID]     INT NOT NULL,
    [GenusID]      INT NOT NULL,
    [SpeciesID]    INT NOT NULL,
    CONSTRAINT [PK_Plants] PRIMARY KEY CLUSTERED ([PlantID] ASC),
    CONSTRAINT [FK_Plants_Classes] FOREIGN KEY ([ClassID]) REFERENCES [dbo].[Classes] ([ClassID]),
    CONSTRAINT [FK_Plants_Kingdoms] FOREIGN KEY ([KingdomID]) REFERENCES [dbo].[Kingdoms] ([KingdomID])
);


GO


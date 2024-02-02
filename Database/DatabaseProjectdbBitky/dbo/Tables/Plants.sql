CREATE TABLE [dbo].[Plants] (
    [PlantID]       INT             IDENTITY (1, 1) NOT NULL,
    [NameID]        INT             NOT NULL,
    [KingdomID]     INT             NOT NULL,
    [SubkingdomID]  INT             NOT NULL,
    [DivisionID]    INT             NOT NULL,
    [ClassID]       INT             NOT NULL,
    [SubclassID]    INT             NOT NULL,
    [OrderID]       INT             NOT NULL,
    [FamilyID]      INT             NOT NULL,
    [GenusID]       INT             NOT NULL,
    [SpeciesID]     INT             NOT NULL,
    [Tags]          NVARCHAR (1024) NULL,
    [Water]         NVARCHAR (256)  NULL,
    [Fertilize]     NVARCHAR (256)  NULL,
    [Repot]         NVARCHAR (256)  NULL,
    [Overview]      NVARCHAR (3072) NULL,
    [Toxic]         BIT             CONSTRAINT [DEFAULT_Plants_Toxic] DEFAULT ((0)) NOT NULL,
    [Type]          NVARCHAR (256)  NULL,
    [MatureSize]    NVARCHAR (256)  NULL,
    [SunExposure]   NVARCHAR (256)  NULL,
    [SoilType]      NVARCHAR (256)  NULL,
    [SoilpH]        NVARCHAR (256)  NULL,
    [BloomTime]     NVARCHAR (256)  NULL,
    [NativeArea]    NVARCHAR (256)  NULL,
    [HowToGrow]     NVARCHAR (3072) NULL,
    [Propagation]   NVARCHAR (3072) NULL,
    [PestsDiseases] NVARCHAR (1024) NULL,
    CONSTRAINT [PK_Plants] PRIMARY KEY CLUSTERED ([PlantID] ASC),
    CONSTRAINT [FK_Plants_Classes] FOREIGN KEY ([ClassID]) REFERENCES [dbo].[Classes] ([ClassID]),
    CONSTRAINT [FK_Plants_Kingdoms] FOREIGN KEY ([KingdomID]) REFERENCES [dbo].[Kingdoms] ([KingdomID])
);


GO


ALTER TABLE [dbo].[Plants]
    ADD CONSTRAINT [DEFAULT_Plants_Toxic] DEFAULT ((0)) FOR [Toxic];
GO


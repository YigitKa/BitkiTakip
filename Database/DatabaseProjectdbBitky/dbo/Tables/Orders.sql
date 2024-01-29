CREATE TABLE [dbo].[Orders] (
    [OrderID]      INT            IDENTITY (1, 1) NOT NULL,
    [OrderNameLat] NVARCHAR (100) NULL,
    [OrderNameTr]  NVARCHAR (100) NULL,
    [OrderNameEn]  NVARCHAR (100) NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED ([OrderID] ASC)
);


GO


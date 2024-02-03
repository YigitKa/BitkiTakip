CREATE VIEW vw_PlantDetails
AS
SELECT  
    Plants.*,
    Classes.ClassNameEn, Classes.ClassNameLat, Classes.ClassNameTr,  
    Divisions.DivisionNameEn, Divisions.DivisionNameLat, Divisions.DivisionNameTr,  
    Families.FamilyNameEn, Families.FamilyNameLat, Families.FamilyNameTr,  
    Genuses.GenusNameEn, Genuses.GenusNameLat, Genuses.GenusNameTr,  
    Kingdoms.KingdomNameEn, Kingdoms.KingdomNameLat, KingdomNameTr,  
    Names.NameCommon, Names.NameEn, Names.NameLat, Names.NameTr,  
    Orders.OrderNameEn, Orders.OrderNameLat, Orders.OrderNameTr,  
    Species.SpeciyNameEn, Species.SpeciyNameLat, Species.SpeciyNameTr,  
    Subclasses.SubclassNameEn, Subclasses.SubclassNameLat, Subclasses.SubclassNameTr 
FROM Plants  
INNER JOIN Classes ON Classes.ClassID = Plants.ClassID 
INNER JOIN Divisions ON Divisions.DivisionID = Plants.DivisionID 
INNER JOIN Families ON Families.FamilyID = Plants.FamilyID 
INNER JOIN Genuses ON Genuses.GenusID = Plants.GenusID 
INNER JOIN Kingdoms ON Kingdoms.KingdomID = Plants.KingdomID 
INNER JOIN [Names] ON [Names].NameID = Plants.NameID 
INNER JOIN Orders ON Orders.OrderID = Plants.OrderID 
INNER JOIN Species ON Species.SpeciyID = Plants.SpeciesID 
INNER JOIN Subclasses ON Subclasses.SubclassID = Plants.SubclassID;
GO


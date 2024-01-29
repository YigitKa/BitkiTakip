using System;
namespace Bitky_API.DTOs.PlantDTOs
{
    /*
     * TODO: Silmeyi unutma
	[KingdomID]    INT NOT NULL,
    [SubkingdomID] INT NOT NULL,
    [DivisionID]   INT NOT NULL,
    [ClassID]      INT NOT NULL,
    [SubclassID]   INT NOT NULL,
    [OrderID]      INT NOT NULL,
    [FamilyID]     INT NOT NULL,
    [GenusID]      INT NOT NULL,
    [SpeciesID]    INT NOT NULL,

    Classes.ClassNameEn, Classes.ClassNameLat, Classes.ClassNameTr, 
        Divisions.DivisionNameEn, Divisions.DivisionNameLat, Divisions.DivisionNameTr, 
        Families.FamilyNameEn, Families.FamilyNameLat, Families.FamilyNameTr, 
        Genuses.GenusNameEn, Genuses.GenusNameLat, Genuses.GenusNameTr, 
        Kingdoms.KingdomNameEn, Kingdoms.KingdomNameLat, KingdomNameTr, 
        Names.NameCommon,[Names].NameEn, Names.NameLat, [Names].NameTr, 
        Orders.OrderNameEn, Orders.OrderNameLat, Orders.OrderNameTr, 
        Species.SpeciyNameEn, Species.SpeciyNameLat, Species.SpeciyNameTr, 
        Subclasses.SubclassNameEn, Subclasses.SubclassNameLat, Subclasses.SubclassNameTr
	*/

    public class ResultPlantDTO
	{
		public int PlantID { get; set; }
		public int NameID { get; set; }
        public int KingdomID { get; set; }
        public int SubkingdomID { get; set; }
        public int DivisionID { get; set; }
        public int ClassID { get; set; }
        public int SubclassID { get; set; }
        public int OrderID { get; set; }
        public int FamilyID { get; set; }
        public int GenusID { get; set; }
        public int SpeciesID { get; set; }

        public string NameCommon { get; set; }
        public string NameEn { get; set; }
        public string NameLat { get; set; }
        public string NameTr { get; set; }

        public string KingdomEn { get; set; }
        public string KingdomLat { get; set; }
        public string KingdomTr { get; set; }

        public string SubkingdomEn { get; set; }
        public string SubkingdomLat { get; set; }
        public string SubkingdomTr { get; set; }

        public string DivisionEn { get; set; }
        public string DivisionLat { get; set; }
        public string DivisionTr { get; set; }

        public string ClassNameEn { get; set; }
        public string ClassNameLat { get; set; }
        public string ClassNameTr { get; set; }

        public string SubclassEn { get; set; }
        public string SubclassLat { get; set; }
        public string SubclassTr { get; set; }

        public string OrderEn { get; set; }
        public string OrderLat { get; set; }
        public string OrderTr { get; set; }

        public string FamilyEn { get; set; }
        public string FamilyLat { get; set; }
        public string FamilyTr { get; set; }

        public string GenusEn { get; set; }
        public string GenusLat { get; set; }
        public string GenusTr { get; set; }

        public string SpeciyNameEn { get; set; }
        public string SpeciyNameLat { get; set; }
        public string SpeciyNameTr { get; set; }
    }
}


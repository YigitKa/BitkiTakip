﻿using System;
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

        public string KingdomNameEn { get; set; }
        public string KingdomNameLat { get; set; }
        public string KingdomNameTr { get; set; }

        public string SubkingdomNameEn { get; set; }
        public string SubkingdomNameLat { get; set; }
        public string SubkingdomNameTr { get; set; }

        public string DivisionNameEn { get; set; }
        public string DivisionNameLat { get; set; }
        public string DivisionNameTr { get; set; }

        public string ClassNameEn { get; set; }
        public string ClassNameLat { get; set; }
        public string ClassNameTr { get; set; }

        public string SubclassNameEn { get; set; }
        public string SubclassNameLat { get; set; }
        public string SubclassNameTr { get; set; }

        public string OrderNameEn { get; set; }
        public string OrderNameLat { get; set; }
        public string OrderNameTr { get; set; }

        public string FamilyNameEn { get; set; }
        public string FamilyNameLat { get; set; }
        public string FamilyNameTr { get; set; }

        public string GenusNameEn { get; set; }
        public string GenusNameLat { get; set; }
        public string GenusNameTr { get; set; }

        public string SpeciyNameEn { get; set; }
        public string SpeciyNameLat { get; set; }
        public string SpeciyNameTr { get; set; }
    }
}


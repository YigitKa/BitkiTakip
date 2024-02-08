﻿using System;
namespace Bitky_WebApp.DTOs.PlantDTOs
{
	public class UpdatePlantDTO
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
    }
}


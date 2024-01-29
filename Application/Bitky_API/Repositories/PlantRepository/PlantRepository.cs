using System;
using Bitky_API.DTOs.PlantDTOs;
using Bitky_API.Models.DapperContext;
using Dapper;

namespace Bitky_API.Repositories.PlantRepository
{
	public class PlantRepository : IPlantRepository
	{
        private readonly Context _context;
		public PlantRepository(Context context)
		{
            _context = context;
		}

        public async Task<List<ResultPlantDTO>> GetAllPlantsAsync()
        {
            // TODO: view ya da prosedür yap.
            string query = "SELECT  Plants.*," +
                "        Classes.ClassNameEn, Classes.ClassNameLat, Classes.ClassNameTr, " +
                "        Divisions.DivisionNameEn, Divisions.DivisionNameLat, Divisions.DivisionNameTr, " +
                "        Families.FamilyNameEn, Families.FamilyNameLat, Families.FamilyNameTr, " +
                "        Genuses.GenusNameEn, Genuses.GenusNameLat, Genuses.GenusNameTr, " +
                "        Kingdoms.KingdomNameEn, Kingdoms.KingdomNameLat, KingdomNameTr, " +
                "        Names.NameCommon,[Names].NameEn, Names.NameLat, [Names].NameTr, " +
                "        Orders.OrderNameEn, Orders.OrderNameLat, Orders.OrderNameTr, " +
                "        Species.SpeciyNameEn, Species.SpeciyNameLat, Species.SpeciyNameTr, " +
                "        Subclasses.SubclassNameEn, Subclasses.SubclassNameLat, Subclasses.SubclassNameTr" +
                " FROM Plants " +
                "            INNER JOIN Classes ON Classes.ClassID = Plants.ClassID" +
                "            INNER JOIN Divisions ON Divisions.DivisionID = Plants.DivisionID" +
                "            INNER JOIN Families ON Families.FamilyID = Plants.FamilyID" +
                "            INNER JOIN Genuses ON Genuses.GenusID = Plants.GenusID" +
                "            INNER JOIN Kingdoms ON Kingdoms.KingdomID = Plants.KingdomID" +
                "            INNER JOIN [Names] ON [Names].NameID = Plants.NameID" +
                "            INNER JOIN Orders ON Orders.OrderID = Plants.OrderID" +
                "            INNER JOIN Species ON Species.SpeciyID = Plants.SpeciesID" +
                "            INNER JOIN Subclasses ON Subclasses.SubclassID = Plants.SubclassID" +
                "";

            using (var con = _context.ConnectSQL())
            {
                var values = await con.QueryAsync<ResultPlantDTO>(query);
                return values.ToList();
            }
        }
    }
}


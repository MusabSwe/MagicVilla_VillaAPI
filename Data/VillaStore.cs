using MagicVilla_VillaAPI.Models.dto;

namespace MagicVilla_VillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> VillaList = new List<VillaDTO>
            {
                new VillaDTO { Id = 1, Name= "Pool View",Occupancy = 11,Sqft = 22},
                new VillaDTO { Id = 2, Name = "Beach View",Occupancy = 24, Sqft = 56}
            };
    }
}

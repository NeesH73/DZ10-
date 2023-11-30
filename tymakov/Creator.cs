using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tymakov11
{
    public static class Creator
    {
        private static Dictionary<int, Builder> buildingsDictionary = new Dictionary<int, Builder>();
        public static Dictionary<int, Builder> BuildingsDictionary
        {
            get
            {
                return buildingsDictionary;
            }
        }
        public static int CreateBuilder(double height, int count_floors, int count_flats, int count_entrance)
        {
            Builder builder = new Builder(height, count_floors, count_flats, count_entrance);
            buildingsDictionary.Add(builder.IdBuilding, builder);
            return builder.IdBuilding;
        }
        public static int CreateBuilder(double height,int count_floors)
        {
            Builder builder = new Builder(height, count_floors);
            buildingsDictionary.Add(builder.IdBuilding, builder);
            return builder.IdBuilding;
        }
        public static int CreateBuilder()
        {
            Builder builder = new Builder();
            buildingsDictionary.Add(builder.IdBuilding, builder);
            return builder.IdBuilding;
        }
        public static void RemoveBuilder(int IdBuilding)
        {
            buildingsDictionary.Remove(IdBuilding);
        }


    }
}

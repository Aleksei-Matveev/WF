using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop
{
    public static class FuelRepository
    {
        public static List<FuelInfo> GetFuels()
        {
            return new List<FuelInfo>()
            {
                new FuelInfo(){Name="АИ-92", Price=1132},
                new FuelInfo(){Name="АИ-95", Price=1444},
                new FuelInfo(){Name="АИ-98", Price=1564},
                new FuelInfo(){Name="Дизель",Price=1536}
            };
        }

    }
}

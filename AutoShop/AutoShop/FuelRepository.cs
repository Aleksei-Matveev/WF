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
                new FuelInfo(){Name="АИ-92", Price=11325},
                new FuelInfo(){Name="АИ-95", Price=14445},
                new FuelInfo(){Name="АИ-98", Price=15643},
                new FuelInfo(){Name="Дизель",Price=15365}
            };
        }

    }
}

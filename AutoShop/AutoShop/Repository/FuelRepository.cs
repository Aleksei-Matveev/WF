using Shop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Repository
{
    public static class FuelRepository
    {
        public static List<FuelInfo> GetFuels()
        {
            return new List<FuelInfo>()
            {
                new FuelInfo(){Name="АИ-92", Price=1.32m},
                new FuelInfo(){Name="АИ-95", Price=1.44m},
                new FuelInfo(){Name="АИ-98", Price=1.56m},
            };
        }

    }
}

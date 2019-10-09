using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class SortByPricePerHour : ISort
    {
        public void Sort(ref List<Vehicle> vehicles, bool descending)
        {
            vehicles = descending ? vehicles.OrderByDescending(v => v.PricePerHour).ToList() : vehicles.OrderBy(v => v.PricePerHour).ToList();
            Console.WriteLine("List was sorted by price per hour");
        }
    }
}

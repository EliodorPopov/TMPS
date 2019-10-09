using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class SortByManufacturer : ISort
    {
        public void Sort(ref List<Vehicle> vehicles, bool descending)
        {
            vehicles = descending ? vehicles.OrderByDescending(v => v.Manufacturer).ToList() : vehicles.OrderBy(v => v.Manufacturer).ToList();
            Console.WriteLine("List was sorted by manufacturer");
        }
    }
}

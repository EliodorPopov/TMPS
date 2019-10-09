using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class SortByModelName : ISort
    {
        public void Sort(ref List<Vehicle> vehicles, bool descending)
        {
            vehicles = descending ? vehicles.OrderByDescending(v => v.Model).ToList() : vehicles.OrderBy(v => v.Model).ToList();
            Console.WriteLine("List was sorted by model");
        }
    }
}

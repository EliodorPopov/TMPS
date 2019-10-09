using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class SortByMaxSpeed : ISort
    {
        public void Sort(ref List<Vehicle> vehicles, bool descending)
        {
            vehicles = descending ? vehicles.OrderByDescending(v => v.MaxSpeed).ToList() : vehicles.OrderBy(v => v.MaxSpeed).ToList();
            Console.WriteLine("List was sorted by maximum speed");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public interface ISort
    {
        void Sort(ref List<Vehicle> vehicles, bool descending = false);
    }
}

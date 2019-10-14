using System;
using System.Collections.Generic;

namespace Patterns
{
    public sealed class Database
    {
        private static readonly Lazy<Database> lazy = new Lazy<Database>(() => new Database(), true);
        public static Database db { get { return lazy.Value; } }
        public List<Vehicle> cars { private set; get; }
        private Database()
        {
            cars = new List<Vehicle>();
        }

        public void IncreasePrice(float percent)
        {
            if (percent <= 0)
            {
                throw new Exception("No can't do");
            }
            cars.ForEach(c =>
            {
                c.PricePerHour += c.PricePerHour * percent;
            });
        }



    }
}

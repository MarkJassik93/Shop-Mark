using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models.Car
{
    public class CarListItem
    {
        public Guid? Id { get; set; }
        public string Mudel { get; set; }
        public string Seeria { get; set; }
        public double Hind { get; set; }
        public double Kaal { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}

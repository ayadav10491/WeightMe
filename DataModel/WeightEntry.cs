using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightMe.DataModel
{
    public class WeightEntry
    {
        public int Id { get; set; }
        public DateTime EntryDate { get; set; }
        public double Weight { get; set; }
    }
}

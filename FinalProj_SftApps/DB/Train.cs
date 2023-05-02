using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProj_SftApps.DB
{
    class Train
    {

        public string No { get; set; }
        public string Type { get; set; }
        public double MaxWeightPower { get; set; }
        public List<RailCar> cars = new List<RailCar>();

        public Train(string no, string type, double maxWeightPower)
        {
            No = no;
            Type = type;
            MaxWeightPower = maxWeightPower;
        }

        
    }
}

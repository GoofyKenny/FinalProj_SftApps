using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProj_SftApps.DB
{
    class RailCar
    {
        public string SN { get; set; } //serial no
        public string MaxWeight { get; set; }
        public string MaxPass { get; set; }

        public RailCar(string sN, string maxWeight, string maxPass)
        {
            SN = sN;
            MaxWeight = maxWeight;
            MaxPass = maxPass;
        }
    }
}

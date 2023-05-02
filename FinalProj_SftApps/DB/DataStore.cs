using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProj_SftApps.DB
{
     class DataStore
    {
        public List<User> users;
        public Train train { get; set; }

        public DataStore()
        {
            users = new List<User>();
            users.Add(new User("Kobi", "0000"));
            users.Add(new User("Liran", "1111"));

            train = new Train("1148", "Diesel",500000);
            train.cars.Add(new RailCar("1234", "45354", "4444"));

            
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Task.Utility
{
    public class States
    {
        public static IEnumerable<State> GetStates()
        {
            return new List<State>
            {
            new State { Id = 1, stateID =1, stateName = "Abia", stateCapital = "Umuahia" },
            new State { Id = 2, stateID = 1, stateName = "Adamawa", stateCapital = "Yola" },
            new State { Id = 3, stateID = 1, stateName = "Akwa-Ibom", stateCapital = "Uyo" },
            new State { Id = 4, stateID = 2, stateName = "Anambra", stateCapital = "Awka" },
            new State { Id = 5, stateID = 2, stateName = "Bauch", stateCapital = "Bauchi" },
            new State { Id = 6, stateID = 2, stateName = "Benue", stateCapital = "Makurdi" },
            new State { Id = 7, stateID = 3, stateName = "Borno", stateCapital = "Maiduguri" },
            new State { Id = 8, stateID = 3, stateName = "Corss River", stateCapital = "Calabar" },
            new State { Id = 9, stateID = 3, stateName = "Delta", stateCapital = "Asaba" },
            new State { Id = 10, stateID = 4, stateName = "Ebonyi", stateCapital = "Abakaliki" },
            new State { Id = 11, stateID = 4, stateName = "Edo", stateCapital = "Benin" },
            new State { Id = 12, stateID = 4, stateName = "Ekiti", stateCapital = "Ado-Ekiti" },
            new State { Id = 13, stateID = 5, stateName = "Enugu", stateCapital = "Enugu" },
            new State { Id = 14, stateID = 5, stateName = "Gombe", stateCapital = "Gombe" },
            new State { Id = 15, stateID = 5, stateName = "Imo", stateCapital = "Owerri" },
            new State { Id = 16, stateID = 6, stateName = "Jigawa", stateCapital = "Dutse" },
            new State { Id = 17, stateID = 6, stateName = "Kaduna", stateCapital = "Kaduna" },
            new State { Id = 18, stateID = 6, stateName = "Kano", stateCapital = "Kano" },
            new State { Id = 19, stateID = 7, stateName = "Katsina", stateCapital = "Katsina" },
            new State { Id = 20, stateID = 7, stateName = "Kebbi", stateCapital = "Birnin Kebbi" },
            new State { Id = 21, stateID = 7, stateName = "Kogi", stateCapital = "Lokoja" },
            new State { Id = 22, stateID = 8, stateName = "Kwara", stateCapital = "Ilorin" },
            new State { Id = 23, stateID = 8, stateName = "Lagos", stateCapital = "Ikeja" },
            new State { Id = 24, stateID = 8, stateName = "Nassarawa", stateCapital = "Lafia" },
            new State { Id = 25, stateID = 9, stateName = "Niger", stateCapital = "Minna" },
            new State { Id = 26, stateID = 9, stateName = "Ogun", stateCapital = "Abeokuta" },
            new State { Id = 27, stateID = 9, stateName = "Ondo", stateCapital = "Akure" },
            new State { Id = 28, stateID = 10, stateName = "Osun", stateCapital = "Osogbo" },
            new State { Id = 29, stateID = 10, stateName = "Oyo", stateCapital = "Ibadan" },
            new State { Id = 30, stateID = 10, stateName = "Pleatue", stateCapital = "Jos" },
            new State { Id = 31, stateID = 11, stateName = "Rivers", stateCapital = "Port Harcourt" },
            new State { Id = 32, stateID = 11, stateName = "Sokoto", stateCapital = "Sokoto" },
            new State { Id = 33, stateID = 11, stateName = "Taraba", stateCapital = "Jalingo" },
            new State { Id = 34, stateID = 12, stateName = "Yobe", stateCapital = "Damaturu" },
            new State { Id = 35, stateID = 12, stateName = "Zamfara", stateCapital = "Gasau" },
            new State { Id = 36, stateID = 12, stateName = "FCT", stateCapital = "Abuja" }

        };
        }
    }
}

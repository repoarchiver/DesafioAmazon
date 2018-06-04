using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    public class DroneDelivery
    {
        public class Drone
        {
            public int Id { get; set; }
            public int FlightRange { get; set; }
        }
        public List<int> GreatestFlightRangeDrones(int requiredDrones, List<Drone> drones, List<int> inMaintenanceDrones)
        {
            List<int> dronesList = new List<int>();

            var packagesWeightOrdered = System.Linq.Enumerable.ToList(
                System.Linq.Enumerable.OrderByDescending(System.Linq.Enumerable.Where
                (drones, x => !inMaintenanceDrones.Contains(x.Id)),
                y => y.FlightRange));

            var allDronesReturn = System.Linq.Enumerable.ToList(System.Linq.Enumerable.Select(System.Linq.Enumerable.Take(packagesWeightOrdered, requiredDrones), x => x.Id));

            return allDronesReturn.ToList();
        }
    }
}

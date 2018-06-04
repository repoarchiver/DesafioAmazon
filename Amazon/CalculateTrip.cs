using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    public class CalculateTrip
    {
        public int minimumNumberOfTrips(int tripMaxWeight, int[] packagesWeight)
        {
            int trips = 0;

            var packagesWeightOrdered = System.Linq.Enumerable.ToList(System.Linq.Enumerable.OrderByDescending(packagesWeight, x => x));

            for (int selected = 0; selected < packagesWeightOrdered.Count;)
            {
                if (packagesWeightOrdered.Count == 1)
                {
                    trips++;
                    break;
                }

                var testTrip = packagesWeightOrdered[selected];
                if (testTrip > tripMaxWeight)
                {
                    packagesWeightOrdered.RemoveAt(0);
                    selected = 0;
                }

                for (int i = selected + 1; i < packagesWeightOrdered.Count; i++)
                {
                    if ((testTrip + packagesWeightOrdered[i]) <= tripMaxWeight)
                    {
                        packagesWeightOrdered.RemoveAt(0);
                        packagesWeightOrdered.RemoveAt(0);
                    }
                    else
                        packagesWeightOrdered.RemoveAt(0);

                    trips++;
                    selected = 0;
                    break;
                }
            }

            return trips;
        }
    }
}

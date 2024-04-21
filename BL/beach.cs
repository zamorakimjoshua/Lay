using Models;
using DLl;

namespace BL
{
    public class Service
    {
        DataService dataService = new DataService();

        public Beach GetBeach(string beachName)
        {
            Beach foundBeach = null;
            foreach (Beach currentBeach in dataService.theBeachList)
            {
                if (currentBeach.name == beachName)
                {
                    foundBeach = currentBeach;
                    break;
                }
            }
            return foundBeach;
        }
    }
}

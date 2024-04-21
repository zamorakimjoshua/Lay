using Models;
using System.Collections.Generic;

namespace DLl
{
    public class DataService
    {
        public List<Beach> theBeachList = new List<Beach>();

        public DataService()
        {
            Beach one = new Beach()
            {
                name = "Boracay",
                place = "Aklan",
                description = "Boracay is a popular tourist destination known for its pristine beaches, exciting activities, and vibrant nightlife, making it a must-visit destination for travelers seeking sun, sand, and relaxation in the Philippines."
            };

            Beach two = new Beach()
            {
                name = "Alona Beach",
                place = "Bohol-Panglao",
                description = "Alona Beach is a popular destination for travelers seeking sun, sea, and relaxation in a tropical paradise. With its stunning beach, vibrant atmosphere, and abundance of activities, it's no wonder that Alona Beach is considered one of the top beach destinations in the Philippines."
            };
            Beach three = new Beach()
            {
                name = "El Nido",
                place = "Miniloc Island",
                description = "El Nido Beach is a paradise destination renowned for its natural beauty, pristine beaches, and adventurous activities, making it a must-visit destination for travelers seeking a tropical escape in the Philippines."
            };
            Beach four = new Beach()
            {
                name = "Saud Beach",
                place = "Pagudpod",
                description = "Saud Beach is a hidden gem on the northern coast of the Philippines, offering pristine natural beauty, tranquil surroundings, and a peaceful escape from the hustle and bustle of city life. With its breathtaking scenery and laid-back atmosphere, Saud Beach is a must-visit destination for travelers seeking paradise in the Philippines.\r\n\r\n\r\n\r\n"
            };
            Beach five = new Beach()
            {
                name = "Coron",
                place = "Palawan",
                description = "Coron is a paradise destination blessed with unparalleled natural beauty, vibrant marine life, and a wealth of outdoor adventures, making it a must-visit destination for travelers seeking an unforgettable island getaway in the Philippines."
            };

            theBeachList.Add(one);
            theBeachList.Add(two);
            theBeachList.Add(three);
            theBeachList.Add(four);
            theBeachList.Add(five);
        }

        public void AddBeach(Beach beach)
        {
            theBeachList.Add(beach);
        }

        public void DeleteBeach(Beach beach)
        {
            theBeachList.Remove(beach);
        }
    }
}
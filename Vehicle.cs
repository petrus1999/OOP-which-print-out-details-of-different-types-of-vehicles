using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_which_print_out_details_of_different_types_of_vehicles
{
     class Vehicle
    {
        public string Name;
        public string Brand;
        public string Colour;
        
        class Car :Vehicle{

            public Car(string name, string brand, string colour)
            {
                Name = name;
                Brand = brand;
                Colour = colour;
            }
        
        
        }

    }
    
}

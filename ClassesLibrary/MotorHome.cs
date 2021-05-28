using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class MotorHome : Vehicle
    {
        //fields
        private int _numberOfBeds;

        //properties
        public int NumberOfBeds
        {
            get { return _numberOfBeds; }
            set { _numberOfBeds = value; }
        }

        //ctor
        public MotorHome(string make, string model, int year, float weight, int numberOfBeds)
        {
            //Prop = param;
            NumberOfBeds = numberOfBeds;

        }//end of Fully Qualified CTOR (FQCTOR) - we used every property in the creation of the object
        public MotorHome()
        {

        }

    }
}

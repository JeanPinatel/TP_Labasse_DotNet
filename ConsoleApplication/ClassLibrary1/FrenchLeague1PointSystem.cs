using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary1;


namespace ClassLibrary1
{
    public class FrenchLeague1PointSystem
    {
        private FrenchLeague1PointSystem theInstance;
        private ITotal InitialPoints;
        private PointSystem Instance;

        public FrenchLeague1PointSystem(FrenchLeague1PointSystem theInstance,ITotal initialPoints,PointSystem Instance)
        {
            this.theInstance = theInstance;
            this.Instance = Instance;
        }




        public ITotal InitialPoints
        {
            get
            {
                return null; /*pas encore fait*/
            }
        }

    }
}

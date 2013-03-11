using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary1;

namespace ClassLibrary1
{
    class PointSystem
    {
      private ITotal InitialPoints;

      public PointSystem(ITotal InitialPoints)
      {
          this.InitialPoints=InitialPoints;
      }
        public ITotal GetPointsFromMatch(Match m, bool home)
            {
               return this.InitialPoints;
            }

        }
}
 
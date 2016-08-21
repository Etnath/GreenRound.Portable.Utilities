using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenRound.Portable.Utilities.AI.PathFinding
{
    public class SearchParameters
    {
        public Point StartLocation { get; private set; }
        public Point EndLocation { get; private set; }

        public SearchParameters(Point startLocation, Point endLocation)
        {
            StartLocation = startLocation;
            EndLocation = endLocation;
        }
    }
}

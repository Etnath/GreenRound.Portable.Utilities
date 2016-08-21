using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenRound.Portable.Utilities.AI.PathFinding
{
    public class Node
    {
        public float G { get; private set; }
        public float H { get; private set; }

        public float F
        {
            get
            {
                return G + H;
            }
        }

        public Point Location { get; private set; }
        public Node Child { get; private set; }
        public Node()
        {
            G = 0;
            H = 0;
            Location = new Point();
        }

        public Node(Point currentPoint, Point startPoint, Point endPoint)
        {
            Location = new Point(currentPoint);
            G = GetDistance(currentPoint, startPoint);
            H = GetDistance(currentPoint, endPoint);

        }

        private float GetDistance(Point point1, Point point2)
        {
            return Math.Abs(point1.Y - point2.Y) + Math.Abs(point1.X - point2.X) ;
        }
    }
}

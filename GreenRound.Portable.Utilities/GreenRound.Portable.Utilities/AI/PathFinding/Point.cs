﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenRound.Portable.Utilities.AI.PathFinding
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point()
        {
            X = 0;
            Y = 0;
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point(Point point)
        {
            X = point.X;
            Y = point.Y;
        }
    }
}

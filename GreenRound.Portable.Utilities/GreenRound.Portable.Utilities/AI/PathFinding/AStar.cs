using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenRound.Portable.Utilities.AI.PathFinding
{
    public class AStar
    {
        public SearchParameters Parameters { get; private set; }
        public List<Node> Path { get; private set; }

        public AStar(SearchParameters parameters)
        {
            Parameters = parameters;
        }

        public IList<Node> SearchPath(PathPoint[][] matrix)
        {
            int height = matrix.Length;
            int width = matrix[0].Length;


            return new List<Node>();
        }

        private void Init()
        {
            
        }
    }
}

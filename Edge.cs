using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeSolver
{
    public class Edge
    {
        public int Weight { get; set; } = int.MaxValue;
        public MazeNode Start { get; set; }
        public MazeNode End { get; set;}

        public Edge(MazeNode startNode, MazeNode endNode)
        {
            Start = startNode;
            End = endNode;
            

        }

    }
}

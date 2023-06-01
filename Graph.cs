using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeSolver
{
    public class Graph
    {
        public List<MazeNode> Nodes = new List<MazeNode>();
        public List<Edge> Edges = new List<Edge>();
        public MazeNode Start { get; set; }
        public MazeNode End { get; set; }


    }
}

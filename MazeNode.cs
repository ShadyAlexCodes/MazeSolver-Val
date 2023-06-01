
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeSolver
{
    // ----- MAZENODE -----
    // connectionList
    // Name
    // previous
    // visited
    public class MazeNode
    {
        public List<Edge> connectionList; // List of Connections
        public string name;
        public bool visited;
        public MazeNode vertex;
       
       
        public MazeNode()
        {
            connectionList = new List<Edge>();
            

        }
    }
}

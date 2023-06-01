using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace MazeSolver
{
    internal class Solver
    {
        public string SolveMaze(Graph graph)
        {
            string solution = string.Empty;
            Queue<MazeNode> enqueueNodes = new Queue<MazeNode>();

            foreach (MazeNode node in graph.Nodes)
            {
                solution += FindPath(node, enqueueNodes);
                Console.WriteLine("Test: " + node.name);
            }

            return "Solved: " + solution;
        }

        public string FindPath(MazeNode node, Queue<MazeNode> mazenodes)
        {
            string mazeSolution = string.Empty;

            node.visited = true;
            mazenodes.Enqueue(node);

            while (mazenodes.Count > 0)
            {
                MazeNode currentNode = mazenodes.Dequeue();
                foreach (Edge edge in currentNode.connectionList)
                {
                    MazeNode nextNode = edge.End;
                    if (!nextNode.visited)
                    {
                        nextNode.visited = true;
                        nextNode.vertex = currentNode;
                        //FindPath(edge.End, mazenodes);
                        mazenodes.Enqueue(nextNode);

                    }

                    mazeSolution += currentNode.name + " ";
                   
                }
            }

            
            return mazeSolution ;
        }



    }
}

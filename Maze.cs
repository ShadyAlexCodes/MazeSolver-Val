using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Channels;

// Need to go through and find the shortest path

// The first line is the name of all the nodes
// Second line is two nodes, first one is the start and second is the end of the maze
// The other lines start with a node (that is the main node) and the rest which one it is adjacent to and connects to
// Comma separated
// File contains multiple mazes, each separeted by a blank line
// It is possible for it to have dead ends
// It is possible for cycles
// Possible to have multiple solutions, it is also not possible for it to not be passed
// Should return the path taken, if it cannot be solved then return "Maze cannot be solved"
// Will need to establish the first two lines in different methods
// Make sure it ignores , or can just delete the comments out
// We will have to keep track of which ones we have visited
namespace MazeSolver
{
    internal class Maze
    {
        // ----- MAZE ------
        // Maze (graph) Has nodes,connections vertices
        // MazeNode Start
        // MazeNode End
        // MazeQueue
        // List of Nodes
        // List of edges or connections

        // File parsing 
        // SolveMaze()
        static void Main(string[] args)
        {
            List<Graph> graphs = GraphInput.DrawGraph();
            Solver solver = new Solver();
            string solution = string.Empty;
            foreach (Graph graph in graphs)
            {
                 solution += solver.SolveMaze(graph);

            }
            Console.WriteLine(solution);
        }
    }
}






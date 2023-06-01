using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

//namespace MazeSolver.OldCode
//{
    // ----- MAZE SOLVER ------
    // SolveMaze()
    // enqueue(maze.Start)
    // dequeue()
    // mazeSolution = getSolutionString(maze.End, "")

    // getSolutionString(node, solutionString)
    // if node.previos != null
    // Solutionstring = getSolutionString(solutionString)
    // soltuionString += node.value
    // return solutionString



    // dequeue()
    // for connectedNode in connections 
    // if connectedNode.name == maze.End.name
    // ConnectedNode.previous = head
    // enqueue(connectNode)
    // Remove head from queue
    // if (head == null)
    //dequeue()
    //public class MazeSolver
    //{
    //    // GOT RID OF THE MAZEQUEUE AS IT WAS NOT BEING USED
    //    // This changes the MazeSolver to have a startNode and endNode and graph
    //    // We might have to take in the graph to keep track of the names and the nodes
    //    // But can't I also just call them within the function as to not mess up  the code too much?
    //    public string StringMazeSolver()
    //    {
    //        // Changing enqueueNode to a priority queue as it will help keep track of the priority nodes
    //        // Specially when getting them from file as it wil help dequeue the least important ones when called
    //        // Or at least the ones with lowest prioriy
    //        // The int stands for the distance we are taking in 
    //        PriorityQueue<DNode, int> enqueueNodes = new PriorityQueue<DNode, int>();

    //        // Startnode at the distance of 0 as it is the beginning
    //        DNode startNode = new DNode();
    //        //MazeNode endNode = ;
    //        string mazeSolution = string.Empty;
    //        startNode.distance = 0;

    //        // Add to queue, this will now take the path and where we are starting       
    //        enqueueNodes.Enqueue(startNode, startNode.distance);
    //        // Need to store the node and where we are
    //        List<MazeNode> visitedNodes = new List<MazeNode>();
    //        visitedNodes.Add(startNode.vertex);

    //        // Also need to keep track of the paths 
    //        // Could use to a dictionary to keep the key as the node and the string as a path
    //        Dictionary<MazeNode, int> paths = new Dictionary<MazeNode, int>();
    //        paths[startNode.vertex] = startNode.distance;

    //        // Iterate through
    //        // Check the Queue is not empty 
    //        // Dequeue the current Nde from the queue
    //        // check if it is the end node if so return the currentNode
    //        while (enqueueNodes.Count > 0)
    //        {
    //            // Now we need to delete the current Data
    //           // MazeNode currentNode = ;
    //            //Console.WriteLine(currentNode.name);

    //            // Checking if we are at the end node of so break out of the loop
    //            //if (currentNode == endNode) break;

    //            // Iterate through the connected nodes
    //            foreach (MazeNode connectedNode in visitedNodes)
    //            {
    //                // Recursive (?)
    //                // If it has not visited the current node calculate the distance and 
    //                // Update the distance path 
    //                if (!visitedNodes.Contains(connectedNode))
    //                {
    //              //      int updateDistance = currentNode.distance + 1;
    //                //    connectedNode.distance = updateDistance;

    //                    // Enqueue the node with its new path and distance
    //                    enqueueNodes.Enqueue(connectedNode, connectedNode.distance);

    //                    // Add it to the list, indicating we have visited it
    //                    visitedNodes.Add(connectedNode);
    //                  //  connectedNode.visitedNode = true;

    //                }
    //            }

    //            // Return empty if no path found
    //            //return "Empty";
    //           // mazeSolution = GetSolutionString(endNode, "");
    //            //enqueueNodes.Dequeue();
    //        }
    //        return mazeSolution;


    //    }

    //    public string GetSolutionString(MazeNode node, string solution)
    //    {
    //        // Add node to the solution
    //        solution += node.name + " ";

    //        // Check that it doesn't jump out and checks if it is the end node
    //        // return the solution if it is the end, The trim removes any extra white space
    //        //if (node.isEndNode) return solution.Trim();

    //        // Iterate through the connected nodes
    //        foreach (MazeNode nextNode in node.connectionList)
    //        {
    //            // Check if the next node is not visited
    //            if (!nextNode.visitedNode)
    //            {
    //                // Set the node as visited
    //                nextNode.visitedNode = true;

    //                // Call GetSolutionString recursively with the next node
    //                // This will call it again but now with the next node in the list
    //                string nextNodeSolution = GetSolutionString(nextNode, solution);

    //                // If solution found, return the found solution
    //                if (!string.IsNullOrEmpty(nextNodeSolution))
    //                {
    //                    return nextNodeSolution;
    //                }
    //            }
    //        }

    //        // If no solution found, return empty string
    //        return solution;
    //    }
    //}
//}

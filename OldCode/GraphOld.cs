using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//namespace MazeSolver.OldCode
//{
//    internal class GraphOld
//    {
//        // Deleted first version as it was only returning first node not the whole graph unless if I used CW
//        // Take in the line that we are on and get each indvidual character from the string ignoring commas using Split()
//        public List<string> GetGraph(string[] lines)
//        {
//            // Create nodes and add them to the list
//            List<MazeNode> nodes = new List<MazeNode>();

//            bool isVertices = true;
//            bool startEnd = true;
//            int index = 0;
//            // Iterate through the length of the line to get names of node
//            for (index = 0; index < lines.Length; index++)
//            {
//                // Get rid of any remaning white spacess
//                string line = lines[index];

//                // Ignore white space/empty lines and comments
//                if (string.IsNullOrEmpty(line) || line.StartsWith("/"))
//                {
//                    continue;
//                }
//                else if (isVertices)
//                {
//                    // Creates the nodes and adds them to the list
//                    // This will get the name and add it in
//                    // Using list to ignore the , in between node names
//                    string[] nodeNames = line.Split(',');

//                    //// Got an error saying mainNode was going null need to add check

//                    foreach (string nodeName in nodeNames)
//                    {
//                        if (!string.IsNullOrEmpty(nodeName))
//                        {

//                            MazeNode node = new MazeNode();
//                            node.name = nodeName;
//                            nodes.Add(node);
//                        }
//                    }
//                }
//                else if (startEnd)
//                {
//                    // Setting the start and end nodes
//                    string[] startEndNode = line.Split(",");
//                    // Find the right nodes using built in function
//                    // Create a node and set it to the name and set the value to the start or end of the array that holds the names of needs in the line
//                    MazeNode startNode = nodes.Find(node => node.name.Equals(startEndNode[0]));
//                    MazeNode endNode = nodes.Find(node => node.name.Equals(startEndNode[1]));
//                    // TEST 
//                    Console.WriteLine(startNode.name + endNode.name);
//                }
//                else
//                {
//                    // Add the connections between nodes
//                    string[] nodeNamesConnections = line.Split(",");
//                    MazeNode beginningNode = nodes.Find(node => node.name.Equals(nodeNamesConnections[0]));
//                    // Need to start at one, since the mainNode is already assigned outside the loop
//                    // This will help us find the connections 
//                    for (int i = 1; i < nodeNamesConnections.Length; i++)
//                    {

//                    }
//                }
//            }
//            index++;

//        }
//            // Return the list, this was a previous issue as it needed to return a graph not just a regular string with one value
//            //return nodes;

//        }

//}




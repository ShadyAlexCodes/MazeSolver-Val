using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeSolver
{
    public class GraphInput
    {
         public static  List<Graph> DrawGraph()
        {
            List<Graph> graphs = new List<Graph>();
            string[] stringGraphs = FileInput();

            List<List<string>> listOfStringGraphs = GetStringGraphs(stringGraphs);

            graphs.Add(CreateGraph(listOfStringGraphs));
            
            

            return graphs;
        }

        static string[] FileInput()
        {
            Console.WriteLine("Insert path: ");
            string input = Console.ReadLine();

            string[] lines = File.ReadAllLines(input);

            return lines;

        }

        static List<List<string>> GetStringGraphs(string[] lines)
        {
            List<List<string>> stringGraphs = new List<List<string>>();
            List<string> stringGraph = new List<string>();

            foreach (string line in lines)
            {
                if (line != " " && line != "")
                {
                    stringGraph.Add(line);
                    stringGraphs.Add(stringGraph);
                    stringGraph = new List<string>();

                }
                else
                {
                    if (!line.StartsWith("/"))
                    {
                        stringGraph.Add(line);
                    }
                }
            }

            return stringGraphs;
        }

        static Graph CreateGraph(List<List<string>> stringGraphs)
        {
            
            Graph graph = new Graph();
            for (int i = 0; i < stringGraphs.Count; i++)
            {
                List<string> graphList = stringGraphs[i];
                if(i == 0)
                {
                    
                    string[] graphNodes = graphList.ElementAt(i).Split(",");
                    foreach(string stringNode  in graphNodes)
                    {
                        MazeNode node = new MazeNode();
                        node.name = stringNode;
                        graph.Nodes.Add(node);
                    }
                    continue;
                }
                else if (i == 1)
                {
                    string[] startEndNode = graphList.ElementAt(0).Split(",");
                    // Find the right nodes using built in function
                    // Create a node and set it to the name and set the value to the start or end of the array that holds the names of needs in the line
                    MazeNode startNode = graph.Nodes.Find(node => node.name.Equals(startEndNode[0]));
                    MazeNode endNode = graph.Nodes.Find(node => node.name.Equals(startEndNode[1]));

                    graph.Start = startNode;
                    graph.End = endNode;
                    continue;
                }
               
                    string[] connectionNodes = graphList.ElementAt(0).Split(",");
                   
                    MazeNode mainNode = graph.Nodes.Find(node => node.name.Equals(connectionNodes[0]));

                    for (int j = 1; j < connectionNodes.Length; j++)
                    {
                        MazeNode endNode = graph.Nodes.Find(node => node.name.Equals(connectionNodes[j]));
                        Edge newEdge = new Edge(mainNode, endNode);
                        mainNode.connectionList.Add(newEdge);
                    }
                
            }


            return graph;
        }
    }
}

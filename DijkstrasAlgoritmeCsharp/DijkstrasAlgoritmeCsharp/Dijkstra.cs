using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstrasAlgoritmeCsharp
{
    public class Dijkstra
    {
        // input data
        public int _source;
        public int[,] _graph;

        /// <summary>
        /// Class containing the Dijkstra algorithm functions
        /// </summary>
        /// <param name="source">Index point where to start searching</param>
        /// <param name="graph">Multidimensional array graph containing the nodes and costs between nodes</param>
        public Dijkstra(int source, int[, ] graph)
        {
            _source = source;
            _graph = graph;
        }

        /// <summary>
        /// Find the node with the lowest cost available and return its index
        /// </summary>
        /// <param name="nodeCosts">Array containing the costs to each available node</param>
        /// <param name="visited">Array containing visited nodes</param>
        /// <returns></returns>
        public int findLowestCost(int index, bool[] visitedNodes)
        {
            int lowestCost = int.MaxValue; // int which holds the lowest cost found
            int node_index = -1; // int which holds the index of the node with lowest cost

            // iterate trough graph node containing the costs to other nodes
            for (int i = 0; i < _graph.GetLength(1); i++)
            {
                // check if the current node is connected (not 0) and has a lower cost
                if (visitedNodes[i] == false && _graph[index, i] > 0 && _graph[index, i] <= lowestCost)
                {
                    lowestCost = _graph[index, i];
                    node_index = i;
                }
            }

            return node_index;
        }

        public void search()
        {
            int amountNodes = _graph.GetLength(0); // get amount of nodes
            int[] distances = new int[amountNodes]; // init new array of distances to return
            bool[] visited = new bool[amountNodes]; // init new array of visited nodes

            // set the distances of all nodes to the highest value and all nodes to unvisited
            for (int i = 0; i < amountNodes; i++)
            {
                distances[i] = int.MaxValue;
                visited[i] = false;
            }

            distances[_source] = 0; // the distance of the first node to itself is always zero

            for (int i = 0; i < amountNodes; i++)
            {
                // find the node with the lowest cost
                int lowestIndex = findLowestCost(i, visited);

                // set this node to visited
                visited[lowestIndex] = true;
            }
        }
    }
}

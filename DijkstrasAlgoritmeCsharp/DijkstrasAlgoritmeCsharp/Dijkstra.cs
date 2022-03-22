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

        public void search()
        {
            // init empty arrays for the calculated distances and visited nodes
            int sizeGraph = _graph.GetLength(1);
            int[] distances = new int[sizeGraph];
            bool[] visitedNodes = new bool[sizeGraph];

            // initialise the distances array with the largest number it can hold and set the visited array all to false
            for (int i = 0; i < sizeGraph; i++)
            {
                distances[i] = int.MaxValue;
                visitedNodes[i] = false;
            }    

            distances[_source] = 0; // set the start node to 0

            // loop trough the list of nodes, but skip the first node
            for (int i = 0; i <= sizeGraph - 1; i++)
            {
                // set current node as visited
                visitedNodes[i] = true;

            }
        }
}
    }

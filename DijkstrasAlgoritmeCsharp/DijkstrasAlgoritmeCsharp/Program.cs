namespace DijkstrasAlgoritmeCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // starting point for the search
            int source = 0;
            // graph where we're going to search in
            int[,] graph = new int[,]
            {
                {0, 6, 0, 1, 0},
                {6, 0, 5, 2, 2},
                {0, 5, 0, 0, 5},
                {1, 2, 0, 0, 1},
                {0, 2, 5, 1, 0}
            };

            Dijkstra dijkstra = new Dijkstra(source, graph);
            dijkstra.search();
        }
    }
}
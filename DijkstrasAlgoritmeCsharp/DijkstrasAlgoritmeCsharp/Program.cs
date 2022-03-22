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
                {0, 4, 0, 0, 7},
                {4, 0, 1, 2, 0},
                {0, 1, 0, 6, 0},
                {0, 2, 6, 0, 0},
                {7, 0, 0, 0, 0}
            };

            Dijkstra dijkstra = new Dijkstra(source, graph);
            dijkstra.search();

            Console.WriteLine("Test");
        }
    }
}
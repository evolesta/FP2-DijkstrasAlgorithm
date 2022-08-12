// F# implementation of Dijkstras algorithm

// create a hardcoded graph with distances between nodes in a multi dim. array
let graph = array2D [
    [0; 6; 0; 1; 0];
    [6; 0; 5; 2; 2];
    [0; 5; 0; 0; 5];
    [1; 2; 0; 0; 1];
    [0; 2; 5; 1; 0]
]

// start node to start searching
let source = 0

// function to search for the lowest cost from a specific node and returns its index
let findLowestIndex (distances : int[]) (visited : bool[]) =
    let lowestCost = 9999
    let node_index = -1

    // recursive function to search for the lowest cost in the array of distances
    let rec findLowestIndexRec i x n =
        if graph.GetLength(0) <= i then n
        else if visited[i] = false && distances[i] <= x then
            findLowestIndexRec (i + 1) distances[i] i
        else findLowestIndexRec (i + 1) x n

    findLowestIndexRec 0 lowestCost node_index


// main function to run to shortest path algorithm
let dijkstrasSearch = 
    let amountNodes = graph.GetLength(0) // get the amount of nodes from the array
    let distances = Array.create amountNodes 9999 // init a new array of distances and set a high distance value
    let visited = Array.create amountNodes false // init a new array of visited nodes and set all nodes to false

    distances[source] <- 0 // the distance of the starting node to itself is always zero

    // recursive function to find the lowest path (in costs) to each node from the starting node
    let rec findShortestPathRec i (distances : int[]) (visited : bool[]) =
        if (amountNodes - 1) <= i then true
        else
            let lowestIndex = findLowestIndex distances visited // call the function to search for the index with the lowest cost
            visited[lowestIndex] <- true // mark the current node as visited

            // recursive function to search the path with the lowest cost
            let rec searchPathRec v =
                if amountNodes <= v then true
                else if visited[v] = false && graph[lowestIndex, v] <> 0 && distances[lowestIndex] <> 9999 &&
                    distances[lowestIndex] + graph[lowestIndex, v] < distances[v] then
                        distances[v] <- (distances[lowestIndex] + graph[lowestIndex, v])
                        searchPathRec (v + 1)
                    else searchPathRec (v + 1)

            searchPathRec 0
            findShortestPathRec (i + 1) distances visited

    findShortestPathRec 0 distances visited

    printf "The shortest paths from source to nodes:"
    printf ""
    
    let rec printShortestPathRec i (distances : int[]) = 
        if distances.Length <= i then true
        else
            printf "%s" (distances[i].ToString())
            printShortestPathRec (i + 1) distances

    printShortestPathRec 0 distances
    
// run dijkstras algorithm searching
dijkstrasSearch
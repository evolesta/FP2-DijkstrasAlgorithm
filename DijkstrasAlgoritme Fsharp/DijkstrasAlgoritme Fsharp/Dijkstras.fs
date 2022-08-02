// F# implementation of Dijkstras algorithm

// create a hardcoded graph with distances between nodes in a multi dim. array
let graph = array2D [
    [0;4;0;0;7];
    [4;0;1;2;0];
    [0;1;0;6;0];
    [0;2;6;0;0];
    [7;0;0;0;0]
]

// start node to start searching
let source = 0

// Find the node with the lowest cost available and return its index
let findLowestCost distances visitedNodes = 
    let lowestCost = 9999
    let node_index = -1
    
    let rec findLowestCostRec i = 
        if visitedNodes[i] = false && distances[i] <= lowestCost then
            lowestCost = distances[i]
            node_index = i
        else
            let x = i + 1
            findLowestCostRec x

    node_index



let dijkstrasSearch = 
    let amountNodes = graph.GetLength(0) // get the amount of nodes from the array
    let distances = Array.create amountNodes 9999 // init a new array of distances and set a high distance value
    let visited = Array.create amountNodes false // init a new array of visited nodes and set all nodes to false

    distances[source] <- 0 // the distance of the starting node to itself is always zero

    

    printf "Test"
    

dijkstrasSearch
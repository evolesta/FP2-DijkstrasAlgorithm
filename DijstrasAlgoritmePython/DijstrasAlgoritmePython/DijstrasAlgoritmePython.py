# Dijkstras algoritme in Python

graph = [
    [0, 6, 0, 1, 0],
    [6, 0, 5, 2, 2],
    [0, 5, 0, 0, 5],
    [1, 2, 0, 0, 1],
    [0, 2, 5, 1, 0]]

source = 0

def findLowestIndex(distances, visited):
    lowestCost = 9999
    node_index = -1

    def findLowestIndexRec(i, x, n):
        if len(graph) <= i:
            return n
        else:
            if visited[i] == False and distances[i] <= x:
                return findLowestIndexRec((i + 1), distances[i], i)
            else:
                return findLowestIndexRec((i + 1), x, n)

    return findLowestIndexRec(0, lowestCost, node_index)

def dijkstrasSearch():
    amountNodes = len(graph) # get the amount of nodes from the graph array
    distances = [9999] * amountNodes # init a new array of distances and set a highj distance value
    visited = [False] * amountNodes # init a new array of visited nodes and set all nodes to false

    distances[0] = 0 # the distance of the starting node to itself is always zero

    # search for the shortest path in costs for each node from the starting node
    for i in range(amountNodes - 1):
        lowestIndex = findLowestIndex(distances, visited)
        visited[lowestIndex] = True

        # search for the shortest path recursively
        def searchPathRec(v):
            if amountNodes <= v:
                return True
            else:
                if visited[v] == False and graph[lowestIndex][v] != 0 and distances[lowestIndex] != 9999 and (distances[lowestIndex] + graph[lowestIndex][v]) < distances[v]:
                    distances[v] = (distances[lowestIndex] + graph[lowestIndex][v])
                    return searchPathRec(v + 1)
                else:
                    return searchPathRec(v + 1)

        searchPathRec(0)

    print("The shortest path from source to nodes:")
    print("")
    
    for i in range(amountNodes):
        print(str(i) + "        " + str(distances[i]))

dijkstrasSearch()
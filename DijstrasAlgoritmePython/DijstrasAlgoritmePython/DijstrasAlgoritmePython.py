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
                findLowestIndexRec((i + 1), distances[i], i)
            else:
                findLowestIndexRec((i + 1), x, n)

    findLowestIndexRec(0, lowestCost, node_index)

def dijkstrasSearch():
    amountNodes = len(graph) # get the amount of nodes from the graph array
    distances = [9999] * amountNodes # init a new array of distances and set a highj distance value
    visited = [False] * amountNodes # init a new array of visited nodes and set all nodes to false

    distances[0] = 0 # the distance of the starting node to itself is always zero

    print("")

dijkstrasSearch()
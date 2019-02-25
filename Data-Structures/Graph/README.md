<h1 align="center">Graphs</h1>
Implement a Graph

## Challenge
Implement your own Graph. The graph should be represented as an adjacency list, and should include the ability to: add a node, add an edge, get all nodes, get a node's neighbors, and get the size of the graph.

## Approach & Efficiency
### AddNode()
 - Time: O(n) since we have to look through the graph to see if the node currently exists
 - Space: O(1) since we are adding a single node

### AddEdge()
 - Time: O(1) since we are adding an edge, not iterating through anything
 - Space: O(1) since we are not returning anything, just adding an edge

### GetNodes()
 - Time: O(n) since we are creating a List of n nodes
 - Space: O(n) since the list is of n length

### GetNeighbors()
 - Time: O(1) since we are not iterating, just returning a property
 - Space: O(n) since this depends on the number of neighbors a node has

### Size()
 - Time: O(n) since we are running a count on the graph size
 - Space: O(1) since we are returning a single integer representing the graph's size

## API
### AddNode()
 - Adds a new node to the graph
 - Takes in the value of that node
 - Returns the added node

### AddEdge()
 - Adds a new edge between two nodes in the graph
 - Include the ability to have a “weight”
 - Takes in the two nodes to be connected by the edge
 - Both nodes should already be in the Graph

### GetNodes()
 - Returns all of the nodes in the graph as a collection (set, list, or similar)

### GetNeighbors()
 - Returns a collection of nodes connected to the given node
 - Takes in a given node
 - Include the weight of the connection in the returned collection

### Size()
 - Returns the total number of nodes in the graph

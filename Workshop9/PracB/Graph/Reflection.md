### Task 1.
### Explain, in plain English, how does your implementation of Dijkstra's algorithm work?
Answer: My implementation of Dijkstra's algorithm finds the shortest path from the Start node to the End node by considering the weights of each edge. First, it sets the distance of the Start node to 0 and all other nodes to infinity. It then uses a priority queue to process the node with the smallest known distance.

For each node, the algorithm checks its neighbours and calculates the total distance to reach them. If a shorter path is found, it updates the distance and stores the current node as the neighbour's parent. This process continues until the End node is reached. Finally, the algorithm uses the parent dictionary to reconstruct and print the shortest path.

In this case, the algorithm finds a path that avoids the bees, with a total weight of 10.


### What is the computational complexity of Dijkstra's? Why is it different than BFS / DFS?
Answer: Dijkstra's algorithm has a commonly stated time complexity of O((V + E) log V) when using a binary-heap priority queue, where V is the number of vertices and E is the number of edges.

In comparison, BFS and DFS have a time complexity of O(V + E). This is because BFS and DFS simply visit nodes and explore their connections, while Dijkstra's algorithm also uses a priority queue to select the node with the smallest distance. Adding and removing elements from the priority queue requires extra time.

Unlike BFS and DFS, Dijkstra's algorithm considers edge weights to find the path with the lowest total cost, making it more suitable for weighted graphs.
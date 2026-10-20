### Task 1.
### What sort of Graph have we created? Is it directed / undirected? Cyclic or acyclic? Weighted or unweighted?
Answer: It's an undirected, acyclic, unweighted graph. It is also a tree.

### Other than Binary Search Tree and Linked List, what are two other commonly used data structures that are also secretly Graphs?
Answer: Tries which is prefix trees and heaps which is when represented as binary trees.


### Task 2.
### Why do we need to create and keep track of which Nodes we've "visited"?
To avoid visiting the same nodes repeatedly and getting stuck in cycles.

### In the adjusted graph above, there are 2 correct paths to I,  which one does your BFS algorithm take? Why?
A → B → E → H → I, because it has fewer edges than A → B → D → G → H → I.

### What is the computational complexity of BFS? What does |V| + |E| mean?
O(V+E)
Here,
V = number of vertices (nodes).
E = number of edges (connections).
BFS processes each node and examines its edges, so its running time grows with both.
|V| + |E| = Total number of vertices plus edges.
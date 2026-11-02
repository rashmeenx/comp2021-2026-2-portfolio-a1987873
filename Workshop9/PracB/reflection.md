## Task 1

1. Explain, in plain English, how does your implementation of Dijkstra's algorithm work?
Ans: Dijkstra's algorithm finds the shortest path in a weighted graph. It starts at the Start node with a distance of 0 and assigns infinity to all other nodes. It uses a PriorityQueue to process nodes with the lowest known distance first. For each neighbouring node, it calculates the new distance and updates it if a shorter path is found. It also stores the parent nodes to reconstruct the shortest path from Start to End.

2. What is the computational complexity of Dijkstra's? Why is it different than BFS / DFS?
Answer: Dijkstra's algorithm using a priority queue typically has a time complexity of O((V+E)log V), where V is the number of vertices and E is the number of edges. BFS and DFS have a complexity of (O(V+E)). Dijkstra's is slower because it uses a priority queue to find the shortest weighted path, while BFS and DFS do not consider edge weights.

## Task 2
1. What AI tool did you use?
Ans: I used Claude.

2. What were some of the prompts you used?
Ans: "Generate a complete C# implementation of Dijkstra's algorithm using a weighted graph, Dictionary and PriorityQueue. Use the horse graph example and print the shortest path from Start to End."

3. Did the AI one-shot the problem, or did it require revision? How many rounds did it take?
Ans: The AI-generated solution required some revisions to match the graph structure and expected output. It took two rounds to get a working solution.

4. What was one of the ways the AI code was substantially different to your approach?
Ans: The AI code used a simpler Dequeue() method to process nodes, while my implementation used TryDequeue() to retrieve both the node and its priority. My code also checked for outdated queue entries to avoid unnecessary processing, which the AI code did not.

5. Compared to your code, what was one aspect the AI tool did better?
Ans: The AI code was shorter and more concise. It used var and a simpler while loop, making the implementation easier to read without requiring as many lines of code.

6. Compared to your code, what was one aspect the AI tool did worse?
Ans: The AI code lacked some error handling and reliability checks. My implementation checks for outdated priority queue entries and handles cases where no path exists, while the AI code assumes a valid path will always be found.

## Task 3
1. What's been your favourite C# feature?
Ans: My favourite C# feature has been LINQ because it makes filtering, sorting and searching collections easier with less code. Furthermore, I did SQL last year, so I find it easier to understand.

2. What's been your most hated C# feature?
Ans: None in particular. However, if I had to choose one, it would be handling null values and understanding how to return non-null values, as I sometimes find it confusing.

3. What was the easiest prac or topic for you, and why?
Ans: Stack and Queue, it was really easy to follow through and I found it really fun.

4. What was the most fun prac or topic for you, and why?
Ans: Stack and Queue. I think it was really easy and that's why I really think that was fun.

5. What's one area you're going to revise before the exam?
Ans: Even though LINQ is one of my favourite features, I plan to revise LINQ and Big O notation because I still find some of the concepts confusing, especially understanding time complexity.

4. What's one piece of advice you would give to new students taking SDP next semester?
Ans: My advice would be practising daily and keep trying to write the codes independently till they can write it themselves.

5. What's one suggestion you have for the course coordinator to make the course better?
Ans: I think the course structure is already pretty well, however, I would suggest providing more guided coding exercises and exam-style practice questions. Though I think it is already plenty.
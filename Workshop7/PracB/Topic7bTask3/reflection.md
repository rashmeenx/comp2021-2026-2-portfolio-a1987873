### 1. What data structure backs a PriorityQueue? How did you find out?

The .NET PriorityQueue<TElement, TPriority> uses an array-backed quaternary min-heap. A min-heap keeps the element with the lowest priority value near the top so that it can be removed efficiently. I found this in the Microsoft .NET documentation for PriorityQueue.

### 2. What happens when you Enqueue two different players with the same priority?

Both players can be added to the PriorityQueue. Unlike a SortedSet, a PriorityQueue does not require its elements or priorities to be unique.

For example:

eventQueue.Enqueue(player1, 1);
eventQueue.Enqueue(player2, 1);

Both players will be stored in the queue.

However, when two elements have the same priority, the PriorityQueue does not guarantee that they will be removed in the same order that they were inserted. Therefore, equal-priority elements should not be assumed to follow FIFO order.

### 3. Why does a PriorityQueue permit duplicates when a SortedSet does not?

The two collections have different purposes.

A SortedSet represents a set of unique elements, so duplicates are not allowed. If two elements compare as equal, the second element is treated as a duplicate.

A PriorityQueue is designed for scheduling or processing items according to priority. Multiple different items may naturally have the same priority, so duplicate priority values are allowed.

For example, two players may both have priority 1:

Player A -> priority 1
Player B -> priority 1

Both still need to be processed, so the PriorityQueue keeps both of them.
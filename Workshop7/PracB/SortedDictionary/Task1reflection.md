### What is the data structure backing the SortedDictionary? How did you find out?
Answer: SortedDictionary<TKey, TValue> is backed by a balanced binary search tree. This allows the dictionary to keep its keys sorted while still supporting efficient insertion, deletion and searching. I found this by checking the Microsoft .NET documentation and source implementation for SortedDictionary.

source: https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.sorteddictionary-2?view=net-10.0

### What happened when you tried to add the a duplicate score? Why?
Answer: When I tried to add another player with a score that already existed, an ArgumentException was thrown. This happened because the score is being used as the key of the SortedDictionary, and dictionary keys must be unique. Therefore, two different players cannot have the same score when the score itself is used as the key.
The .Add() method specifically checks for an existing key and throws if found (as opposed to [] indexer assignment, which would just overwrite the value). Adding a duplicate name worked fine, because the name is just the value. And the dictionaries don't enforce uniqueness on values, only on keys.

### Contrast SortedSet and SortedDictionary. Provide an example of when each might be useful.
Answer: SortedSet<T> stores a collection of unique values only, sorted automatically, with no duplicates allowed. SortedDictionary<TKey, TValue> stores unique keys paired with values, sorted by key, where the values themselves can repeat.

Therefore,  we can use SortedSet when we need a sorted collection of unique items with no extra data attached, and SortedDictionary when each item needs an associated value linked to a unique key.

Example - SortedSet: Keeping a sorted, duplicate-free list of player names who have completed a level, where we only care about who finished and want them alphabetically sorted.

```csharp
var completedLevel = new SortedSet<string>();
completedLevel.Add("Alice");
completedLevel.Add("Bob");
completedLevel.Add("Alice"); // ignored silently, no duplicate allowed
```

Example - SortedDictionary: A leaderboard where each score (key) needs an associated player name (value), and you need to look things up by score while keeping everything sorted.

```csharp
var leaderboard = new SortedDictionary<int, string>();
leaderboard.Add(99, "George");
leaderboard.Add(85, "Alice");
```
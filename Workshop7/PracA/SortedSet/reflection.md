# Reflection Questions
### Did you need to run .Sort() or similiar on your SortedSet to maintain its ordering? Why or why not?
Answer: I did not need to run .Sort() as SortedSet already automatically sorts its element from lower to higher. That is why, when I displayed the output using foreach, they were already sorted without using .Sort().

### What is the underlying data structure used by SortedSet? How did you find out?
Answer: SortedSet uses a red-black tree, which is a type of binary search tree. This allows it to keep the elements sorted while values are being added or removed. I found this by checking the Microsoft .NET documentation and the SortedSet source code.

Source: https://github.com/dotnet/dotnet/blob/b0f34d51fccc69fd334253924abd8d6853fad7aa/src/runtime/src/libraries/System.Collections/src/System/Collections/Generic/SortedSet.cs

### What happened when you tried to add the duplicate score to the set? Why does SortedSet behave this way?
Answer: When I tried to add a duplicate score, it was not added and the set stayed the same. This is because a SortedSet only stores unique values, so duplicates are not allowed. If .Add() is used with a value that already exists, it returns false instead of adding another copy of the value.
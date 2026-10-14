## 1. What does the ! symbol at the end of the Deserialize line do?
The ! is the null-forgiving operator. It tells C# that we expect the result not to be null, so the compiler should not give a nullable warning.
For example:
JsonSerializer.Deserialize<List<Player>>(loadedJson)!

## 2. What happens if all your class properties aren't public?
JsonSerializer normally serialises public properties. If properties are not public, they may not be included in the JSON file and their values may not be restored properly when deserialising. So the value might not get updated if in private.

## Reflection from Task 3
### What does where T : class mean?
It means the generic type T must be a reference type, such as a class. It prevents value types like int, double, or bool from being used with that method.

## Reflection from Task 4
### 1. What is the purpose of the Garbage Collector?
The Garbage Collector automatically manages memory in .NET. It finds objects that are no longer being used and frees the memory occupied by them.
### 2. Why does it know the current amount of bytes allocated to the Heap?
Because the Garbage Collector manages the managed heap where .NET objects are stored, so it keeps track of how much memory is currently allocated there.
### 3. What does GC.Collect() do?
GC.Collect() forces a garbage collection to run. It checks for objects that are no longer reachable and attempts to reclaim their memory.
### 4. Was the PeakWorkingSet64 different to the HeapSizeBytes? Why?
Yes, it is usually larger. HeapSizeBytes measures the managed .NET heap, while PeakWorkingSet64 measures the maximum physical memory used by the entire process. That includes more than just managed objects, such as runtime memory, libraries, stacks, and other operating system resources.

## Reflection from Task 5

### 1. Which class used more memory?
LinkedList<Player> use more memory than List<Player>.
### 2. Why?
A List<T> mainly stores its elements in one array.
A LinkedList<T> stores each item inside a separate node, and each node also keeps references to the previous and next nodes. Those extra references and node objects require additional memory.
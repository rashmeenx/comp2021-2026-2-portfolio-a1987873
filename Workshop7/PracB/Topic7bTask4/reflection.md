### 1. In previous tasks we had to implement IComparer or IComparable to get priority working. Why wasn't it required for our Priority enum?

An enum already has a natural numeric ordering because each enum member has an underlying integer value.

For example:

public enum Priority
{
    HighPriority,
    MediumPriority,
    LowPriority
}

is effectively:

HighPriority   = 0
MediumPriority = 1
LowPriority    = 2

Because these enum values can already be compared, the PriorityQueue can use the default comparer and does not need a custom IComparer.

Since PriorityQueue removes the lowest priority value first, HighPriority with the value 0 will be processed before MediumPriority and LowPriority.

### 2. If instead of an enum, we used a struct with one property int Priority { get; set; } = 0, would we need to implement IComparer or IComparable? Why or why not?

Yes, a custom struct would normally need to implement IComparable/IComparable<T>, or a separate IComparer would need to be supplied.

For example:

public struct MyPriority
{
    public int Priority { get; set; }
}

Although the property inside the struct is an int, the PriorityQueue is comparing MyPriority objects, not the integer property directly.

C# does not automatically know that the Priority property is the value we want to use for comparison. We therefore need to define how two MyPriority objects should be ordered.

For example, an IComparer<MyPriority> could compare:

x.Priority.CompareTo(y.Priority);

This explicitly tells the collection that a smaller Priority value should come before a larger one.
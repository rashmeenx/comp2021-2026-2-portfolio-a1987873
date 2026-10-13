## 1. What happened when you tried to add the (Key: String, Value: int) entry? Why?
The entry was added successfully even though the key was a String instead of a Player.
This happens because Hashtable stores keys and values as Object, so it does not enforce compile-time type safety. Therefore, different types of objects can be added to the same Hashtable.


## 2. What happened when you tried to add the duplicate Key?
An exception was thrown when I attempted to add the same key again.
A Hashtable requires every key to be unique. The .Add() method does not overwrite an existing value when the key already exists; instead, it throws an exception.


## 3. Were you able to use LINQ methods when writing your sorting algorithm? Why / why not?
Not directly. Hashtable is a non-generic collection, so its keys and values are stored as object. This makes LINQ less straightforward because the entries usually need to be cast or converted into a suitable type first.
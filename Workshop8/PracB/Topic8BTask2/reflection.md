## 1. What does the ! symbol at the end of the Deserialize line do?
The ! is the null-forgiving operator. It tells C# that we expect the result not to be null, so the compiler should not give a nullable warning.
For example:
JsonSerializer.Deserialize<List<Player>>(loadedJson)!

## 2. What happens if all your class properties aren't public?
JsonSerializer normally serialises public properties. If properties are not public, they may not be included in the JSON file and their values may not be restored properly when deserialising. So the value might not get updated if in private.

## Reflection from Task 3
### What does where T : class mean?
It means the generic type T must be a reference type, such as a class. It prevents value types like int, double, or bool from being used with that method.
# comp2021-2026-2-portfolio-a1987873-2-

An overview of the repository structure, including:  
Student name: Rashmeen Islam
ID: a1987873
Description of each module/topic:
Module 1:
Topic 1: We translated code from python to C#
Topic 2: Learnt to write classes, methods and Properties.
Topic 3: Learnt Inheritance, polymorphism and interface.
Module 2:
Topic 4: Learnt how to use debugger and how to refactor codes according to coding standard.
Topic 5: Learnt the difference between Arrays and LinkedList and how to use them.
Topic 6: Learnt the difference between two data structure- stack and queues where stack being LIFO(last in first out) and Queue being FIFO(First in first out)
Topic 7: Learnt about trees and heaps.
Topic 8: Learnt the knowledge of hash tables and complexity analysis.
Topic 9: Learnt about graphs and application and dijkstra's algorithm.

And in the topic 10: We attempted the sample questions.


Instructions for running examples: go to each of their own directories in the terminal and run "dotnet run", it will be run using the .NET.

Summary of learning progression:
According to the structure, we get to learn the basic foundations first, how to make classes using object oriented programming and then gradually learning how to use different data structures and finally how to make graphs and time complexity of each data structures, so that we can know which data structure is the most optimal for each type of code.

## Workshop 1

### Environment Check

#### dotnet --info
![info](<Week1a.Task1.Screenshot1.png>)
![dotnet info](<Week1a.Task1.Screenshot2.png>)


#### Debugger

![Debugger](<Week1a.Task1.Screenshot3.png>)

---

### Payroll Calculator

![Payroll Output](<Screenshot 2026-08-07 131022.png>)


---

### Git Log

![Git Log](<Screenshot 2026-08-07 130415.png>)

## Workshop 2

Changing from procedural to class-based design, made the program more organised, as payroll attributes and data are kept inside the Payroll class. In the procedural version, almost everything was in the Program.cs file. Whereas, the payroll logic seperates the payroll logic from user interaction, which made it easier to reuse, test and maintain.

Because of Static typing, I had to define the types, parameter and variable before running the program. It helps catching the mistakes earlier during compilation. For example, C# distinguishes between double and decimal, so I had to be more careful about which type I use, but the compiler gives useful errors when the types do not match. 
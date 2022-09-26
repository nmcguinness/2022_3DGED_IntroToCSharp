# Introduction To CSharp

## Overview ##
This repository contains code samples used to learn the basics of C# in preparation for the development of the MonoGame-based 3D game engine.

## Table of Contents ##
| Topic | Description | See (Source Code) | Additional Reading |
| :---------------- | :--------------- | :--------------- | :--------------- | 
| Namespace definition | Demo - defining namespaces  | [Program](https://github.com/nmcguinness/2022_3DGED_IntroToCSharp/blob/main/IntroductionToCSharp/Program.cs) | [Namespace](https://www.tutorialspoint.com/csharp/csharp_namespaces.htm) |
| Class definition | Demo - class, constructor, variables, ToString, GetHashCode | [Player](https://github.com/nmcguinness/2022_3DGED_IntroToCSharp/blob/main/IntroductionToCSharp/Demo/Player.cs), [Playerv2](https://github.com/nmcguinness/2022_3DGED_IntroToCSharp/blob/main/IntroductionToCSharp/Demo/Playerv2.cs)  | [Class & Object](https://www.geeksforgeeks.org/c-sharp-class-and-object/) |
| Constructor chaining | Demo - calling one constructor from another | [Vector3](https://github.com/nmcguinness/2022_3DGED_IntroToCSharp/blob/main/IntroductionToCSharp/Demo/Vector3.cs), [Transform](https://github.com/nmcguinness/2022_3DGED_IntroToCSharp/blob/main/IntroductionToCSharp/Demo/Transform.cs)  | [Constructor Chaining](https://www.delftstack.com/howto/csharp/constructor-chaining-in-csharp/) |
| Properties | Demo - adding get/set properties | [Vector3](https://github.com/nmcguinness/2022_3DGED_IntroToCSharp/blob/main/IntroductionToCSharp/Demo/Vector3.cs), [Transform](https://github.com/nmcguinness/2022_3DGED_IntroToCSharp/blob/main/IntroductionToCSharp/Demo/Transform.cs)  | [C# Properties](https://www.geeksforgeeks.org/c-sharp-properties/) |
| Static Methods | Demo - creating user-friendly constants (e.g. Vector3.Zero) | [Vector3](https://github.com/nmcguinness/2022_3DGED_IntroToCSharp/blob/main/IntroductionToCSharp/Demo/Vector3.cs)  | [Static Methods](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members) |
| Shallow vs Deep Copy | Demo - creating shared (shallow) or distinct (deep) objects | [Vector3](https://github.com/nmcguinness/2022_3DGED_IntroToCSharp/blob/main/IntroductionToCSharp/Demo/Vector3.cs)  | [Shallow Copy and Deep Copy in C#](https://www.geeksforgeeks.org/shallow-copy-and-deep-copy-in-c-sharp/) |
| Operator overloading | Demo - adding useful arithmetic (e.g. +, *) and logical (e.g. ==) operators | [Vector3](https://github.com/nmcguinness/2022_3DGED_IntroToCSharp/blob/main/IntroductionToCSharp/Demo/Vector3.cs)  | [Operator Overloading](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading) |
| Data Structures | Demo - using a List<T> | [Program](https://github.com/nmcguinness/2022_3DGED_IntroToCSharp/blob/main/IntroductionToCSharp/Program.cs)  | [C# List Tutorial](https://www.c-sharpcorner.com/article/c-sharp-list/) |
| Lambda Expressions | Demo - using a Lambda Expression to find in a List<T> | [Program](https://github.com/nmcguinness/2022_3DGED_IntroToCSharp/blob/main/IntroductionToCSharp/Program.cs) | [Lambda Expressions](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions) |
| enum | Demo - using an enum to represent a fixed set of player types, sorting by enum | [Program](https://github.com/nmcguinness/2022_3DGED_IntroToCSharp/blob/main/IntroductionToCSharp/Program.cs), [Player](https://github.com/nmcguinness/2022_3DGED_IntroToCSharp/blob/main/IntroductionToCSharp/Demo/Player.cs), [PlayerType](https://github.com/nmcguinness/2022_3DGED_IntroToCSharp/blob/main/IntroductionToCSharp/Demo/PlayerType.cs)  | [C# Enumeration (or enum)](https://www.geeksforgeeks.org/c-sharp-enumeration-or-enum/) |
| Predicate | Demo - how to use a Predicate in the List class, how to pass a Predicate as a parameter | [Program](https://github.com/nmcguinness/2022_3DGED_IntroToCSharp/blob/main/IntroductionToCSharp/Program.cs)  | [Predicate](https://www.tutorialsteacher.com/csharp/csharp-predicate) |
| Func & Action | Demo - how to store a lambda expression in a Func/Action, how to pass a Func/Action as a parameter | [Program](https://github.com/nmcguinness/2022_3DGED_IntroToCSharp/blob/main/IntroductionToCSharp/Program.cs)  | [Func](https://www.tutorialsteacher.com/csharp/csharp-func-delegate), [Action](https://www.tutorialsteacher.com/csharp/csharp-action-delegate) |
| Indexer | Demo - how to use an indexer to gain access to a List in a class | [PlayerList](https://github.com/nmcguinness/2022_3DGED_IntroToCSharp/blob/main/IntroductionToCSharp/Demo/PlayerList.cs) | [Indexers](https://www.tutorialspoint.com/csharp/csharp_indexers.htm) |

### To Do - Week 1
- [x] Added Transform
- [x] Added Vector3
- [x] Added constructor chaining
- [x] Added properties (set/get)
- [x] Added validation on set properties
- [x] Added protected on set properties
- [x] Added static readonly constants (e.g. Vector3.Zero)
- [x] Added intellisense regions to organise our code
- [x] Added demo for deep/shallow copy using Clone
- [x] Used 'as' keyword to perform a typecast

### To Do - Week 2
- [x] Operator overloading
- [x] Added demo using list to store strings, Vector3 objects
- [x] Added FindAll, RemoveAll, Sort demos using Lambda expressions
- [x] Added enum demo to show how to set enum symbol order (e.g Mage = 1) and how to sort by enum
- [x] Predicate, Func, Action
- [x] Enums in PlayerType
- [x] Indexers in PlayerList
- [x] Inheritance in PlayerListInheritance

### To Do - Week 3
- [ ] Inheritance - simpler example
- [ ] Keywords: virtual, override
- [ ] Keywords: var, ref, out
- [ ] Polymorphism
- [ ] Interfaces
- [ ] Structs
- [ ] Generics
- [ ] Tuple
- [ ] Collections 2 - Array, Dictionary, Set
- [ ] Exception Handling
- [ ] Tuple
- [ ] Delegates
- [ ] Events


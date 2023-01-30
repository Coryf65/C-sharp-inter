# C-sharp-inter

A demo for learning more C# concepts and reviewing things. 

C# .NET6 Console App

##  Inheritance

1. What is it?

- a relationship between two classes that allows one to inherit code from the other.

- Is-A (relationship)

Example: A Car is a Vehicle.

2. Why ?

Benefits

 - *Code re-use*
 - Poymorphic behaviour


## Composition

1. What

- A kind of relationship between two classes that allows one to contain the other.

- Has-a relationship

- Example: A Car has an Engine

2. Why ?

- *Code re-use*

- Flexibility

- A means to loose-coupling

## Favor Composition over Inheritance

- Problems with inheritance

1. Easily abused by amatuer designers / developers

2. Large hierarchies

3. Fragility

4. Tightly Coupled

- Advantages of Composition over Inheritance

Any Inheritance relationship can be translated to Composition.

1. Greater Flexibility

2. Loose Coupling

## 2 types of relationships between clases

1. Inheritance (IS-A)

| Pros  | Cons |
| ----- | ---- |
| Code re-use  | Tightly coupled / fragile  |
| easier to understand (Person is-a Animal)  | can be abused  |

2. Composition (HAS-A)

| Pros  | Cons |
| ----- | ---- |
| Great flexibility  | harder to understand |
| Loose coupling  | |
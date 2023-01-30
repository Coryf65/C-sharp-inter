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

## Access Modifiers

- Why access modifiers are important

- Black box Metaphor
	- Design a class like a black box only expose what you have to and make it simple. Like a DVD player (simple for the end user and complicated for the engineer)

### Access Modifiers in C#

1. Public

	- The type or member can be accessed by any other code in the same assembly or another assembly that references it.
		The accessibility level of public members of a type is controlled by the accessibility level of the type itself.

2. Private

	- The type or member can be accessed only by code in the same class or struct.

3. Protected

	- The type or member can be accessed only by code in the same class, or in a class that is derived from that class.

4. Internal

	- The type or member can be accessed by any code in the same assembly, but not from another assembly.
		In other words, internal types or members can be accessed from code that is part of the same compilation.

5. Protected Internal

	- The type or member can be accessed by any code in the assembly in which it's declared, or from within a derived class in another assembly.

6. Protected Private

	- The type or member can be accessed by types derived from the class that are declared within its containing assembly.


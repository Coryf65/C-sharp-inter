# C-sharp-inter

A demo for learning more C# concepts and reviewing things. 

These are some notes I found interesting or wanted to elaborate more for myself.

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

 > The *Object Class* is the base of all classes in .NET

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

## Upcasting and Downcasting

- Conversion from a dervied class to a base class (upcasting)
- Conversion from a base class to a derived class (downcasting)
- The *as* and *is* keywords

Upcasting (example)

```C#
Circle circle = new();
Shape shape = circle;
```

Downcastin (example)

```C#
Circle circle = new();
Shape shape = circle;

Circle anotherCircle = (Circle)shape;
```

The *as* Keyword

```C#
Car car = obj as Car;

if (car != null)
{
	Console.WriteLine("The conversion worked");
}

Console.WriteLine("This object is a Car!");
```

The *is* Keyword

```C#
if (obj is Car)
{
	Console.WriteLine("This object is a Car!");
}
```

## Boxing and Unboxing

The process of converting a value type instance to an object reference.

exmaple:
```C#
int number = 10;
object obj = number;

// or
object obj = 10;
```

> They do have a performance penalty

### Types in C#

#### Value Types 

- are stored on the stack

- examples 

	- All primitive types: byte, float, int, char, bool
	- The struct type

- These have a short lifetime once out of scope they get kicked off the stack and removed from the runtime

#### Reference Types

- are stored in the heap

- examples

	- Any classes: Object, Array, String, Custom Classes etc..

- Longer lifetime stores larger size items

## Method Overriding

Modifying the implementation of an inherited method

keyword *override*

```C#

public class Shape
{
	public virtual void Draw()
	{
		Console.WriteLine("Base Draw function.");
	}
}

public class Circle : Shape
{
	// Here we are changing the behaviour of the Draw funciton
	public override void Draw()
	{
		base.Draw(); // using the base functionality could be removed

		Console.WriteLine("New functionality from Circle!");
	}
}
```

##  Polymorphism (Many Forms)


## Abstract Classes and Members

- The *Abstract* modifier indicates that a class or a member is missing implementation

### Why

When you want to provide some common behaviour, while forcing other developers to **follow your design**.

### Rules

- Do *not* include implementation
```C#
public abstract void Draw();
```

- If a member is declared as abstract, the containing class *needs*
 to be declared as abstract too.
```C#
public abstract class Shape
{
	public abstract void Draw();
}
```

- The Dervied class *Must* implement all abstract members from the base abstract class.

- Abstract classes *cannot* be instantiated

```C#
Shape shape = new(); // Won't compile
```

Example:

```C#
public abstract class Shape
{
	// we are not providing an implementation
	public abstract void Draw();
}

public class Circle : Shape
{
	// overriding the Draw Method
	public override void Draw()
	{
		// Providing our own implementation
		Console.WriteLine("Drawing a circle");
	}
}
```

## Sealed Classes and members

Prevents derivation of classes or overriding of methods

When applied to a class, the sealed modifier prevents other classes from inheriting from it. 
In the following example, class B inherits from class A, but no class can inherit from class B.

You can also use the sealed modifier on a method or property that overrides a virtual method or property in a base class.
This enables you to allow classes to derive from your class and prevent them from overriding specific virtual methods or properties.

To determine whether to seal a class, method, or property, you should generally consider the following two points:

    1. The potential benefits that deriving classes might gain through the ability to customize your class.

    2. The potential that deriving classes could modify your classes in such a way that they would no longer work correctly or as expected.


```C#
public sealed class Circle : Shape
{
	public override void Draw()
	{
		Console.WriteLine("Drawing a circle");
	}
}
```

## Interfaces

A language construct that is similar to a class but is fundamentally different

Defines the capability a class should provide

> Interfaces are *NOT* multiple inheritance, they have nothing to do with inheritance they *Implement* Interfaces

These help build loosley coupled apps

also help improve testability 

> Demo of Unit tests using XUnit and OrderingDemo, along with OrderingDemo.UnitTest

Interfaces also help with Extensibility

created an ILogger and now able to use a Console or a File class to write out messages!

```C#
DBMigrator migrator = new(new ConsoleLogger());
DBMigrator migrator = new(new FileLogger(@"/log/log.txt"));
```


## Polymorphism


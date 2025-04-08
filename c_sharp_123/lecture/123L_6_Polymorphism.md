Classes: Polymorphism


## silde1 Objectives
---

- What is Polymorphism?
- Benefits of Polymorphism
- Example
- Summary



## silde3 What is polymorphism?
---

Polymorphism is often referred to as the third pillar of object-oriented programming, after encapsulation and inheritance.

It facilitates a class to have many implementation with the same name

There are two distinct aspects:

Static (compile time)

Dynamic (runtime)


## silde4
---



## silde5 Static Polymorphism
---
It is also known as Early Binding.

It is also known as Compile Time Polymorphism because the decision of which method is to be called is made at compile time.

Method overloading is an example of Static Polymorphism.

Operator overloading is another example of Static Polymorphism

Overloading is when multiple methods have the same name. They are different by the parameter list

## silde6 Dynamic Polymorphism
---
uIt is also known as Late Binding.

uIt is also known as Runtime Polymorphism because the decision of which method is to be called is made at runtime.

uInheritance facilitates this type of polymorphism

uIn your source code you might invoke a call on the base class, but because that member is replaced, the implementation in the child class is called

uMember replacement is done via the virtual/override technique

u

uThis form of polymorphism depends on inheritance.


## silde7 Static Binding
---

The method to be called is is fixed when the program complies.

We have already looked a lots of examples of method overloading as well as operator overloading.


## silde8 Example 1 – Dynamic binding
---

```c#
//This will be the parent class of all the other classes

class DrawingObject

{

  public virtual void Draw()   //may be overridden in derived classes

  {

     Console.WriteLine("I am just a generic drawing object.");

  }

}

class Line : DrawingObject

{

  //replaces the same member of the parent class

  public override void Draw()  

  {

     Console.WriteLine("I am a line.");

  }

}

class Circle : DrawingObject {

  public override void Draw(){   //replaces the same member of the parent class

     Console.WriteLine("I am a circle.");

  }

}

class Square : DrawingObject {

  public override void Draw(){   //replaces the same member of the parent class

     Console.WriteLine("I am a square.");

  }

}

List<DrawingObject> objs = new List<DrawingObject>()

  { new Line(), new Circle(), new Square(), new DrawingObject() };

foreach (DrawingObject obj in objs){

  obj.Draw();          //this Draw() method points to different

}                      // logic (depending on the type of obj)

//Output – Although all the Draw method have a single WriteLine(), it does not have to be so. They can implement different logic.

I am a Line.

I am a Circle.

I am a Square.

I am just a generic drawing object.
```


## silde12 summary
---

Early binding and late binding are important features of the runtime

Late binding depends on inheritance.

You don’t have to know the type at runtime to invoke the appropriate method, this is done automatically by the runtime.


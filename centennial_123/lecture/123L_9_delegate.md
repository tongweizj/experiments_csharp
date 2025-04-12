## OUTLINE

- To know what is a delegate
- To understand when to use delegates
- To know how to declare, instantiate and call a delegate
- Built-in delegates
	- Action
	- Func
## 概念
delegate代表

- A type that safely and securely **encapsulates** a named or anonymous method. (A type the represents references to methods.)
	- 一种安全且可靠的类型(type)
	- 用来封装其他的方法(可以是**命名或匿名)方法**
	- 表示对方法的引用的类型

- When instantiated, it stores a reference to a method (either named or anonymous) or some code (lambda expression)
- 实例化时，它存储对方法（命名或匿名）或某些代码（lambda 表达式）的引用

- This object can then be passed to code to call the reference method. The invoking method does not know at compile time which method will be called
然后可以将此对象传递给代码以调用引用方法。调用方法在编译时不知道将调用哪个方法

- This reference method is not bound at compile time, it can dynamically change to invoke different methods during the execution of the program
此引用方法在编译时不受约束，它可以在程序执行期间动态更改以调用不同的方法

- It allows you to pass a method of a class to objects of other classes
它允许您将一个类的方法传递给其他类的对象

- The delegate object does not need to know the class of the object that calls it, all that matters is the method argument and the method return type matches the delegate
委托对象不需要知道调用它的对象的类，重要的是方法参数和方法返回类型与委托匹配

- Can be considered as an object that acts on behalf or in coordination with another object
可以被视为代表另一个对象或与另一个对象协调行事的对象


## When and why do you use a delegate

- Events and callback would not work without delegates. 
- Allows methods to be passed as parameters.
- Can be stored in a class or struct 可以存储在类或结构中
- GUI programming depends solely on the use of Events and Callbacks (which are special delegates). 

- When you would like to invoke methods that you don't know until runtime. 
- 当您想要调用直到运行时才知道的方法时。
- Calling anonymous methods.
- Calling lambda expressions. 
- The caller has no need to access other properties, methods, or interfaces on the object implementing the method. 
- Can replace Interface. 
- To update the GUI from a thread.

  
如果没有委托，事件和回调将无法工作。
允许将方法作为参数传递。

GUI 编程完全依赖于事件和回调（特殊委托）的使用。

调用匿名方法。
调用 lambda 表达式。
调用者无需访问实现该方法的对象上的其他属性、方法或接口。
可以替换接口。
从线程更新 GUI。

## code

```c#
// STEP 1 - Code the method that the delegate will point to
// This is the first step, because the return type as well as the argument type is needed when the delegate will be declared 

//this is the method that will be passed in the delegate 
private static void Picasso() 
{ 
  Console.WriteLine( "Done by picasso" ); 
}

// More than one method can be passed by the same delegate provided the return type and the number and type of parameter are the same. 
// 只要返回类型以及参数的数量和类型相同，同一个委托就可以传递多个方法。
// Otherwise you will have to use a different delegate for each method that is different.  否则，您将必须对每种不同的方法使用不同的委托。


// STEP 2 - Declaration

// As with all declarations the placement depends on the scope of the intended usage. If it is used in a single method, class or a number of classes .. 

//Syntax: 

public delegate return_type delegate_name( arg1_type arg1, arg2_type arg2);

//Our delegate will be declared directly in the namespace: 
public delegate void Signor( );


// STEP 3 - Instantiation

// After a delegate type has been declared, a delegate object is created and associated with the appropriate method. 

// Syntax: 
delegate_name delegate_object = new delegate_name(method_name); 

// Our delegate instantiation
Signor delegate = new Signor(Picasso); //one delegate
Signor picasso = new Signor(Picasso);  //another delegate

// STEP 4 - Invocation/Calling
// After a delegate object is created, it is normally passed to other code that will call the delegate. 
// A delegate object is called by using the name of the delegate object, followed by the parenthesized arguments 

// Syntax: 
delegate_object(argument_list); 

Calling the method
delegate(); 
picasso(); 


```
  



  



  



  



  


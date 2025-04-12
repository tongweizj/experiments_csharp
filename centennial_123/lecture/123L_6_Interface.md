[[123N_interface]]

- ## Classes: Interface
- ### index
- What is an Interface?
- Uses of Interface
- Example
- The is and as operator
- Summary
- ## What is an interface?
  
  An interface in C# is a <font color="#f79646">type that contains</font> only the declaration of <font color="#f79646">methods, properties, events or indexers</font>.
  These declaration are empty i.e. there is no implementation.
  C# 中的接口是一种仅包含方法、属性、事件或索引器声明的类型。
  这些声明为空，即没有实现。
- An interface contains contracts (promises) for a group of **related functionalities** that a class or a struct can implement.
  接口包含类或结构可以实现的一组相关功能的契约（承诺）。
- May not contain constants or fields.
- Members cannot be **static**.
- All the members of an interface are implicitly public.
- Actually, any accessibility modifier will cause a compiler error.
  可能不包含常量或字段。
  成员不能是静态的。
  接口的所有成员都是隐式公共的。
  实际上，任何可访问性修饰符都会导致编译器错误。
- ## What are the benefits of an interface?
  
  It allows you to include behavior from multiple sources in a single class. 
  它允许您在单个类中包含来自多个来源的行为。
  
  This is important in C# because the language doesn't support multiple inheritance of classes. 
  这在 C# 中很重要，因为该语言不支持类的多重继承。
  
  In addition, it enables you to simulate inheritance for structs, because they can't actually inherit from another struct or class.
  此外，它使您能够模拟结构的继承，因为它们实际上不能从另一个结构或类继承。
  
  Most of the **collection classes** implements the `ICollection<T>` interface, so you have the
- Clear(),
- Contains()
- and Remove() methods. 
  
  Some classes implements multiple interfaces `IEnumerable<T>, IEnumerator<T>, IList<T>, IDictionary<T> ISet<T>` 
  
  If a class implements an interface, then you may refer to its objects as if they were that of the interface type. See slide # 10
  
  
  大多数集合类都实现了 `ICollection<T>` 接口，因此您有 `Clear()、Contains() 和 Remove()` 方法。一些类实现了多个接口 `IEnumerable<T>、IEnumerator<T>、IList<T>、IDictionary<T> ISet<T>`
  如果一个类实现了一个接口，那么您可以引用它的对象，就好像它们是接口类型的对象一样。参见幻灯片 # 10
- ## Example 1
  
  interface name starts with I and ends with able
  implicitly public
  
  ```c#
  interface ISingable 		//starts with I and ends with able
  { 
    void Sing();				//member is implicitly public
  }
  
  interface ILikeable
  { 
    bool Like(string dish); //method that takes a string and returns a bool
  }
  
  interface IMoveable
  {
     string Move { get; } 	//this is a property
  }
  
  ```
  
  
  
  ```c#
  class Frog : ISingable
  {
  public void Sing()
  {
    Console.WriteLine("ribbit");
  } 
  }
  
  class Rabbit : IMoveable
  {
  public string Move
  { 
    get  => "hop";
  } 
  }
  ```
  
  
  ```c#
  class Bird : ISingable, ILikeable 
  {    
    public void Sing()
      { 
        Console.WriteLine("tweet tweet");
      }   
  
    public bool Like(string food) 
    => food == "worm" || food == "seeds";
  } 
  
  
  ```
- ## abstract class
  abstract可以用来修饰类,方法,属性,索引器和时间,这里不包括字段. 
  使用abstrac修饰的类,该类只能作为其他类的基类,不能实例化,
  而且abstract修饰的成员在派生类中必须全部实现,不允许部分实现,否则编译异常. 
  
  ```c#
  interface ILikeable
  { 
    bool Like(string dish); //method that takes a string and returns a bool
  }
  
  interface IMoveable
  {
     string Move { get; } 	//this is a property
  }
  
  abstract class Pet : IMoveable, ILikeable
  {
  public abstract string Move { get; }
  public abstract bool Like(string dish); 
  }
  
  class Snake : Pet
  {
  public override string Move 
  {
    get => "crawl";
  }
  public override bool Like(string dish)
    => dish == "mouse";
  }
  
  ```
- ## Example 2
  
  ```c#
  interface IBar
  {
  void Foo();
  }
  interface IBaz
  {
  void Foo(); 、、 定义方法
  }
  
  ```
  
  
  ```c#
  class Qux : IBar, IBaz{ 
  void IBar.Foo() // 具体实现了
  { 
    Console.WriteLine("IBar.Foo");
  }  
  
  void IBaz.Foo()
  { 
    Console.WriteLine("IBaz.Foo");
  }
  } 
  
  
  //sample run 
  // TODO 实现一次，不太明白
  Qux obj = new Qux(); 
  ((IBar)obj).Foo();  // iBar.Foo          
  ((IBaz)obj).Foo();  
  
  ```
- ## Example 3
  
  ```c#
  
  interface IDrivable
  {
  void ChangeGear(int i);
  void SlowDown(int i);
  void SpeedUp(int i);
  }
  
  class Bicycle : IDrivable
  {
  int speed, gear;
  public void ChangeGear(int i) => gear = i; 
  public void SlowDown(int i) => speed -= i; 
  public void SpeedUp(int i) => speed += i;
  public override string ToString()
    => $"Gear:{gear}, speed:{speed}"; 
  }
  }
  
  
  ```
- ## Example 4
  
  ```c#
  interface IEmployee
  {
    string Name
    {
        get;
        set;
    }
  
    int Counter
    {
        get;
    }
  }
  
  public class Employee : IEmployee {
  public static int numberOfEmployees;
  private string name;
  public string Name { 		// read-write instance property
    get =>  name;
    set =>  name = value;
  }
  
  private int counter;
  public int Counter{  		// read-only instance property
    get =>  counter;
  }
  
  public Employee() => counter = ++numberOfEmployees;	// constructor
  }
  
  ```
- ## Example 5 – Inheritance
  
  ```c#
  interface IBar
  {
  void Foo();
  }
  interface IBaz
  {
  void Quz();
  }
  interface IQux : IBar, IBaz
  {
  void Quux();
  }
  
  
  ```
- ## The `is` operator
  
  The is operator is used to check if the run-time type of an object is compatible with the given type or not
  The is operator returns true if the given object is of the same type
  The is operator returns false if the given object is not of the same type
  is 运算符用于检查对象的运行时类型是否与给定类型兼容
- 如果给定对象属于同一类型，则 is 运算符返回 true
- 如果给定对象不属于同一类型，则 is 运算符返回 false
  
  The is operator is used for only **<font color="#f79646">reference, boxing, and unboxing conversions</font>**
  
  It is also possible to do pattern matching (will not be done in this course)
  The is operator works with interface as well as classes
  Slide #8
  
  
  
  is 运算符仅用于引用、装箱和拆箱转换
  也可以进行模式匹配（本课程不会进行）
  is 运算符适用于接口和类
  
  ```c#
  Bird jake = new Bird();
  jake is Bird -> true
  jake is ISingable -> true
  jake is ILikeable -> true
  jake is IMoveable -> false
  
  ```
- ## The `as` operator
  
  The as operator is used to perform conversion between compatible reference types or nullable types
  
  if conversion fails a null is returned instead of an error being raised
  
  The as operator works with interface as well as classes
  
  
  Slide #8
  ```c#
  
  Bird b = new Bird();
  
  AnotherClass c = b as AnotherClass;
  
  if (b != null)
  
  {
  
  Console.WriteLine("Conversion successful");
  
  }
  ```
- ## 对比
  
  | Abstract Class                                                                               | Interface                                                                                                 |
  | -------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
  |                                                                                              |                                                                                                           |
  | Cannot be instantiated（实例化）                                                                  | Can not be instantiated                                                                                   |
  | Can contain both declaration and implementations (complete methods)                          | Contains only declarations                                                                                |
  | Members can be decorated with different access modifiers                                     | All members are public                                                                                    |
  | A class can inherit only one abstract class                                                  | A class may implement multiple interfaces                                                                 |
  | A class that is derived from an abstract class must implement all inherited abstract members | A class or struct that implements an interface must provide implementation for all the promised behaviors |
  | May have data members (both fields and properties)                                           | May only have properties                                                                                  |
  | May have constructor                                                                         | Does not have constructors                                                                                |
- ## Some useful interfaces
  
  ```c#
  ICloneable,
  // Allows you to clone an object
  
  IComparable<T>,
  // Allows you to sort a collection of objects
  ```
- ## Summary
  
  Only contains declarations of method, events, indexers or properties.
  
  Can be implement implicitly or explicitly.
  
  Cannot include private members. All the members are public by default.
  
  Like an abstract class and it can contain only declarations of members such as methods, properties, indexers and events.
  
  Members are public and we are not allowed to include any other access modifiers.
  
  Cannot be instantiated directly, but it can be instantiated by a class or struct that implements an interface.
  
  The class or struct that implements an interface must provide an implementation for all the members that are specified in the interface definition.
  
  The class or struct can implement multiple interfaces.
  仅包含方法、事件、索引器或属性的声明。
  
  可以隐式或显式实现。
  
  不能包含私有成员。默认情况下，所有成员都是公共的。
  
  类似于抽象类，它只能包含成员的声明，例如方法、属性、索引器和事件。
  
  成员是公共的，不允许包含任何其他访问修饰符。
  
  不能直接实例化，但可以通过实现接口的类或结构实例化。
  
  实现接口的类或结构必须为接口定义中指定的所有成员提供实现。
  
  类或结构可以实现多个接口。
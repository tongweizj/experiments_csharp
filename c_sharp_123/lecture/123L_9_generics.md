## generics
泛型
定义变量时，不确定类型

## outline

- Problems
- Generics in action
- What is Generics?
- Where can you use Generics?
- Constraints
- More examples
	- Class
	- Interface
	- .NET generics
- Summary

## Problems

如果不使用generics 范型,存在的问题
```c#
// Consider the following method definition:
// 重复代码
public static int Add(int a, int b)
   => a + b;

public static long Add(long a, long b)
   => a + b;
   
public static double Add(double a, double b)
   => a + b;

// Type Safety

ArrayList list = new ArrayList();  
list.Add(50);  
list.Add("Dog");   
list.Add(new TestClass());  // 到这儿位置,添加是成功的

foreach(int i in list)  //this fails for the last two items
{  
    Console.WriteLine(i);    
} 

```

### Boxing and Un-Boxing

Boxing is converting a **value type** to a reference type 
值类型转换为引用类型
Un-boxing is converting a reference type to a value type
拆箱是将引用类型转换为值类型

```c#
ArrayList list = new ArrayList();  
list.Add(50);             //boxing (expensive)
int x = (int)list[0];     //unboxing (expensive)  

```
## 概念

- Was introduced in C# 2.0
- - 在 C# 2.0 中引入
- Generics allow you to defer the specification of the data type in a class or a method, until it is used in the program.- 泛型允许您推迟类或方法中数据类型的指定，直到在程序中使用时才指定。
> 在写代码的时候,不用立刻指定类型


- In other words, generics allow you to write a class or method without specifying a particular any data type.
- 换句话说，泛型允许您编写类或方法而无需指定任何特定的数据类型。
- 
- You write the specifications for the class or the method, with substitute parameters for data types. 您编写类或方法的规范，并使用数据类型的替代参数。
- 
- When the compiler encounters a constructor for the class or a function call for the method, it generates code to handle the specific data type. 当编译器遇到类的构造函数或方法的函数调用时，它会生成代码来处理特定的数据类型。
- Generics performs faster by not doing boxing and unboxing operation.
- 泛型不执行装箱和拆箱操作，因此执行速度更快。
- 
- Most **frequently** used with **collections** and the method that operates on them
- 最常用于集合及其操作方法

- Provides type-safety without the overhead of multiple implementations
- 提供类型安全性，而无需多次实现的开销

Generics can be applied to the following
- interface
- Abstract class
- Class
- Method
- Static method
- Property
- Event
- Delegates
- Operator

```C#
// generics <T> 这是标志
static void Display<T>(string msg, T value) // T = type
{
  Console.WriteLine($"{msg} {value}");
}

Display<int>("Hello", 5); // 在调佣的时候，才明确类型
Display<string>("Hello", "World");
// Hello 5
// Hello World
```


```C#

static void Swap<T>(ref T x, ref T y)
{
  T temp = a;
  a = b;
  b = temp;
}

int x = 4, y = 8;
Console.WriteLine($"Before x: {x} y: {y}");
Swap<int>(ref x, ref y);
Console.WriteLine($"After x: {x} y: {y}");

// Before x: 4 y: 8
// After x: 8 y: 4
```



```C#
static T[] MakeArray<T>(T value, int size)
{
  T[] result = new T[size];
  for(int i = 0;i < size;i++)
  {
    result[i] = value;
  }
}

int x[] bees = MakeArray<char>('b', 8);
Console.WriteLine($"{string.join(", ", bees)}");
// b, b, b, b, b, b, b, b

Console.WriteLine($"{string.join(", ", MakeArray<string>("Narendra", 3))}");
// Narendra, Narendra, Narendra

Console.WriteLine($"{string.join(", ", MakeArray<int>(12,  5))}");
// 12, 12, 12, 12, 12
```



```C#
Console.WriteLine($"{string.join(", ", MakeArray<string>("Narendra", 3))}");
// Narendra, Narendra, Narendra
```
这个遍历打印 list 的方法，要记牢

## generics class

```c#

class GenericClass<T>
{
  public T Value { get; }
  public GenericClass(T value)
  {
    Value = value;
  }
}

GenericClass obj = new GenericClass<int>(123);
Console.WriteLine($"Value is: {obj.Value}");
// Value is: 123

Console.WriteLine($"Value is: {new GenericClass<string>("Hello").Value}");
// Value is: Hello
```


```C#
class GenericClass<K, V>
{
  public K Key { get; }
  public V Value { get; }
  public GenericClass(K key, V value)
  {
    Key = key;
    Value = value;
  }
}

GenericClass obj = new GenericClass<string, string>("docx", "Word");
Console.WriteLine($"Files ending with {obj.Key} will be opened with: {obj.Value}");
// Files ending with docx will be opened with Word

obj = new GenericClass<string, string>("xlsx", "Excel");
Console.WriteLine($"Files ending with {obj.Key} will be opened with: {obj.Value}");
// Files ending with xlsx will be opened with Excel
```


## Generic Constraints
通用约束

```c#
Constraints are validations that we can put on generic Type parameter. At the instantiation time of generic class, if client provides invalid type parameter then compile will give an error.

There are six types of constraints.

where T : struct  
// Type argument must be a value type

where T : class - Type argument must be a reference type

where T : new() - Type argument must have a public parameterless constructor.

where T : <base class> - Type argument must inherit from <base class> class.

where T : <interface> -  Type argument must implement from <interface> interface.

where T : U - There are two type arguments T and U. T must be inherit from U.

```



```c#
interface IShowable<T>
{
  void Show(T val);
}

class GenericCls<T> : IShowable<T>
{
  public void Show(T value)
  {
    Console.WriteLine($"Value is {value}");
  }
}

IShowable obj = new GenericCls<string>();
obj.Show("Hello world!");

new GenericCls<int>().Show(123);

```


## Advantages of generics


### Reusability: 
You can use a single generic type definition for multiple purposes in the same code without any alterations. For example, you can create a generic method to add two numbers. This method can be used to add two integers as well as two floats without any modification in the code.


### Type Safety: 
Generic data types provide better type safety, especially in the case of collections. When using generics, you need to define the type of objects to be passed to a collection. This helps the compiler to ensure that only those object types that are defined in the definition can be passed to the collection.

### Performance: 
Generic types provide better performance as compared to normal system types because they reduce the need for boxing, unboxing, and typecasting of variables or objects.

## class members

- Constants
- Fields
- Methods
- Properties
- Events
- Indexers
- Operators
- Finalizers
- Instance Constrctors
- Static Constrctors
- Types

## class type

- partial class 部分类
- nested class
- Anonymos Class


### partial class
分部類
```c#
public partial class Employee 
{ 
  public void DoWork() { } 
} 

public partial class Employee { 
  public void GoToLunch() { } 
}
```


When a class in defined in **multiple source file**

Happens when mltiple entities/developers are assembling a single class

When mltiple parties needs ownership of their parts of the implementation

Or simply when it is convenient for the fill implementation of a class to be placed in multiple files

To achieve this, you need to decorate all the class definition with the partial keyword

Compiler will assemble all the parts

This is also possible with strcts and interfaces

Very convenient in gi programming

Visal Stdio generates code to manage the widgets in the gi – this code in contained in a class and placed in a file

Developer writing code to implement logic is contained in the same class bt in a different file

This techniqe is great to keep machine generated code separate from developer written code
## method

Extension Method




## class-Properties

### Usage of Properties

Can be used to perform the following:

- Conversion
- Sanity checks
- Secret stuffs

- Properties are used for data binding and **serialization**, not fields
属性用于数据绑定和序列化，而不是字段
- Remove write access
- Allows you to specify different read and write access level for the same property

- Ref and out decorators will not work when parameters are properties
可用于执行以下操作：
转换
完整性检查
机密内容
删除写入权限

允许您为同一属性指定不同的读取和写入访问级别

当参数是属性时，Ref 和 out 装饰器将不起作用


### Auto-implemented Property

```c#
public int Age { get; private set; }

//public read and write
public int Age { get; set; }           

//public read private write
public string Name{ get; private set;} 

//public read and set only in constructor
public string Id { get; }   

// accessor 隐藏 = private
int Age { get; private set; }
private int Age { get; private set; }

```

- If you are using a property to ONLY read or write a variable, C# provides an auto implemented property

- The syntax is extremely simple
- Great for trivial set and get:
- If you omit the accessor modifier for the property, then private is assumed (this is true for all members)

- If you omit the accessor modifier for the getter and the setter then the accessibility of the property is assumed

- An explicit accessor of both the getter and the setter **MUST BE** less restrictive than the property accessor
如果省略属性的访问器修饰符，则假定为私有（所有成员都是如此）

如果省略 getter 和 setter 的访问器修饰符，则假定属性具有可访问性

getter 和 setter 的显式访问器必须比属性访问器的限制更少


The compiler does the following:

- Creates a private anonymous backing field
创建一个私有匿名支持字段
- This is not available directly to the developer 

- For **get** it creates a parameter less method that returns the above backing field

- This method is automatically invoked whenever the property has to be read
对于 get，它会创建一个无参数方法，该方法返回上述支持字段
每当必须读取属性时，都会自动调用此方法

- For **set** it creates a method with a single implicit parameter name **value**

- This method is automatically invoked with the implicit argument whenever the property has to be written to

对于 set，它会创建一个具有单个隐式参数名称值的方法
每当必须将属性写入时，都会使用隐式参数自动调用此方法

```c#

// Creates a private anonymous backing field
private int age;

//method to read age
public int GetAge()                 
{
  return age;
}

//method to write age
public void SetAge(int value)      
{
  age = value;
}
```


```c#
//create an instance of the enclosing class
//assuming the class defines a property Age

Foo f = new Foo();

//read the property value
Console.WriteLine(f.Age);

//set the property value to 33
f.Age = 33;
```

public read and set only in constructor
```c#
class Person 
{ 
  public int Age { get; }
  public string Name { get; }

  public string Person(int age, string name)
  {
    Age = age;
    Name = name; 
  }
}
```



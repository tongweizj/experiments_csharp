## C# Feat - res That S - pport LINQ

- Query Expression

 - Implicitly types Variables

 - Object and Collection Initializers

 - Anonymous Types

 - Extension Methods

 - Lambda Expression

- Auto-Implemented Properties


## Auto-Implemented Properties
自动实现的属性
This makes property-declaration more concise
The compiler creates private anonymous backing filed that is not accessible except through the property getter and setter
这使得属性声明更加简洁
编译器创建私有匿名后备文件，除通过属性 getter 和 setter 外，无法访问

```c#
public string Name { get; set; }
```

##  The var keyword

### Implicitly Typed Variables
隐式类型变量 – var 关键字

Allows the compiler to infer and assign the type
推断并分配类型
```c#

var age = 25;

var name = "Narendra";
```


More importantly var makes it possible to create anonymous types
Or to **work with complex types**


Local variable may be declared without giving an explicit type
The var key instructs the complier to infer the type of the variable from the expression on the right side of the initialization statement

```c#

var i = 5;   // i is compiled as an int

~~i~~ ~~=~~ ~~"Hello"~~~~;~~   // cannot assign a string to an int variable

var s = "Hello";   // s is compiled as a string

var a = new[] { 0, 1, 2 };   // a is compiled as int[]
```

### Restrictions on var

限制

var can only be used when a local variable is declared and initialized in the same statement

Cannot be initialized to null, or to a method group or an anonymous function. 

var cannot be used on fields at class scope. 

Variables declared by using var cannot be used in the initialization expression
```c#

// this expression is legal: 
int i = (i = 20); 

// but this is not: 
var i = (i = 20);
```

Multiple implicitly-typed variables cannot be initialized in the same statement. 
Can make your program more difficult for other to read.

## Advantages of var

Can be useful with query expressions in which.
The var keyword can also be useful when
the specific type of the variable is tedious to type on the keyboard,
the exact constructed type of the query variable is difficult to determine
or is obvious,
or does not add to the readability of the code.

One example where var is helpful in this manner is with nested generic types such as those used with group operations. In one of the following queries, the type of the result is `IEnumerable<IGrouping<string, Student>>`

Implicit typing is userful for convenience and brevity.
隐式类型有利于方便和简洁。

Indispensable when working with anonymous types
在使用匿名类型时不可或缺
## Object and Collection Initializers

Make it possible to initialize object without explicitly calling a constructor
Are typically used in query expression when they project source data into a new data type
```c#

Customer cust   //object initializer
= new Customer { Name = "Narendra", Cell = "416-123-4567" };

List<string> friends   //object initializer
= new List<string> { "Mayy", "Ilia", "Hao", "Arben", };
```


## Anonymous Types

This is constructed by the compiler and the type name is only available to the compiler.

Provides a convenient way to group a set of properties temporarily in a query result without having to define a separate name type

Anonymous types are  initialized with a new expression and an object initializer.

这是由编译器构造的，类型名称仅对编译器可用。

提供一种方便的方法，可以在查询结果中临时对一组属性进行分组，而无需定义单独的名称类型

匿名类型使用新表达式和对象初始化器进行初始化。
```c#
var obj = new { Name = "Narendra", Cell = "416-123-4567" };
```

## Extension Methods

An extension method is a static method that can be associates with a type, so that it can be called as it it was an instance method of the type.

Allows you to add new methods to existing types without actually modifying them


## Lambda Expressions

This is an inline function that uses the  ` => ` operator to separate input parameter from the function body.

Can be converted at compile time to a delegate or an expression tree.
The its power is the convenience of writing/passing logic.



## Query Expression
Uses a declarative syntax similar to SQL or XQuery to query over IEnumerable collections.

At compile time, it is converted to method calls.
Don’t worry if you don’t understand the statement below, we will cover that in the next video.

```c#


var query = from str in stringArray

    group str by str[0] into stringGroup

    orderby stringGroup.Key

    select stringGroup;
```

## Summary

All the proceeding features were covered in C# 3.0.
These were necessary to implement linq
examples uses primitive type (int and string) as the query source.

The real strength of linq lies in the way you are able to access the parts of the underlying object to apply the linq operators.

In the next video, we will be using the query syntax to query a collection.

And the following one, we will be using method syntax to query a collection.
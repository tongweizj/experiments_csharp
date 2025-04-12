## Index

- What is Linq?
- Why is it useful?
- Linq vs Procedure
- var keyword
- Query Syntax
	- Filter
	- Order
	- Grouping
	- Project
	- Joins
- Method Syntax (covered in next class)

## What is Linq?

- Language Integrated Query
- Introduced in .NET3.5
- Both C# and VB have LINQ capabilities.
- Used for querying data such as relational, XML, and even objects.
- Another way to describe LINQ is that it is programming language syntax that is used to query data.

## Why is it useful?

Offers syntax highlighting that proves helpful to find out mistakes during design time.
提供语法高亮，有助于在设计时发现错误。

Offers IntelliSense which means writing more accurate queries easily.
Writing codes is faster in LINQ and thus development time also gets reduced significantly.
Makes easy debugging due to its integration in the C# language.
Viewing relationship between two tables is easy with LINQ due to its hierarchical feature and this enables composing queries joining multiple tables in less time.


## Linq vs Stored Procedure

Allows usage of a single LINQ syntax while querying many diverse data sources and this is mainly because of its unitive foundation.

Is extensible that means it is possible to use knowledge of LINQ to querying new data source types.

Offers the facility of joining several data sources in a single query as well as breaking complex problems into a set of short queries easy to debug.

Offers easy transformation for conversion of one data type to another like transforming SQL data to XML data.

Stored procedures are much faster than a LINQ query as they follow an expected execution plan.

It is easy to avoid run-time errors while executing a LINQ query than in comparison to a stored procedure as the former has Visual Studio’s Intellisense support as well as full-type checking during compile-time.

LINQ allows debugging by making use of .NET debugger which is not in case of stored procedures.

LINQ offers support for multiple databases in contrast to stored procedures, where it is essential to re-write the code for diverse types of databases.

Deployment of LINQ based solution is easy and simple in comparison to deployment of a set of stored procedures.



## Query Syntax

### Selection
选取

```c#

int[] nums = { 2, 3, 5, 7, 11, 13 };
IEnumerable<int> result =   //result is an IEnumerable<int>
  from x in nums  //the variable x will assume the value of each item in nums
  select x;  //the item is being captured

  //the lines are just for visual purposes

Console.WriteLine(string.Join(" ", result));

// 2 3 5 7 11 13


IEnumerable<int> result = 
  from x in nums
  select 2 * x;   //twice the value of the item is captured
  
Console.WriteLine(string.Join(" ", result));

// 4 6 10 14 22 26
```


### Filter
过滤
```c#
IEnumerable<int> result = 
  from x in nums
  where x < 10   //condition is imposed on the item  
  select x;
 
Console.WriteLine(string.Join(" ", result));

2 3 5 7

//
var poem = "Mary had a little lamb its fleece was white as snow".Split(); //it is more convenient to use var instead of specifying the type  
var r1 =   
    from w in poem
    where w.Length > 4  
    select w;

  
Console.WriteLine(string.Join(" ", r1));
```


### Ordering

```c#
var r1 =  from w in poem  
          where w.Length > 4  
          orberby w   
          select w;
//specifying the order of the item

Console.WriteLine(string.Join(" ", r1));


var r1 =  from w in poem  
          where w.Length > 4  
          orberby w descending
          select w;

var r1 =  from w in poem  
          orberby w.Length, w  //alphabetic with the same word length
          select w;
```


### Grouping

```c#
//a collection of groups 
var r2 = from w in poem  
         group w by w.Length into word_groups  
         select word_groups;

//each group has a key and a count
foreach (var grp in r2){

  Console.WriteLine($"key:{grp.Key} count:{grp.Count()}");
  Console.WriteLine($"group: {(string.Join(" ", grp))}");
}
```


### Projection
投影
```c#
int[] nums = { 1, 2, 3, 4, 5, 6 };
var r1 = from x in nums
         select $"{x} * 12 = {x * 12}"; 
         //type of item is int and
         //a string being captured

Console.WriteLine(string.Join(" ", r1));
```


### Join
```c#

int[] nums = new int[] { 1, 2, 3 };
string[] letters = "A B C".Split();
  
var r1 = 
  from a in nums 
  from b in letters 
  select a + " " + b;

Console.WriteLine(string.Join(" ", r1));

//

string[] letters = "A B C".Split();
  
var r1 = 
  from a in letters orderby a descending 
  from b in letters 
  from c in letters 

  select a + " " + b + " " + c;

Console.WriteLine(string.Join(" ", r1));
```


## Summary
All the proceeding examples uses collections of native types (int and string) as the query source.

The real strength of linq lies in the way you are able to access the parts of the underlying object to apply the linq operators

A query does not change the input sequence; instead it returns a new sequence
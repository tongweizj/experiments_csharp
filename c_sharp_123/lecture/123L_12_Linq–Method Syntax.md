## index

- Linq Execution model
- Chaining queries
	- Select(),
	- Where(),
	- OrderBy(), 
	- ThenBy(),
	- OrderByDescending()
	- ThenByDescending(),
	- GroupBy
- The Enumerable class

## The execution model

LINQ uses a model called deferred execution or lazy loaded.
延迟执行或延迟加载。

This means that a query is not executed until the first bit of data is required by another statement.
这意味着直到另一个语句需要第一位数据时，查询才会执行。
You can force the execution by converting the resulting collection into a concrete collection, for example, by calling the ToList() method or requiring other data linked to the actual use of the collection, such as counting the number of rows returned.
您可以通过将结果集合转换为具体集合来强制执行，
例如，通过调用 ToList() 方法或要求与集合的实际使用相关的其他数据，例如计算返回的行数。

```c#
List<int> nums = new List<int>{ 4, 2, 3};

var r1 = from x in nums
         where x % 2 == 0  
         select x;  // 后执行

nums.AddRange(new int[] { 6, 5, 8 }); // 先执行

Console.WriteLine($"{(string.Join(", ", r1))}");

//outputs 4, 2, 6, 8, why???
```

## Chaining queries

Most of the queries produce a result of type `IEnumerable<T>`
So, your query does not HAVE to end with a select method.
So you may use the result of one query as the source of another query e.g.
大多数查询都会产生类型为 `IEnumerable<T>` 的结果
因此，您的查询不必以 select 方法结束。
因此，您可以将一个查询的结果用作另一个查询的源，例如

```c#

var r = nums
  .Where(x => x > 10)
  .Select(x => x * x)
  .GroupBy(x => x % 2);

```

N.B. The last query GroupBy produces a result of type `IEnumerable<IGrouping<T>>` so you will not be able to chain as you did before

### Selecting (Projections)

The select clause produces the results of the query
It specifies the shape or the type of each returned element
When the select clause produces something other than a copy or portion of the source element, the operation is called a projection

select 子句生成查询结果
它指定每个返回元素的形状或类型
当 select 子句生成除源元素的副本或部分以外的内容时，该操作称为投影

```c#

var result = customer.Select(c => c);  //selection

var result = customer.Select(c => c.Name);   //project captures the name

var result = customer

  .Select(c => new { Name = c.Name, Tel = c.Tel });//projection

var result = numbers.Select(x => $"{x} -> {x * x}");//projection

int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

string[] digits = { "zero", "one", "two", "three", "four", "five",

"six", "seven", "eight", "nine" };

var digitOddEvens = numbers

  .Select(n => new { Digit = digits[n], Even = (n % 2 == 0)});          


foreach (var d in digitOddEvens)      
{          
 Console.WriteLine($"The digit {d.Digit} is {(d.Even ? "even" : "odd")}.");      
}

```

### Restriction (Filter)

```c#
var poem = "Mary had a little lamb its fleece was white as snow".Split();  
var containsA = poem.Where(w => w.Contains("a"));

foreach (var i in  containsA) 
  Console.Write($"{i} ");

var r1 = Enumeration
  .Range(1, 10)
  .Where(x => x % 3 == 0 || x % 2 == 0)
  .Select(x => $"{x} * 12 = {x * 12}");

string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

var shortDigits = digits
    .Where((digit, index)   //this form of where gets the item as well as the index

        => digit.Length < index);  

Console.WriteLine("Short digits:");

foreach (var d in shortDigits)

{
  Console.WriteLine($"The word {d} is shorter than its value.");
}


int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

var numsInPlace = numbers

 .Select((num, index) 

    => new { Num = num, InPlace = (num == index) });         

Console.WriteLine("Number: In-place?");      

foreach (var n in numsInPlace)      

{          

  Console.WriteLine($"{n.Num}: {n.InPlace}");      

}
```

### Ordering

```c#
var r1 = poem
  .OrderBy(x => w.Length)
  .ThenBy(x => x);

var r1 = persons
  .OrderBy(p => p.Name.Split()[1].Length)  //order by the length of the last name
  .ThenByDescending(p => p.Age);  //then by age in descending order
 
 var r2 = poem 
  .GroupBy(w => w.Length);

foreach (var grp in r2)
{
  Console.WriteLine($"{grp.Count()} words of length {grp.Key}");  foreach (var w in grp)  
    Console.WriteLine($"{w} ");  
}

string[] words = { "blueberry", "cherry", "chimpanzee", "bonzai", "abacus", "chalk", "banana", "apple", "cheese" , "apricot" };

var wordGroups = words

  .GroupBy(w => w[0]);

foreach (var grp in wordGroups)

{

  Console.Write($"Words that start with the letter '{grp.Key}' -> ",);

  Console.WriteLine($"{string.Join(", ", grp)}");

}
```


## Using Enumerable class to generate data

```c#
Random rnd = new Random();            

var r1 = Enumerable.Range(-10, 21);   //sequence from -10 to + 10

r1 = Enumerable.Range(1, 5).Select(x => x * x);   //the first 5 squares

r1 = Enumerable.Range(0, 20).Select(x => rnd.Next(0, 10));   //20 random numbers less than 10

var r2 = Enumerable.Repeat(1, 10);   //10 one’s  

var r3 = Enumerable.Repeat("Narendra", 5);  //5 strings of "Narendra"

var r2 = Enumerable

  .Range(0, 21)

  .Select(x => (char)('A' + x % 3));   //the sequence ABCABC...

r2 = Enumerable

  .Range(0, 50)

  .Select(x => (char)('A' + rnd.Next(0, 26)));   //random letter sequence 

var r3 = Enumerable

  .Range(1, 5)

  .SelectMany(x => Enumerable.Range(10, 5)

  .Select(y => x + " " + y));   //cartesian product
```


## Summary
uThis is the second way of writing linq queries.

uThe compiler translates the query syntax into method syntax.

uYou can write more capable queries using the method syntax.

uYou can even mix the two syntaxes.

uThere are many other operators that we did not cover but hopefully after understanding these operators, you will be able to figure out how to use the other ones.
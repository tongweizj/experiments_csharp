


## List

- It is a collection.
- A list is an object that can hold objects. 
- Can be considered as the Object Oriented version of an array.
- The list may grow or shrink as items are adding or removed. 
- A list is a generic collection type. 

- List is a generic collection that means amongst other things is that at declaration you specify what type the collection will work with.

- You may have a list of ints, or chars or even a number of custom objects. 
- It is possible to have duplicates in a list. 

- Other collections include 
	- SortedList, 
	- LinkedList, 
	- Stacks, 
	- Queue and 
	- Dictionary. 
	  These collections will be covered later in the course.

### create
```c#
//a declaration of uninitialized list

List<int> evens;

  

//Creating an empty list of ints

List<int> numbers = new List<int>();

  

//Creating a list with three doubles

List<double> radii = new List<double>(){ 1.0, 2.1, 3.6 };

  

//Creating a list with five strings

List<string> pms = new List<string>(){ "Trudeau", "Harper", "Martin", "Chretien", "Campbell" };

  

//Creating a list of rectangle

List<Rectangle> rectangles = new List<Rectangle>();
```


### Adding items

```c#
//- **Adding an item to a list:**
//The new item will be appended to the end of the list

numbers.Add(3);         //numbers will have a single item
pms.Add("Mulroney");    //pms will now have six items

// - **Adding a collection  to a list:**

pms.AddRange( pms );    //add the pms collection to itself

// - **Inserting an item to a list**
//This adds an item at a specified position
pms.Insert(2, "William Lyon Mackenzie King");
```


### Removing items

- **Removing an item from a list**
```c#

//This method will remove an item from the list if it exists. 
//If it not present, nothing happens.
pms.Remove("Mulroney");  //pms will now have six items            


//You may also remove an item at a specified location in a list.
radii.RemoveAt( 1 );

//You may also remove multiple items
radii.RemoveRange( position, amount );
```

- **Removing all items from a list**
```c#
//This method will remove all of the items from a list.
numbers.Clear();
```


### Checking for an item

- **The contains method checks for any occurrence of an item to a list:**
```c#
  
string name = "Mulroney";         

if (pms.Contains(name))
{
  //this will be executed
  Console.WriteLine($"{name} is present in the list");    
}
else
{
  //this will not be executed
  Console.WriteLine($"{name} is not present in the list");
}
```

### Traversing
- You may use any type of loop to traverse a list, however the preferred way is using a foreach loop.

```c#
for(int i = 0;i < numbers.Count;i++)
//numbers.Count will give the number of items  
{  
  Console.Write(numbers[i] + " ");  
}

foreach(int x in numbers)           
//more optimized, but you may not modify the collection
{  
  Console.Write(x + ", ");  
}

Console.WriteLine("\n\nDisplay names that are longer than 6 letters");  
foreach(string pm in pms)  
{  
  if(pm.Length > 6)  
  {    
    Console.Write(pm + ", ");  
  }  
}


Console.WriteLine("\n\nDisplay names that starts with C");  
foreach(string pm in pms)  
{  if(pm.StartsWith("C")  
  {    Console.Write(pm + ", ");  
  }  
}
```

### Converting a list to a string

```c#
- If you just want to print a list, you can use the static method in the string class Join()

  

res = string.Join(" ", pm);   //each item is separated by a space

res = string.Join(",", pm);   //each item is separated by a comma

res = string.Join(", ", pm);  //each item is separated by a comma and a space

res = string.Join("\n", pm);  //each item is separated by a newline

res = string.Join("\n ", pm); //each item is separated by a newline and a space

res = string.Join("\n\t ", pm); //each item is separated by a newline and a tab

  

  
Console.WriteLine( res );     //send the results to the screen
```


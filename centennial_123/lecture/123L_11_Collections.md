## Index
What are collections?  
 -  Benefits of working with collections  
 -  Some common collections:  
 -  List, Dictionary and HashSet  
 -  SortedList, SortedDictionary,


## What are collections?

- An array is a data structure that works with a group of strongly-type objects  
	-  Array are not dynamically sized  

### Collection
-  Collection provides a more flexible way to work with groups of objects  
 -  Collections are enhancements to arrays  集合是数组的增强
	 -  Less expensive成本 to insert items in the middle of the collection  
	 -  Less expensive to grow and shrink  缩小
	 -  Easier to locate a particular item, and to order  
 -  There are two types of collections:  
	 -  Standard collection found in the `System.Collections` 
	 -  Generic collection通用集合 found in the `System.Collections.Generic`  
 -  Generic collection is preferred because it enhances:  
	 -  Code re-use  
	 -  Type safety  
	 -  Performance


An object that is able to contain multiple values (value or ref types)  
 -  All collection implements the `IEnumerable<T>` interface  
 -  Can be iterated through using a `foreach` loop  
 -  Can be queried using `LIINQ`  
 -  Most collections implements one or more of the following interfaces:  
	 -  `IList<T>`, `ICollection<T>`, `IDictionary<U, T>`


### Benefits

Collections are useful is lots of application  
 -  .NET supplies numerous collections for free, so you don’t need to create your own collection class  
 -  .NET collections allows you to process all groups of data in a uniform way e.g.  
	 -  You can get a count of all the data value  
	 -  Some maintain uniqueness  
	 -  Some maintain ordering  
	 -  Provides a way to enumerate the data values  
	 -  Perform queries on the items (next few topics)


## List, Dictionary and HashSet

### List  

 -  Collection of `<TValue>` items  
 -  The workhorse 主力of all the collection  
 -  Items accessed by index  
 
### Dictionary  
 -  **Unordered** collection of `<TKey, TValue>` pairs  
 -  Value accessed by key  

### HashSet  
 -  Unordered collection of `<TValue>` unique items



### SortedSet, SortedList, SortedDictionary and LinkedList  

 #### SortedSet  
 -  Ordered collection of `<TValue>` unique items.  

#### SortedList  
 -  Collection of `<TKey, TValue>` pairs, orders by` <TKey>`  
 -  Value accessed by key or index  
 -  Similar to a SortedDictionary  

####  SortedDictionary  
 -  Collection of `<TKey, TValue>` pairs, orders by `<TKey>`  
 -  Value accessed by key  

#### LinkedList  
 -  No direct access to elements  
 -  Efficient insertions and deletions



### Stacks and Queues  

 -  Both are sequential collection where the elements are discarded after its  
value is retrieved.  

 -  Stack  
	 -  Last In First Out  
 -  Queue  
	 -  First In First Out



### List  
 -  Collection of strongly type objects.  
 -  It is probable the most used collection in the .NET framework.  
 -  It can do pretty much anything that you might want a normal collection to do.  
 -  Sort the list using the default comparator 比较器(normally none is present)  

```

List<string> courses = new List<string>{ 
   "COMP100", "COMP100", "COMP123"
   });
```

### Dictionary  
 -  Also known as hashmap or hashtable  
 -  Can be used as a very fast lookup table  
 -  Can add or remove items (pairs) without performance overhead  
 -  A generic collection of keys and values pairs.  
 -  Each key must be unique in the collection.  
 -  Values may be nulls or be duplicated  
Dictionary<int, string > dict1 = new Dictionary<int, string >();  
Dictionary<string, string > dict2 = new Dictionary<string, string >();  
Dictionary<string, double> dict3 = new Dictionary<string, double >();  
Dictionary<string, Student> dict4 = new Dictionary<string, Student>();


HashSet  
 -  This is an un-ordered collection that does not permit duplicates.  
 -  It checks uniqueness by the GetHashCode() method and Equals() method.  
 -  You may override these methods to specify uniqueness  
 -  It is based on the model of mathematical sets. It provide high performance  
set operations such as:  
 -  UnionWith, IntersectWith, ExceptWith, SymmetricExceptWith, Overlaps,  
IsSubsetOf, IsProperSubsetOf, IsSuperSetOf, IsProperSuperSetOf, SetEquals  
 -  HashSet<string> courses = new HashSet<string>{ "COMP100",  
"COMP120", "COMP123" });


LinkList  
 -  This is the foundation of all other collection: stacks, queues, double-linked  
list sorted list, circular list etc.  
 -  Manages file clusters.  
 -  Manages memory allocation.  
 -  Web browsers uses it to maintain a list of web-pages visited.  
 -  Useful for collections where insertions and deletions occurs frequently at the  
non-terminals.


Stack  
 -  The Stack class represents a last-in-first-out (LIFO) Stack of Objects.  
 -  Stack follows the push-pop operations.  
 -  You can Push (insert) Items into Stack and Pop (retrieve) it back .  
 -  Stack is implemented as a circular buffer. That is, we can push the items into  
a stack and get it in reverse order  
 -  As elements are added to a Stack, the capacity is automatically increased as  
required through reallocation.


Push() and Pop()




Applications of Stack  
 -  The simplest application of a stack is to reverse a word. You push a given word to stack - letter by  
letter - and then pop letters from the stack.  
 -  Another application is an "undo" mechanism in text editors; this operation is accomplished by  
keeping all text changes in a stack.  
 -  Backtracking. This is a process when you need to access the most recent data element in a series  
of elements. Think of a labyrinth or maze - how do you find a way from an entrance to an exit?  
Once you reach a dead end, you must backtrack. But backtrack to where? to the previous choice  
point. Therefore, at each choice point you store on a stack all possible choices. Then backtracking  
simply means popping a next choice from the stack.  
 -  Memory management, run-time environment for nested language features.  
 -  Language processing:  
 -  space for parameters and local variables is created internally using a stack.  
 -  compiler's syntax check for matching braces is implemented by using stack.  
 -  support for recursion



Queue  
 -  The Queue works like FIFO system , a first-in, first-out collection of Objects.  
 -  Objects stored in a Queue are inserted at one end and removed from the  
other.  
 -  Enqueue<T>() adds items in Queue  
 -  Dequeue() removes items from Queue  
 -  Peek() allows access to the item to be removed, but does not remove it  
 -  Queue accepts null reference as a valid value and allows duplicate elements.


Enqueue() and Dequeue()  
Enqueue() Fourth  
Item  
Dequeue()  
First  
Item  
First  
Item  
Second  
Item  
Third  
Item  
First  
Item  
Second  
Item  
Third  
Item  
Fourth  
Item



Collection Ordering Contiguous  
Storage?  
Direct  
Access?  
Notes  
Dictionary Unordered Yes Via Key Best for high performance lookups.  
SortedList Sorted Yes Via Key Very similar to SortedDictionary, except tree  
is implemented in an array, so has faster  
lookup on preloaded data, but slower loads.  
Values maybe accessed with key or index.  
List User has precise  
control over element  
ordering  
Yes Via Index Best for smaller lists where direct access  
required and no sorting.  
LinkedList User has precise  
control over element  
ordering  
No No Best for lists where inserting/deleting in  
middle is common and no direct access  
required.  
Stack LIFO Yes Only Top Essentially same as List<T> except only  
process as LIFO  
Queue FIFO Yes Only Front Essentially same as List<T> except only  
process as FIFO


## Common properties/methods  
Count  
 -  Returns a int representing the number of items in the collection  
Add(<T>)  
 -  Adds an item to the collection  
 -  Identical functionality in Stack and Queue are Push() and Enqueue()  
respectively.  
 -  A Dictionary has Add(<T>,<U>)  
 -  Additionally List has AddRange()  
Clear()  
 -  Removes all the items from the collection


Remove(<T>)  
 -  Removes the specified item from the collection  
 -  Identical functionality in Stack and Queue are Pop() and Dequeue()  
Contains(<T>)  
 -  Returns a bool indicating if the argument is present in the collection  
 -  Alternately, a Dictionary and SortedList has ContainKey(<T>) and  
ContainsValue(<T>)


Specialized methods  
Stack, Queue  
 -  Peek()  
 -  Returns the top element without removing from collection  
List  
 -  RemoveAt(int), RemoveAll(), RemoveRange()  
 -  Find(), FindFirst(), FindLast(), FindAll(), FindIndex()  
 -  Insert(), InsertRange()  
 -  Reverse()  
 -  Sort()


Summary  
 -  .NET provides collection classes are specialized for data processing and storage.  
 -  These classes provide support for stacks, queues, lists, sets, and dictionaries.  
 -  Be sure to select the appropriate collection for your use.  
 -  Most collection classes implement the same interfaces. E.g. IEnumerable,  
IList, IDictionary, ...  
 -  You must include the System.Collections.Generic namespace.
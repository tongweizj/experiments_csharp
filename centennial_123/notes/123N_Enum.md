
## Enum
枚举
### No Magic

Magic numbers are numeric literals that appears in your code statements other than zero and 1

``` c#
area = 3.14 * radius * radius;
tax  = 0.13 * price;

const double PI = 3.1415;
const double TAX_RATE = 0.13;
const int MAX_NUMBER_OF_COURSE = 7;
```

- It makes code less readable and more difficult to maintain
- Named constants solves this problem and as the name suggest, it may not be modified after it is declared

编程的时候，不要 magic number

### enums

- Provides an efficient way of defining a set of named constants
- The underlining data type are ints

- You may overwrite this with any integral type such as byte, short, int or long

- No doubles, or strings, or chars

- Useful when you have a variable that can exist in a limited number of discrete states

- Like classes, enums is also a user-define type.

- This type only contains constants
- No action members or constructors


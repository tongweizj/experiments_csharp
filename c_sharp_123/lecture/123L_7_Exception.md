## Objectives

- Conditions for abnormal conditions in your program程序中异常情况的条件
- Learn about **exceptions** 了解异常
- Learn about traditional and object-oriented **error handling methods** 了解传统和面向对象的错误处理方法
- Use the **Message property** to display information about the exception 使用 Message 属性显示有关异常的信息
- Catch **multiple exceptions** 捕获多个异常

- Use the **finally block** 使用 finally 块
- Handle Exceptions thrown from outside methods 处理从外部方法抛出的异常
- Dealing with Overflow and underflow operations  处理溢出和下溢操作


## Conditions for abnormal behavior
序中异常情况的条件

- Bugs
Errors made by the programmer. E.g.

- User Errors
Entering a **mal-formed** string into a textbox
在文本框中输入格式错误的字符串

- Exceptions
Runtime anomalies 
that are difficult if not impossible to predict. e.g. 
难以预测甚至无法预测的运行时异常。

connecting to a non-existent database, reading a corrupt xml file, accessing a disconnected drive
例如，连接到不存在的数据库、读取损坏的 xml 文件、访问断开连接的驱动器


## Handling Application Errors
uBe proactive

uDesign application logic to avoid errors

uUse defensive programming techniques like TryParse(), checking for nulls, file existance

u

uOld technique of dealing with application errors

uEach method will return a number (error code)

uThe main method will have a lookup table to check the code and display a suitable message to the user

u

u.NET technique

uExecution will cause an Exception object to be created and thrown

uCode will create and throw an Exception object

uThis object will contain details of the error condition that raise this exception

u

The next slide shows the properties belonging to a typical Exception Object

---

mal-formed  格式错误
Runtime anomalies 运行时异常
predict 预测
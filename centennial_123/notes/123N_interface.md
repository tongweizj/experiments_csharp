## 定义

a <font color="#f79646">type that contains</font> only the declaration of <font color="#f79646">methods, properties, events or indexers</font>.


接口定义了所有类继承接口时应遵循的语法合同。

用途
- 接口提供了派生类应遵循的标准结构。
    - 接口定义了语法合同 "是什么" 部分
    - 派生类,定义了语法合同 "怎么做" 部分。
- 接口相当于实现了一半的 superclass
    - 继承了接口,必须自己重新定义.
    - 优点在于,框定住了标准. 
    - 比如,所有哺乳动物,都生孩子.但怀孕多久,每种动物自己定义.但必须是胎生.


## 技术特点

- no static
- implicitly public
不用 public 关键词标注，但实现 public 功能



## 技术优点

-  a single class can get interface from multiple sources

某种特点结构的抽象
- 接口声明了对象的各类参数。但不实现。
- 优点：
	- 下一次再写这类对象时，减少重复工作。

接口定义了属性、方法和事件，
这些都是接口的成员。
接口只包含了成员的声明。

成员的定义是派生类的责任。

接口使得实现接口的类或结构在形式上保持一致。

抽象类在某种程度上与接口类似，但是，它们大多只是用在当只有少数方法由基类声明由派生类实现时。



抽象类不能直接实例化，但允许派生出具体的，具有实际功能的类。

https://www.runoob.com/csharp/csharp-interface.html


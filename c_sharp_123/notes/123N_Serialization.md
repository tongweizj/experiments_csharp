##Serialization 
序列化

序列化（serialization）在计算机科学的资料处理中，是指**将数据结构或对象状态转换成可取用格式（例如存成文件，存于缓冲，或经由网络中发送），以留待后续在相同或另一台计算机环境中，能恢复原先状态的过程**


uIs the process of converting an object into a stream of bytes either to store or to transmit.

uThe data members of the object and the name of the class, including the assembly containing the class, is converted to a stream of bytes, which is then written to a data stream.

uIt is the only way to persistent an object.

uWhen the object is subsequently de-serialized, an exact clone of the original object is created.

uCan be used for deep copy of an object (Shallow copy is provided by .NET)

uSerialization is not part of C# language but part of the .NET Framework


uWhy Serialize?

uTechniques to Serialize

uBinary

uManual

uXML

uJson

uSerialize and deserialize collection of objects


## demo
Xml Serialization
```c#
//Add the necessary namespace
using System.Xml.Serialization;

// Create and initialise a serializer object
XmlSerializer serializer = new XmlSerializer(typeof(Student));

// You will also need a writable stream such as a TextWriter
TextWriter writer = new StreamWriter(filename);

// Use the Serialize method to serialize the object
serializer.Serialize(writer, student);
```
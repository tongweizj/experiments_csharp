## Purpose
The purpose of this assignment is to help you:
• Understand the ML.NET pipeline 
• Identify the type of problems that can be solved with ML.NET I

## Instructions: 
Be sure to read the following general instructions carefully: 
This assignment should be completed individually by all the students. 
You are encouraged to demonstrate your solution, and submit your solution through the dropbox.
You must name your submission according to the following rule: studentID(yourlastname)_Labnumber.zip. e.g., 300123456(smith)_Lab#5.zip

301034450_Lab#5.zip

## Rubric 
Functionality Marks 
#### Q1 
1.1 Regression algorithm 1 
1.2 Classification 1 
1.3 Clustering 1 
1.4 Anomaly detection 1 
1.5 ML.NET pipeline 2 

### Q2 
2.1 Generate cost prediction regression model 3 
2.2 Consume the generated model 2 

### Q3 
3.1 Student class and ClusterPrediction class 1 
3.2 Customize options for K-Means 1 
3.3 Create the pipeline 1 
3.4 Instantiate an instance of Student class 1 
3.5 Create the prediction engine from the model and perform the prediction 1


以下是专业的技术文档翻译（中英对照，保持术语一致性）：

---

### **问题1**  
#### Q1  
1.1 回归算法（Regression algorithm）  
1.2 分类（Classification）  
1.3 聚类（Clustering）  
1.4 异常检测（Anomaly detection）  
1.5 ML.NET 管道（ML.NET pipeline）  

### **问题2**  
#### Q2  
2.1 生成成本预测回归模型（Generate cost prediction regression model）  
2.2 调用生成后的模型（Consume the generated model）  

### **问题3**  
#### Q3  
3.1 学生类与聚类预测类（Student class and ClusterPrediction class）  
3.2 自定义K-Means算法选项（Customize options for K-Means）  
3.3 构建管道（Create the pipeline）  
3.4 实例化学生类（Instantiate an instance of Student class）  
3.5 从模型创建预测引擎并执行预测（Create the prediction engine from the model and perform the prediction）  

---

### **翻译要点说明**  
1. **术语统一性**：  
   - "Pipeline" 译为"管道"（ML领域标准译法）  
   - "Consume" 在此语境译为"调用"而非"消费"  
2. **技术准确性**：  
   - "K-Means" 保留原名（算法名不翻译）  
   - "Prediction engine" 译为"预测引擎"（ML.NET官方术语）  
3. **格式保留**：  
   - 分级编号结构与原文完全一致  
   - 括号内保留英文术语便于对照  

如需调整术语风格或补充说明，请随时告知


## Question 1 [6 marks] 
1.1 List two problems that regression algorithms can be used to solve [1 mark] 
1.2 List two problems that belong to classification problem [1 mark] 
1.3 List two problems that can be solved by using clustering algorithm(s) [1 mark] 
1.4 What is anomaly detection? [1 mark] 
1.5 Use an example to illustrate what the ML.NET pipeline is [2 marks]

## Question 2 [5 marks] 
Implement C# application to predict the medical cost by using ML.NET based on the dataset insurance.csv

### Question 3 [5 marks] 

Implement C# application to predict **student’s knowledge level** by using ML.NET based on the dataset Student.csv and readme.txt

[Hint] you can do it by mimicking the tutorial at https://docs.microsoft.com/en-us/dotnet/machine learning/tutorials/iris-clustering


以下是技术文档的专业翻译（中英对照，保留关键术语）：

---

### **问题1 [6分]**
1.1 列出回归算法可解决的两类问题 [1分]  
1.2 列出属于分类问题的两类场景 [1分]  
1.3 列出聚类算法可解决的两类问题 [1分]  
1.4 什么是异常检测？ [1分]  
1.5 举例说明ML.NET管道（Pipeline）的作用 [2分]  

### **问题2 [5分]**  
基于insurance.csv数据集，使用ML.NET实现医疗费用预测的C#应用程序  

### **问题3 [5分]**  
基于Student.csv和readme.txt数据集，使用ML.NET实现学生知识水平预测的C#应用程序  
[提示] 可参考微软官方教程实现：  
https://docs.microsoft.com/en-us/dotnet/machine-learning/tutorials/iris-clustering  

---

### **翻译规范说明**
1. **术语处理**：
   - "Regression/Classification/Clustering" 保留技术领域标准译法
   - "Pipeline" 译为"管道"（ML.NET框架官方中文文档用词）
   - "anomaly detection" 译为"异常检测"（网络安全/数据分析通用译法）

2. **技术细节**：
   - 数据集名称（insurance.csv/Student.csv）保留原文
   - 微软官方链接不做翻译（保证可追溯性）

3. **格式保留**：
   - 分值标注方式与原文一致
   - 提示框用方括号[]突出显示
   - 分级编号严格对应原结构

4. **本地化适配**：
   - "implement" 译为"实现"（更符合中文技术文档习惯）
   - "mimicking the tutorial" 意译为"参考教程"（避免直译生硬）

如需调整术语风格或补充注释，请随时告知。
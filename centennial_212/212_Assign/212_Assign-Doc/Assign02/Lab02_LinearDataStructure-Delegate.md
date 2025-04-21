## Purpose:
The purpose of this assignment is to help you: 
- Understand linear data structure 
- Understand delegate 
- Review Windows Form applications

You must name your submission according to the following rule: `studentID(yourlastname)_LABnumber.zip`
e.g., 
`300123456(smith)_lab#2.zip`


## Question1 [2 marks]

产品
Suppose you are asked to develop a <span style="background:#fff88f">course management system</span> for our college. 


The implemented console app should 
- allow users to insert new course(s), 
- search specific course, 
- iterate over the dictionary to display all course details (e.g., 
- course 
	- code, 
	- course title, 
	- course description, 
	- the number of the credit, etc.)


技术要求
Your supervisor asks you to utilize a Dictionary to organize the course information, where TValue is Course class, and TKey is the course code. 

### TODO

1. [x] 对话窗口 ✅ 2025-02-13
2. [x] 检查课程model 是否完善 ✅ 2025-02-13
	1. [x] 字段 ✅ 2025-02-13
	2. [x] toString ✅ 2025-02-13
3. [x] 检查courseDict 功能是否完成 ✅ 2025-02-14
	1. [x] add ✅ 2025-02-14
	2. [x] display all ✅ 2025-02-14
	3. [x] display one ✅ 2025-02-14
4. [x] 调用courseDict 功能 ✅ 2025-02-14
	1. [x] 添加course, 包含对话过程 ✅ 2025-02-14
	2. [ ] 

## Question2 [18 marks]

In the real world, the <span style="background:#fff88f">notification management system</span> consists of two parts, 
- one is to allow clients to subscribe/unsubscribe the notification, 
- and another part is to facilitate administrator(s) to publish the notification. 
另一部分是为了方便管理员发布通知。

This assignment simplifies the problem, and merges two parts as one. 
In this assignment, you are asked to implement a `C# WinForm application` to mimic notification management system. 

You are required to use <span style="background:#fff88f">delegate</span>. 
Your app facilitates clients to subscribe/unsubscribe notification as well as send notification to all subscribers. 
您的应用程序方便客户订阅/取消订阅通知以及向所有订阅者发送通知。

订阅人资料检查
Your App needs to make sure that 
- the provided email address is valid 
- and provided cell phone number is followed the specified format. 

After the app has been launched, following GUI (or similar one) should be presented. As there is no subscriber yet when the app just launches, “Publish Notification” button is disabled.应用程序启动后，应显示以下 GUI（或类似 GUI）。由于应用程序刚启动时尚无订阅者，“发布通知”按钮处于禁用状态。


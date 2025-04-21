## Due Date: 
Midnight of Week11’s Friday 

## Purpose: 

The purpose of this assignment is to help you become familiar with 
- ui
	- WPF data binding, 
	- WPF <font color="#00b050">UserControl,</font> 
	- MVVM pattern 
- Entity Framework Core 
- 
## Instructions: 
Be sure to read the following general instructions carefully:
This assignment must be completed individually. 
Submit your solution through the Luminate. 
You must name your submission according to the following rule: 
studentID(yourlastname)_Labnumber.zip. 
e.g., 300123456(smith)_Lab#4.zip


## Functionality

1. Class library project 
   Use EF Core to create data model classes (2 marks) 

2. Implement a utility class to access data from database, please make sure to use asynchronous programming whenever it is suitable 
- Get data for comboBox that displays the shopper’s email & IdBasket (2 marks) 
- Get data for the DataGrid (2 marks) 
- Get data for the comboBox that displays the product’s information (2 marks) 
- Save data to database (2 marks)
前台显示数据，从数据库来

MVVM
- main
	- MainWindow.xaml (1 mark) 
	- MainWindowViewMode.cs
- list order detail
	- ListOrderDetailsView.xaml (4 marks) 2. 
	- ListOrderDetailsViewModel.cs (4 mark) 8 
- add new item
	- AddNewItemView.xaml 
	- AddNewItemViewModel.cs (4 marks)

Overall (readability, efficiency, maintainability) 2 Exercise 1 [30 marks] You are asked to implement a WPF Application using MVVM pattern. 

The app is to facilitate order administrators to manage all orders.

数据来源
Run OMS.sql to generate the Database, and below is the database ER d
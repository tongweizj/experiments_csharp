Question 2 [13 marks] 
(Restaurant Bill Calculator) 

A restaurant wants a WPF app that calculates a table’s bill. The app should display all following menu items (shown below) in four ComboBoxes. 
一家餐厅想要一个可以计算餐桌账单的 WPF 应用。
该应用应在四个 ComboBox 中显示以下所有菜单项（如下所示）。

Each ComboBox should contain a category of food offered by the restaurant (Beverage, Appetizer, Main Course and Dessert). 
每个 ComboBox 应包含餐厅提供的食物类别（饮料、开胃菜、主菜和甜点）。

You application should have following functionalities 
您的应用程序应具有以下功能
1) Users can choose an item from any comboBox, the selected item should be added to the DataGrid, and the bill should be updated correspondingly a. 
	- If the selected item(s) has not existed the DataGrid, then your app should add a new row in the DataGrid b. 
	- Otherwise, your app changes the quantity of the corresponding items rather than add a new row 

用户可以从任意组合框中选择一个项目，所选项目应添加到 DataGrid 中，账单应相应更新 a.
- 如果所选项目不存在于 DataGrid 中，则您的应用应在 DataGrid 中添加新行 b.
- 否则，您的应用将更改相应项目的数量，而不是添加新行


1) Users can remove the selected item(s) from the DataGrid, and the bill should be updated as well 
2) 用户可以从 DataGrid 中删除所选项目，账单也应更新

3) Users can update the quantity for a particular item in the DataGrid, and the bill should be updated correspondingly 
4) 用户可以在 DataGrid 中更新特定项目的数量，账单也应相应更新

5) After users click the Clear Bill Button, your app should clear DataGrid, and restore the SubTotal:, Tax: and Total: fields to $0.00.
6) 用户单击“清除账单”按钮后，您的应用应清除 DataGrid，并将 SubTotal:、Tax: 和 Total: 字段恢复为 $0.00。
# SE104.M21.PMCL - Library Management System
## *Group Information:* 
Nguyễn Công Đoàn - 20520447 **(Leader)**  
Nguyễn Tấn Huy - 20520204  
Phan Nhật Lâm - 20520608  
## *Installation Instructions:*  
Before running the program, you need to follow these steps to create **Database** and change the connection to the **Database**  

**Step 1**: Download code from **Github** by download **ZIP file** or use **Git bash** in the directory you want to install and enter the command:  
"git clone https://github.com/LamPhan08/LibraryManagementSystem.git"  

**Step 2**: Open file **SQLLibrary.sql** and create **Database** for the program  

**Step 3**: Open file **LibraryManagementSystem.sln** > View code file **Database.cs**

**Step 4**: In line 20 of file **Database.cs** has the variable named **connectionName**, change the value of that variable into your **Server name** (which is featured in the **Connect to Server** window in Microsoft SQL Sever Management)
Note: Remember to add an additional backslash ("\") to the **connectionName** if you copy the whole Server name from MySQL.

## *Using software:*

Using the sample account:

  **Username: Admin**
  
  **Password: 123456**

**Step 1**: Go to MySQL, and add this line: INSERT INTO USERS VALUES('Default', 'User', 'Admin', '123456', 'owner')

**Step 2**: Go back to the solution, and start running program.

**Step 3**: Enter Username (Admin) and password (123456)

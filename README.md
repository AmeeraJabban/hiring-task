# MSTART Hiring Task
Introduction
Before we conduct any in person interview, candidates are required to complete a programing task; candidates
that complete the task will be interviewed; interview will be about the task and a code review will be conducted
during the interview.
Who Can Apply
Any candidate looking for work as a programmer regardless of their degree; having a scientific degree (ex.
Computer Engineering, Computer Science, any other Engineering Branch.) is a plus but is not mandatory.
Where to Send your Task
Once you complete the task, please email your solution in a ZIP file with your CV to hr@mstart.com and use the
Email Subject Line (MSTART Hiring Task Files) include instruction to be able to run the solution such as the
required framework or any special instructions.
Task
To create a REST API and Web Application using C# programming language and SQL Server Database.
You can use online resources and request help in completing the task, but you have to demonstrate full
understanding of the task and the completed code, also you should be able to describe and modify the code during
the Interview.

Required Tools
• Microsoft Visual Studio 2019 Community
• https://visualstudio.microsoft.com/vs/community/
• Microsoft SQL Server 2019 Express
• https://www.microsoft.com/en-us/Download/details.aspx?id=101064

Database Structure
[User Table]
[ID]
[Server_DateTime]
[DateTime_UTC]
[Update_DateTime_UTC]
[Last_Login_DateTime_UTC]
[First_Name]
[Last_Name]
[Status]
[Gender]
[Date_Of_Birth]

Page 2

[Account Table]
[ID]
[User_ID]
[Server_DateTime]
[DateTime_UTC]
[Update_DateTime_UTC]
[Account_Number]
[Balance]
[Available_Balance]
[Currency]
[Status]
[Transaction Table]
[ID]
[User_ID]
[Account_ID]
[Server_DateTime]
[DateTime_UTC]
[Is_Credit]
[Amount]
[Currency]

Task Description
Create web pages/views Consuming REST API to process the following features:
· Add new user
· Add new account
· Add Credit/Debit Transaction for selected account
· Grid view of all users saved on the database (Grid must return 10 records at a time)
· Grid view of all accounts saved on the database (Grid must return 10 records at a time)
· Grid view of all transactions saved on the database (Grid must return 10 records at a time)
· Delete one or more user on the same time
· Upload user Photo and Save it on Database
Advanced Task Features (Suggested Ideas – Not Mandatory to Apply)
If you feel the above task is easy and would like to work on a more advance solution; the following are suggestions
that will demonstrate your advanced capabilities and understanding of .NET:
1. Reverse Transaction Page (Easy Skill Level): Create a Page to Reverse Transactions.
2. Client Side & Server-Side Form Validation (Easy-Mid Skill Level): To add Page Form validation; server
side (Code behind) and Client Side (Java Script).
3. REGEX Validation (Mid Skill Level): Use REGEX expressions to validate Employee data for data
requirements and data types including Email, and Mobile Number
4. MVC (Mid-High Skill Level): Use MVC project with Entity Framework or Dapper.
5. Login/Logoff (Mid Skill Level): Add the ability for admin user to login to view the employees page, login
with a username and a password; try to use secure session management practices and try to encrypt the
admin password with one way MD5 Encryption; also User must be logged out after the session expires (15
minutes session time); you are free to decide how to manage the admin data on the Database.

Page 3
6. Multi Language (Mid Skill Level): Add Arabic support with the ability to switch between English and
Arabic on the page and must change the page orientation from LTR to RTL.
7. Unit Testing (Mid-High Skill Level): Create unit test cases to check that your code functioning as it
should, test cases should include at least 6 unit cases: for Adding, Updating and Deleting Employee records,
some with successful messages and some with failed messages.
8. 2 Factor Authentication (High Skill Level): add Google Authenticator to the Login Screen (if we were
able to complete the Login task with session management); solution can be found here:
https://github.com/BrandonPotter/GoogleAuthenticator
9. Responsive UI with Boot Strap (Mid-High Skill Level): Apply Boot Strap design framework to the page
and make sure that it can support desktop and mobile views.
10. Proper Error Handling (Mid Skill Level): to catch exceptions and errors and return proper errors and
use returned error codes; also to fully log errors and exception to a file or to the database.
11. Any Other Additional Ideas: Any other suggestions or ideas you add will be considered a plus to your
work; other ideas such as Ability to Change Page Themes, Use Advanced Grid Controls and Filters,
Advanced User Image Controls, etc.
Task Evaluation Criteria
We will evaluate the submitted solutions as follows:
1. Solution must not have any spelling mistakes (Candidate must spell check all their work)
2. Solution compile and basic function are working (Ability to Add, Update, Delete) (Must be completed to
setup an Interview)
3. Solution compile and run without any errors or warning or exceptions (Not Required for interview but will
greatly improve candidate chances to be hired)
4. To successfully complete one or more of the suggested ideas. (Not Required for interview but will greatly
improve candidate chances to be hired)
Learning Resources
If you did not work with .NET framework or need to improve your ASP.NET programing skills; the following
learning resources and tutorials should help you in completing the task:
1. Video .NET Tutorial (time needed 1-2 Days)
[https://www.youtube.com/playlist?list=PLq2RqejfmpFc5Ygy5DXelYpUrqjq8iwcw]
2. ASP.NET: Building Web Application Using ASP.NET and Visual Studio (time needed 1 Day)
[https://www.youtube.com/watch?v=UEEYqMU4org]

3. .NET Getting Started Pages (time needed 1-2 days) [https://docs.microsoft.com/en-us/aspnet/web-
forms/overview/getting-started/]

4. Create a Movie Database Application in 15 Minutes ASP.NET MVC C# (time needed 1 Day)

[https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions-1/movie-database/create-a-
movie-database-application-in-15-minutes-with-asp-net-mvc-cs]

5. Creating a Basic Web Forms Page in Visual Studio (time needed 1-3 Days)
[https://msdn.microsoft.com/en-us/library/k4cbh4dh.aspx?f=255&MSPPError=-2147217396]
6. Complete .NET Tutorial (time needed 3-5 Days) [https://www.tutorialspoint.com/asp.net/index.htm]
7. Full C# online course (time needed 3-5 Days) [https://www.devu.com/cs-asp/]
8. You can search the web for other tutorials and help regarding completing the task.
Good Luck!

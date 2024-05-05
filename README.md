# PREFINALS_ASSIGNMENT_ARANDIA_AERICAMAE_BSIT32E1

Onion Architecture: (Yes/No) 
 
1. Have you heard of the Onion Architecture principle in software design?
 - Yes
 
 
MVC Pattern: (Yes/No) 
 
2. Are you familiar with the Model-View-Controller (MVC) pattern for building web applications?
 - Yes
 
 
Web API: (Yes/No) 
 
3. Do you understand the concept of building RESTful APIs using ASP.NET Core Web API?
 - No
 
 

Application & Bottlenecks:
Onion Architecture:
 
 
Benefits: (1-3 keywords)
 
 
1. Briefly list some key benefits of using Onion Architecture in .NET Core projects. (e.g., separation of concerns, testability)
 - It neatly organizes code into layers.
 - it enhances the ease of unit testing, allowing for isolated testing of individual components..
 - Changes in one layer don't necessarily affect others.
 - Onion Architecture provides a scalable structure, allowing for the addition of new features without major restructuring..
   
 
 
 
Bottlenecks (Encountered): (Yes/No and Briefly Explain)
 
 
2. Have you encountered any challenges with Onion Architecture in your projects? If so, briefly describe the bottleneck(s). (e.g., Increased complexity for simple projects, difficulty finding developers familiar with the pattern)
 - Yes, i find it hard to add code in different parts of the project since i am not really familiar in onion architecture. Also, I've encountered a lot of errors and mistakes doing this project.
 
 

MVC:
 
 
Components: (1-3 keywords each)
 
 
3. Briefly describe the roles of the Model, View, and Controller in the MVC pattern.
 
 - Model: Describes the application's data and business logic. It processes data, communicates with the database, and holds the state of the application.
View: Shows the application's display layer. It manages user interface interactions and shows the user the data.
Controller: Serves as a go-between for the View and the Model. It takes in information from the user, processes it (usually by interacting with the Model), and then updates the View in response. It coordinates the logic and data flow inside the programme.


 
 
Bottlenecks (Encountered): (Yes/No and Briefly Explain)
 
 
4. Have you encountered any challenges with tight coupling between Model and Controller in MVC projects? If so, briefly describe the issue(s). (e.g., Difficulty in unit testing controllers, logic changes rippling through the application)
 
 - Yes, I've faced challenges with tight coupling between Model and Controller in MVC projects. Specifically, it often led to complexities during configuration and maintenance. Sometimes, it became unclear which part of the code needed modification, leading to errors and inefficiencies.
 

Web API:
 
 
Differences from MVC: (Yes/No and Briefly Explain)
 
 
5. Can you differentiate between traditional MVC applications and Web APIs? Briefly explain the main difference.
 - In traditional MVC applications, the focus is on building web pages where the View layer generates HTML to be displayed in the browser. The Controller manages user requests, interacts with the Model to retrieve data, and updates the View accordingly. While in Web APIs primarily focus on providing data and functionality to be consumed by other applications, typically over HTTP. They don't necessarily have a View layer and instead expose endpoints that can be accessed to perform specific actions or retrieve data, often in formats like JSON or XML.
 
 
 
Bottlenecks (Encountered): (Yes/No and Briefly Explain)
 
 
6. Have you encountered any performance challenges with traditional MVC applications compared to Web APIs? If so, briefly describe the scenario(s). (e.g., Frequent page refreshes causing performance overhead, complex data exchange requiring a more lightweight approach)

- No


 

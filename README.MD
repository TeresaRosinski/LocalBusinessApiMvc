<h1 align="center"><strong>Local Business API</strong></h1>

<h4 align="center"><em>API and MVC application created to track local restaurants and stores</em></h4>


##### __Created:__ 8/21/2020
##### __Last Updated:__ 8/21/2020 
##### By _** Teresa Rosinski**_  


## Description
This is an API project that offers full CRUD functionality. Users are able to add, remove, view and deleter local businesses. 

## Setup/Installation Requirements

* to clone this content, copy the url provided by the 'clone or download' button in GitHub
* in command line use the command 'git clone (GitHub url)'
* open the program in a code editor
* you will need [.NET] (https://dotnet.microsoft.com/download/dotnet-core/2.2) installed to run this program 
* then install dotnet script REPL by typing 'dotnet tool installl -g dotnet-script' in the command line
* type dotnet build in the command line to compile the code
* create a .gitignore file and store the bin and obj folders in .gitignore
* type dotnet run in the command line to run the program

# Importing and Updating the Database

* MySql must be installed on your device
* To connect the database type in the command line: dotnet ef migrations add Initial 
* To update the database type in the command line: dotnet ef database update    
* The database will automatically be populated with the data in the BusinessApiContext file


## API Documentation

### &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Available API Routes:

  * Business List [Type: POST]: http://<span></span>localhost:5000/api/businesses...
      * Returns a list of businesses based on parameters below
      * Parameters:
          - Name (string [max 50 characters])
          - Type (Restaurant or Store)
          - Description 
          - City 

  * Create Business [Type: POST]: http://<span></span>localhost:5000/api/businesses...
      * Creates a new Business records, all fields required for valid entry.
      * Parameters:
          - Name *required
          - Type *required
          - Description *required
          - City *required

  * Business Info [Type: GET]: http://<span></span>localhost:5000/api/businesses/{id}
      * Returns a single business record based on the id parameter below
      * Parameters:
          - id (integer) *required

  * Business Update [Type: PUT]: http://<span></span>localhost:5000/api/businesses/{id}
      * Updates a single business record based on the id parameter below,
      * Parameters:
          - id (integer) *required

  * Business Delete [Type: DELETE]: http://<span></span>localhost:5000/api/businesses/{id}
      * Deletes a single business record based on the id parameter below, userName parameter must match the userName on the record. 
      * Parameters:
          - id (integer) *required
          - userName (string [max 20 characters], must match userName on record) *required

### &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Using the API:

  * Using a platform like Postman, specify the type of request (GET/POST/PUT/DELETE)
  * Enter the appropriate URL for your route above.
  * Define any optional parameters if available and click "send"

      ```
      Call:
        Type: GET
        http://localhost:5000/api/businesses?City=Evanston

      Response (JSON, format: pretty):
        {
          "BusinessId": 5,
          "Name": "FlacosTacos",
          "City": "Evanston",
          "Type": "Restaurant",
          "Description": "Delicious Mexican food"
        }
      ```
      
      ```
      Call:
        Type: GET
        http://localhost:5000/api/businesses?random=true
      
      Response (JSON, format: pretty):
        {
          "BusinessId": 3,
          "Name": "El Famous",
          "City": "Chicago",
          "Type": "Restaurant",
          "Description": "Great tacos!"
        }
      ```

      ```
      Call:
        Type: PUT
        http://localhost:5000/api/businesses/5?Name=Portillos

      Response:
        n/a
        -DB record modified-
      ```

### &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Swagger UI use:

  * API calls can be used through the swagger UI
    http://<span></span>localhost:5000/

## Known Bugs

* n/a

## Support and contact details

* Name: Teresa Rosinski
* Email: trosinski89@gmail.com


## Technologies Used

* Visual Studio Code
* C#
* Swagger
* MySQL Workbench
* Entity Framework
* .NET Core

### License

Copyright (c) 2020 **_Teresa Rosinski_**

This software is licensed under the MIT license.
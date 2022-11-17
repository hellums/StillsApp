# StillsApp

Objective and Scope

Create a CRUD API and collection of basic .NET Web API endpoints, whose functions can be used to populate a databased of backend data using Entity Framework with the capability of being consumed in future by a web or mobile application related to the bourbon industry, including information on available tours and prices, locations, photos, and reviews.

Statement of Work

Create project proposal, code-first POCO entities and navigation properties, EF Core migrations, a cross-platform portable development database and production SQL Server contexts, basic anonymous httpGET and httpPOST API development endpoints, add the Swashbuckle UI, gather information related to domain entities, populate the development database with at least one full record or entity using the CRUD API calls, and provide a limited functionality Razor page to directly display data from the Entity Framework and database. The demonstration UI will not consume data using the API, that work will be saved for an upcoming UI design course with Code Louisville.

![WebApi2](https://user-images.githubusercontent.com/83464025/194877848-dc32a620-fe95-4d28-b5ef-6d5e522e9736.jpg)

General Requirements
- [x] Project is uploaded to your GitHub repository and shows at minimum 5 separate commits.
  - https://github.com/hellums/StillsApp/commits/root
- [x] Project includes a README file with a project description, any special instructions required to run, and a list of 3+ features
  - https://github.com/hellums/StillsApp#readme
- [x] Create at least one class, then create at least one object of that class, populate it with data from a database (minimum one table or one entity), and use or display the data in your application
  - https://github.com/hellums/StillsApp/blob/root/StillsApp/DL/Entities.cs
- [x] Create and call at least 3 functions or methods, at least one of which must return a value that is used in your application
  - Owners: https://github.com/hellums/StillsApp/blob/7d55570e5b20b728642cdea1ea4d4efb577f3f11/StillsApp/UI/Controllers/OwnersController.cs#L19
  - Distilleries: https://github.com/hellums/StillsApp/blob/7d55570e5b20b728642cdea1ea4d4efb577f3f11/StillsApp/UI/Controllers/DistilleryController.cs#L20
  - Photos: https://github.com/hellums/StillsApp/blob/7d55570e5b20b728642cdea1ea4d4efb577f3f11/StillsApp/UI/Controllers/PhotosController.cs#L19

FEATURE Requirements (3 minimum, preferably 4)
- [x] Make your application an API
  - API
      https://github.com/hellums/StillsApp/blob/7d55570e5b20b728642cdea1ea4d4efb577f3f11/StillsApp/Program.cs#L63
      https://github.com/hellums/StillsApp/tree/root/StillsApp/UI/Controllers
- [x] Make your application a CRUD API
  - C https://github.com/hellums/StillsApp/blob/7d55570e5b20b728642cdea1ea4d4efb577f3f11/StillsApp/UI/Controllers/DistilleryController.cs#L83-L84
  - R https://github.com/hellums/StillsApp/blob/7d55570e5b20b728642cdea1ea4d4efb577f3f11/StillsApp/UI/Controllers/DistilleryController.cs#L19-L20
      https://github.com/hellums/StillsApp/blob/7d55570e5b20b728642cdea1ea4d4efb577f3f11/StillsApp/UI/Controllers/DistilleryController.cs#L32-L33
  - U https://github.com/hellums/StillsApp/blob/7d55570e5b20b728642cdea1ea4d4efb577f3f11/StillsApp/UI/Controllers/DistilleryController.cs#L52-L53
  - D https://github.com/hellums/StillsApp/blob/7d55570e5b20b728642cdea1ea4d4efb577f3f11/StillsApp/UI/Controllers/DistilleryController.cs#L97-L98
- [x] Create a dictionary or list, populate it with several values, retrieve at least one value, and use it in your program
  - Owners: https://github.com/hellums/StillsApp/blob/7d55570e5b20b728642cdea1ea4d4efb577f3f11/StillsApp/UI/Controllers/OwnersController.cs#L19
  - Distilleries: https://github.com/hellums/StillsApp/blob/7d55570e5b20b728642cdea1ea4d4efb577f3f11/StillsApp/UI/Controllers/DistilleryController.cs#L20
  - Photos: https://github.com/hellums/StillsApp/blob/7d55570e5b20b728642cdea1ea4d4efb577f3f11/StillsApp/UI/Controllers/PhotosController.cs#L19
- [x] Add comments to your code explaining how you are using at least 2 of the solid principles
- SRP
  - https://github.com/hellums/StillsApp/blob/7d55570e5b20b728642cdea1ea4d4efb577f3f11/StillsApp/Program.cs#L51
  - https://github.com/hellums/StillsApp/blob/7d55570e5b20b728642cdea1ea4d4efb577f3f11/StillsApp/DL/DataContext.cs#L7
  - https://github.com/hellums/StillsApp/blob/7d55570e5b20b728642cdea1ea4d4efb577f3f11/StillsApp/DL/DataContext.cs#L25
  - https://github.com/hellums/StillsApp/blob/7d55570e5b20b728642cdea1ea4d4efb577f3f11/StillsApp/DL/Entities.cs#L3
  - https://github.com/hellums/StillsApp/blob/7d55570e5b20b728642cdea1ea4d4efb577f3f11/StillsApp/Properties/launchSettings.json#L2
- OCP
  - https://github.com/hellums/StillsApp/blob/7d55570e5b20b728642cdea1ea4d4efb577f3f11/StillsApp/Program.cs#L29
  - https://github.com/hellums/StillsApp/blob/7d55570e5b20b728642cdea1ea4d4efb577f3f11/StillsApp/DL/SqliteDataContext.cs#L7
- DIP
  - https://github.com/hellums/StillsApp/blob/7d55570e5b20b728642cdea1ea4d4efb577f3f11/StillsApp/Program.cs#L41
  - https://github.com/hellums/StillsApp/blob/7d55570e5b20b728642cdea1ea4d4efb577f3f11/StillsApp/appsettings.json#L10
  - https://github.com/hellums/StillsApp/blob/7d55570e5b20b728642cdea1ea4d4efb577f3f11/StillsApp/DL/DataContext.cs#L26

INSTRUCTIONS:

Clone the repo to a folder on your local system, and open the StillsApp.sln file in Visual Studio. Select Debug in the strip, then select and click StillsDevApp on the environment dropdown to bring up a sample front end in your default browser. This selects a few items from a sample distillery in the database. 

To test the API using the Swashbuckle UI, add /swagger/index.html to the URL in the address bar (for example, http://localhost:7218/swagger/index.html). To test the Read component of each entity, select Get, Try it Out, and Execute. The results will be visible in the Responses section immediate below. 

Further testing of the API and CRUD capabilities will require the tester to be familiar with the Swashbuckle user interface. For example, to delete an specific review or address, a specific recrod's ID number will need to be entered as an ID parameter before pressing Execture. Using the ID 1 will delete the first entity in that database table, for example. The Update function could be used in the same way to change a field in that same record, using properly formatted JSON.

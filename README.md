# StillsApp

Objective and Scope

Create a collection of basic .NET Web API endpoints and backend data that can be consumed by a web or mobile application related to the bourbon industry, including information on available tours and prices, locations, photos, reviews, that could be used for a future eCommerce app for photography products.

Statement of Work

Create project proposal, code-first POCO entities and navigation properties, EF Core migrations, a cross-platform portable development database and production SQL Server contexts, basic anonymous httpGET and httpPOST API development endpoints, add the Swashbuckle UI, gather information related to domain entities, populate the development database with at least one full record or entity, perform unit testing.

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

FEATURE Requirements (3-4, or more)
- [x] Make your application an API or CRUD API
  - API
      https://github.com/hellums/StillsApp/blob/7d55570e5b20b728642cdea1ea4d4efb577f3f11/StillsApp/Program.cs#L63
      https://github.com/hellums/StillsApp/tree/root/StillsApp/UI/Controllers
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
- [x] Create 3 or more unit tests for your application

![WebApi2](https://user-images.githubusercontent.com/83464025/194877848-dc32a620-fe95-4d28-b5ef-6d5e522e9736.jpg)

![Stills CRUD API](https://user-images.githubusercontent.com/83464025/194878366-dc1fcde6-e853-4434-85cf-acc6b34f0d52.jpg)


# Install MongoDb

**Note:** This is for Windows x64

- Go to [MongoDb Documentary, download and install](https://www.mongodb.com/docs/manual/tutorial/install-mongodb-on-windows/)  You may install, either as servive or not. Additionally, installing Compass will be better. (Both choices are asked while installing.)
- After installing add MongoDb `bin` folder to your `Path` in system environment variables. The default locaiont is:

  ```
  C:\Program Files\MongoDB\Server\{Monbo version}\bin
  ```
  
# Project

- Install `MongoDB.Driver` Package to your project using NuGet, PMC or PowerShell, for PMC:
```
Install-Package MongoDB.Driver -Version {VERSION}
```
- MongoDb has data annotations like EFs to configure Entity properties.
- Configure appsettings.Json and DbSettings.cs (in the Models folder), these two have exact same property names to easily map between.
- Register Db settings in the Startup.cs.
- A MongoClient is used for db read/write operations, and the Db connection string is injected to the MongoDb via MongoDbBooksDbSettings. The usage is shown in BookService in the project.  
**Note:**
    - Collection in Mongo roughly represents a Table in SQL datagbases.
    - Document in Mongo roughly represents Entity or one row in a SQL database Table.

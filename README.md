# Install MongoDb

**Note:** This is for Windows x64

- Go to [MongoDb Documentary, download and install](https://www.mongodb.com/docs/manual/tutorial/install-mongodb-on-windows/)  You may install, either as servive or not. Additionally, installing Compass will be better. (Both choices are asked while installing.)
- After installing add MongoDb `bin` folder to your `Path` in system environment variables. The default locaiont is:

  ```
  C:\Program Files\MongoDB\Server\{Monbo version}\bin
  ```
- Choose (or create) a directory to store your data. For example: `C:\BooksData`.
- Open a CMD or PowerShell and run the command:
```
mongod --dbpath <your chosen data folder path>
```
leave the cmd open.
  
# Project

- Install `MongoDB.Driver` Package to your project using NuGet, PMC or PowerShell, for PMC:
```
Install-Package MongoDB.Driver -Version {VERSION}
```
- MongoDb has data annotations like EFs to configure Entity properties.
- Configure appsettings.Json and DbSettings.cs (in the Models folder), these two have exact same property names to easily map between.
- It will create a Database and a collection in it, if they do not already exist.
- Register Db settings in the Startup.cs.
- A MongoClient is used for db read/write operations, and the Db connection string is injected to the MongoDb via MongoDbBooksDbSettings. The usage is shown in BookService in the project.  
**Note:**
    - Collection in Mongo roughly represents a Table in SQL datagbases.
    - Document in Mongo roughly represents Entity or one row in a SQL database Table.

## Serialization of Json Responses
Propery names will be in lower case in Json, if you prefer to match the casing, add the package below to your project, then register in the Startup.cs. After that, your Requests and Responses will be in Pascal case like in your classes.
```
Microsoft.AspNetCore.Mvc.NewtonsoftJson
```

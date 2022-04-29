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

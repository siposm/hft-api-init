# hft-api-init

### What do we have?

- Data + Repo + Logic layers
- Thick Client layer
- Unit tests with mocked repo

### What is new?

- BlogLogic and IBlogLogic and BlogRepository
	- AddNewBlog
	- UpdateBlog
	- DeleteBlog

### What will be added?

- delete project references from client except for Data layer/project (or if there is dedicated Models project)

- Sln -> add new project
	- BlogSystem.Endpoint
	- ASP.NET Core Empty Project!!!
	- ASP.NET Core 5.0
	- HTTPS not needed
     
- set the Endpoint project as startup
- run, check if browser opens (launchsettings.json --> localhost:0123)
- set chrome as default browser for IIS

- add references to Endpoint layer (Data + Repo + Logic)
 
- Startup.cs --> UseEndpoints update
- Startup.cs --> ConfigureServices update

- Create Controllers folder in Endpoint
- Add controllers
	- API --> API with read/write
	- update main route
	- add ctor with interface reference
	- update http method routes
     
- launchSettings.json --> launchUrl --> set default url

- add IoC --> startup.cs --> add transients

- JSON serialization problem --> JsonIgnore

- nonCrud --> statController --> main route update []/[action]

- Test from browser (GET)
- Test from Postman (POST, PUT, DELETE)
    - GetAll
    - GetById
    - POST -> body -> raw -> json (create new blog with title)

- Client --> add nuget WebApi.Client

- RestService --> similar to JS Fetch API

- Sln -> properties -> multiple startup project (client + endpoint)
    - Thread.sleep in client
     
- Test through RestService calls


### SimpleBloggingAPI

This is a basic RESTful API built for personal blogging. It allows performing `CRUD` operations. Posts are stored in a user’s defined defined database (set in the installation process).

### Installation

1. Clone the repository
```bash

https://github.com/migmaram/SimpleBloggingAPI.git
```
3. Navigate to the project’s directory
```bash

cd ./SimpleBloggingAPI
``` 
4. Open the project using Visual Studio or Visual Studio Code
5. Set your database connection string in the `appsettings.json` file.
```json

"ConnectionStrings": {
    "BloggingDatabase" : "{your-database-connectio--string}"
}
```
7. Run migrations (Make sure you have Entity Framework Core installed):
    - VS console: `Update-database`
    - VS Code console: `dotnet ef database update`
8. Run the application

### Usage

**Create post**
```json

POST /posts
{
  "title": "My First Blog Post",
  "content": "This is the content of my first blog post.",
  "category": "Technology",
  "tags": ["Tech", "Programming"]
}
```

**Update Blog Post**
Update an existing  post
```json
PUT /posts/{id}

{
  "title": "My Updated Blog Post",
  "content": "This is the updated content of my first blog post.",
  "category": "Technology",
  "tags": ["Tech", "Programming"]
}
```

**Delete post**
```json

DELETE /posts/{id}
```

**Get post**
```json

GET /posts/{id}
```

**Get all posts**
```json

GET /posts
```

**Get posts using wildcard**
```json

GET /posts?term={term}
```
### Statement

The main goal of building this project was to practice:
- C# coding
- SOLID principles
- Entity Framework, code first.
- Dependency injecton, repository and unitOfWork desing patterns

✨I took the idea from: [Developer Roadmaps - Blogging platform API project](https://roadmap.sh/projects/blogging-platform-api)

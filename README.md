### SimpleBloggingAPI

This is a basic RESTful API built for personal blogging. It allows performing `CRUD` operations. Posts are stored in a user’s defined defined database (set in the installation process).

### Installation

1. Clone the repository: 
2. Navigate to the project’s directory
   ```
   
   cd ./SimpleBloggingAPI
   
   ``` 
4. Open the project using Visual Studio or Visual Studio Code
5. Set your database connection string in the `appsettings.json` file
6. Run migrations (Make sure you have Entity Framework Core installed):
    - VS console: `Update-database`
    - VS Code console: `dotnet ef database update`
7. Run the application

### Usage

**Create post**
```

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
```
PUT /posts/{id}

{
  "title": "My Updated Blog Post",
  "content": "This is the updated content of my first blog post.",
  "category": "Technology",
  "tags": ["Tech", "Programming"]

}
```

**Delete post**
```

DELETE /posts/{id}
```

**Get post**
```

GET /posts/{id}
```

**Get all posts**
```

GET /posts
```

**Get posts using wildcard**
```sql

GET /posts?term={term}
```
### Statement

The main goal of building this project was to practice:
- C# coding
- SOLID principles
- Entity Framework, code first.
- Dependency injecton, repository and unitOfWork desing patterns

✨I took the idea, from the back end software development at: [https://roadmap.sh/projects/task-tracker](https://roadmap.sh/projects/blogging-platform-api)

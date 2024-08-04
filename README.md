## GameStore API

This repository contains a RESTful API for the GameStore application, built with ASP.NET Core. It uses Entity Framework Core for data access and SQLite as the database.
## Author

- [@milansaji](https://github.com/Milansaji)


## Features

- RESTful API for managing games and genres
- CRUD operations for games and genres
- Entity Framework Core integration
- SQLite as the database provider


## Requirements
- .NET 6 SDK
- SQLite
## Installation

Clone the repository:


```bash
 gh repo clone Milansaji/GameStore-API
```

Install the required dependencies:

```bash
 dotnet restore

```
Update the database:

```bash
 dotnet ef database update


```
## Usage

```bash
 dotnet run


```
## API Endpoints

Games
- GET /games: Get all games
- POST /games: Create a new game
- GET /games/{id}: Get a game by ID
- PUT /games/{id}: Update a game by ID
- DELETE /games/{id}: Delete a game by ID

Genres
- GET /genres: Get all genres
## Technologies

- ASP.NET Core: Web framework for building modern, cloud-based, internet-connected applications.
- Entity Framework Core: Object-database mapper for .NET.
- SQLite: Self-contained, high-reliability, embedded, full-featured, public-domain, SQL database engine.

using System.Reflection.Metadata.Ecma335;
using GameStore;
using GameStore.endpoints;
using GameStore.GamesDots;
using Microsoft.AspNetCore.Mvc;

 var builder = WebApplication.CreateBuilder(args);
        var connstring = builder.Configuration.GetConnectionString("GameStore");
        builder.Services.AddSqlite<GameContext>(connstring);
        var app = builder.Build();
     

      app.MapGamesEndPoints();
      app.MapGenresEndpoints();
     await app.MigrateDbAsync();

        app.Run();
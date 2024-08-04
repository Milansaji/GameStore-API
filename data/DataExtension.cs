using System.Security.Cryptography.X509Certificates;
using GameStore.GamesDots;
using Microsoft.EntityFrameworkCore;

namespace GameStore;

public  static class DataExtension
{


public static async Task  MigrateDbAsync(this WebApplication app){
using var scope = app.Services.CreateScope();
var dbContext = scope.ServiceProvider.GetRequiredService<GameContext>();
 await   dbContext.Database.MigrateAsync();
}
}

using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace GameStore.GamesDots;

public static  class GamesEndPoints
{
   const string GetGameEndpointNames = "GetGame";
  
public static RouteGroupBuilder MapGamesEndPoints(this WebApplication app){
    var group = app.MapGroup("games").WithParameterValidation();
    
        app.MapGet("/",async (GameContext dbcxt) => await dbcxt.Games.Include(Games => Games.Genre).AsNoTracking().ToListAsync());
        app.MapGet("/{id}",async (int id, GameContext dbcxt ) =>
        {
            Game? game = await dbcxt.Games.FindAsync(id);
            return game is null ? Results.NoContent() : Results.Ok(game.ToGamedetailDto());


        }
        ).WithName(GetGameEndpointNames);

        app.MapPost("/",async (CreateGameDto newGame, GameContext dbcontext) =>
        {
        Game game = newGame.ToEntity();
        game.Genre = dbcontext.Genres.Find(newGame.GenreId);
          
          dbcontext.Games.Add(game);
         await dbcontext.SaveChangesAsync();

         

            return Results.CreatedAtRoute(GetGameEndpointNames, new {id = game.Id}, game.ToDto());
        }).WithParameterValidation();
        app.MapPut("/{id}",async (int id, UpdateGameDto updatedgame, GameContext dbcxt) =>
        {
           var Listedgame = await dbcxt.Games.FindAsync(id);
            if(Listedgame  == null){
                return Results.NotFound();
            }

          dbcxt.Entry(Listedgame).CurrentValues.SetValues(updatedgame.ToEntity(id));

    await      dbcxt.SaveChangesAsync();

            return Results.Ok();

        }).WithParameterValidation();
        app.MapDelete("/games/{id}", async (int id , GameContext dbcxt) =>
        {
            string res = "Deleted id " + id;

   await   dbcxt.Games.Where(games => games.Id == id).ExecuteDeleteAsync();
   
    return res;
          
            
        }

        );

        return group;
}

}

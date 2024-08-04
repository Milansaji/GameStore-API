using GameStore.GamesDots;
using GameStore.Mapping;
using Microsoft.EntityFrameworkCore;

namespace GameStore.endpoints
{
    public static class GenreEndpoints
    {
        public static RouteGroupBuilder MapGenresEndpoints(this WebApplication app)
        {
            var group = app.MapGroup("genres");
            group.MapGet("/", async (GameContext dbcxt) => 
                await dbcxt.Genres.Select(genre => genre.ToDto()).AsNoTracking().ToListAsync());
            return group;
        }
    }
}

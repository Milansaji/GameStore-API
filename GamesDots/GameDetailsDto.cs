namespace GameStore.GamesDots.GameDetailsDto;

public record class GameDetailsDto(int id ,
string Name, 
int GenreId ,
 decimal Price , 
 DateOnly ReleaseDate 
);

﻿using GameStore.GamesDots;

namespace GameStore;

public class Game
{
public int Id { get; set; }
public required string Name { get; set; }

public int GenreId { get; set; }

public Genre? Genre { get; set; }

public decimal Price { get; set; }

public DateOnly ReleaseDate { get; set; }


}

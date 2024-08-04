﻿using System.ComponentModel.DataAnnotations;

namespace GameStore.GamesDots;

public record class UpdateGameDto(
[Required] [StringLength(50)]string Name, 
int  GenreId ,
 [Required] [Range(1,100)]decimal Price , 
 DateOnly ReleaseDate 
);

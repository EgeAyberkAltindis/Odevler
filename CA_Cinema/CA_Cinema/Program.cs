
using CA_Cinema.Models;

Cinema cinema = new Cinema();
foreach (Cinema movie in cinema.GetCinemas())
{
    Console.WriteLine($"sinema ismi : {movie.Name} ---Sinema kategori : {movie.Categories}");
}

cinema.Id = 4;
cinema.Name = "Forrest Gump";
cinema.Categories = "Comedy";

cinema.AddCinema( cinema );
Console.WriteLine($"sinema ismi : {cinema.Name} ---Sinema kategori : {cinema.Categories}");

cinema.RemoveCinema( cinema );
foreach (Cinema movie in cinema.GetCinemas())
{
    Console.WriteLine($"sinema ismi : {movie.Name} ---Sinema kategori : {movie.Categories}");
}

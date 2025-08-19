namespace webPokemonAPI.Entities;

public class Category
{
    public int Id { get; set; }

    public string Name { get; set; }

    // Joins 

    // * - * 

    public ICollection<PokemonCategory> PokemonCategories { get; set; }
    
}
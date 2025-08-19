namespace webPokemonAPI.Entities;

public class Country
{
    public int Id { get; set; }

    public string Name { get; set; }

    // Joins 

    public ICollection<Owner> Owners { get; set; }
}

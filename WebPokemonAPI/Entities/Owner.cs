namespace webPokemonAPI.Entities;

public class Owner
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Gym { get; set; }

    // Joins

    // 1 - 1 
    public Country Country { get; set; }


}


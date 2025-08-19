namespace webPokemonAPI.Entities;

public class Reviewer
{
    public int Id { get; set; }

    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Joins 1-* : llamo a una lista de * en la de 1 (ej: estoy en Reviewer y llamo la lista de Review que son *)

    public ICollection<Review> Reviews { get; set; }
}
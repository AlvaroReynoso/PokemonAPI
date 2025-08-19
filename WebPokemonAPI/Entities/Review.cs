namespace webPokemonAPI.Entities;

public class Review
{
    public int Id { get; set; }

    public string Title { get; set; }
    public string Text { get; set; }

    // JOINS 1-1  : cuando hay 1-1 se llama como tipo de dato a esa clase referida (ej: Reviewer)
    public Reviewer Reviewer { get; set; }
    
    public Pokemon Pokemon { get; set; }

}
namespace webPokemonAPI.Entities
{
    // Creamos la entidad Pokemon que va a tener ciertos atributos
    public class Pokemon
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        // Joins

        //1 - * o * - 1
        public ICollection<Review> Reviews { get; set; }

        // public ICollection<Owner> Owners { get; set; }
        
        // public ICollection<Category> Categories{ get; set; }
    
    }

}
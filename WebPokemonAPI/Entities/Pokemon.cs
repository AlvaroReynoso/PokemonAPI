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


// * - * , se crean tablas pivots tambien
        public ICollection<PokemonOwner> PokemonOwners { get; set; }
        
        public ICollection<PokemonCategory> PokemonCategories { get; set; }
    
    }

}
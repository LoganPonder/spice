namespace spice.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int TimeToMake { get; set; }
        public bool Vegan { get; set; }
        public bool Vegetarian { get; set; }
    }
}
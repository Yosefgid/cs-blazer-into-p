namespace Complimentree.Models
{
    public class Tree
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public (decimal Latitude, decimal Longitude ) Location { get; set; }
        public string Size { get; set; }
        public string Species { get; set; }
        public List<Compliment> Compliments { get; set; } = new();



    }
}

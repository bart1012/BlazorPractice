namespace BlazorApp1.Models
{
    public class Tree
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public (double x, double y) Location { get; set; }
        public double Size { get; set; }
        public string Species { get; set; }
        public List<string> Compliments { get; set; }

    }


}

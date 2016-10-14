namespace Sweet.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Resolve Resolve { get; set; }

    }
    public enum Resolve
    {
        Open = 1,
        Closed
    }
}
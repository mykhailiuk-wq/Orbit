namespace Orbit.Models
{
    public class UserTask
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public required string name { get; set; }
        public DateTime? deadline { get; set; }
        public bool? isDone { get; set; }
    }
}

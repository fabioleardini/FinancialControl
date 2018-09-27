namespace Domain
{
    public class Spent
    {
        public int Id { get; set; }

        public Category Category { get; set; }

        public Month Month { get; set; }

        public short Year { get; set; }

        public string Note { get; set; }
    }
}
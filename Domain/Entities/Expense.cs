namespace Domain
{
    public class Expense : Entity
    {
        public string Name { get; set; }

        public Category Category { get; set; }

        public Month Month { get; set; }

        public short Year { get; set; }

        public string Note { get; set; }
     }
}
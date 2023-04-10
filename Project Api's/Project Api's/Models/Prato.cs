namespace Project_Api_s.Models {
    public class Prato {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }

        public Prato() { }

        public Prato(int id, string name, string description, double value) {
            Id = id;
            Name = name;
            Description = description;
            Value = value;
        }

    }
}

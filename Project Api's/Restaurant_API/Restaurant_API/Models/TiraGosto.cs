using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant_API.Models {
    [Table("tira_gostos")]
    public class TiraGosto {

        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("value")]
        public double Value { get; set; }

        public TiraGosto(int id, string name, string description, double value){ 
        
            Id = id;
            Name = name;
            Description = description;
            Value = value;
        }

    }
}

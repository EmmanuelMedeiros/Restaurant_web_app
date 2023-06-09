﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant_API.Models {
    [Table("guarnicoes")]
    public class Guarnicao {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }

        public Guarnicao() { }

        public Guarnicao(int id, string name, double value) {

            Id = id;
            Name = name;
            Value = value;
        }

    }
}

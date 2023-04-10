using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities {
    internal class Prato {

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

        public virtual void FullValue() {
            Value += Value;
        }
    }
}
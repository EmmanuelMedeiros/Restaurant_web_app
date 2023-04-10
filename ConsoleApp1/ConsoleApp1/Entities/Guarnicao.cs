using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities {
    internal class Guarnicao {

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

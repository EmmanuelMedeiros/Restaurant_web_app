using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities {
    internal class TiraGosto : Prato {

        public TiraGosto() { }

        public TiraGosto(int id, string name, string description, double value) : base(id, name, description, value) {

        }

    }
}

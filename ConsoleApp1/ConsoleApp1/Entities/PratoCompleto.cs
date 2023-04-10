using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities {
    internal class PratoCompleto : Prato{

        public List<Guarnicao> _guarnicao { get; set; } = new List<Guarnicao>();

        public PratoCompleto() { }

        public PratoCompleto(int id, string name, string description, double value) : base(id, name, description, value) {
        }

        public void AddGuarnicao(Guarnicao guarnicao) {

            if(_guarnicao.Count < 2 && guarnicao.Id != 3) {

                Guarnicao guarnicao_to_add = new Guarnicao(guarnicao.Id, guarnicao.Name, 0);
                _guarnicao.Add(guarnicao_to_add);
            } else {

                _guarnicao.Add(guarnicao);
            }
        }

        public override void FullValue() {

            double valorGuarnicao = 0;

            foreach (var guarnicao in _guarnicao) {

                valorGuarnicao += guarnicao.Value;
            }

            Value += valorGuarnicao;
        }

        public override string ToString() {

            string acompanhamento = "";

            foreach (Guarnicao guarnicao in _guarnicao) {
                acompanhamento += $"{guarnicao.Name};";
            }

            return $"Código: {Id} - {Name} \nAcompanhamentos: {acompanhamento} \nValor: {Value}";
        }
    }

}

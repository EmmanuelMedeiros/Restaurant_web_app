using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json;

namespace Restaurant_API.Models {
    [Table("pratos_completos")]
    public class PratoCompleto {

        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("value")]
        public double Value { get; set; }
        private List<Guarnicao> _guarnicao = new List<Guarnicao>();

        public PratoCompleto() { }

        public PratoCompleto(int id, string name, string description, double value, List<Guarnicao> guarnicao) {

            Id = id;
            Name = name;
            Description = description;
            Value = value;
            _guarnicao = guarnicao;
        }

        public void AddGuarnicao(Guarnicao guarnicao) {

            if (_guarnicao.Count < 2 && guarnicao.Id != 3) {

                Guarnicao guarnicao_to_add = new Guarnicao(guarnicao.Id, guarnicao.Name, 0);
                _guarnicao.Add(guarnicao_to_add);
            }
            else {

                _guarnicao.Add(guarnicao);
            }
        }

        public void FullValue() {

            foreach(var element in _guarnicao) {

                if(element.Id == 3) {
                    Value += element.Value;
                }
            }

            if(_guarnicao.Count > 2) {
                for(int i = 3; i <= _guarnicao.Count; i++) {
                    Value += _guarnicao[i - 1].Value;
                }
            }
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

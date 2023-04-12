using System.ComponentModel.DataAnnotations.Schema;

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

        public PratoCompleto(int id, string name, string description, double value) {

            Id = id;
            Name = name;
            Description = description;
            Value = value;
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

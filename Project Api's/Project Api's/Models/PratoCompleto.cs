namespace Project_Api_s.Models {
    public class PratoCompleto : Prato {

        public Guarnicao _guarnicao { get; set; }

        public PratoCompleto() { }

        public PratoCompleto(int id, string name, string description, double value, Guarnicao guarnicao) : base(id, name, description, value) {

            _guarnicao= guarnicao;
        }
    }
}

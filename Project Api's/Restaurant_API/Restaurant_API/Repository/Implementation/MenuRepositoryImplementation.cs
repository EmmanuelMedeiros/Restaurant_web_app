using Restaurant_API.Context;
using Restaurant_API.Models;

namespace Restaurant_API.Repository.Implementation {
    public class MenuRepositoryImplementation : IMenuRepositoryInterface {

        private MySQLContext _context;
        public MenuRepositoryImplementation(MySQLContext context) {

            _context = context;
        }

        public List<PratoCompleto> GetAllPratosCompletos() {

            return _context.Pratos_Completos.ToList();
        }

        public PratoCompleto GetPratoCompletoById(int id) {

            if(_context.Pratos_Completos.Any(p => p.Id == id)) {
                try {
                    return _context.Pratos_Completos.FirstOrDefault(p => p.Id == id);
                } catch(Exception ex) {
                    throw;
                }
            } else {
                return null;
            }
        }

        public Guarnicao GetGuarnicaoById(int id) {

            if(_context.Guarnicoes.Any(g => g.Id == id)) {
                try {
                    return _context.Guarnicoes.FirstOrDefault(g => g.Id == id);
                } catch(Exception ex) {
                    throw;
                }
            } else {
                return null;
            }
        }

        public List<Guarnicao> GetAllGuarnicoes() {

            return _context.Guarnicoes.ToList();
        }

    }
}

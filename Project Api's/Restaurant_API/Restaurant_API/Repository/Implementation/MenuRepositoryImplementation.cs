using Restaurant_API.Context;
using Restaurant_API.Models;

namespace Restaurant_API.Repository.Implementation {
    public class MenuRepositoryImplementation : IMenuRepositoryInterface {

        private MySQLContext _context;
        public MenuRepositoryImplementation(MySQLContext context) {
            _context = context;
        }

        public List<PratoCompleto> GetAllPratoCompletos() {
            return _context.Pratos_Completos.ToList();
        }

    }
}

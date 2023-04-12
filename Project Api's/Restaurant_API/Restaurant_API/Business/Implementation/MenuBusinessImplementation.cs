using Restaurant_API.Models;
using Restaurant_API.Repository;

namespace Restaurant_API.Business.Implementation {
    public class MenuBusinessImplementation : IMenuBusinessInterface {

        private IMenuRepositoryInterface _repository;

        public MenuBusinessImplementation(IMenuRepositoryInterface repository) {

            _repository = repository;
        }

        public List<PratoCompleto> GetAllPratosCompletos() {

            return _repository.GetAllPratosCompletos();
        }

        public PratoCompleto GetPratoCompletoById(int id) {

            return _repository.GetPratoCompletoById(id);
        }

        public Guarnicao GetGuarnicaoById(int id) {

            return _repository.GetGuarnicaoById(id);
        }

        public List<Guarnicao> GetAllGuarnicoes() {

            return _repository.GetAllGuarnicoes();
        }
    }
}

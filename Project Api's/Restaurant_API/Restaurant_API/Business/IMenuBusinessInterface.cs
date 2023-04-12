using Restaurant_API.Models;

namespace Restaurant_API.Business {
    public interface IMenuBusinessInterface {

        List<PratoCompleto> GetAllPratosCompletos();
        PratoCompleto GetPratoCompletoById(int id);
        Guarnicao GetGuarnicaoById(int id);
        List<Guarnicao> GetAllGuarnicoes();
    }
}

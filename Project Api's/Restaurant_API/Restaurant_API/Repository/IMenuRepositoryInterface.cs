using Restaurant_API.Models;

namespace Restaurant_API.Repository {
    public interface IMenuRepositoryInterface {

        List<PratoCompleto> GetAllPratoCompletos();
    }
}

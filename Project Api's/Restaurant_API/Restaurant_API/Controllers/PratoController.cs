using Microsoft.AspNetCore.Mvc;
using Restaurant_API.Repository;

namespace Restaurant_API.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class PratoController : ControllerBase {

        private readonly ILogger<PratoController> _logger;
        private readonly IMenuRepositoryInterface _repository;

        public PratoController(ILogger<PratoController> logger, IMenuRepositoryInterface repository) {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public ActionResult Teste() {

            return Ok(_repository.GetAllPratoCompletos());
        }



    }
}

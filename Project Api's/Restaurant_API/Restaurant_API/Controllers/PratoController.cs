using Microsoft.AspNetCore.Mvc;
using Restaurant_API.Repository;
using Restaurant_API.Models;
using Restaurant_API.Business;

namespace Restaurant_API.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class PratoController : ControllerBase {

        private readonly ILogger<PratoController> _logger;
        private readonly IMenuBusinessInterface _business;

        public PratoController(ILogger<PratoController> logger, IMenuBusinessInterface business) {
            _logger = logger;
            _business = business;
        }
        [HttpGet("guarnicoes")]
        public IActionResult GetAllGuarnicoes() {

            return Ok(_business.GetAllGuarnicoes());
        }

        [HttpGet("pratos_completos")]
        public IActionResult GetAll() {

            return Ok(_business.GetAllPratosCompletos());
        }


        [HttpPost("{id}")]
        public ActionResult GetaNewPrato(int id, List<Guarnicao> guarnicao) {

            PratoCompleto meu_prato = _business.GetPratoCompletoById(id);

            if(meu_prato != null) { 
            
                foreach(var element in guarnicao) {

                    meu_prato.AddGuarnicao(element);
                }

                meu_prato.FullValue();

                return Ok(meu_prato);
            } else {
                return BadRequest();
            }
        }



    }
}

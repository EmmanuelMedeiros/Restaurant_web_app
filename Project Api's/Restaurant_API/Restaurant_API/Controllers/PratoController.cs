using Microsoft.AspNetCore.Mvc;
using Restaurant_API.Repository;
using Restaurant_API.Models;
using Restaurant_API.Business;
using System.Text;
using System.Text.Json;

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

                Dictionary<string, object> dict = new Dictionary<string, object>();

                dict.Add("Id", meu_prato.Id);
                dict.Add("Nome_do_prato", meu_prato.Name);

                List<Guarnicao> my_list = new List<Guarnicao>();
                foreach(var element in guarnicao) {

                    var my_guarnicao = new Guarnicao(element.Id, element.Name, element.Value);
                    my_list.Add(my_guarnicao);
                }

                dict.Add("Guarnicao", my_list);
                meu_prato.FullValue();

                dict.Add("Valor Total", meu_prato.Value);

                return Ok(dict);
            } else {
                return BadRequest();
            }
        }



    }
}

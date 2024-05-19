using Microsoft.AspNetCore.Mvc;
using PazYSalvoAPP.Business.Services;
using PazYSalvoAPP.Models;
using PazYSalvoAPP.WebApp.Models.ViewModels;

namespace PazYSalvoAPP.WebApp.Controllers.Personas
{
    public class PersonaController : Controller
    {
        private readonly IPersonaService _personaService;
        public PersonaController(IPersonaService personaService)
        {
            _personaService = personaService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ListarPersonas()
        {
            IQueryable<Persona>? consultaDePersonas = await _personaService.LeerTodos();

            List<PersonaViewModel> listadoDePersonas = consultaDePersonas.Select(e => new PersonaViewModel
            {

                Id = e.Id,
                Nombres = e.Nombres,
                Telefono  = e.Telefono,
                CorreoElectronico =e.CorreoElectronico,
                DocumentoIdentificacion =e.DocumentoIdentificacion,
                FechaDeCreacion =e.FechaDeCreacion,
                

            }).ToList();

            return PartialView("_ListadoDePersonas",
                              listadoDePersonas);
        }
        //[HttpPost] // *
        //public async Task<IActionResult> AgregarFacturas([FromBody] FacturaViewModel model)
        //{
        //    Estado estado = new estado()
        //    {

        //        Nombre = e.Nombre,
        //        Descripcion = e.Descripcion,
        //    };

        //    bool response = await _estadoService.Insertar(estado);

        //    return RedirectToAction("Index");

        //}

        //[HttpPost]
        //public async Task<IActionResult> ActualizarFacturas([FromBody] FacturaViewModel model)
        //{
        //    Factura factura = new Factura()
        //    {


        //    };

        //    bool response = await _estadoService.Actualizar(factura);

        //    return StatusCode(StatusCodes.Status200OK,
        //                      new { valor = response });

        //}
    }
}

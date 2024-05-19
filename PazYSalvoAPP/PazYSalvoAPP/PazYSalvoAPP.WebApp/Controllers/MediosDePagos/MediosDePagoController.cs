using Microsoft.AspNetCore.Mvc;
using PazYSalvoAPP.Business.Services;
using PazYSalvoAPP.Models;
using PazYSalvoAPP.WebApp.Models.ViewModels;

namespace PazYSalvoAPP.WebApp.Controllers.MediosDePagos
{
    public class MediosDePagoController : Controller
    {
        private readonly IMediosDePagoService _mediosdepagoService;
        public MediosDePagoController(IMediosDePagoService mediosdepagoService)
        {
            _mediosdepagoService = mediosdepagoService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ListarMediosDePagos()
        {
            IQueryable<MediosDePago>? consultaDeMediosDePagos = await _mediosdepagoService.LeerTodos();

            List<MediosDePagoViewModel> listadoDeMediosDePagos = consultaDeMediosDePagos.Select(e => new MediosDePagoViewModel
            {

                Id = e.Id,
                Nombre = e.Nombre,
                Descripcion  = e.Descripcion ,
                FechaDeCreacion =e.FechaDeCreacion,

            }).ToList();

            return PartialView("_ListadoDeMediosDePagos",
                              listadoDeMediosDePagos);
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

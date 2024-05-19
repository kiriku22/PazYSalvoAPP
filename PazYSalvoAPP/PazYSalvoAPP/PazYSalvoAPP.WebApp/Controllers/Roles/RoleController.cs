using Microsoft.AspNetCore.Mvc;
using PazYSalvoAPP.Business.Services;
using PazYSalvoAPP.Models;
using PazYSalvoAPP.WebApp.Models.ViewModels;

namespace PazYSalvoAPP.WebApp.Controllers.Roles
{
    public class RoleController : Controller
    {
        private readonly IRoleService _roleService;
        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ListarRoles()
        {
            IQueryable<Role>? consultaDeRoles = await _roleService.LeerTodos();

            List<RoleViewModel> listadoDeRoles = consultaDeRoles.Select(e => new RoleViewModel
            {

                Id = e.Id,
                Nombre = e.Nombre,
                Descripcion = e.Descripcion,
                Activo =e.Activo,
                FechaDeCreacion=e.FechaDeCreacion,


            }).ToList();

            return PartialView("_ListadoDeRole",
                              listadoDeRoles);
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

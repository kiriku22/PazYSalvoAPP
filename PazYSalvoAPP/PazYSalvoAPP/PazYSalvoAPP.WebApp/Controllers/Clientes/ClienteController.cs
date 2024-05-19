﻿using Microsoft.AspNetCore.Mvc;
using PazYSalvoAPP.Business.Services;
using PazYSalvoAPP.Models;
using PazYSalvoAPP.WebApp.Models.ViewModels;

namespace PazYSalvoAPP.WebApp.Controllers.Clientes
{
    public class ClienteController : Controller
    {
        private readonly IClienteService _clienteService;
        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ListarClientes()
        {
            IQueryable<Cliente>? consultaDeClientes = await _clienteService.LeerTodos();

            List<ClienteViewModel> listadoDeClientes = consultaDeClientes.Select(e => new ClienteViewModel
            {
                Id = e.Id,
                PersonaId = e.PersonaId,
                RolId = e.RolId,

            }).ToList();

            return PartialView("_ListadoDeCliente",
                              listadoDeClientes);
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

using PazYSalvoAPP.Models;
using System.ComponentModel.DataAnnotations;

namespace PazYSalvoAPP.WebApp.Models.ViewModels
{
    public class ClienteViewModel
    {
        public int Id { get; set; }

        public string Nombres { get; set; } = null!;

        public string Telefono { get; set; } = null!;

        public string CorreoElectronico { get; set; } = null!;

        public string DocumentoIdentificacion { get; set; } = null!;

        public DateTime? FechaDeCreacion { get; set; }
    }
}


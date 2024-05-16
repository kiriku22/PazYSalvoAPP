using PazYSalvoAPP.Models;
using System.ComponentModel.DataAnnotations;

namespace PazYSalvoAPP.WebApp.Models.ViewModels
{
    public class ClienteViewModel
    {
        public int Id { get; set; }

        public int? PersonaId { get; set; }

        public int? RolId { get; set; }

        public DateTime? FechaDeCreacion { get; set; }

    }
}


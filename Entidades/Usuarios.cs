using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public  class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public int CargoId { get; set; }
        public string Nombre { get; set; }

        public string Email { get; set; }
        public int NivelUsuario { get; set; }

        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Confirmar { get; set; }
        public DateTime FechaIngreso { get; set; }

        public Usuarios()
        {
            this.UsuarioId = 0;
            this.CargoId = 0;
            this.Nombre = string.Empty;
            this.Email = string.Empty;
            this.NivelUsuario = 0;
            this.Usuario = string.Empty;
            this.Contraseña = string.Empty;
            this.Confirmar = string.Empty;
            this.FechaIngreso = DateTime.Now;
        }
    }
}

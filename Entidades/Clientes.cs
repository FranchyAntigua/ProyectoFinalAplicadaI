using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public  class Clientes
    {

        [Key]
        public int ClienteId { get; set; }
        public string Nombres { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Telefono { get; set; }
        public DateTime Fecha { get; set; }
        public int UsuarioId { get; set; }



        public Clientes(int Clienteid, string nombre, string cedula, string direccion, string email, string celular, string telefono, DateTime fecha)
        {
            this.ClienteId = Clienteid;
            this.Nombres = nombre;
            this.Cedula = cedula;
            this.Email = string.Empty;
            this.Celular = celular;
            this.Telefono = telefono;
            this.Fecha = fecha;
            this.UsuarioId = UsuarioId;
        }

        public Clientes()
        {
            this.ClienteId = 0;
            this.Nombres = string.Empty;
            this.Cedula = string.Empty;
            this.Email = string.Empty;
            this.Celular= string.Empty;
            this.Telefono = string.Empty;
            this.Fecha = DateTime.Now;
            this.UsuarioId = 0;

        }

        public override string ToString()
        {
            return this.Nombres;
        }
    }
}


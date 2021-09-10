using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Persona.Models
{
    public class Persona
    {
        public int DUI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Fecha { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
    }

    public class PeliculaDBContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
    }

}
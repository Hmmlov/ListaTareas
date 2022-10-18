using SQLite;
using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Text;

namespace ListaTareas.Modelo
{
    public class Mtareas
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Titulo { get; set; }
        [MaxLength(250)]
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        [MaxLength(50)]
        public string Estado { get; set; }
    }
}

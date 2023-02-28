using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace EJERCICIO14JBSM.Models
{
    public class Photos
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string nombre { get; set; }
        [MaxLength(50)]
        public string descripcion { get; set; }
        [MaxLength(50)]
        public Byte[] foto { get; set; }
    }
}

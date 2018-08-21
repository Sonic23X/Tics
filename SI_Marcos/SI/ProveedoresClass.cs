using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI
{
    class ProveedoresClass
    {
        public int id { get; set; }
        public string RFC { get; set; }
        public string nombre_empresa { get; set; }
        public string domicilio_fiscal { get; set; }
        public string domicilio_ubicacion { get; set; }
        public long telefono { get; set; }
        public string email { get; set; }

        public ProveedoresClass() { }

        public ProveedoresClass(string RFC, string nombre_empresa, string domicilio_fiscal, string domicilio_ubicacion, long telefono, string email)
        {
            this.RFC = RFC;
            this.nombre_empresa = nombre_empresa;
            this.domicilio_fiscal = domicilio_fiscal;
            this.domicilio_ubicacion = domicilio_ubicacion;
            this.telefono = telefono;
            this.email = email;
        }

        public ProveedoresClass(int id, string RFC, string nombre_empresa, string domicilio_fiscal, string domicilio_ubicacion, long telefono, string email) //Para recuperar el id
        {
            this.id = id;
            this.RFC = RFC;
            this.nombre_empresa = nombre_empresa;
            this.domicilio_fiscal = domicilio_fiscal;
            this.domicilio_ubicacion = domicilio_ubicacion;
            this.telefono = telefono;
            this.email = email;
        }
    }
}

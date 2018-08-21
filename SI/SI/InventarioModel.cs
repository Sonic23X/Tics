using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI
{
    class InventarioModel
    {
        public int id { get; set; }
        public String nombre { get; set; }
        public String marca { get; set; }
        public String unidad_medida { get; set; }
        public String categoria { get; set; }
        public String fecha_compra { get; set; }
        public float costo_compra { get; set; }
        public float costo_venta { get; set; }
        public float cantidad { get; set; }
        public int idProveedores { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI
{
    class Proyecto
    {
        int id; //0
        string folio_volumetria; //1
        string proyecto; //2
        string descripcion; //3
        string fecha_inicio; //4
        string fecha_asignacion; // 5
        string fecha_cierre; // 6
        float costo_inversion; // 7
        int supervisor; //8
        int responsable; //9
        int cliente; //10
        string tipo_servicio; //11

        public string clienteNom { get; set; }//12
        public string clienteApe { get; set; }//13
        public string superNom { get; set; }//14
        public string superApe { get; set; }//15
        public string empleadoNom { get; set; }//16
        public string empleadoApe { get; set; }//17

        //constructor vacio 
        public Proyecto()
        {
        }

        public Proyecto(int id, string folio_vol, string proyecto, string descripcion, string fecha_inicio, string fecha_asig, string fecha_cierre, float costo_inversion, int supervisor, int responsable, int cliente, string tipo_servicio)
        {
            this.id = id;
            this.folio_volumetria = folio_vol;
            this.proyecto = proyecto;
            this.descripcion = descripcion;
            this.fecha_inicio = fecha_inicio;
            this.fecha_asignacion = fecha_asig;
            this.fecha_cierre = fecha_cierre;
            this.costo_inversion = costo_inversion;
            this.supervisor = supervisor;
            this.responsable = responsable;
            this.cliente = cliente;
            this.tipo_servicio = tipo_servicio;
        }

        public Proyecto(int id, string folio_vol, string proyecto, string descripcion, string fecha_inicio, string fecha_asig, 
            string fecha_cierre, float costo_inversion, string tipo_servicio, 
            string clienteNom, string clienteApe, string superNom, string superApe, string empleadoNom, string empleadoApe)
        {
            this.id = id;
            this.folio_volumetria = folio_vol;
            this.proyecto = proyecto;
            this.descripcion = descripcion;
            this.fecha_inicio = fecha_inicio;
            this.fecha_asignacion = fecha_asig;
            this.fecha_cierre = fecha_cierre;
            this.costo_inversion = costo_inversion;
            this.tipo_servicio = tipo_servicio;
            this.clienteNom = clienteNom;
            this.clienteApe = clienteApe;
            this.superNom = superNom;
            this.superApe = superApe;
            this.empleadoNom = empleadoNom;
            this.empleadoApe = empleadoApe;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Folio_volumetria
        {
            get
            {
                return folio_volumetria;
            }

            set
            {
                folio_volumetria = value;
            }
        }

        public string Proyecto_name
        {
            get
            {
                return proyecto;
            }

            set
            {
                proyecto = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public string Fecha_inicio
        {
            get
            {
                return fecha_inicio;
            }

            set
            {
                fecha_inicio = value;
            }
        }

        public string Fecha_asignacion
        {
            get
            {
                return fecha_asignacion;
            }

            set
            {
                fecha_asignacion = value;
            }
        }

        public string Fecha_cierre
        {
            get
            {
                return fecha_cierre;
            }

            set
            {
                fecha_cierre = value;
            }
        }

        public float Costo_inversion
        {
            get
            {
                return costo_inversion;
            }

            set
            {
                costo_inversion = value;
            }
        }

        public int Supervisor
        {
            get
            {
                return supervisor;
            }

            set
            {
                supervisor = value;
            }
        }

        public int Responsable
        {
            get
            {
                return responsable;
            }

            set
            {
                responsable = value;
            }
        }

        public int Cliente
        {
            get
            {
                return cliente;
            }

            set
            {
                cliente = value;
            }
        }

        public string Tipo_servicio
        {
            get
            {
                return tipo_servicio;
            }

            set
            {
                tipo_servicio = value;
            }
        }
    }
}

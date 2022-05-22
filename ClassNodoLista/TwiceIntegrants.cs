using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassNodoLista
{
    public class TwiceIntegrants
    {
        //Se va a crear la lista de las integrantes del grupo TWICE
        //Se va a definir la información a usar
        public int idTwice { get; set; }
        public string nombre { get; set; }
        public int edad { get; set; }

        //Aquí posteriormente publicaré la foto
        //public string foto { get; set; }

        public string MostrarDatos()
        {
            return "La integrante es #" + this.idTwice + " Nombre " + this.nombre + " Edad " + this.edad;
        }

    }//Fin de la clase
}

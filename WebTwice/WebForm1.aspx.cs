using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassNodoLista;

namespace WebTwice
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            NodoLista miNodo = new NodoLista(
            new TwiceIntegrants() // Este es una función anonima
            {
                idTwice = 1,
                nombre = "Im Na-yeon",
                edad = 26
            });

            //Otra integrante con sus respectivas propiedades
            NodoLista miNodo2 = new NodoLista(2, "Yoo Jeong-yeon", 25);

            /////////////////////////////////////////////////////////////////////////////////////////////////
            //Vamos a ligar los nodos
            miNodo.sig = miNodo2;

            NodoLista ref1 = null;
            ref1 = miNodo;

            //Tercer objeto ya ligado al objeto 2
            miNodo2.sig = new NodoLista(3, "Park Ji-hyo", 24);

            //Cuarto objeto ya ligado al objeto 3
            miNodo2.sig.sig = new NodoLista(4, "Sana Minatozaki", 25);

            //Quinto objeto ya ligado al objeto 4
            miNodo2.sig.sig.sig = new NodoLista(5, "Mina Sharon Myoi", 25);

            //Sexto objeto ya ligado al objeto 5
            miNodo2.sig.sig.sig.sig = new NodoLista(6, "Hirai Momo", 25);

            //Septimo objeto ya ligado al objeto 6
            miNodo2.sig.sig.sig.sig.sig = new NodoLista(7, "Chou Tzuyu", 22);

            //Octavo objeto ya ligado al objeto 7
            //miNodo2.sig.sig.sig.sig.sig.sig = new NodoLista(8, "Kim Da-hyun", 23);

            //Noveno objeto ya ligado al objeto 8
            //miNodo2.sig.sig.sig.sig.sig.sig.sig = new NodoLista(9, "Son Chae-young", 23);

            //Vamos a recorrer los nodos
            while(ref1 != null)
            {
                ListBox1.Items.Add(ref1.informacion.MostrarDatos());
                ref1 = ref1.sig;
            }

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            int id_twice = Convert.ToInt32(txtId.Text);
            string nomTwice = txtNombre.Text;
            int edadTwice = Convert.ToInt32(txtEdad.Text);
            NodoLista nodoAdd = new NodoLista(id_twice, nomTwice, edadTwice);
            NodoLista ref2 = null;
            ref2 = nodoAdd;
            while(ref2 != null)
            {
                ListBox1.Items.Add(ref2.informacion.MostrarDatos());
                ref2 = ref2.sig;
            }
        }
    }
}
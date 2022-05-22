using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassNodoLista
{
    public class NodoLista
    {
        public TwiceIntegrants informacion; //Se crea una variable de tipo CLASE
        public NodoLista sig = null; //Referencia / Definicion recursiva


        //Se crearan dos constructores
        public NodoLista(TwiceIntegrants objNuevo)
        {
            informacion = objNuevo;
            sig = null;
        }

        public NodoLista(int id, string nom, int year)
        {
            informacion = new TwiceIntegrants()
            {
                idTwice = id,
                nombre = nom,
                edad = year
            };//Fin de mi instancia en JSON
            sig = null;
        }//Fin de mi metodo

        
                 
    }//Fin de la clase
}

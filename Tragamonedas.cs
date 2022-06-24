using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tragamonedas.Aplicacion
{
    public class Tragamonedas
    {
        public Casilla[] casillas { get; set; }

        public Tragamonedas()
        {
            casillas = new Casilla[3];
            casillas[0] = new Casilla();
            casillas[1] = new Casilla();    
            casillas [2] = new Casilla();
        }
    }
}

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
        public string JalarPalanca()
        {
            for (int i = 0; i < casillas.Length -1; i++)
            {
                casillas[i].FrutaRandom();
                casillas[i].Imprimir();
                System.Threading.Thread.Sleep(30000);
            }
            return " ";
        }
    }
}

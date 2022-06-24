using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tragamonedas.Aplicacion
{
    public class JuegoTragamonedas
    {
        public Casilla[] casillas { get; set; }

        public JuegoTragamonedas()
        {
            casillas = new Casilla[3];
            casillas[0] = new Casilla();
            casillas[1] = new Casilla();    
            casillas [2] = new Casilla();
        }
        public string JalarPalanca()
        {
            foreach (Casilla item in casillas)
            {
                item.FrutaRandom();
                item.Imprimir();
                //System.Threading.Thread.Sleep(30000);
            }
            if (casillas[0] == casillas[1]
                && casillas[1] == casillas[2])
            {
                return "Has Ganado!!!";
            }
            else
            {
            return "Tu Pierdes";
            }
        }
    }
}

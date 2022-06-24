using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tragamonedas.Aplicacion
{
    public class Casilla
    {
        public TipoFruta Fruta { get; set; }

        public void FrutaRandom()
        { 
            Array valores  = Enum.GetValues(typeof(TipoFruta)); 
            Random random = new Random();
            int index = random.Next(valores.Length);
            Fruta = (TipoFruta)valores.GetValue(index);
        } 
        public void Imprimir()
        {
            
            Console.WriteLine("Obtuviste: " + Fruta);
        }
    }
}

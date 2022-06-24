using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tragamonedas
{
    public class Casilla
    {
        public TipoFruta Fruta { get; set; }

        public void FrutaRandom()
        {
            Fruta = new TipoFruta(); 
            Array valores  = Enum.GetValues(typeof(TipoFruta)); 
            Random random = new Random();
            int index = random.Next(valores.Length);
            TipoFruta frutarandom = (TipoFruta)valores.GetValue(index);
        }
        public void Imprimir()
        {
            Console.WriteLine(value: FrutaRandom);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpBbancaOop
{
    abstract class Conto
    {
        string tipoConto = "ContoRisparmio";
        int ammontareConto;
        public abstract int Preleva(int quantita);
        public abstract void Deposita(int quantita);
    }
}

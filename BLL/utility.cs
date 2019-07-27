using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class utility
    {
        public static int ToInt(string text)
        {
            int numero;
            int.TryParse(text,out numero);
            return numero;
        }
    }
}

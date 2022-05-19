using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionaria.Lib.MyExeptions
{
    public class ValidarInput : Exception
    {
        public ValidarInput()
        {

        }
        public ValidarInput(string msg) : base(msg)
        {

        }
    }
}


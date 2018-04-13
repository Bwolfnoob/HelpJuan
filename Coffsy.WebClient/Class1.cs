using System;
using ServiceReference1;

namespace Coffsy.WebClient
{
    public class Class1
    {
        public Class1()
        {
            var a = new AtendeClienteClient();
            var cliente = a.buscaClienteAsync("" , "","","");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenewApp
{
    //One interface Multiple implementations 
    public  interface IAll<T> where T : class
    {
        String read();
    }
}

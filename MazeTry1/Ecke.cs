using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace MazeTry1
{
    public class Ecke<T1, T2>
    {
        internal int data;
        internal Ecke<T1, T2>? next;
        public Ecke(int d)
        {
            data = d;
            next = null;
            //int value;            
            Ecke<T1, T2> Left;
            Ecke<T1, T2> Right;   
        }
    }
}

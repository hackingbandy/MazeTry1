using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace MazeTry1
{
    public class Ecke
    {
        internal int data;
        internal Ecke? next;
        public Ecke(int d)
        {
            data = d;
            next = null;
            //int value;            
            Ecke Left;
            Ecke Right;   
        }
    }
}

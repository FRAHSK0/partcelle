using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partcelle
{
    internal class Vettore
    {
        int x;
        int y;
        public  Vettore(int x, int y)
        {
            this.x = x;
            this.y= y;

        }
        public int X
        {
            get => this.x;
            set=>this.x=value;
        }
        public int Y
        {
            get => this.y;
            set => this.y = value;
        }
        public void Scrivivettore(Vettore v)
        {
            Console.WriteLine("{0},{1}", v.x, v.y);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partcelle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           
            int n;
            n = 100;
         List< Vettore > list = new List<Vettore> ();
         Random rx = new Random ();
        
            for (int i = 0; i < n; i++)
            {
                
                Vettore v= new Vettore(rx.Next(3,50),rx.Next(3,50)); 
                list.Add(v);
            }
            int x2;
            int y2;
            
            for (int i = 0;i < 30; i++)
            {
            foreach ( Vettore Z in list) 
            {
                    
                    
                    Z.X =Z.X+rx.Next(1,2);
                    Z.Y= Z.X+rx.Next(1,2);
            }
               
            }
            int c;
            c = 0;


            foreach (Vettore Z in list)
            {
                if ((Z.X < 51) && (Z.Y < 51))
                {
                    c++;
                }
            }
            Console.WriteLine("ci sono particelle  {0}", c);


            Console.ReadLine();
        }
    }
}

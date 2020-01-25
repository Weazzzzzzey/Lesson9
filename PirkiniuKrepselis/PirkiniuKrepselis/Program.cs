using PirkiniuKrepselisBiblioteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PirkiniuKrepselis
{
    class Program
    {
        static void Main(string[] args)
        {
            Meniu p1 = new Meniu();
            p1.pradzia();
            p1.sarasoPatikra();

            Console.ReadLine();
        }
    }
}

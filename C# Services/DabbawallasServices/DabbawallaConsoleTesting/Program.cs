using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DabbawallasBusiness.Classes;

namespace DabbawallaConsoleTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario(1);
            Console.WriteLine(usuario.Nombre);
            Console.ReadKey();
            Console.Clear();
            //Usuario usuario2 = new Usuario(2, "Memazo", "memito", "asdas", "grineer", "123@gmail.com", "1324312");
            //Console.WriteLine(usuario2.CreateUser());
            //Console.ReadKey();
        }
    }
}

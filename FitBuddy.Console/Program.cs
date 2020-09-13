using DAL;
using DAL.Services;
using LicitProd.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitBuddy.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var ds = new UsuarioDataService();
            ds.GetUsuarioByNameAndPassword("aaa", "aaa");

            //var hashService = new HashService();
            //var hp = hashService.Hash("123456");

            //System.Console.WriteLine(hp);

            System.Console.ReadLine();
        }
    }
}

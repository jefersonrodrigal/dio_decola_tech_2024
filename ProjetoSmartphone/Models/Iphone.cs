using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoSmartphone.Models
{
    public class Iphone : Smatphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }

        public override void InstalarApp(string app)
        {
            Console.WriteLine($"Instalando ... {app}");
            Console.WriteLine("Em progresso...");
            Console.WriteLine("Instalação concluida.");
        }
    }
}
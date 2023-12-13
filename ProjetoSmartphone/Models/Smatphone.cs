using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoSmartphone.Models
{
    public abstract class Smatphone
    {
        public string Numero {get; set;}
        private string Modelo {get; set;}
        private string Imei {get; set;}
        private int Memoria {get; set;}


        public Smatphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {   
            Console.WriteLine("Digite o numero: ");
            Numero = Console.ReadLine();

            Console.WriteLine("Chamando ....");
            Console.ReadKey();
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação");
        }

        public abstract void InstalarApp(string app);
    }
}
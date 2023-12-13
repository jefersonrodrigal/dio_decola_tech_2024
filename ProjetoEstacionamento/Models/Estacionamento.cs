using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEstacionamento.Models
{
    public class Estacionamento
    {
        decimal PrecoInicial {get; set;}
        decimal PrecoPorHora {get; set;}
        List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora )
        {
            this.PrecoInicial = precoInicial;
            this.PrecoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo");
            string placa = Console.ReadLine();

            veiculos.Add(placa.ToUpper());
        }

        public void ListarVeiculos()
        {
            if(veiculos.Any())
            {
                Console.WriteLine("Os veiculos estacionados são:");
                foreach(var veiculo in veiculos){
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não existe veiculo cadastrado");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            { 
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                string QtdHoras = Console.ReadLine();
                bool parse = decimal.TryParse(QtdHoras, out decimal OutQtdHoras);
                decimal valor = (PrecoInicial + PrecoPorHora) * OutQtdHoras;
                Console.WriteLine($"O valor cobrado é {valor:C}");
                veiculos.Remove(placa);
            }
        }
    }
}
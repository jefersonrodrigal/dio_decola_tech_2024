using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEstacionamento.Models
{
    public class Menu
    {
        string Opcao {get; set;}
        Estacionamento estacionamento = new Estacionamento(2,2);

        public void ChamarOpcao()
        {
            Console.WriteLine("Bem vindo ao sistema de Estacionamento. Selecione a opção desejada.");
            while(Opcao != "4")
            {
                Console.WriteLine("Digite a opção desejada");
                Console.WriteLine("1- Adicionar Veiculo");
                Console.WriteLine("2- Remover Veiculo");
                Console.WriteLine("3- Listar veiculos");
                Console.WriteLine("4- Encerrar programa");
                Opcao = Console.ReadLine();

                switch(Opcao)
                {
                    case "1": 
                    estacionamento.AdicionarVeiculo();
                    break;
                    case "2":
                    estacionamento.RemoverVeiculo();
                    break;
                    case "3":
                    estacionamento.ListarVeiculos();
                    break;
                    case "4":
                    Console.WriteLine("Encerrando o sistema");
                    break;
                    default:
                    Console.WriteLine("Opcao invalida");
                    break;
                }
            }
        }
    }
}
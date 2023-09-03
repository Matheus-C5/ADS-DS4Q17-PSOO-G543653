using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciar_Tarefas
{
    public class Gerenciar_Tarefas
    {
        static List<Tarefa> Tarefas = new List<Tarefa>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1 - Criar tarefa");
                Console.WriteLine("2 - Listar tarefas");
                Console.WriteLine("3 - Editar tarefa");
                Console.WriteLine("4 - Remover tarefa");
                Console.WriteLine("5 - Sair");

                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Criar_Tarefa();
                        break;
                    case 2:
                        Listar_Tarefas();
                        break;
                    case 3:
                        Editar_Tarefa();
                        break;
                    case 4:
                        Remover_Tarefa();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

        static void Criar_Tarefa()
        {
            Console.Write("\nDigite o nome da tarefa: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a data limite (dd/mm/aaaa): ");
            string data_limite = Console.ReadLine();

            Console.Write("Digite a prioridade: ");
            string prioridade = Console.ReadLine();

            Console.Write("Digite o status: ");
            string status = Console.ReadLine();

            Console.Write("Digite o nome da pessoa responsável: ");
            string nome_pessoa = Console.ReadLine();

            Tarefa tarefa = new Tarefa(nome, data_limite, prioridade, status, nome_pessoa);
            Tarefas.Add(tarefa);

            Console.WriteLine("\nTarefa criada com sucesso!");
        }

        static void Listar_Tarefas()
        {
            if (Tarefas.Count == 0)
            {
                Console.WriteLine("\nNão há tarefas cadastradas.");
                return;
            }

            for (int indice = 0; indice < Tarefas.Count; indice++)
            {
                Tarefa tarefa = Tarefas[indice];
                Console.WriteLine($"\n#{indice} - {tarefa.Nome} - {tarefa.Data_Limite} -" +
                    $"{tarefa.Prioridade} - {tarefa.Status} - {tarefa.Nome_Pessoa}");
            }
        }

        static void Editar_Tarefa()
        {
            Console.Write("\nDigite o número da tarefa que deseja editar: ");
            int indice = Convert.ToInt32(Console.ReadLine());

            if (indice < 0 || indice >= Tarefas.Count)
            {
                Console.WriteLine("\nÍndice inválido!");
                return;
            }

            Tarefa tarefa = Tarefas[indice];

            Console.Write($"\nDigite o novo nome ({tarefa.Nome}): ");
            string nome = Console.ReadLine();

            if (!string.IsNullOrEmpty(nome))
                tarefa.Nome = nome;

            Console.Write($"Digite a nova data limite ({tarefa.Data_Limite}): ");
            string data_limite = Console.ReadLine();

            if (!string.IsNullOrEmpty(data_limite))
                tarefa.Data_Limite = data_limite;

            Console.Write($"Digite a nova prioridade ({tarefa.Prioridade}): ");
            string prioridade = Console.ReadLine();

            if (!string.IsNullOrEmpty(prioridade))
                tarefa.Prioridade = prioridade;

            Console.Write($"Digite o novo status ({tarefa.Status}): ");
            string status = Console.ReadLine();

            if (!string.IsNullOrEmpty(status))
                tarefa.Status = status;

            Console.Write($"Digite o novo nome da pessoa responsável ({tarefa.Nome_Pessoa}): ");
            string nome_pessoa = Console.ReadLine();

            if (!string.IsNullOrEmpty(nome_pessoa))
                tarefa.Nome_Pessoa = nome_pessoa;

            Console.WriteLine("\nTarefa editada com sucesso!");
        }

        static void Remover_Tarefa()
        {
            Console.Write("\nDigite o número da tarefa que deseja remover: ");
            int indice = Convert.ToInt32(Console.ReadLine());

            if (indice < 0 || indice >= Tarefas.Count)
            {
                Console.WriteLine("\nÍndice inválido!");
                return;
            }

            Tarefas.RemoveAt(indice);

            Console.WriteLine("\nTarefa removida com sucesso!");
        }
    }
}

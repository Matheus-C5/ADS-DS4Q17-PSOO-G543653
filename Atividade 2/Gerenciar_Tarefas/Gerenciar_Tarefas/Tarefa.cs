using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciar_Tarefas
{
    public class Tarefa
    {
        public string Nome { get; set; }
        public string Data_Limite { get; set; }
        public string Prioridade { get; set; }
        public string Status { get; set; }
        public string Nome_Pessoa { get; set; }

        public Tarefa(string nome, string data_limite, string prioridade, string status, string nome_pessoa)
        {
            Nome = nome;
            Data_Limite = data_limite;
            Prioridade = prioridade;
            Status = status;
            Nome_Pessoa = nome_pessoa;
        }
    }
}

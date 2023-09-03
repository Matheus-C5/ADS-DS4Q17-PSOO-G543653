using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidarAluno
{
    public class Program
    {
        static void Main(string[] args)
        {
            string nome, ra;

            Console.WriteLine("Validar aluno");

            Console.Write("Nome do aluno: ");
            nome = Console.ReadLine();

            Console.Write("RA do aluno: ");
            ra = Console.ReadLine();

            Aluno aluno = new Aluno(nome, ra);

            if (aluno.Validar())
            {
                Console.WriteLine("Aluno validado!");
            }

            else
            {
                Console.WriteLine("Dados do aluno inválidos!");
            }

            Console.ReadKey();
        }
    }
}

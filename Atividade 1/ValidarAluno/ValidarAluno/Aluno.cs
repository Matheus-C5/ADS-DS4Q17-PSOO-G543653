using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidarAluno
{
    public class Aluno : Pessoa
    {
        public string RA { get; set; }

        public Aluno(string nome, string ra) : base(nome)
        {
            RA = ra;
        }

        public bool Validar()
        {
            return (RA == "G543653" || RA == "g543653") &&
                (Nome == "Matheus Henrique" || Nome == "matheus henrique"
                || Nome == "Matheus henrique" || Nome == "matheus Henrique");
        }
    }
}

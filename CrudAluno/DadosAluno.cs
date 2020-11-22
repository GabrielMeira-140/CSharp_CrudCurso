using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAluno.Aluno.Classes
{
    class DadosAluno
    {
        public String nome { get; set; }
        public String email { get; set; }
        public String adobe { get; set; }
        public String linux { get; set; }
        public String cisco { get; set; }
        public String microsoft { get; set; }
        public String Conclusao { get; set; }
        public String TempoExtra { get; set; }

        public DadosAluno()
        {
            nome = "";
            email = "";
            adobe = "";
            linux = "";
            cisco = "";
            microsoft = "";
            Conclusao = "";
            TempoExtra = "";

        }

        public DadosAluno(String Nome, String Email, String Microsoft, String Adobe, String Cisco, String Linux, String ConclusaoCurso, String TempoExtraCurso)
        {
            nome = Nome;
            email = Email;
            adobe = Adobe;
            microsoft = Microsoft;
            cisco = Cisco;
            linux = Linux;
            Conclusao = ConclusaoCurso;
            TempoExtra = TempoExtraCurso;
        }


    }
}

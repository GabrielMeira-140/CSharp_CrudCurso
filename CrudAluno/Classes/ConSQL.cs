using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CrudAluno.Classes.Entidade
{
    class ConSQL
    {
        public string StringAdicionar()
        {
           string STRAdicionar = "INSERT INTO dadosalunos (nome, email, curso1, curso2, curso3, curso4, FinalCurso, TempoExtra, DataInicio, DataFim) " +
                    "VALUE (@nome, @email, @curso1, @curso2, @curso3, @curso4, @FinalCurso, @TempoExtra, @DataInicio, @DataFim)"; 

            return STRAdicionar;
        }

        public string StringEditar()
        {
            string STREditar = "UPDATE dadosalunos SET email = @email, curso1 = @curso1, curso2 = @curso2, curso3 = @curso3, curso4 = @curso4, FinalCurso = @FinalCurso," +
                " TempoExtra = @TempoExtra, DataInicio = @DataInicio, DataFim = @DataFim WHERE nome = @nome";

            return STREditar;
        }

        public string StringTempo()
        {
            string STRTempo = "UPDATE dadosalunos SET email = @email, curso1 = @curso1, curso2 = @curso2, curso3 = @curso3, curso4 = @curso4, FinalCurso = @FinalCurso," +
                " TempoExtra = @TempoExtra, DataInicio = @DataInicio, DataFim = @DataFim WHERE nome = @nome";

            return STRTempo;
        }

        public string StringNota()
        {
            string STRNota = "SELECT * FROM dadosalunos Where nome = @nome";

            return STRNota;
        }

        public string StringProfessorEditar()
        {
            string StringProfEditar = "UPDATE dadosalunos SET email = @email, curso1 = @curso1, curso2 = @curso2, curso3 = @curso3, curso4 = @curso4, DataInicio = @DataInicio, DataFim = @DataFim," +
                    " notaAdobe = @notaAdobe, notaCisco = @notaCisco, notaLinux = @notaLinux, notaMicrosoft = @notaMicrosoft WHERE nome = @nome";

            return StringProfEditar;
        }

        public string StringProfessorExibir()
        {
            string StringProfExibir = "SELECT * FROM dadosalunos";

            return StringProfExibir;
        }

        public string StringProfessorConsulta()
        {
            string StringProfConsulta = "SELECT * FROM dadosalunos Where nome = @nome";

            return StringProfConsulta;
        }
    }
}
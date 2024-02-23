using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InfraData.Domain
{
    public class TabelaQuiz
    {

        //Tabela das perguntas
        
        public int IDPerguntasQuiz { get; set; }

      
        public  string? Perguntas { get; set; }
        


    }
}

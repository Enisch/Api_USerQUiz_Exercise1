
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InfraData.Domain.Models_Entities
{


  
    public class RespostaQuiz
    {
        /*Tabela que não possui chave primaria, possui unica e exclusivamente foreign key para linkar as duas tabelas.
         possui ainda o elemento perguntas. 
         */

        public int id { get; set; }
        public required ICollection<Alternativa_RespostasQuiz>   IDRespostasQuiz { get; set; }
       
        public required ICollection<TabelaQuiz>  IDPerguntasQuiz { get; set; }

        public string? PerguntasDasAlternativas { get; set; }

    }
}

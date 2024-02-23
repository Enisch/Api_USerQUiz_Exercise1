namespace InfraData.Domain.Models_Entities
{
    public class Alternativa_RespostasQuiz
    {
        //Tabela que servirá para linkar as perguntas com uma alternativa.Pk=>IDRespostasQuiz
        public int IDRespostasQuiz { get; set; }
        public required string AlternativaQuiz { get; set; }
        

    }
}

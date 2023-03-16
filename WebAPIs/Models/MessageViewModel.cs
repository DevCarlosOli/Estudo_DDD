namespace WebAPIs.Models
{
    public class MessageViewModel
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public string UserID { get; set; }
    }
}

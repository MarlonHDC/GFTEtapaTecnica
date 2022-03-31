namespace GFTEtapaTecnica.Teste01.src.Entities
{
    public class Pessoa
    {
       
        DateTime dataHoje = DateTime.Today;
        DateTime Aniversario = new DateTime(1983, 2, 28) ; 
        private string Nome {get; set;}
        private string Nascimento {get; set;}
        private float Altura{get; set;}
        

        public Pessoa(string Nome, string Nascimento, float Altura)
        {
            this.Nome = Nome;
            this.Nascimento = Nascimento;
            this.Altura = Altura;
        }

        public string imprimirDados()
        {
            return "Nome: " + Nome + "\n"
            + "Nascimento: " + Nascimento + "\n"
            + "Altura: " + Altura + "\n";
        }

        public void calcularIdade() 
        {
            dataHoje - Aniversario;
        }

    }
}
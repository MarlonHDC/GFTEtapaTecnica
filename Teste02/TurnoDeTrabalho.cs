namespace GFTEtapaTecnica.Teste02
{
    public class TurnoDeTrabalho
    {
        string turnoDigitado;
        public string M = "m";
        public string V = "v";
        public string N = "n";
        public void turnoDeTrabalho()
        {
            Console.WriteLine(" Em que turno você trabalha? Degite 'M' para Matitino, 'V' para vespertino, e 'N' para noturno: ");
            turnoDigitado = Console.ReadLine();

             if (turnoDigitado == M)
             {
                 Console.WriteLine("Bom Dia!");
             }
             else if (turnoDigitado == V)
             {
                 Console.WriteLine("Boa Tarde");
             }
             else if (turnoDigitado == N)
             {
                 Console.WriteLine("Boa noite");
             }
             else
             {
                 Console.WriteLine("Valor inválido");
             }            

        }
        
    }
}
namespace GFTEtapaTecnica.Teste03
{
    public class DescontoSucos
    {
        public string Limao = "L";
        public string Tamarindo = "T"; 

        public void descontoSuco()
        {            
            Console.WriteLine (" Informe Quantos litros de suco você vai tomar? ")
            int litros = int.Parse(Console.ReadLine());

            if( litros <= 2)
            {
                Console.WriteLine("Descondo de ");
            }




        }
    }
}